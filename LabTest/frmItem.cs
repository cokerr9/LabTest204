using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LabTest
{
    public partial class frmItem : Form
    {
        private int _selectedItemID = 0;
        private string _selectedImagePath = string.Empty;
        private DataTable? _itemsTable;
        private DataTable? _categoriesLookupTable;
        private bool _isBinding = false;

        public frmItem()
        {
            InitializeComponent();
        }

        private void FrmItem_Load(object sender, EventArgs e)
        {
            LoadCategoriesIntoComboBox();
            LoadItems();
            ResetItemForm();
        }

        #region UI Rendering & Styling

        private void CardPanel_Paint(object? sender, PaintEventArgs e)
        {
            if (sender is Panel panel)
            {
                using (var pen = new Pen(Color.FromArgb(226, 232, 240), 1))
                {
                    e.Graphics.DrawRectangle(pen, 0, 0, panel.Width - 1, panel.Height - 1);
                }
            }
        }

        private void PnlTopHeader_Paint(object? sender, PaintEventArgs e)
        {
            using (var pen = new Pen(Color.FromArgb(226, 232, 240), 1))
            {
                e.Graphics.DrawLine(pen, 0, pnlTopHeader.Height - 1, pnlTopHeader.Width, pnlTopHeader.Height - 1);
            }
        }

        private void ChkStatus_CheckedChanged(object? sender, EventArgs e)
        {
            if (chkStatus.Checked)
            {
                chkStatus.Text = "✓ Active (Item is in distribution)";
                chkStatus.ForeColor = Color.FromArgb(16, 185, 129);
            }
            else
            {
                chkStatus.Text = "✕ Inactive (Item discontinued)";
                chkStatus.ForeColor = Color.FromArgb(100, 116, 139);
            }
        }

        #endregion

        #region Numeric Validation for UnitPrice

        private void TxtUnitPrice_KeyPress(object? sender, KeyPressEventArgs e)
        {
            // Allow control keys (backspace, delete, arrows)
            if (char.IsControl(e.KeyChar)) return;

            // Allow digits
            if (char.IsDigit(e.KeyChar)) return;

            // Allow at most one decimal separator
            char decimalSeparator = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
            if ((e.KeyChar == '.' || e.KeyChar == decimalSeparator) && !txtUnitPrice.Text.Contains('.') && !txtUnitPrice.Text.Contains(decimalSeparator))
            {
                return;
            }

            // Reject all other characters
            e.Handled = true;
        }

        private void TxtUnitPrice_Leave(object? sender, EventArgs e)
        {
            string raw = txtUnitPrice.Text.Trim();
            if (decimal.TryParse(raw, NumberStyles.Number, CultureInfo.CurrentCulture, out decimal value) ||
                decimal.TryParse(raw, NumberStyles.Number, CultureInfo.InvariantCulture, out value))
            {
                txtUnitPrice.Text = value.ToString("F2");
            }
        }

        #endregion

        #region Database Operations (Stored Procedures via Microsoft.Data.SqlClient)

        /// <summary>
        /// Populates the Category ComboBox with DisplayMember = CategoryName and ValueMember = CategoryID using stored procedure 'sp_GetCategoriesLookup'.
        /// </summary>
        public void LoadCategoriesIntoComboBox()
        {
            try
            {
                _categoriesLookupTable = DbHelper.ExecuteStoredProcedure("sp_GetCategoriesLookup");

                // Bind main category input ComboBox
                cmbCategory.DataSource = _categoriesLookupTable.Copy();
                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.ValueMember = "CategoryID";
                if (cmbCategory.Items.Count > 0) cmbCategory.SelectedIndex = 0;

                // Bind filter category ComboBox (with an "All Categories" option at top)
                var filterTable = _categoriesLookupTable.Copy();
                var allRow = filterTable.NewRow();
                allRow["CategoryID"] = 0;
                allRow["CategoryName"] = "All Categories";
                filterTable.Rows.InsertAt(allRow, 0);

                cmbFilterCategory.DataSource = filterTable;
                cmbFilterCategory.DisplayMember = "CategoryName";
                cmbFilterCategory.ValueMember = "CategoryID";
                cmbFilterCategory.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not load categories:\n\n{ex.Message}", "Database Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Reads all items from tblitems joined with tblcategories using stored procedure 'sp_GetAllItems'.
        /// </summary>
        public void LoadItems()
        {
            try
            {
                _isBinding = true;
                _itemsTable = DbHelper.ExecuteStoredProcedure("sp_GetAllItems");

                // Add ImagePreview column for thumbnail rendering
                if (!_itemsTable.Columns.Contains("ImagePreview"))
                {
                    _itemsTable.Columns.Add("ImagePreview", typeof(Image));
                }

                foreach (DataRow row in _itemsTable.Rows)
                {
                    string? path = row["ItemImage"]?.ToString();
                    row["ImagePreview"] = LoadThumbnailSafe(path, 48, 48);
                }

                dgvItems.DataSource = _itemsTable;
                ApplyFilters();
                dgvItems.ClearSelection();
                dgvItems.CurrentCell = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not load items:\n\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _isBinding = false;
            }
        }

        private bool InsertItem(string name, int categoryId, string description, decimal price, string imagePath, string status)
        {
            var parameters = new[]
            {
                new SqlParameter("@ItemName", SqlDbType.NVarChar, 150) { Value = name },
                new SqlParameter("@CategoryID", SqlDbType.Int) { Value = categoryId },
                new SqlParameter("@Description", SqlDbType.NVarChar, -1) { Value = string.IsNullOrWhiteSpace(description) ? (object)DBNull.Value : description },
                new SqlParameter("@UnitPrice", SqlDbType.Decimal) { Value = price, Precision = 18, Scale = 2 },
                new SqlParameter("@ItemImage", SqlDbType.NVarChar, 500) { Value = string.IsNullOrWhiteSpace(imagePath) ? (object)DBNull.Value : imagePath },
                new SqlParameter("@Status", SqlDbType.NVarChar, 20) { Value = status }
            };

            var scalarResult = DbHelper.ExecuteScalarProcedure("sp_InsertItem", parameters);
            return scalarResult != null && Convert.ToInt32(scalarResult) > 0;
        }

        private bool UpdateItem(int itemId, string name, int categoryId, string description, decimal price, string imagePath, string status)
        {
            var parameters = new[]
            {
                new SqlParameter("@ItemID", SqlDbType.Int) { Value = itemId },
                new SqlParameter("@ItemName", SqlDbType.NVarChar, 150) { Value = name },
                new SqlParameter("@CategoryID", SqlDbType.Int) { Value = categoryId },
                new SqlParameter("@Description", SqlDbType.NVarChar, -1) { Value = string.IsNullOrWhiteSpace(description) ? (object)DBNull.Value : description },
                new SqlParameter("@UnitPrice", SqlDbType.Decimal) { Value = price, Precision = 18, Scale = 2 },
                new SqlParameter("@ItemImage", SqlDbType.NVarChar, 500) { Value = string.IsNullOrWhiteSpace(imagePath) ? (object)DBNull.Value : imagePath },
                new SqlParameter("@Status", SqlDbType.NVarChar, 20) { Value = status }
            };

            return DbHelper.ExecuteNonQueryProcedure("sp_UpdateItem", parameters) > 0;
        }

        private bool DeleteItem(int itemId)
        {
            var parameters = new[]
            {
                new SqlParameter("@ItemID", SqlDbType.Int) { Value = itemId }
            };

            return DbHelper.ExecuteNonQueryProcedure("sp_DeleteItem", parameters) > 0;
        }

        #endregion

        #region Event Handlers

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            // Validation 1: Item Name
            string itemName = txtItemName.Text.Trim();
            if (string.IsNullOrWhiteSpace(itemName))
            {
                MessageBox.Show("Please enter an Item Name.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtItemName.Focus();
                return;
            }

            // Validation 2: Category
            if (cmbCategory.SelectedValue == null || !int.TryParse(cmbCategory.SelectedValue.ToString(), out int categoryId) || categoryId <= 0)
            {
                MessageBox.Show("Please select a valid Category.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCategory.Focus();
                return;
            }

            // Validation 3: Unit Price
            string priceText = txtUnitPrice.Text.Trim();
            if (!decimal.TryParse(priceText, NumberStyles.Number, CultureInfo.CurrentCulture, out decimal unitPrice) &&
                !decimal.TryParse(priceText, NumberStyles.Number, CultureInfo.InvariantCulture, out unitPrice))
            {
                MessageBox.Show("Please enter a valid numeric Unit Price (e.g., 14.50).", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUnitPrice.Focus();
                return;
            }

            if (unitPrice < 0)
            {
                MessageBox.Show("Unit Price cannot be negative.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUnitPrice.Focus();
                return;
            }

            string description = txtDescription.Text.Trim();
            string status = chkStatus.Checked ? "Active" : "Inactive";
            string imagePath = _selectedImagePath;

            try
            {
                if (_selectedItemID == 0)
                {
                    // CREATE
                    if (InsertItem(itemName, categoryId, description, unitPrice, imagePath, status))
                    {
                        MessageBox.Show(
                            "Record inserted successfully!",
                            "Inserted",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ResetItemForm();
                        LoadItems();
                    }
                }
                else
                {
                    // UPDATE
                    if (UpdateItem(_selectedItemID, itemName, categoryId, description, unitPrice, imagePath, status))
                    {
                        MessageBox.Show(
                            "Record updated successfully!",
                            "Updated",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ResetItemForm();
                        LoadItems();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving item:\n\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            if (_selectedItemID <= 0)
            {
                MessageBox.Show("Please select an item to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirmResult = MessageBox.Show(
                $"Are you sure you want to delete item '{txtItemName.Text.Trim()}' (ID: {_selectedItemID})?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    if (DeleteItem(_selectedItemID))
                    {
                        MessageBox.Show(
                            "Record deleted successfully!",
                            "Deleted",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ResetItemForm();
                        LoadItems();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting item:\n\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnClear_Click(object? sender, EventArgs e)
        {
            ResetItemForm();
        }

        private void BtnBrowseImage_Click(object? sender, EventArgs e)
        {
            using (var openDialog = new OpenFileDialog())
            {
                openDialog.Title = "Select Item Image";
                openDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp;*.webp)|*.jpg;*.jpeg;*.png;*.bmp;*.webp|All Files (*.*)|*.*";
                openDialog.RestoreDirectory = true;

                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    SetImagePreview(openDialog.FileName);
                }
            }
        }

        private void BtnRemoveImage_Click(object? sender, EventArgs e)
        {
            ClearImagePreview();
        }

        private void DgvItems_SelectionChanged(object? sender, EventArgs e)
        {
            if (_isBinding) return;
            if (dgvItems.CurrentRow == null || !dgvItems.CurrentRow.Selected) return;
            PopulateSelectedItem();
        }

        private void DgvItems_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                PopulateSelectedItem();
            }
        }


        private void CmbFilterCategory_SelectedIndexChanged(object? sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void BtnRefresh_Click(object? sender, EventArgs e)
        {
            LoadCategoriesIntoComboBox();
            LoadItems();
        }

        private void BtnNavToCategories_Click(object? sender, EventArgs e)
        {
            var frm = new frmCategory();
            frm.Show();
        }

        #endregion

        #region Helper Methods

        private void ResetItemForm()
        {
            _selectedItemID = 0;
            _selectedImagePath = string.Empty;

            txtItemID.Text = "(Auto-generated)";
            txtItemName.Clear();
            txtUnitPrice.Clear();
            txtDescription.Clear();
            chkStatus.Checked = true;
            ChkStatus_CheckedChanged(null, EventArgs.Empty);

            if (cmbCategory.Items.Count > 0)
            {
                cmbCategory.SelectedIndex = 0;
            }

            ClearImagePreview();

            lblModeBadge.Text = "NEW ITEM";
            lblModeBadge.BackColor = Color.FromArgb(239, 246, 255);
            lblModeBadge.ForeColor = Color.FromArgb(37, 99, 235);

            btnSave.Text = "Save";
            btnSave.BackColor = Color.FromArgb(37, 99, 235);
            btnDelete.Enabled = false;
            btnDelete.BackColor = Color.FromArgb(241, 245, 249);
            btnDelete.ForeColor = Color.FromArgb(148, 163, 184);

            _isBinding = true;
            dgvItems.ClearSelection();
            dgvItems.CurrentCell = null;
            _isBinding = false;

            txtItemName.Focus();
        }

        private void PopulateSelectedItem()
        {
            if (dgvItems.CurrentRow == null || dgvItems.CurrentRow.Index < 0) return;

            var row = dgvItems.CurrentRow;
            if (row.Cells["colItemID"].Value == null || row.Cells["colItemID"].Value == DBNull.Value) return;

            _selectedItemID = Convert.ToInt32(row.Cells["colItemID"].Value);
            txtItemID.Text = _selectedItemID.ToString();
            txtItemName.Text = row.Cells["colItemName"].Value?.ToString() ?? string.Empty;

            if (row.Cells["colCategoryID"].Value != null && int.TryParse(row.Cells["colCategoryID"].Value.ToString(), out int catId))
            {
                cmbCategory.SelectedValue = catId;
            }

            if (row.Cells["colUnitPrice"].Value != null && decimal.TryParse(row.Cells["colUnitPrice"].Value.ToString(), out decimal price))
            {
                txtUnitPrice.Text = price.ToString("F2");
            }
            else
            {
                txtUnitPrice.Clear();
            }

            txtDescription.Text = row.Cells["colDescription"].Value?.ToString() ?? string.Empty;

            string status = row.Cells["colStatus"].Value?.ToString() ?? "Active";
            chkStatus.Checked = string.Equals(status, "Active", StringComparison.OrdinalIgnoreCase);
            ChkStatus_CheckedChanged(null, EventArgs.Empty);

            string? imagePath = row.Cells["colItemImage"].Value?.ToString();
            if (!string.IsNullOrWhiteSpace(imagePath) && File.Exists(imagePath))
            {
                SetImagePreview(imagePath);
            }
            else
            {
                ClearImagePreview();
                if (!string.IsNullOrWhiteSpace(imagePath))
                {
                    _selectedImagePath = imagePath;
                    lblImagePath.Text = $"File missing: {Path.GetFileName(imagePath)}";
                }
            }

            lblModeBadge.Text = $"EDITING #{_selectedItemID}";
            lblModeBadge.BackColor = Color.FromArgb(254, 243, 199);
            lblModeBadge.ForeColor = Color.FromArgb(180, 83, 9);

            btnSave.Text = "Update";
            btnSave.BackColor = Color.FromArgb(22, 163, 74);
            btnDelete.Enabled = true;
            btnDelete.BackColor = Color.FromArgb(239, 68, 68);
            btnDelete.ForeColor = Color.White;
        }

        private void SetImagePreview(string filePath)
        {
            try
            {
                using (var stream = new MemoryStream(File.ReadAllBytes(filePath)))
                {
                    picItemPreview.Image?.Dispose();
                    picItemPreview.Image = Image.FromStream(stream);
                }

                _selectedImagePath = filePath;
                lblImagePath.Text = Path.GetFileName(filePath);
                lblImagePath.ForeColor = Color.FromArgb(30, 41, 59);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not preview image: {ex.Message}", "Image Load Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearImagePreview()
        {
            picItemPreview.Image?.Dispose();
            picItemPreview.Image = null;
            _selectedImagePath = string.Empty;
            lblImagePath.Text = "No image selected";
            lblImagePath.ForeColor = Color.FromArgb(148, 163, 184);
        }

        private void ApplyFilters()
        {
            if (_itemsTable == null) return;

            int selectedCatId = 0;
            if (cmbFilterCategory.SelectedValue != null && int.TryParse(cmbFilterCategory.SelectedValue.ToString(), out int parsedCatId))
            {
                selectedCatId = parsedCatId;
            }

            if (selectedCatId > 0)
            {
                _itemsTable.DefaultView.RowFilter = $"CategoryID = {selectedCatId}";
            }
            else
            {
                _itemsTable.DefaultView.RowFilter = string.Empty;
            }

            int count = _itemsTable.DefaultView.Count;
            lblRecordCount.Text = $"{count} {(count == 1 ? "item" : "items")} found";
        }

        private static Bitmap? _cachedItemPlaceholder;

        private static Image LoadThumbnailSafe(string? filePath, int width, int height)
        {
            if (string.IsNullOrWhiteSpace(filePath) || !File.Exists(filePath))
            {
                return GetPlaceholderBitmap(width, height);
            }

            try
            {
                using (var stream = new MemoryStream(File.ReadAllBytes(filePath)))
                using (var original = Image.FromStream(stream))
                {
                    var thumbnail = new Bitmap(width, height);
                    using (var g = Graphics.FromImage(thumbnail))
                    {
                        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                        g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                        g.Clear(Color.Transparent);

                        float scale = Math.Min((float)width / original.Width, (float)height / original.Height);
                        int scaledWidth = Math.Max(1, (int)(original.Width * scale));
                        int scaledHeight = Math.Max(1, (int)(original.Height * scale));
                        int x = (width - scaledWidth) / 2;
                        int y = (height - scaledHeight) / 2;

                        g.DrawImage(original, x, y, scaledWidth, scaledHeight);
                    }
                    return thumbnail;
                }
            }
            catch
            {
                return GetPlaceholderBitmap(width, height);
            }
        }

        private static Image GetPlaceholderBitmap(int width, int height)
        {
            if (_cachedItemPlaceholder != null) return _cachedItemPlaceholder;

            var bmp = new Bitmap(width, height);
            using (var g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.FromArgb(241, 245, 249));
                using (var pen = new Pen(Color.FromArgb(226, 232, 240), 1))
                {
                    g.DrawRectangle(pen, 0, 0, width - 1, height - 1);
                }
                using (var brush = new SolidBrush(Color.FromArgb(148, 163, 184)))
                using (var font = new Font("Segoe UI", 7.5F))
                {
                    var text = "No Img";
                    var size = g.MeasureString(text, font);
                    g.DrawString(text, font, brush, (width - size.Width) / 2, (height - size.Height) / 2);
                }
            }
            _cachedItemPlaceholder = bmp;
            return _cachedItemPlaceholder;
        }

        #endregion
    }
}
