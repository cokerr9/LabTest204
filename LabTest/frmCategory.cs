using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LabTest
{
    public partial class frmCategory : Form
    {
        private int _selectedCategoryID = 0;
        private string _selectedImagePath = string.Empty;
        private DataTable? _categoriesTable;
        private bool _isBinding = false;

        public frmCategory()
        {
            InitializeComponent();
        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            LoadCategories();
            ResetForm();
        }

        #region UI Rendering & Visual Effects

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
                chkStatus.Text = "✓ Active (Category visible in catalog)";
                chkStatus.ForeColor = Color.FromArgb(16, 185, 129); // Modern Emerald Green
            }
            else
            {
                chkStatus.Text = "✕ Inactive (Category hidden)";
                chkStatus.ForeColor = Color.FromArgb(100, 116, 139); // Slate Muted
            }
        }

        #endregion

        #region Database CRUD Operations (Stored Procedures via Microsoft.Data.SqlClient)

        /// <summary>
        /// Reads all category records from tblcategories using stored procedure 'sp_GetAllCategories' and binds to DataGridView.
        /// </summary>
        public void LoadCategories()
        {
            try
            {
                _isBinding = true;
                _categoriesTable = DbHelper.ExecuteStoredProcedure("sp_GetAllCategories");

                // Add ImagePreview column for thumbnail rendering
                if (!_categoriesTable.Columns.Contains("ImagePreview"))
                {
                    _categoriesTable.Columns.Add("ImagePreview", typeof(Image));
                }

                foreach (DataRow row in _categoriesTable.Rows)
                {
                    string? path = row["CategoryImage"]?.ToString();
                    row["ImagePreview"] = LoadThumbnailSafe(path, 48, 48);
                }

                dgvCategories.DataSource = _categoriesTable;
                dgvCategories.ClearSelection();
                dgvCategories.CurrentCell = null;
                UpdateRecordCountLabel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Unable to load categories from database:\n\n{ex.Message}\n\nPlease check your SQL Server connection in DbHelper.cs or run DatabaseSetup.sql / StoredProcedures.sql.",
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                _isBinding = false;
            }
        }

        /// <summary>
        /// Inserts a new category into tblcategories using stored procedure 'sp_InsertCategory'.
        /// </summary>
        private bool InsertCategory(string name, string imagePath, string status)
        {
            var parameters = new[]
            {
                new SqlParameter("@CategoryName", SqlDbType.NVarChar, 100) { Value = name },
                new SqlParameter("@CategoryImage", SqlDbType.NVarChar, 500) { Value = string.IsNullOrWhiteSpace(imagePath) ? (object)DBNull.Value : imagePath },
                new SqlParameter("@Status", SqlDbType.NVarChar, 20) { Value = status }
            };

            var newIdObj = DbHelper.ExecuteScalarProcedure("sp_InsertCategory", parameters);
            return newIdObj != null && Convert.ToInt32(newIdObj) > 0;
        }

        /// <summary>
        /// Updates an existing category in tblcategories using stored procedure 'sp_UpdateCategory'.
        /// </summary>
        private bool UpdateCategory(int categoryId, string name, string imagePath, string status)
        {
            var parameters = new[]
            {
                new SqlParameter("@CategoryID", SqlDbType.Int) { Value = categoryId },
                new SqlParameter("@CategoryName", SqlDbType.NVarChar, 100) { Value = name },
                new SqlParameter("@CategoryImage", SqlDbType.NVarChar, 500) { Value = string.IsNullOrWhiteSpace(imagePath) ? (object)DBNull.Value : imagePath },
                new SqlParameter("@Status", SqlDbType.NVarChar, 20) { Value = status }
            };

            return DbHelper.ExecuteNonQueryProcedure("sp_UpdateCategory", parameters) > 0;
        }

        /// <summary>
        /// Deletes a category by CategoryID from tblcategories using stored procedure 'sp_DeleteCategory'.
        /// </summary>
        private bool DeleteCategory(int categoryId)
        {
            var parameters = new[]
            {
                new SqlParameter("@CategoryID", SqlDbType.Int) { Value = categoryId }
            };

            return DbHelper.ExecuteNonQueryProcedure("sp_DeleteCategory", parameters) > 0;
        }

        #endregion

        #region Event Handlers

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            // Input Validation
            string categoryName = txtCategoryName.Text.Trim();
            if (string.IsNullOrWhiteSpace(categoryName))
            {
                MessageBox.Show(
                    "Please enter a valid Category Name.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtCategoryName.Focus();
                return;
            }

            string status = chkStatus.Checked ? "Active" : "Inactive";
            string imagePath = _selectedImagePath;

            try
            {
                if (_selectedCategoryID == 0)
                {
                    // CREATE (INSERT)
                    if (InsertCategory(categoryName, imagePath, status))
                    {
                        MessageBox.Show(
                            "Record inserted successfully!",
                            "Inserted",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ResetForm();
                        LoadCategories();
                    }
                }
                else
                {
                    // UPDATE
                    if (UpdateCategory(_selectedCategoryID, categoryName, imagePath, status))
                    {
                        MessageBox.Show(
                            "Record updated successfully!",
                            "Updated",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ResetForm();
                        LoadCategories();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error saving category:\n\n{ex.Message}",
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            if (_selectedCategoryID <= 0)
            {
                MessageBox.Show("Please select a category to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirmResult = MessageBox.Show(
                $"Are you sure you want to delete category '{txtCategoryName.Text.Trim()}' (ID: {_selectedCategoryID})?\n\nNote: In a relational database, associated child items in tblitems may also be removed.",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    if (DeleteCategory(_selectedCategoryID))
                    {
                        MessageBox.Show(
                            "Record deleted successfully!",
                            "Deleted",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ResetForm();
                        LoadCategories();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"Error deleting category:\n\n{ex.Message}",
                        "Database Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void BtnClear_Click(object? sender, EventArgs e)
        {
            ResetForm();
        }

        private void BtnBrowseImage_Click(object? sender, EventArgs e)
        {
            using (var openDialog = new OpenFileDialog())
            {
                openDialog.Title = "Select Category Image";
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

        private void DgvCategories_SelectionChanged(object? sender, EventArgs e)
        {
            if (_isBinding) return;
            if (dgvCategories.CurrentRow == null || !dgvCategories.CurrentRow.Selected) return;
            PopulateSelectedCategory();
        }

        private void DgvCategories_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                PopulateSelectedCategory();
            }
        }


        private void BtnRefresh_Click(object? sender, EventArgs e)
        {
            LoadCategories();
        }

        private void BtnNavToItems_Click(object? sender, EventArgs e)
        {
            // Open Item Management form
            var frm = new frmItem();
            frm.Show();
        }

        #endregion

        #region Helper Methods

        private void ResetForm()
        {
            _selectedCategoryID = 0;
            _selectedImagePath = string.Empty;

            txtCategoryID.Text = "(Auto-generated)";
            txtCategoryName.Clear();
            chkStatus.Checked = true;
            ChkStatus_CheckedChanged(null, EventArgs.Empty);

            ClearImagePreview();

            // Reset UI Badges & Buttons
            lblModeBadge.Text = "NEW RECORD";
            lblModeBadge.BackColor = Color.FromArgb(239, 246, 255);
            lblModeBadge.ForeColor = Color.FromArgb(37, 99, 235);

            btnSave.Text = "Save";
            btnSave.BackColor = Color.FromArgb(37, 99, 235);
            btnDelete.Enabled = false;
            btnDelete.BackColor = Color.FromArgb(241, 245, 249);
            btnDelete.ForeColor = Color.FromArgb(148, 163, 184);

            _isBinding = true;
            dgvCategories.ClearSelection();
            dgvCategories.CurrentCell = null;
            _isBinding = false;

            txtCategoryName.Focus();
        }

        private void PopulateSelectedCategory()
        {
            if (dgvCategories.CurrentRow == null || dgvCategories.CurrentRow.Index < 0) return;

            var row = dgvCategories.CurrentRow;
            if (row.Cells["colCategoryID"].Value == null || row.Cells["colCategoryID"].Value == DBNull.Value) return;

            _selectedCategoryID = Convert.ToInt32(row.Cells["colCategoryID"].Value);
            txtCategoryID.Text = _selectedCategoryID.ToString();
            txtCategoryName.Text = row.Cells["colCategoryName"].Value?.ToString() ?? string.Empty;

            string status = row.Cells["colStatus"].Value?.ToString() ?? "Active";
            chkStatus.Checked = string.Equals(status, "Active", StringComparison.OrdinalIgnoreCase);
            ChkStatus_CheckedChanged(null, EventArgs.Empty);

            string? imagePath = row.Cells["colImagePath"].Value?.ToString();
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

            // Update UI State for Edit Mode
            lblModeBadge.Text = $"EDITING #{_selectedCategoryID}";
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
                // Load image into memory to avoid file-locking on disk
                using (var stream = new MemoryStream(File.ReadAllBytes(filePath)))
                {
                    picPreview.Image?.Dispose();
                    picPreview.Image = Image.FromStream(stream);
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
            picPreview.Image?.Dispose();
            picPreview.Image = null;
            _selectedImagePath = string.Empty;
            lblImagePath.Text = "No image selected";
            lblImagePath.ForeColor = Color.FromArgb(148, 163, 184);
        }

        private void UpdateRecordCountLabel()
        {
            int count = _categoriesTable?.DefaultView.Count ?? 0;
            lblRecordCount.Text = $"{count} {(count == 1 ? "category" : "categories")} found";
        }

        private static Bitmap? _cachedCategoryPlaceholder;

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
            if (_cachedCategoryPlaceholder != null) return _cachedCategoryPlaceholder;

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
            _cachedCategoryPlaceholder = bmp;
            return _cachedCategoryPlaceholder;
        }

        #endregion
    }
}
