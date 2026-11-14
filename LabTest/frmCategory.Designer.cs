namespace LabTest
{
    partial class frmCategory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();

            this.pnlTopHeader = new System.Windows.Forms.Panel();
            this.btnNavToItems = new System.Windows.Forms.Button();
            this.lblHeaderSubtitle = new System.Windows.Forms.Label();
            this.lblHeaderTitle = new System.Windows.Forms.Label();

            this.pnlLeftCardWrapper = new System.Windows.Forms.Panel();
            this.pnlLeftCard = new System.Windows.Forms.Panel();
            this.pnlCardBody = new System.Windows.Forms.Panel();
            this.pnlCardHeader = new System.Windows.Forms.Panel();
            this.lblModeBadge = new System.Windows.Forms.Label();
            this.lblCardTitle = new System.Windows.Forms.Label();
            this.lblCategoryID = new System.Windows.Forms.Label();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.lblImageHeading = new System.Windows.Forms.Label();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.pnlImageButtons = new System.Windows.Forms.Panel();
            this.btnRemoveImage = new System.Windows.Forms.Button();
            this.btnBrowseImage = new System.Windows.Forms.Button();
            this.lblImagePath = new System.Windows.Forms.Label();

            this.pnlCardFooter = new System.Windows.Forms.Panel();
            this.pnlButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();

            this.pnlRightCardWrapper = new System.Windows.Forms.Panel();
            this.pnlRightCard = new System.Windows.Forms.Panel();
            this.pnlGridHeader = new System.Windows.Forms.Panel();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblGridTitle = new System.Windows.Forms.Label();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.colImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.colCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImagePath = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.pnlTopHeader.SuspendLayout();
            this.pnlLeftCardWrapper.SuspendLayout();
            this.pnlLeftCard.SuspendLayout();
            this.pnlCardBody.SuspendLayout();
            this.pnlCardHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.pnlImageButtons.SuspendLayout();
            this.pnlCardFooter.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlRightCardWrapper.SuspendLayout();
            this.pnlRightCard.SuspendLayout();
            this.pnlGridHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.SuspendLayout();

            // 
            // pnlTopHeader
            // 
            this.pnlTopHeader.BackColor = System.Drawing.Color.White;
            this.pnlTopHeader.Controls.Add(this.btnNavToItems);
            this.pnlTopHeader.Controls.Add(this.lblHeaderSubtitle);
            this.pnlTopHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlTopHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlTopHeader.Name = "pnlTopHeader";
            this.pnlTopHeader.Padding = new System.Windows.Forms.Padding(24, 12, 24, 12);
            this.pnlTopHeader.Size = new System.Drawing.Size(1084, 72);
            this.pnlTopHeader.TabIndex = 0;
            this.pnlTopHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlTopHeader_Paint);

            // 
            // btnNavToItems
            // 
            this.btnNavToItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNavToItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.btnNavToItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavToItems.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(210)))), ((int)(((byte)(254)))));
            this.btnNavToItems.FlatAppearance.BorderSize = 1;
            this.btnNavToItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavToItems.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnNavToItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnNavToItems.Location = new System.Drawing.Point(884, 16);
            this.btnNavToItems.Name = "btnNavToItems";
            this.btnNavToItems.Size = new System.Drawing.Size(176, 40);
            this.btnNavToItems.TabIndex = 2;
            this.btnNavToItems.Text = "Manage Items →";
            this.btnNavToItems.UseVisualStyleBackColor = false;
            this.btnNavToItems.Click += new System.EventHandler(this.BtnNavToItems_Click);

            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(24, 42);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(434, 15);
            this.lblHeaderSubtitle.TabIndex = 1;
            this.lblHeaderSubtitle.Text = "Parent Table: tblcategories • Add, update, view, and organize catalog categories";

            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblHeaderTitle.Location = new System.Drawing.Point(23, 13);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(232, 28);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Category Management";

            // 
            // pnlLeftCardWrapper
            // 
            this.pnlLeftCardWrapper.Controls.Add(this.pnlLeftCard);
            this.pnlLeftCardWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftCardWrapper.Location = new System.Drawing.Point(0, 72);
            this.pnlLeftCardWrapper.Name = "pnlLeftCardWrapper";
            this.pnlLeftCardWrapper.Padding = new System.Windows.Forms.Padding(20, 16, 10, 20);
            this.pnlLeftCardWrapper.Size = new System.Drawing.Size(420, 609);
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
            this.pnlLeftCard.Size = new System.Drawing.Size(390, 573);
            this.pnlLeftCard.TabIndex = 0;
            this.pnlLeftCard.Paint += new System.Windows.Forms.PaintEventHandler(this.CardPanel_Paint);

            // 
            // pnlCardBody
            // 
            this.pnlCardBody.AutoScroll = true;
            this.pnlCardBody.Controls.Add(this.pnlCardHeader);
            this.pnlCardBody.Controls.Add(this.lblCategoryID);
            this.pnlCardBody.Controls.Add(this.txtCategoryID);
            this.pnlCardBody.Controls.Add(this.lblCategoryName);
            this.pnlCardBody.Controls.Add(this.txtCategoryName);
            this.pnlCardBody.Controls.Add(this.chkStatus);
            this.pnlCardBody.Controls.Add(this.lblImageHeading);
            this.pnlCardBody.Controls.Add(this.picPreview);
            this.pnlCardBody.Controls.Add(this.pnlImageButtons);
            this.pnlCardBody.Controls.Add(this.lblImagePath);
            this.pnlCardBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCardBody.Location = new System.Drawing.Point(18, 18);
            this.pnlCardBody.Name = "pnlCardBody";
            this.pnlCardBody.Size = new System.Drawing.Size(354, 483);
            this.pnlCardBody.TabIndex = 0;

            // 
            // pnlCardHeader
            // 
            this.pnlCardHeader.Controls.Add(this.lblModeBadge);
            this.pnlCardHeader.Controls.Add(this.lblCardTitle);
            this.pnlCardHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCardHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlCardHeader.Name = "pnlCardHeader";
            this.pnlCardHeader.Size = new System.Drawing.Size(354, 40);
            this.pnlCardHeader.TabIndex = 0;

            // 
            // lblCardTitle
            // 
            this.lblCardTitle.AutoSize = true;
            this.lblCardTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCardTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblCardTitle.Location = new System.Drawing.Point(0, 6);
            this.lblCardTitle.Name = "lblCardTitle";
            this.lblCardTitle.Size = new System.Drawing.Size(135, 21);
            this.lblCardTitle.TabIndex = 0;
            this.lblCardTitle.Text = "Category Details";

            // 
            // lblModeBadge
            // 
            this.lblModeBadge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblModeBadge.BackColor = System.Drawing.Color.FromArgb(239, 246, 255);
            this.lblModeBadge.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblModeBadge.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.lblModeBadge.Location = new System.Drawing.Point(234, 6);
            this.lblModeBadge.Name = "lblModeBadge";
            this.lblModeBadge.Size = new System.Drawing.Size(120, 24);
            this.lblModeBadge.TabIndex = 1;
            this.lblModeBadge.Text = "NEW RECORD";
            this.lblModeBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblCategoryID
            // 
            this.lblCategoryID.AutoSize = true;
            this.lblCategoryID.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCategoryID.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblCategoryID.Location = new System.Drawing.Point(0, 50);
            this.lblCategoryID.Name = "lblCategoryID";
            this.lblCategoryID.Size = new System.Drawing.Size(82, 17);
            this.lblCategoryID.TabIndex = 1;
            this.lblCategoryID.Text = "Category ID";

            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCategoryID.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.txtCategoryID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategoryID.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtCategoryID.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.txtCategoryID.Location = new System.Drawing.Point(0, 71);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.ReadOnly = true;
            this.txtCategoryID.Size = new System.Drawing.Size(354, 24);
            this.txtCategoryID.TabIndex = 2;
            this.txtCategoryID.Text = "(Auto-generated)";

            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCategoryName.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblCategoryName.Location = new System.Drawing.Point(0, 107);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(115, 17);
            this.lblCategoryName.TabIndex = 3;
            this.lblCategoryName.Text = "Category Name *";

            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCategoryName.BackColor = System.Drawing.Color.White;
            this.txtCategoryName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategoryName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCategoryName.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.txtCategoryName.Location = new System.Drawing.Point(0, 128);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.PlaceholderText = "e.g., Beverages, Electronics";
            this.txtCategoryName.Size = new System.Drawing.Size(354, 25);
            this.txtCategoryName.TabIndex = 4;

            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Checked = true;
            this.chkStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.chkStatus.ForeColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.chkStatus.Location = new System.Drawing.Point(0, 168);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(252, 21);
            this.chkStatus.TabIndex = 5;
            this.chkStatus.Text = "✓ Active (Category visible in catalog)";
            this.chkStatus.UseVisualStyleBackColor = true;
            this.chkStatus.CheckedChanged += new System.EventHandler(this.ChkStatus_CheckedChanged);

            // 
            // lblImageHeading
            // 
            this.lblImageHeading.AutoSize = true;
            this.lblImageHeading.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblImageHeading.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblImageHeading.Location = new System.Drawing.Point(0, 206);
            this.lblImageHeading.Name = "lblImageHeading";
            this.lblImageHeading.Size = new System.Drawing.Size(107, 17);
            this.lblImageHeading.TabIndex = 6;
            this.lblImageHeading.Text = "Category Image";

            // 
            // picPreview
            // 
            this.picPreview.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.picPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPreview.Location = new System.Drawing.Point(0, 228);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(160, 125);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreview.TabIndex = 7;
            this.picPreview.TabStop = false;

            // 
            // pnlImageButtons
            // 
            this.pnlImageButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlImageButtons.Controls.Add(this.btnRemoveImage);
            this.pnlImageButtons.Controls.Add(this.btnBrowseImage);
            this.pnlImageButtons.Location = new System.Drawing.Point(170, 228);
            this.pnlImageButtons.Name = "pnlImageButtons";
            this.pnlImageButtons.Size = new System.Drawing.Size(184, 125);
            this.pnlImageButtons.TabIndex = 8;

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
            this.btnBrowseImage.Location = new System.Drawing.Point(0, 12);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(184, 34);
            this.btnBrowseImage.TabIndex = 0;
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
            this.btnRemoveImage.Location = new System.Drawing.Point(0, 56);
            this.btnRemoveImage.Name = "btnRemoveImage";
            this.btnRemoveImage.Size = new System.Drawing.Size(184, 34);
            this.btnRemoveImage.TabIndex = 1;
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
            this.lblImagePath.Location = new System.Drawing.Point(0, 362);
            this.lblImagePath.Name = "lblImagePath";
            this.lblImagePath.Size = new System.Drawing.Size(354, 20);
            this.lblImagePath.TabIndex = 9;
            this.lblImagePath.Text = "No image selected";

            // 
            // pnlCardFooter
            // 
            this.pnlCardFooter.Controls.Add(this.pnlButtons);
            this.pnlCardFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCardFooter.Location = new System.Drawing.Point(18, 501);
            this.pnlCardFooter.Name = "pnlCardFooter";
            this.pnlCardFooter.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pnlCardFooter.Size = new System.Drawing.Size(354, 54);
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
            this.pnlButtons.Size = new System.Drawing.Size(354, 44);
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
            this.btnSave.Location = new Point(0, 0);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 44);
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
            this.btnClear.Location = new Point(123, 0);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 44);
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
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.btnDelete.Location = new Point(239, 0);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 44);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);

            // 
            // pnlRightCardWrapper
            // 
            this.pnlRightCardWrapper.Controls.Add(this.pnlRightCard);
            this.pnlRightCardWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRightCardWrapper.Location = new Point(420, 72);
            this.pnlRightCardWrapper.Name = "pnlRightCardWrapper";
            this.pnlRightCardWrapper.Padding = new System.Windows.Forms.Padding(10, 16, 20, 20);
            this.pnlRightCardWrapper.Size = new System.Drawing.Size(664, 609);
            this.pnlRightCardWrapper.TabIndex = 2;

            // 
            // pnlRightCard
            // 
            this.pnlRightCard.BackColor = System.Drawing.Color.White;
            this.pnlRightCard.Controls.Add(this.dgvCategories);
            this.pnlRightCard.Controls.Add(this.pnlGridHeader);
            this.pnlRightCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRightCard.Location = new Point(10, 16);
            this.pnlRightCard.Name = "pnlRightCard";
            this.pnlRightCard.Padding = new System.Windows.Forms.Padding(18);
            this.pnlRightCard.Size = new System.Drawing.Size(634, 573);
            this.pnlRightCard.TabIndex = 0;
            this.pnlRightCard.Paint += new System.Windows.Forms.PaintEventHandler(this.CardPanel_Paint);

            // 
            // dgvCategories
            // 
            this.dgvCategories.AllowUserToAddRows = false;
            this.dgvCategories.AllowUserToDeleteRows = false;
            this.dgvCategories.AllowUserToResizeRows = false;
            this.dgvCategories.BackgroundColor = System.Drawing.Color.White;
            this.dgvCategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCategories.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCategories.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCategories.ColumnHeadersHeight = 42;
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colImage,
            this.colCategoryID,
            this.colCategoryName,
            this.colStatus,
            this.colImagePath});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle2.Padding = new Padding(8, 0, 8, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(30, 58, 138);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategories.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCategories.Dock = DockStyle.Fill;
            this.dgvCategories.EnableHeadersVisualStyles = false;
            this.dgvCategories.GridColor = Color.FromArgb(241, 245, 249);
            this.dgvCategories.Location = new Point(18, 78);
            this.dgvCategories.MultiSelect = false;
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.ReadOnly = true;
            this.dgvCategories.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCategories.RowHeadersVisible = false;
            this.dgvCategories.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(30, 58, 138);
            this.dgvCategories.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCategories.RowTemplate.Height = 52;
            this.dgvCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategories.Size = new Size(598, 477);
            this.dgvCategories.TabIndex = 1;
            this.dgvCategories.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCategories_CellClick);
            this.dgvCategories.SelectionChanged += new System.EventHandler(this.DgvCategories_SelectionChanged);
            // 
            // colImage
            // 
            this.colImage.DataPropertyName = "ImagePreview";
            this.colImage.HeaderText = "Image";
            this.colImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colImage.MinimumWidth = 60;
            this.colImage.Name = "colImage";
            this.colImage.ReadOnly = true;
            this.colImage.Width = 70;
            // 
            // colCategoryID
            // 
            this.colCategoryID.DataPropertyName = "CategoryID";
            this.colCategoryID.HeaderText = "ID";
            this.colCategoryID.MinimumWidth = 50;
            this.colCategoryID.Name = "colCategoryID";
            this.colCategoryID.ReadOnly = true;
            this.colCategoryID.Width = 60;
            // 
            // colCategoryName
            // 
            this.colCategoryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCategoryName.DataPropertyName = "CategoryName";
            this.colCategoryName.FillWeight = 70F;
            this.colCategoryName.HeaderText = "Category Name";
            this.colCategoryName.MinimumWidth = 120;
            this.colCategoryName.Name = "colCategoryName";
            this.colCategoryName.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "Status";
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 70;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 80;
            // 
            // colImagePath
            // 
            this.colImagePath.DataPropertyName = "CategoryImage";
            this.colImagePath.HeaderText = "Image Path";
            this.colImagePath.Name = "colImagePath";
            this.colImagePath.ReadOnly = true;
            this.colImagePath.Visible = false;
            // 
            // pnlGridHeader
            // 
            this.pnlGridHeader.Controls.Add(this.lblRecordCount);
            this.pnlGridHeader.Controls.Add(this.btnRefresh);
            this.pnlGridHeader.Controls.Add(this.lblGridTitle);
            this.pnlGridHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGridHeader.Location = new System.Drawing.Point(18, 18);
            this.pnlGridHeader.Name = "pnlGridHeader";
            this.pnlGridHeader.Size = new System.Drawing.Size(598, 60);
            this.pnlGridHeader.TabIndex = 0;
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new Font("Segoe UI", 8.5F);
            this.lblRecordCount.ForeColor = Color.FromArgb(100, 116, 139);
            this.lblRecordCount.Location = new Point(2, 32);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(107, 15);
            this.lblRecordCount.TabIndex = 2;
            this.lblRecordCount.Text = "Loading records...";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnRefresh.Location = new System.Drawing.Point(504, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(94, 34);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "🔄 Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // lblGridTitle
            // 
            this.lblGridTitle.AutoSize = true;
            this.lblGridTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblGridTitle.Location = new System.Drawing.Point(0, 8);
            this.lblGridTitle.Name = "lblGridTitle";
            this.lblGridTitle.Size = new System.Drawing.Size(155, 21);
            this.lblGridTitle.TabIndex = 0;
            this.lblGridTitle.Text = "Existing Categories";
            // 
            // frmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1084, 681);
            this.Controls.Add(this.pnlRightCardWrapper);
            this.Controls.Add(this.pnlLeftCardWrapper);
            this.Controls.Add(this.pnlTopHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.MinimumSize = new System.Drawing.Size(960, 640);
            this.Name = "frmCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category Management";
            this.Load += new System.EventHandler(this.FrmCategory_Load);
            this.pnlTopHeader.ResumeLayout(false);
            this.pnlTopHeader.PerformLayout();
            this.pnlLeftCardWrapper.ResumeLayout(false);
            this.pnlLeftCard.ResumeLayout(false);
            this.pnlCardBody.ResumeLayout(false);
            this.pnlCardBody.PerformLayout();
            this.pnlCardHeader.ResumeLayout(false);
            this.pnlCardHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.pnlImageButtons.ResumeLayout(false);
            this.pnlCardFooter.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.pnlRightCardWrapper.ResumeLayout(false);
            this.pnlRightCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            this.pnlGridHeader.ResumeLayout(false);
            this.pnlGridHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSubtitle;
        private System.Windows.Forms.Button btnNavToItems;
        private System.Windows.Forms.Panel pnlLeftCardWrapper;
        private System.Windows.Forms.Panel pnlLeftCard;
        private System.Windows.Forms.Panel pnlCardBody;
        private System.Windows.Forms.Panel pnlCardHeader;
        private System.Windows.Forms.Label lblCardTitle;
        private System.Windows.Forms.Label lblModeBadge;
        private System.Windows.Forms.Label lblCategoryID;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.Label lblImageHeading;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Panel pnlImageButtons;
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
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.DataGridView dgvCategories;
        private System.Windows.Forms.DataGridViewImageColumn colImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImagePath;
    }
}
