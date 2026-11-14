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
            System.Windows.Forms.DataGridViewCellStyle dgvHeaderStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvRowStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvAltRowStyle = new System.Windows.Forms.DataGridViewCellStyle();

            this.pnlTopHeader = new System.Windows.Forms.Panel();
            this.btnNavToCategories = new System.Windows.Forms.Button();
            this.lblHeaderSubtitle = new System.Windows.Forms.Label();
            this.lblHeaderTitle = new System.Windows.Forms.Label();

            this.pnlLeftCardWrapper = new System.Windows.Forms.Panel();
            this.pnlLeftCard = new System.Windows.Forms.Panel();
            this.pnlCardBody = new System.Windows.Forms.Panel();
            this.pnlCardHeader = new System.Windows.Forms.Panel();
            this.lblCardTitle = new System.Windows.Forms.Label();
            this.lblModeBadge = new System.Windows.Forms.Label();

            this.lblItemID = new System.Windows.Forms.Label();
            this.txtItemID = new System.Windows.Forms.TextBox();

            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();

            this.lblItemName = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();

            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();

            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();

            this.chkStatus = new System.Windows.Forms.CheckBox();

            this.lblImageHeading = new System.Windows.Forms.Label();
            this.picItemPreview = new System.Windows.Forms.PictureBox();
            this.btnBrowseImage = new System.Windows.Forms.Button();
            this.btnRemoveImage = new System.Windows.Forms.Button();
            this.lblImagePath = new System.Windows.Forms.Label();

            this.pnlCardFooter = new System.Windows.Forms.Panel();
            this.pnlButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();

            this.pnlRightCardWrapper = new System.Windows.Forms.Panel();
            this.pnlRightCard = new System.Windows.Forms.Panel();
            this.pnlGridHeader = new System.Windows.Forms.Panel();
            this.lblGridTitle = new System.Windows.Forms.Label();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.lblFilterCategory = new System.Windows.Forms.Label();
            this.cmbFilterCategory = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();

            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.colItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemImage = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.pnlTopHeader.SuspendLayout();
            this.pnlLeftCardWrapper.SuspendLayout();
            this.pnlLeftCard.SuspendLayout();
            this.pnlCardBody.SuspendLayout();
            this.pnlCardHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItemPreview)).BeginInit();
            this.pnlCardFooter.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlRightCardWrapper.SuspendLayout();
            this.pnlRightCard.SuspendLayout();
            this.pnlGridHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();

            // 
            // pnlTopHeader
            // 
            this.pnlTopHeader.BackColor = System.Drawing.Color.White;
            this.pnlTopHeader.Controls.Add(this.btnNavToCategories);
            this.pnlTopHeader.Controls.Add(this.lblHeaderSubtitle);
            this.pnlTopHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlTopHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlTopHeader.Name = "pnlTopHeader";
            this.pnlTopHeader.Padding = new System.Windows.Forms.Padding(24, 12, 24, 12);
            this.pnlTopHeader.Size = new System.Drawing.Size(1184, 72);
            this.pnlTopHeader.TabIndex = 0;
            this.pnlTopHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlTopHeader_Paint);

            // 
            // btnNavToCategories
            // 
            this.btnNavToCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNavToCategories.BackColor = System.Drawing.Color.FromArgb(238, 242, 255);
            this.btnNavToCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavToCategories.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(199, 210, 254);
            this.btnNavToCategories.FlatAppearance.BorderSize = 1;
            this.btnNavToCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavToCategories.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnNavToCategories.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnNavToCategories.Location = new System.Drawing.Point(980, 16);
            this.btnNavToCategories.Name = "btnNavToCategories";
            this.btnNavToCategories.Size = new System.Drawing.Size(180, 40);
            this.btnNavToCategories.TabIndex = 2;
            this.btnNavToCategories.Text = "← Manage Categories";
            this.btnNavToCategories.UseVisualStyleBackColor = false;
            this.btnNavToCategories.Click += new System.EventHandler(this.BtnNavToCategories_Click);

            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(24, 42);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(460, 15);
            this.lblHeaderSubtitle.TabIndex = 1;
            this.lblHeaderSubtitle.Text = "Child Table: tblitems • Foreign Key: CategoryID linked to tblcategories.CategoryID";

            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblHeaderTitle.Location = new System.Drawing.Point(23, 13);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(188, 28);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Item Management";

            // 
            // pnlLeftCardWrapper
            // 
            this.pnlLeftCardWrapper.Controls.Add(this.pnlLeftCard);
            this.pnlLeftCardWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftCardWrapper.Location = new System.Drawing.Point(0, 72);
            this.pnlLeftCardWrapper.Name = "pnlLeftCardWrapper";
            this.pnlLeftCardWrapper.Padding = new System.Windows.Forms.Padding(20, 16, 10, 20);
            this.pnlLeftCardWrapper.Size = new System.Drawing.Size(460, 649);
            this.pnlLeftCardWrapper.TabIndex = 1;

            // 
            // pnlLeftCard
            // 
            this.pnlLeftCard.BackColor = System.Drawing.Color.White;
            this.pnlLeftCard.Controls.Add(this.pnlCardBody);
            this.pnlLeftCard.Controls.Add(this.pnlCardFooter);
            this.pnlLeftCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeftCard.Location = new System.Drawing.Point(20, 16);
            this.pnlLeftCard.Name = "pnlLeftCard";
            this.pnlLeftCard.Padding = new System.Windows.Forms.Padding(18);
            this.pnlLeftCard.Size = new System.Drawing.Size(430, 613);
            this.pnlLeftCard.TabIndex = 0;
            this.pnlLeftCard.Paint += new System.Windows.Forms.PaintEventHandler(this.CardPanel_Paint);

            // 
            // pnlCardBody
            // 
            this.pnlCardBody.AutoScroll = true;
            this.pnlCardBody.Controls.Add(this.pnlCardHeader);
            this.pnlCardBody.Controls.Add(this.lblItemID);
            this.pnlCardBody.Controls.Add(this.txtItemID);
            this.pnlCardBody.Controls.Add(this.lblCategory);
            this.pnlCardBody.Controls.Add(this.cmbCategory);
            this.pnlCardBody.Controls.Add(this.lblItemName);
            this.pnlCardBody.Controls.Add(this.txtItemName);
            this.pnlCardBody.Controls.Add(this.lblUnitPrice);
            this.pnlCardBody.Controls.Add(this.txtUnitPrice);
            this.pnlCardBody.Controls.Add(this.lblDescription);
            this.pnlCardBody.Controls.Add(this.txtDescription);
            this.pnlCardBody.Controls.Add(this.chkStatus);
            this.pnlCardBody.Controls.Add(this.lblImageHeading);
            this.pnlCardBody.Controls.Add(this.picItemPreview);
            this.pnlCardBody.Controls.Add(this.btnBrowseImage);
            this.pnlCardBody.Controls.Add(this.btnRemoveImage);
            this.pnlCardBody.Controls.Add(this.lblImagePath);
            this.pnlCardBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCardBody.Location = new System.Drawing.Point(18, 18);
            this.pnlCardBody.Name = "pnlCardBody";
            this.pnlCardBody.Size = new System.Drawing.Size(394, 523);
            this.pnlCardBody.TabIndex = 0;

            // 
            // pnlCardHeader
            // 
            this.pnlCardHeader.Controls.Add(this.lblModeBadge);
            this.pnlCardHeader.Controls.Add(this.lblCardTitle);
            this.pnlCardHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCardHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlCardHeader.Name = "pnlCardHeader";
            this.pnlCardHeader.Size = new System.Drawing.Size(394, 40);
            this.pnlCardHeader.TabIndex = 0;

            // 
            // lblCardTitle
            // 
            this.lblCardTitle.AutoSize = true;
            this.lblCardTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCardTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblCardTitle.Location = new System.Drawing.Point(0, 6);
            this.lblCardTitle.Name = "lblCardTitle";
            this.lblCardTitle.Size = new System.Drawing.Size(102, 21);
            this.lblCardTitle.TabIndex = 0;
            this.lblCardTitle.Text = "Item Details";

            // 
            // lblModeBadge
            // 
            this.lblModeBadge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblModeBadge.BackColor = System.Drawing.Color.FromArgb(239, 246, 255);
            this.lblModeBadge.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblModeBadge.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.lblModeBadge.Location = new System.Drawing.Point(274, 6);
            this.lblModeBadge.Name = "lblModeBadge";
            this.lblModeBadge.Size = new System.Drawing.Size(120, 24);
            this.lblModeBadge.TabIndex = 1;
            this.lblModeBadge.Text = "NEW ITEM";
            this.lblModeBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblItemID.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblItemID.Location = new System.Drawing.Point(0, 48);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(54, 17);
            this.lblItemID.TabIndex = 1;
            this.lblItemID.Text = "Item ID";

            // 
            // txtItemID
            // 
            this.txtItemID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItemID.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.txtItemID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemID.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtItemID.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.txtItemID.Location = new System.Drawing.Point(0, 68);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.ReadOnly = true;
            this.txtItemID.Size = new System.Drawing.Size(394, 24);
            this.txtItemID.TabIndex = 2;
            this.txtItemID.Text = "(Auto-generated)";

            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblCategory.Location = new System.Drawing.Point(0, 100);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(123, 17);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Parent Category *";

            // 
            // cmbCategory
            // 
            this.cmbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCategory.BackColor = System.Drawing.Color.White;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategory.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(0, 120);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(394, 25);
            this.cmbCategory.TabIndex = 4;

            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblItemName.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblItemName.Location = new System.Drawing.Point(0, 154);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(86, 17);
            this.lblItemName.TabIndex = 5;
            this.lblItemName.Text = "Item Name *";

            // 
            // txtItemName
            // 
            this.txtItemName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItemName.BackColor = System.Drawing.Color.White;
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtItemName.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.txtItemName.Location = new System.Drawing.Point(0, 174);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.PlaceholderText = "e.g., Organic Green Tea";
            this.txtItemName.Size = new System.Drawing.Size(394, 25);
            this.txtItemName.TabIndex = 6;

            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblUnitPrice.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblUnitPrice.Location = new System.Drawing.Point(0, 208);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(78, 17);
            this.lblUnitPrice.TabIndex = 7;
            this.lblUnitPrice.Text = "Unit Price *";

            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUnitPrice.BackColor = System.Drawing.Color.White;
            this.txtUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUnitPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUnitPrice.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.txtUnitPrice.Location = new System.Drawing.Point(0, 228);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.PlaceholderText = "0.00";
            this.txtUnitPrice.Size = new System.Drawing.Size(394, 25);
            this.txtUnitPrice.TabIndex = 8;
            this.txtUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUnitPrice_KeyPress);
            this.txtUnitPrice.Leave += new System.EventHandler(this.TxtUnitPrice_Leave);

            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblDescription.Location = new System.Drawing.Point(0, 262);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(79, 17);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "Description";

            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.txtDescription.Location = new System.Drawing.Point(0, 282);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PlaceholderText = "Enter specifications or notes...";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(394, 46);
            this.txtDescription.TabIndex = 10;

            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Checked = true;
            this.chkStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.chkStatus.ForeColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.chkStatus.Location = new System.Drawing.Point(0, 338);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(225, 21);
            this.chkStatus.TabIndex = 11;
            this.chkStatus.Text = "✓ Active (Item is in distribution)";
            this.chkStatus.UseVisualStyleBackColor = true;
            this.chkStatus.CheckedChanged += new System.EventHandler(this.ChkStatus_CheckedChanged);

            // 
            // lblImageHeading
            // 
            this.lblImageHeading.AutoSize = true;
            this.lblImageHeading.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblImageHeading.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblImageHeading.Location = new System.Drawing.Point(0, 368);
            this.lblImageHeading.Name = "lblImageHeading";
            this.lblImageHeading.Size = new System.Drawing.Size(78, 17);
            this.lblImageHeading.TabIndex = 12;
            this.lblImageHeading.Text = "Item Image";

            // 
            // picItemPreview
            // 
            this.picItemPreview.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.picItemPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picItemPreview.Location = new System.Drawing.Point(0, 390);
            this.picItemPreview.Name = "picItemPreview";
            this.picItemPreview.Size = new System.Drawing.Size(130, 95);
            this.picItemPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picItemPreview.TabIndex = 13;
            this.picItemPreview.TabStop = false;

            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseImage.BackColor = System.Drawing.Color.FromArgb(238, 242, 255);
            this.btnBrowseImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowseImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(199, 210, 254);
            this.btnBrowseImage.FlatAppearance.BorderSize = 1;
            this.btnBrowseImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseImage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBrowseImage.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnBrowseImage.Location = new System.Drawing.Point(142, 390);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(252, 32);
            this.btnBrowseImage.TabIndex = 14;
            this.btnBrowseImage.Text = "📁 Browse File...";
            this.btnBrowseImage.UseVisualStyleBackColor = false;
            this.btnBrowseImage.Click += new System.EventHandler(this.BtnBrowseImage_Click);

            // 
            // btnRemoveImage
            // 
            this.btnRemoveImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveImage.BackColor = System.Drawing.Color.FromArgb(254, 242, 242);
            this.btnRemoveImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(254, 202, 202);
            this.btnRemoveImage.FlatAppearance.BorderSize = 1;
            this.btnRemoveImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveImage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRemoveImage.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnRemoveImage.Location = new System.Drawing.Point(142, 428);
            this.btnRemoveImage.Name = "btnRemoveImage";
            this.btnRemoveImage.Size = new System.Drawing.Size(252, 32);
            this.btnRemoveImage.TabIndex = 15;
            this.btnRemoveImage.Text = "✕ Clear Image";
            this.btnRemoveImage.UseVisualStyleBackColor = false;
            this.btnRemoveImage.Click += new System.EventHandler(this.BtnRemoveImage_Click);

            // 
            // lblImagePath
            // 
            this.lblImagePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImagePath.AutoEllipsis = true;
            this.lblImagePath.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblImagePath.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblImagePath.Location = new System.Drawing.Point(142, 465);
            this.lblImagePath.Name = "lblImagePath";
            this.lblImagePath.Size = new System.Drawing.Size(252, 20);
            this.lblImagePath.TabIndex = 16;
            this.lblImagePath.Text = "No image selected";

            // 
            // pnlCardFooter
            // 
            this.pnlCardFooter.Controls.Add(this.pnlButtons);
            this.pnlCardFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCardFooter.Location = new System.Drawing.Point(18, 541);
            this.pnlCardFooter.Name = "pnlCardFooter";
            this.pnlCardFooter.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pnlCardFooter.Size = new System.Drawing.Size(394, 54);
            this.pnlCardFooter.TabIndex = 1;

            // 
            // pnlButtons
            // 
            this.pnlButtons.ColumnCount = 3;
            this.pnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.pnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.pnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.pnlButtons.Controls.Add(this.btnSave, 0, 0);
            this.pnlButtons.Controls.Add(this.btnClear, 1, 0);
            this.pnlButtons.Controls.Add(this.btnDelete, 2, 0);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtons.Location = new System.Drawing.Point(0, 10);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.RowCount = 1;
            this.pnlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlButtons.Size = new System.Drawing.Size(394, 44);
            this.pnlButtons.TabIndex = 0;

            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(0, 0);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 44);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);

            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnClear.FlatAppearance.BorderSize = 1;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnClear.Location = new System.Drawing.Point(136, 0);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(124, 44);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);

            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.btnDelete.Location = new System.Drawing.Point(266, 0);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 44);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);

            // 
            // pnlRightCardWrapper
            // 
            this.pnlRightCardWrapper.Controls.Add(this.pnlRightCard);
            this.pnlRightCardWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRightCardWrapper.Location = new System.Drawing.Point(460, 72);
            this.pnlRightCardWrapper.Name = "pnlRightCardWrapper";
            this.pnlRightCardWrapper.Padding = new System.Windows.Forms.Padding(10, 16, 20, 20);
            this.pnlRightCardWrapper.Size = new System.Drawing.Size(724, 649);
            this.pnlRightCardWrapper.TabIndex = 2;

            // 
            // pnlRightCard
            // 
            this.pnlRightCard.BackColor = System.Drawing.Color.White;
            this.pnlRightCard.Controls.Add(this.dgvItems);
            this.pnlRightCard.Controls.Add(this.pnlGridHeader);
            this.pnlRightCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRightCard.Location = new System.Drawing.Point(10, 16);
            this.pnlRightCard.Name = "pnlRightCard";
            this.pnlRightCard.Padding = new System.Windows.Forms.Padding(18);
            this.pnlRightCard.Size = new System.Drawing.Size(694, 613);
            this.pnlRightCard.TabIndex = 0;
            this.pnlRightCard.Paint += new System.Windows.Forms.PaintEventHandler(this.CardPanel_Paint);

            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AllowUserToResizeRows = false;
            this.dgvItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dgvHeaderStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dgvHeaderStyle.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            dgvHeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dgvHeaderStyle.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            dgvHeaderStyle.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            dgvHeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            dgvHeaderStyle.SelectionForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            dgvHeaderStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItems.ColumnHeadersDefaultCellStyle = dgvHeaderStyle;
            this.dgvItems.ColumnHeadersHeight = 42;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItemID,
            this.colItemName,
            this.colCategoryName,
            this.colCategoryID,
            this.colUnitPrice,
            this.colStatus,
            this.colDescription,
            this.colItemImage});
            dgvRowStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dgvRowStyle.BackColor = System.Drawing.Color.White;
            dgvRowStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dgvRowStyle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            dgvRowStyle.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            dgvRowStyle.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
            dgvRowStyle.SelectionForeColor = System.Drawing.Color.FromArgb(30, 58, 138);
            dgvRowStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItems.DefaultCellStyle = dgvRowStyle;
            this.dgvItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItems.EnableHeadersVisualStyles = false;
            this.dgvItems.GridColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.dgvItems.Location = new System.Drawing.Point(18, 82);
            this.dgvItems.MultiSelect = false;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvItems.RowHeadersVisible = false;
            dgvAltRowStyle.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            dgvAltRowStyle.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
            dgvAltRowStyle.SelectionForeColor = System.Drawing.Color.FromArgb(30, 58, 138);
            this.dgvItems.RowsDefaultCellStyle = dgvAltRowStyle;
            this.dgvItems.RowTemplate.Height = 38;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(658, 513);
            this.dgvItems.TabIndex = 1;
            this.dgvItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvItems_CellClick);
            this.dgvItems.SelectionChanged += new System.EventHandler(this.DgvItems_SelectionChanged);

            // 
            // colItemID
            // 
            this.colItemID.DataPropertyName = "ItemID";
            this.colItemID.HeaderText = "ID";
            this.colItemID.MinimumWidth = 50;
            this.colItemID.Name = "colItemID";
            this.colItemID.ReadOnly = true;
            this.colItemID.Width = 60;

            // 
            // colItemName
            // 
            this.colItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colItemName.DataPropertyName = "ItemName";
            this.colItemName.FillWeight = 40F;
            this.colItemName.HeaderText = "Item Name";
            this.colItemName.MinimumWidth = 110;
            this.colItemName.Name = "colItemName";
            this.colItemName.ReadOnly = true;

            // 
            // colCategoryName
            // 
            this.colCategoryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCategoryName.DataPropertyName = "CategoryName";
            this.colCategoryName.FillWeight = 30F;
            this.colCategoryName.HeaderText = "Category";
            this.colCategoryName.MinimumWidth = 90;
            this.colCategoryName.Name = "colCategoryName";
            this.colCategoryName.ReadOnly = true;

            // 
            // colCategoryID
            // 
            this.colCategoryID.DataPropertyName = "CategoryID";
            this.colCategoryID.HeaderText = "CatID";
            this.colCategoryID.Name = "colCategoryID";
            this.colCategoryID.ReadOnly = true;
            this.colCategoryID.Visible = false;

            // 
            // colUnitPrice
            // 
            this.colUnitPrice.DataPropertyName = "UnitPrice";
            this.colUnitPrice.HeaderText = "Unit Price";
            this.colUnitPrice.MinimumWidth = 85;
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.ReadOnly = true;
            this.colUnitPrice.Width = 95;

            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "Status";
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 75;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 85;

            // 
            // colDescription
            // 
            this.colDescription.DataPropertyName = "Description";
            this.colDescription.HeaderText = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            this.colDescription.Visible = false;

            // 
            // colItemImage
            // 
            this.colItemImage.DataPropertyName = "ItemImage";
            this.colItemImage.HeaderText = "Image";
            this.colItemImage.Name = "colItemImage";
            this.colItemImage.ReadOnly = true;
            this.colItemImage.Visible = false;

            // 
            // pnlGridHeader
            // 
            this.pnlGridHeader.Controls.Add(this.lblRecordCount);
            this.pnlGridHeader.Controls.Add(this.btnRefresh);
            this.pnlGridHeader.Controls.Add(this.cmbFilterCategory);
            this.pnlGridHeader.Controls.Add(this.lblFilterCategory);
            this.pnlGridHeader.Controls.Add(this.lblGridTitle);
            this.pnlGridHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGridHeader.Location = new System.Drawing.Point(18, 18);
            this.pnlGridHeader.Name = "pnlGridHeader";
            this.pnlGridHeader.Size = new System.Drawing.Size(658, 64);
            this.pnlGridHeader.TabIndex = 0;

            // 
            // lblGridTitle
            // 
            this.lblGridTitle.AutoSize = true;
            this.lblGridTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblGridTitle.Location = new System.Drawing.Point(0, 8);
            this.lblGridTitle.Name = "lblGridTitle";
            this.lblGridTitle.Size = new System.Drawing.Size(123, 21);
            this.lblGridTitle.TabIndex = 0;
            this.lblGridTitle.Text = "Item Inventory";

            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblRecordCount.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblRecordCount.Location = new System.Drawing.Point(2, 34);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(89, 15);
            this.lblRecordCount.TabIndex = 1;
            this.lblRecordCount.Text = "Loading items...";

            // 
            // lblFilterCategory
            // 
            this.lblFilterCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFilterCategory.AutoSize = true;
            this.lblFilterCategory.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblFilterCategory.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblFilterCategory.Location = new System.Drawing.Point(340, 18);
            this.lblFilterCategory.Name = "lblFilterCategory";
            this.lblFilterCategory.Size = new System.Drawing.Size(39, 15);
            this.lblFilterCategory.TabIndex = 2;
            this.lblFilterCategory.Text = "Filter:";

            // 
            // cmbFilterCategory
            // 
            this.cmbFilterCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFilterCategory.BackColor = System.Drawing.Color.White;
            this.cmbFilterCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFilterCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbFilterCategory.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.cmbFilterCategory.FormattingEnabled = true;
            this.cmbFilterCategory.Location = new System.Drawing.Point(385, 14);
            this.cmbFilterCategory.Name = "cmbFilterCategory";
            this.cmbFilterCategory.Size = new System.Drawing.Size(175, 23);
            this.cmbFilterCategory.TabIndex = 3;
            this.cmbFilterCategory.SelectedIndexChanged += new System.EventHandler(this.CmbFilterCategory_SelectedIndexChanged);

            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnRefresh.Location = new System.Drawing.Point(568, 11);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 32);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "🔄 Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);

            // 
            // frmItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(244, 246, 249);
            this.ClientSize = new System.Drawing.Size(1184, 721);
            this.Controls.Add(this.pnlRightCardWrapper);
            this.Controls.Add(this.pnlLeftCardWrapper);
            this.Controls.Add(this.pnlTopHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular);
            this.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.MinimumSize = new System.Drawing.Size(1020, 680);
            this.Name = "frmItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Management";
            this.Load += new System.EventHandler(this.FrmItem_Load);

            this.pnlTopHeader.ResumeLayout(false);
            this.pnlTopHeader.PerformLayout();
            this.pnlLeftCardWrapper.ResumeLayout(false);
            this.pnlLeftCard.ResumeLayout(false);
            this.pnlCardBody.ResumeLayout(false);
            this.pnlCardBody.PerformLayout();
            this.pnlCardHeader.ResumeLayout(false);
            this.pnlCardHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItemPreview)).EndInit();
            this.pnlCardFooter.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.pnlRightCardWrapper.ResumeLayout(false);
            this.pnlRightCard.ResumeLayout(false);
            this.pnlGridHeader.ResumeLayout(false);
            this.pnlGridHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemImage;
    }
}
