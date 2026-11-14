namespace LabTest
{
    partial class frmItem
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dgvHeaderStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle dgvRowStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle dgvAltRowStyle = new DataGridViewCellStyle();
            pnlTopHeader = new Panel();
            btnNavToCategories = new Button();
            lblHeaderSubtitle = new Label();
            lblHeaderTitle = new Label();
            pnlLeftCardWrapper = new Panel();
            pnlLeftCard = new Panel();
            pnlCardBody = new Panel();
            pnlCardHeader = new Panel();
            lblCardTitle = new Label();
            lblModeBadge = new Label();
            lblItemID = new Label();
            txtItemID = new TextBox();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            lblItemName = new Label();
            txtItemName = new TextBox();
            lblUnitPrice = new Label();
            txtUnitPrice = new TextBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            chkStatus = new CheckBox();
            lblImageHeading = new Label();
            picItemPreview = new PictureBox();
            btnBrowseImage = new Button();
            btnRemoveImage = new Button();
            lblImagePath = new Label();
            pnlCardFooter = new Panel();
            pnlButtons = new TableLayoutPanel();
            btnSave = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            pnlRightCardWrapper = new Panel();
            pnlRightCard = new Panel();
            pnlGridHeader = new Panel();
            lblGridTitle = new Label();
            lblRecordCount = new Label();
            lblFilterCategory = new Label();
            cmbFilterCategory = new ComboBox();
            btnRefresh = new Button();
            dgvItems = new DataGridView();
            colImage = new DataGridViewImageColumn();
            colItemID = new DataGridViewTextBoxColumn();
            colItemName = new DataGridViewTextBoxColumn();
            colCategoryName = new DataGridViewTextBoxColumn();
            colUnitPrice = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colCategoryID = new DataGridViewTextBoxColumn();
            colDescription = new DataGridViewTextBoxColumn();
            colItemImage = new DataGridViewTextBoxColumn();
            pnlTopHeader.SuspendLayout();
            pnlLeftCardWrapper.SuspendLayout();
            pnlLeftCard.SuspendLayout();
            pnlCardBody.SuspendLayout();
            pnlCardHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picItemPreview).BeginInit();
            pnlCardFooter.SuspendLayout();
            pnlButtons.SuspendLayout();
            pnlRightCardWrapper.SuspendLayout();
            pnlRightCard.SuspendLayout();
            pnlGridHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // pnlTopHeader
            // 
            pnlTopHeader.BackColor = Color.White;
            pnlTopHeader.Controls.Add(btnNavToCategories);
            pnlTopHeader.Controls.Add(lblHeaderSubtitle);
            pnlTopHeader.Controls.Add(lblHeaderTitle);
            pnlTopHeader.Dock = DockStyle.Top;
            pnlTopHeader.Location = new Point(0, 0);
            pnlTopHeader.Name = "pnlTopHeader";
            pnlTopHeader.Padding = new Padding(24, 12, 24, 12);
            pnlTopHeader.Size = new Size(1184, 72);
            pnlTopHeader.TabIndex = 0;
            pnlTopHeader.Paint += PnlTopHeader_Paint;
            // 
            // btnNavToCategories
            // 
            btnNavToCategories.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNavToCategories.BackColor = Color.FromArgb(238, 242, 255);
            btnNavToCategories.Cursor = Cursors.Hand;
            btnNavToCategories.FlatAppearance.BorderColor = Color.FromArgb(199, 210, 254);
            btnNavToCategories.FlatAppearance.BorderSize = 1;
            btnNavToCategories.FlatStyle = FlatStyle.Flat;
            btnNavToCategories.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnNavToCategories.ForeColor = Color.FromArgb(37, 99, 235);
            btnNavToCategories.Location = new Point(980, 16);
            btnNavToCategories.Name = "btnNavToCategories";
            btnNavToCategories.Size = new Size(180, 40);
            btnNavToCategories.TabIndex = 2;
            btnNavToCategories.Text = "← Manage Categories";
            btnNavToCategories.UseVisualStyleBackColor = false;
            btnNavToCategories.Click += BtnNavToCategories_Click;
            // 
            // lblHeaderSubtitle
            // 
            lblHeaderSubtitle.AutoSize = true;
            lblHeaderSubtitle.Font = new Font("Segoe UI", 9F);
            lblHeaderSubtitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblHeaderSubtitle.Location = new Point(24, 42);
            lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            lblHeaderSubtitle.Size = new Size(460, 15);
            lblHeaderSubtitle.TabIndex = 1;
            lblHeaderSubtitle.Text = "Child Table: tblitems • Foreign Key: CategoryID linked to tblcategories.CategoryID";
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblHeaderTitle.Location = new Point(23, 13);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(188, 28);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "Item Management";
            // 
            // pnlLeftCardWrapper
            // 
            pnlLeftCardWrapper.Controls.Add(pnlLeftCard);
            pnlLeftCardWrapper.Dock = DockStyle.Left;
            pnlLeftCardWrapper.Location = new Point(0, 72);
            pnlLeftCardWrapper.Name = "pnlLeftCardWrapper";
            pnlLeftCardWrapper.Padding = new Padding(20, 16, 10, 20);
            pnlLeftCardWrapper.Size = new Size(460, 649);
            pnlLeftCardWrapper.TabIndex = 1;
            // 
            // pnlLeftCard
            // 
            pnlLeftCard.BackColor = Color.White;
            pnlLeftCard.Controls.Add(pnlCardBody);
            pnlLeftCard.Controls.Add(pnlCardFooter);
            pnlLeftCard.Dock = DockStyle.Fill;
            pnlLeftCard.Location = new Point(20, 16);
            pnlLeftCard.Name = "pnlLeftCard";
            pnlLeftCard.Padding = new Padding(18);
            pnlLeftCard.Size = new Size(430, 613);
            pnlLeftCard.TabIndex = 0;
            pnlLeftCard.Paint += CardPanel_Paint;
            // 
            // pnlCardBody
            // 
            pnlCardBody.AutoScroll = true;
            pnlCardBody.Controls.Add(pnlCardHeader);
            pnlCardBody.Controls.Add(lblItemID);
            pnlCardBody.Controls.Add(txtItemID);
            pnlCardBody.Controls.Add(lblCategory);
            pnlCardBody.Controls.Add(cmbCategory);
            pnlCardBody.Controls.Add(lblItemName);
            pnlCardBody.Controls.Add(txtItemName);
            pnlCardBody.Controls.Add(lblUnitPrice);
            pnlCardBody.Controls.Add(txtUnitPrice);
            pnlCardBody.Controls.Add(lblDescription);
            pnlCardBody.Controls.Add(txtDescription);
            pnlCardBody.Controls.Add(chkStatus);
            pnlCardBody.Controls.Add(lblImageHeading);
            pnlCardBody.Controls.Add(picItemPreview);
            pnlCardBody.Controls.Add(btnBrowseImage);
            pnlCardBody.Controls.Add(btnRemoveImage);
            pnlCardBody.Controls.Add(lblImagePath);
            pnlCardBody.Dock = DockStyle.Fill;
            pnlCardBody.Location = new Point(18, 18);
            pnlCardBody.Name = "pnlCardBody";
            pnlCardBody.Size = new Size(394, 523);
            pnlCardBody.TabIndex = 0;
            // 
            // pnlCardHeader
            // 
            pnlCardHeader.Controls.Add(lblModeBadge);
            pnlCardHeader.Controls.Add(lblCardTitle);
            pnlCardHeader.Dock = DockStyle.Top;
            pnlCardHeader.Location = new Point(0, 0);
            pnlCardHeader.Name = "pnlCardHeader";
            pnlCardHeader.Size = new Size(394, 40);
            pnlCardHeader.TabIndex = 0;
            // 
            // lblCardTitle
            // 
            lblCardTitle.AutoSize = true;
            lblCardTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCardTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblCardTitle.Location = new Point(0, 6);
            lblCardTitle.Name = "lblCardTitle";
            lblCardTitle.Size = new Size(102, 21);
            lblCardTitle.TabIndex = 0;
            lblCardTitle.Text = "Item Details";
            // 
            // lblModeBadge
            // 
            lblModeBadge.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblModeBadge.BackColor = Color.FromArgb(239, 246, 255);
            lblModeBadge.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblModeBadge.ForeColor = Color.FromArgb(37, 99, 235);
            lblModeBadge.Location = new Point(274, 6);
            lblModeBadge.Name = "lblModeBadge";
            lblModeBadge.Size = new Size(120, 24);
            lblModeBadge.TabIndex = 1;
            lblModeBadge.Text = "NEW ITEM";
            lblModeBadge.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblItemID
            // 
            lblItemID.AutoSize = true;
            lblItemID.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblItemID.ForeColor = Color.FromArgb(30, 41, 59);
            lblItemID.Location = new Point(0, 48);
            lblItemID.Name = "lblItemID";
            lblItemID.Size = new Size(54, 17);
            lblItemID.TabIndex = 1;
            lblItemID.Text = "Item ID";
            // 
            // txtItemID
            // 
            txtItemID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtItemID.BackColor = Color.FromArgb(248, 250, 252);
            txtItemID.BorderStyle = BorderStyle.FixedSingle;
            txtItemID.Font = new Font("Segoe UI", 9.5F);
            txtItemID.ForeColor = Color.FromArgb(100, 116, 139);
            txtItemID.Location = new Point(0, 68);
            txtItemID.Name = "txtItemID";
            txtItemID.ReadOnly = true;
            txtItemID.Size = new Size(394, 24);
            txtItemID.TabIndex = 2;
            txtItemID.Text = "(Auto-generated)";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCategory.ForeColor = Color.FromArgb(30, 41, 59);
            lblCategory.Location = new Point(0, 100);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(123, 17);
            lblCategory.TabIndex = 3;
            lblCategory.Text = "Parent Category *";
            // 
            // cmbCategory
            // 
            cmbCategory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbCategory.BackColor = Color.White;
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FlatStyle = FlatStyle.Flat;
            cmbCategory.Font = new Font("Segoe UI", 10F);
            cmbCategory.ForeColor = Color.FromArgb(30, 41, 59);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(0, 120);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(394, 25);
            cmbCategory.TabIndex = 4;
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblItemName.ForeColor = Color.FromArgb(30, 41, 59);
            lblItemName.Location = new Point(0, 154);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(86, 17);
            lblItemName.TabIndex = 5;
            lblItemName.Text = "Item Name *";
            // 
            // txtItemName
            // 
            txtItemName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtItemName.BackColor = Color.White;
            txtItemName.BorderStyle = BorderStyle.FixedSingle;
            txtItemName.Font = new Font("Segoe UI", 10F);
            txtItemName.ForeColor = Color.FromArgb(30, 41, 59);
            txtItemName.Location = new Point(0, 174);
            txtItemName.Name = "txtItemName";
            txtItemName.PlaceholderText = "e.g., Organic Green Tea";
            txtItemName.Size = new Size(394, 25);
            txtItemName.TabIndex = 6;
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblUnitPrice.ForeColor = Color.FromArgb(30, 41, 59);
            lblUnitPrice.Location = new Point(0, 208);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(78, 17);
            lblUnitPrice.TabIndex = 7;
            lblUnitPrice.Text = "Unit Price *";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUnitPrice.BackColor = Color.White;
            txtUnitPrice.BorderStyle = BorderStyle.FixedSingle;
            txtUnitPrice.Font = new Font("Segoe UI", 10F);
            txtUnitPrice.ForeColor = Color.FromArgb(30, 41, 59);
            txtUnitPrice.Location = new Point(0, 228);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.PlaceholderText = "0.00";
            txtUnitPrice.Size = new Size(394, 25);
            txtUnitPrice.TabIndex = 8;
            txtUnitPrice.KeyPress += TxtUnitPrice_KeyPress;
            txtUnitPrice.Leave += TxtUnitPrice_Leave;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblDescription.ForeColor = Color.FromArgb(30, 41, 59);
            lblDescription.Location = new Point(0, 262);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(79, 17);
            lblDescription.TabIndex = 9;
            lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescription.BackColor = Color.White;
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Font = new Font("Segoe UI", 9.5F);
            txtDescription.ForeColor = Color.FromArgb(30, 41, 59);
            txtDescription.Location = new Point(0, 282);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Enter specifications or notes...";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(394, 46);
            txtDescription.TabIndex = 10;
            // 
            // chkStatus
            // 
            chkStatus.AutoSize = true;
            chkStatus.Checked = true;
            chkStatus.CheckState = CheckState.Checked;
            chkStatus.Cursor = Cursors.Hand;
            chkStatus.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            chkStatus.ForeColor = Color.FromArgb(16, 185, 129);
            chkStatus.Location = new Point(0, 338);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new Size(225, 21);
            chkStatus.TabIndex = 11;
            chkStatus.Text = "✓ Active (Item is in distribution)";
            chkStatus.UseVisualStyleBackColor = true;
            chkStatus.CheckedChanged += ChkStatus_CheckedChanged;
            // 
            // lblImageHeading
            // 
            lblImageHeading.AutoSize = true;
            lblImageHeading.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblImageHeading.ForeColor = Color.FromArgb(30, 41, 59);
            lblImageHeading.Location = new Point(0, 368);
            lblImageHeading.Name = "lblImageHeading";
            lblImageHeading.Size = new Size(78, 17);
            lblImageHeading.TabIndex = 12;
            lblImageHeading.Text = "Item Image";
            // 
            // picItemPreview
            // 
            picItemPreview.BackColor = Color.FromArgb(248, 250, 252);
            picItemPreview.BorderStyle = BorderStyle.FixedSingle;
            picItemPreview.Location = new Point(0, 390);
            picItemPreview.Name = "picItemPreview";
            picItemPreview.Size = new Size(130, 95);
            picItemPreview.SizeMode = PictureBoxSizeMode.Zoom;
            picItemPreview.TabIndex = 13;
            picItemPreview.TabStop = false;
            // 
            // btnBrowseImage
            // 
            btnBrowseImage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnBrowseImage.BackColor = Color.FromArgb(238, 242, 255);
            btnBrowseImage.Cursor = Cursors.Hand;
            btnBrowseImage.FlatAppearance.BorderColor = Color.FromArgb(199, 210, 254);
            btnBrowseImage.FlatAppearance.BorderSize = 1;
            btnBrowseImage.FlatStyle = FlatStyle.Flat;
            btnBrowseImage.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBrowseImage.ForeColor = Color.FromArgb(37, 99, 235);
            btnBrowseImage.Location = new Point(142, 390);
            btnBrowseImage.Name = "btnBrowseImage";
            btnBrowseImage.Size = new Size(252, 32);
            btnBrowseImage.TabIndex = 14;
            btnBrowseImage.Text = "📁 Browse File...";
            btnBrowseImage.UseVisualStyleBackColor = false;
            btnBrowseImage.Click += BtnBrowseImage_Click;
            // 
            // btnRemoveImage
            // 
            btnRemoveImage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnRemoveImage.BackColor = Color.FromArgb(254, 242, 242);
            btnRemoveImage.Cursor = Cursors.Hand;
            btnRemoveImage.FlatAppearance.BorderColor = Color.FromArgb(254, 202, 202);
            btnRemoveImage.FlatAppearance.BorderSize = 1;
            btnRemoveImage.FlatStyle = FlatStyle.Flat;
            btnRemoveImage.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRemoveImage.ForeColor = Color.FromArgb(220, 38, 38);
            btnRemoveImage.Location = new Point(142, 428);
            btnRemoveImage.Name = "btnRemoveImage";
            btnRemoveImage.Size = new Size(252, 32);
            btnRemoveImage.TabIndex = 15;
            btnRemoveImage.Text = "✕ Clear Image";
            btnRemoveImage.UseVisualStyleBackColor = false;
            btnRemoveImage.Click += BtnRemoveImage_Click;
            // 
            // lblImagePath
            // 
            lblImagePath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblImagePath.AutoEllipsis = true;
            lblImagePath.Font = new Font("Segoe UI", 8.5F);
            lblImagePath.ForeColor = Color.FromArgb(148, 163, 184);
            lblImagePath.Location = new Point(142, 465);
            lblImagePath.Name = "lblImagePath";
            lblImagePath.Size = new Size(252, 20);
            lblImagePath.TabIndex = 16;
            lblImagePath.Text = "No image selected";
            // 
            // pnlCardFooter
            // 
            pnlCardFooter.Controls.Add(pnlButtons);
            pnlCardFooter.Dock = DockStyle.Bottom;
            pnlCardFooter.Location = new Point(18, 541);
            pnlCardFooter.Name = "pnlCardFooter";
            pnlCardFooter.Padding = new Padding(0, 10, 0, 0);
            pnlCardFooter.Size = new Size(394, 54);
            pnlCardFooter.TabIndex = 1;
            // 
            // pnlButtons
            // 
            pnlButtons.ColumnCount = 3;
            pnlButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            pnlButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            pnlButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            pnlButtons.Controls.Add(btnSave, 0, 0);
            pnlButtons.Controls.Add(btnClear, 1, 0);
            pnlButtons.Controls.Add(btnDelete, 2, 0);
            pnlButtons.Dock = DockStyle.Fill;
            pnlButtons.Location = new Point(0, 10);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.RowCount = 1;
            pnlButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlButtons.Size = new Size(394, 44);
            pnlButtons.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(37, 99, 235);
            btnSave.Cursor = Cursors.Hand;
            btnSave.Dock = DockStyle.Fill;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(0, 0);
            btnSave.Margin = new Padding(0, 0, 4, 0);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(129, 44);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += BtnSave_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(241, 245, 249);
            btnClear.Cursor = Cursors.Hand;
            btnClear.Dock = DockStyle.Fill;
            btnClear.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnClear.FlatAppearance.BorderSize = 1;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnClear.ForeColor = Color.FromArgb(51, 65, 85);
            btnClear.Location = new Point(136, 0);
            btnClear.Margin = new Padding(3, 0, 3, 0);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(124, 44);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += BtnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(241, 245, 249);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Enabled = false;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnDelete.ForeColor = Color.FromArgb(148, 163, 184);
            btnDelete.Location = new Point(266, 0);
            btnDelete.Margin = new Padding(3, 0, 0, 0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(128, 44);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += BtnDelete_Click;
            // 
            // pnlRightCardWrapper
            // 
            pnlRightCardWrapper.Controls.Add(pnlRightCard);
            pnlRightCardWrapper.Dock = DockStyle.Fill;
            pnlRightCardWrapper.Location = new Point(460, 72);
            pnlRightCardWrapper.Name = "pnlRightCardWrapper";
            pnlRightCardWrapper.Padding = new Padding(10, 16, 20, 20);
            pnlRightCardWrapper.Size = new Size(724, 649);
            pnlRightCardWrapper.TabIndex = 2;
            // 
            // pnlRightCard
            // 
            pnlRightCard.BackColor = Color.White;
            pnlRightCard.Controls.Add(dgvItems);
            pnlRightCard.Controls.Add(pnlGridHeader);
            pnlRightCard.Dock = DockStyle.Fill;
            pnlRightCard.Location = new Point(10, 16);
            pnlRightCard.Name = "pnlRightCard";
            pnlRightCard.Padding = new Padding(18);
            pnlRightCard.Size = new Size(694, 613);
            pnlRightCard.TabIndex = 0;
            pnlRightCard.Paint += CardPanel_Paint;
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AllowUserToDeleteRows = false;
            dgvItems.AllowUserToResizeRows = false;
            dgvItems.BackgroundColor = Color.White;
            dgvItems.BorderStyle = BorderStyle.None;
            dgvItems.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvItems.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvHeaderStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgvHeaderStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgvHeaderStyle.ForeColor = Color.FromArgb(71, 85, 105);
            dgvHeaderStyle.Padding = new Padding(8, 0, 8, 0);
            dgvHeaderStyle.SelectionBackColor = Color.FromArgb(248, 250, 252);
            dgvHeaderStyle.SelectionForeColor = Color.FromArgb(71, 85, 105);
            dgvHeaderStyle.WrapMode = DataGridViewTriState.True;
            dgvItems.ColumnHeadersDefaultCellStyle = dgvHeaderStyle;
            dgvItems.ColumnHeadersHeight = 42;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { colImage, colItemID, colItemName, colCategoryName, colUnitPrice, colStatus, colCategoryID, colDescription, colItemImage });
            dgvRowStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvRowStyle.BackColor = Color.White;
            dgvRowStyle.Font = new Font("Segoe UI", 9.5F);
            dgvRowStyle.ForeColor = Color.FromArgb(30, 41, 59);
            dgvRowStyle.Padding = new Padding(8, 0, 8, 0);
            dgvRowStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgvRowStyle.SelectionForeColor = Color.FromArgb(30, 58, 138);
            dgvRowStyle.WrapMode = DataGridViewTriState.False;
            dgvItems.DefaultCellStyle = dgvRowStyle;
            dgvItems.Dock = DockStyle.Fill;
            dgvItems.EnableHeadersVisualStyles = false;
            dgvItems.GridColor = Color.FromArgb(241, 245, 249);
            dgvItems.Location = new Point(18, 82);
            dgvItems.MultiSelect = false;
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvItems.RowHeadersVisible = false;
            dgvAltRowStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgvAltRowStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgvAltRowStyle.SelectionForeColor = Color.FromArgb(30, 58, 138);
            dgvItems.RowsDefaultCellStyle = dgvAltRowStyle;
            dgvItems.RowTemplate.Height = 52;
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItems.Size = new Size(658, 513);
            dgvItems.TabIndex = 1;
            dgvItems.CellClick += DgvItems_CellClick;
            dgvItems.SelectionChanged += DgvItems_SelectionChanged;
            // 
            // colImage
            // 
            colImage.DataPropertyName = "ImagePreview";
            colImage.HeaderText = "Image";
            colImage.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colImage.MinimumWidth = 60;
            colImage.Name = "colImage";
            colImage.ReadOnly = true;
            colImage.Width = 70;
            // 
            // colItemID
            // 
            colItemID.DataPropertyName = "ItemID";
            colItemID.HeaderText = "ID";
            colItemID.MinimumWidth = 50;
            colItemID.Name = "colItemID";
            colItemID.ReadOnly = true;
            colItemID.Width = 60;
            // 
            // colItemName
            // 
            colItemName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colItemName.DataPropertyName = "ItemName";
            colItemName.FillWeight = 40F;
            colItemName.HeaderText = "Item Name";
            colItemName.MinimumWidth = 110;
            colItemName.Name = "colItemName";
            colItemName.ReadOnly = true;
            // 
            // colCategoryName
            // 
            colCategoryName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCategoryName.DataPropertyName = "CategoryName";
            colCategoryName.FillWeight = 30F;
            colCategoryName.HeaderText = "Category";
            colCategoryName.MinimumWidth = 90;
            colCategoryName.Name = "colCategoryName";
            colCategoryName.ReadOnly = true;
            // 
            // colUnitPrice
            // 
            colUnitPrice.DataPropertyName = "UnitPrice";
            colUnitPrice.HeaderText = "Unit Price";
            colUnitPrice.MinimumWidth = 85;
            colUnitPrice.Name = "colUnitPrice";
            colUnitPrice.ReadOnly = true;
            colUnitPrice.Width = 95;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "Status";
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 75;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.Width = 85;
            // 
            // colCategoryID
            // 
            colCategoryID.DataPropertyName = "CategoryID";
            colCategoryID.HeaderText = "CatID";
            colCategoryID.Name = "colCategoryID";
            colCategoryID.ReadOnly = true;
            colCategoryID.Visible = false;
            // 
            // colDescription
            // 
            colDescription.DataPropertyName = "Description";
            colDescription.HeaderText = "Description";
            colDescription.Name = "colDescription";
            colDescription.ReadOnly = true;
            colDescription.Visible = false;
            // 
            // colItemImage
            // 
            colItemImage.DataPropertyName = "ItemImage";
            colItemImage.HeaderText = "Image Path";
            colItemImage.Name = "colItemImage";
            colItemImage.ReadOnly = true;
            colItemImage.Visible = false;
            // 
            // pnlGridHeader
            // 
            pnlGridHeader.Controls.Add(lblRecordCount);
            pnlGridHeader.Controls.Add(btnRefresh);
            pnlGridHeader.Controls.Add(cmbFilterCategory);
            pnlGridHeader.Controls.Add(lblFilterCategory);
            pnlGridHeader.Controls.Add(lblGridTitle);
            pnlGridHeader.Dock = DockStyle.Top;
            pnlGridHeader.Location = new Point(18, 18);
            pnlGridHeader.Name = "pnlGridHeader";
            pnlGridHeader.Size = new Size(658, 64);
            pnlGridHeader.TabIndex = 0;
            // 
            // lblGridTitle
            // 
            lblGridTitle.AutoSize = true;
            lblGridTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblGridTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblGridTitle.Location = new Point(0, 8);
            lblGridTitle.Name = "lblGridTitle";
            lblGridTitle.Size = new Size(123, 21);
            lblGridTitle.TabIndex = 0;
            lblGridTitle.Text = "Item Inventory";
            // 
            // lblRecordCount
            // 
            lblRecordCount.AutoSize = true;
            lblRecordCount.Font = new Font("Segoe UI", 8.5F);
            lblRecordCount.ForeColor = Color.FromArgb(100, 116, 139);
            lblRecordCount.Location = new Point(2, 34);
            lblRecordCount.Name = "lblRecordCount";
            lblRecordCount.Size = new Size(89, 15);
            lblRecordCount.TabIndex = 1;
            lblRecordCount.Text = "Loading items...";
            // 
            // lblFilterCategory
            // 
            lblFilterCategory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFilterCategory.AutoSize = true;
            lblFilterCategory.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblFilterCategory.ForeColor = Color.FromArgb(100, 116, 139);
            lblFilterCategory.Location = new Point(340, 18);
            lblFilterCategory.Name = "lblFilterCategory";
            lblFilterCategory.Size = new Size(39, 15);
            lblFilterCategory.TabIndex = 2;
            lblFilterCategory.Text = "Filter:";
            // 
            // cmbFilterCategory
            // 
            cmbFilterCategory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbFilterCategory.BackColor = Color.White;
            cmbFilterCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterCategory.FlatStyle = FlatStyle.Flat;
            cmbFilterCategory.Font = new Font("Segoe UI", 9F);
            cmbFilterCategory.ForeColor = Color.FromArgb(30, 41, 59);
            cmbFilterCategory.FormattingEnabled = true;
            cmbFilterCategory.Location = new Point(385, 14);
            cmbFilterCategory.Name = "cmbFilterCategory";
            cmbFilterCategory.Size = new Size(175, 23);
            cmbFilterCategory.TabIndex = 3;
            cmbFilterCategory.SelectedIndexChanged += CmbFilterCategory_SelectedIndexChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.BackColor = Color.FromArgb(241, 245, 249);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.FromArgb(51, 65, 85);
            btnRefresh.Location = new Point(568, 11);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(90, 32);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "🔄 Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += BtnRefresh_Click;
            // 
            // frmItem
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(1184, 721);
            Controls.Add(pnlRightCardWrapper);
            Controls.Add(pnlLeftCardWrapper);
            Controls.Add(pnlTopHeader);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular);
            ForeColor = Color.FromArgb(30, 41, 59);
            MinimumSize = new Size(1020, 680);
            Name = "frmItem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Item Management";
            Load += FrmItem_Load;
            pnlTopHeader.ResumeLayout(false);
            pnlTopHeader.PerformLayout();
            pnlLeftCardWrapper.ResumeLayout(false);
            pnlLeftCard.ResumeLayout(false);
            pnlCardBody.ResumeLayout(false);
            pnlCardBody.PerformLayout();
            pnlCardHeader.ResumeLayout(false);
            pnlCardHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picItemPreview).EndInit();
            pnlCardFooter.ResumeLayout(false);
            pnlButtons.ResumeLayout(false);
            pnlRightCardWrapper.ResumeLayout(false);
            pnlRightCard.ResumeLayout(false);
            pnlGridHeader.ResumeLayout(false);
            pnlGridHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTopHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSubtitle;
        private System.Windows.Forms.Button btnNavToCategories;

        private System.Windows.Forms.Panel pnlLeftCardWrapper;
        private System.Windows.Forms.Panel pnlLeftCard;
        private System.Windows.Forms.Panel pnlCardBody;
        private System.Windows.Forms.Panel pnlCardHeader;
        private System.Windows.Forms.Label lblCardTitle;
        private System.Windows.Forms.Label lblModeBadge;

        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.TextBox txtItemID;

        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;

        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.TextBox txtItemName;

        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox txtUnitPrice;

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;

        private System.Windows.Forms.CheckBox chkStatus;

        private System.Windows.Forms.Label lblImageHeading;
        private System.Windows.Forms.PictureBox picItemPreview;
        private System.Windows.Forms.Button btnBrowseImage;
        private System.Windows.Forms.Button btnRemoveImage;
        private System.Windows.Forms.Label lblImagePath;

        private System.Windows.Forms.Panel pnlCardFooter;
        private System.Windows.Forms.TableLayoutPanel pnlButtons;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;

        private System.Windows.Forms.Panel pnlRightCardWrapper;
        private System.Windows.Forms.Panel pnlRightCard;
        private System.Windows.Forms.Panel pnlGridHeader;
        private System.Windows.Forms.Label lblGridTitle;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Label lblFilterCategory;
        private System.Windows.Forms.ComboBox cmbFilterCategory;
        private System.Windows.Forms.Button btnRefresh;

        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.DataGridViewImageColumn colImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemImage;
    }
}
