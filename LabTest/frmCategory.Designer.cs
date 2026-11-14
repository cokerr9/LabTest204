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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlTopHeader = new Panel();
            btnNavToItems = new Button();
            lblHeaderTitle = new Label();
            pnlLeftCardWrapper = new Panel();
            pnlLeftCard = new Panel();
            pnlCardBody = new Panel();
            pnlCardHeader = new Panel();
            lblModeBadge = new Label();
            lblCardTitle = new Label();
            lblCategoryID = new Label();
            txtCategoryID = new TextBox();
            lblCategoryName = new Label();
            txtCategoryName = new TextBox();
            chkStatus = new CheckBox();
            lblImageHeading = new Label();
            picPreview = new PictureBox();
            pnlImageButtons = new Panel();
            btnRemoveImage = new Button();
            btnBrowseImage = new Button();
            lblImagePath = new Label();
            pnlCardFooter = new Panel();
            pnlButtons = new TableLayoutPanel();
            btnSave = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            pnlRightCardWrapper = new Panel();
            pnlRightCard = new Panel();
            dgvCategories = new DataGridView();
            colImage = new DataGridViewImageColumn();
            colCategoryID = new DataGridViewTextBoxColumn();
            colCategoryName = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colImagePath = new DataGridViewTextBoxColumn();
            pnlGridHeader = new Panel();
            lblRecordCount = new Label();
            btnRefresh = new Button();
            lblGridTitle = new Label();
            pnlTopHeader.SuspendLayout();
            pnlLeftCardWrapper.SuspendLayout();
            pnlLeftCard.SuspendLayout();
            pnlCardBody.SuspendLayout();
            pnlCardHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPreview).BeginInit();
            pnlImageButtons.SuspendLayout();
            pnlCardFooter.SuspendLayout();
            pnlButtons.SuspendLayout();
            pnlRightCardWrapper.SuspendLayout();
            pnlRightCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            pnlGridHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTopHeader
            // 
            pnlTopHeader.BackColor = Color.White;
            pnlTopHeader.Controls.Add(btnNavToItems);
            pnlTopHeader.Controls.Add(lblHeaderTitle);
            pnlTopHeader.Dock = DockStyle.Top;
            pnlTopHeader.Location = new Point(0, 0);
            pnlTopHeader.Name = "pnlTopHeader";
            pnlTopHeader.Padding = new Padding(24, 12, 24, 12);
            pnlTopHeader.Size = new Size(1084, 72);
            pnlTopHeader.TabIndex = 0;
            pnlTopHeader.Paint += PnlTopHeader_Paint;
            // 
            // btnNavToItems
            // 
            btnNavToItems.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNavToItems.BackColor = Color.FromArgb(238, 242, 255);
            btnNavToItems.Cursor = Cursors.Hand;
            btnNavToItems.FlatAppearance.BorderColor = Color.FromArgb(199, 210, 254);
            btnNavToItems.FlatStyle = FlatStyle.Flat;
            btnNavToItems.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnNavToItems.ForeColor = Color.FromArgb(37, 99, 235);
            btnNavToItems.Location = new Point(884, 16);
            btnNavToItems.Name = "btnNavToItems";
            btnNavToItems.Size = new Size(176, 40);
            btnNavToItems.TabIndex = 2;
            btnNavToItems.Text = "Manage Items →";
            btnNavToItems.UseVisualStyleBackColor = false;
            btnNavToItems.Click += BtnNavToItems_Click;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.FromArgb(192, 192, 255);
            lblHeaderTitle.Location = new Point(23, 13);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(285, 35);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "Category Management";
            // 
            // pnlLeftCardWrapper
            // 
            pnlLeftCardWrapper.Controls.Add(pnlLeftCard);
            pnlLeftCardWrapper.Dock = DockStyle.Left;
            pnlLeftCardWrapper.Location = new Point(0, 72);
            pnlLeftCardWrapper.Name = "pnlLeftCardWrapper";
            pnlLeftCardWrapper.Padding = new Padding(20, 16, 10, 20);
            pnlLeftCardWrapper.Size = new Size(420, 609);
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
            pnlLeftCard.Size = new Size(390, 573);
            pnlLeftCard.TabIndex = 0;
            pnlLeftCard.Paint += CardPanel_Paint;
            // 
            // pnlCardBody
            // 
            pnlCardBody.AutoScroll = true;
            pnlCardBody.Controls.Add(pnlCardHeader);
            pnlCardBody.Controls.Add(lblCategoryID);
            pnlCardBody.Controls.Add(txtCategoryID);
            pnlCardBody.Controls.Add(lblCategoryName);
            pnlCardBody.Controls.Add(txtCategoryName);
            pnlCardBody.Controls.Add(chkStatus);
            pnlCardBody.Controls.Add(lblImageHeading);
            pnlCardBody.Controls.Add(picPreview);
            pnlCardBody.Controls.Add(pnlImageButtons);
            pnlCardBody.Controls.Add(lblImagePath);
            pnlCardBody.Dock = DockStyle.Fill;
            pnlCardBody.Location = new Point(18, 18);
            pnlCardBody.Name = "pnlCardBody";
            pnlCardBody.Size = new Size(354, 483);
            pnlCardBody.TabIndex = 0;
            // 
            // pnlCardHeader
            // 
            pnlCardHeader.Controls.Add(lblModeBadge);
            pnlCardHeader.Controls.Add(lblCardTitle);
            pnlCardHeader.Dock = DockStyle.Top;
            pnlCardHeader.Location = new Point(0, 0);
            pnlCardHeader.Name = "pnlCardHeader";
            pnlCardHeader.Size = new Size(354, 40);
            pnlCardHeader.TabIndex = 0;
            // 
            // lblModeBadge
            // 
            lblModeBadge.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblModeBadge.BackColor = Color.FromArgb(239, 246, 255);
            lblModeBadge.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblModeBadge.ForeColor = Color.FromArgb(37, 99, 235);
            lblModeBadge.Location = new Point(223, 6);
            lblModeBadge.Name = "lblModeBadge";
            lblModeBadge.Size = new Size(120, 24);
            lblModeBadge.TabIndex = 1;
            lblModeBadge.Text = "NEW RECORD";
            lblModeBadge.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCardTitle
            // 
            lblCardTitle.AutoSize = true;
            lblCardTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCardTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblCardTitle.Location = new Point(10, 6);
            lblCardTitle.Name = "lblCardTitle";
            lblCardTitle.Size = new Size(170, 28);
            lblCardTitle.TabIndex = 0;
            lblCardTitle.Text = "Category Details";
            // 
            // lblCategoryID
            // 
            lblCategoryID.AutoSize = true;
            lblCategoryID.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCategoryID.ForeColor = Color.FromArgb(30, 41, 59);
            lblCategoryID.Location = new Point(0, 50);
            lblCategoryID.Name = "lblCategoryID";
            lblCategoryID.Size = new Size(101, 21);
            lblCategoryID.TabIndex = 1;
            lblCategoryID.Text = "Category ID";
            // 
            // txtCategoryID
            // 
            txtCategoryID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCategoryID.BackColor = Color.FromArgb(248, 250, 252);
            txtCategoryID.BorderStyle = BorderStyle.FixedSingle;
            txtCategoryID.Font = new Font("Segoe UI", 9.5F);
            txtCategoryID.ForeColor = Color.FromArgb(100, 116, 139);
            txtCategoryID.Location = new Point(0, 71);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.ReadOnly = true;
            txtCategoryID.Size = new Size(354, 29);
            txtCategoryID.TabIndex = 2;
            txtCategoryID.Text = "(Auto-generated)";
            // 
            // lblCategoryName
            // 
            lblCategoryName.AutoSize = true;
            lblCategoryName.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCategoryName.ForeColor = Color.FromArgb(30, 41, 59);
            lblCategoryName.Location = new Point(0, 107);
            lblCategoryName.Name = "lblCategoryName";
            lblCategoryName.Size = new Size(141, 21);
            lblCategoryName.TabIndex = 3;
            lblCategoryName.Text = "Category Name *";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCategoryName.BackColor = Color.White;
            txtCategoryName.BorderStyle = BorderStyle.FixedSingle;
            txtCategoryName.Font = new Font("Segoe UI", 10F);
            txtCategoryName.ForeColor = Color.FromArgb(30, 41, 59);
            txtCategoryName.Location = new Point(0, 128);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(354, 30);
            txtCategoryName.TabIndex = 4;
            // 
            // chkStatus
            // 
            chkStatus.AutoSize = true;
            chkStatus.Checked = true;
            chkStatus.CheckState = CheckState.Checked;
            chkStatus.Cursor = Cursors.Hand;
            chkStatus.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            chkStatus.ForeColor = Color.FromArgb(16, 185, 129);
            chkStatus.Location = new Point(10, 176);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new Size(317, 25);
            chkStatus.TabIndex = 5;
            chkStatus.Text = "✓ Active (Category visible in catalog)";
            chkStatus.UseVisualStyleBackColor = true;
            chkStatus.CheckedChanged += ChkStatus_CheckedChanged;
            // 
            // lblImageHeading
            // 
            lblImageHeading.AutoSize = true;
            lblImageHeading.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblImageHeading.ForeColor = Color.FromArgb(30, 41, 59);
            lblImageHeading.Location = new Point(0, 206);
            lblImageHeading.Name = "lblImageHeading";
            lblImageHeading.Size = new Size(132, 21);
            lblImageHeading.TabIndex = 6;
            lblImageHeading.Text = "Category Image";
            // 
            // picPreview
            // 
            picPreview.BackColor = Color.FromArgb(248, 250, 252);
            picPreview.BorderStyle = BorderStyle.FixedSingle;
            picPreview.Location = new Point(0, 228);
            picPreview.Name = "picPreview";
            picPreview.Size = new Size(160, 125);
            picPreview.SizeMode = PictureBoxSizeMode.Zoom;
            picPreview.TabIndex = 7;
            picPreview.TabStop = false;
            // 
            // pnlImageButtons
            // 
            pnlImageButtons.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlImageButtons.Controls.Add(btnRemoveImage);
            pnlImageButtons.Controls.Add(btnBrowseImage);
            pnlImageButtons.Location = new Point(170, 228);
            pnlImageButtons.Name = "pnlImageButtons";
            pnlImageButtons.Size = new Size(184, 125);
            pnlImageButtons.TabIndex = 8;
            // 
            // btnRemoveImage
            // 
            btnRemoveImage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnRemoveImage.BackColor = Color.FromArgb(254, 242, 242);
            btnRemoveImage.Cursor = Cursors.Hand;
            btnRemoveImage.FlatAppearance.BorderColor = Color.FromArgb(254, 202, 202);
            btnRemoveImage.FlatStyle = FlatStyle.Flat;
            btnRemoveImage.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRemoveImage.ForeColor = Color.FromArgb(220, 38, 38);
            btnRemoveImage.Location = new Point(14, 71);
            btnRemoveImage.Name = "btnRemoveImage";
            btnRemoveImage.Size = new Size(157, 34);
            btnRemoveImage.TabIndex = 1;
            btnRemoveImage.Text = "✕ Clear Image";
            btnRemoveImage.UseVisualStyleBackColor = false;
            btnRemoveImage.Click += BtnRemoveImage_Click;
            // 
            // btnBrowseImage
            // 
            btnBrowseImage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnBrowseImage.BackColor = Color.FromArgb(238, 242, 255);
            btnBrowseImage.Cursor = Cursors.Hand;
            btnBrowseImage.FlatAppearance.BorderColor = Color.FromArgb(199, 210, 254);
            btnBrowseImage.FlatStyle = FlatStyle.Flat;
            btnBrowseImage.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBrowseImage.ForeColor = Color.FromArgb(37, 99, 235);
            btnBrowseImage.Location = new Point(14, 27);
            btnBrowseImage.Name = "btnBrowseImage";
            btnBrowseImage.Size = new Size(157, 34);
            btnBrowseImage.TabIndex = 0;
            btnBrowseImage.Text = "📁 Browse File...";
            btnBrowseImage.UseVisualStyleBackColor = false;
            btnBrowseImage.Click += BtnBrowseImage_Click;
            // 
            // lblImagePath
            // 
            lblImagePath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblImagePath.AutoEllipsis = true;
            lblImagePath.Font = new Font("Segoe UI", 8.5F);
            lblImagePath.ForeColor = Color.FromArgb(148, 163, 184);
            lblImagePath.Location = new Point(0, 362);
            lblImagePath.Name = "lblImagePath";
            lblImagePath.Size = new Size(354, 20);
            lblImagePath.TabIndex = 9;
            lblImagePath.Text = "No image selected";
            // 
            // pnlCardFooter
            // 
            pnlCardFooter.Controls.Add(pnlButtons);
            pnlCardFooter.Dock = DockStyle.Bottom;
            pnlCardFooter.Location = new Point(18, 501);
            pnlCardFooter.Name = "pnlCardFooter";
            pnlCardFooter.Padding = new Padding(0, 10, 0, 0);
            pnlCardFooter.Size = new Size(354, 54);
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
            pnlButtons.Size = new Size(354, 44);
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
            btnSave.Size = new Size(116, 44);
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
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnClear.ForeColor = Color.FromArgb(51, 65, 85);
            btnClear.Location = new Point(123, 0);
            btnClear.Margin = new Padding(3, 0, 3, 0);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(110, 44);
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
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnDelete.ForeColor = Color.FromArgb(148, 163, 184);
            btnDelete.Location = new Point(239, 0);
            btnDelete.Margin = new Padding(3, 0, 0, 0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(115, 44);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += BtnDelete_Click;
            // 
            // pnlRightCardWrapper
            // 
            pnlRightCardWrapper.Controls.Add(pnlRightCard);
            pnlRightCardWrapper.Dock = DockStyle.Fill;
            pnlRightCardWrapper.Location = new Point(420, 72);
            pnlRightCardWrapper.Name = "pnlRightCardWrapper";
            pnlRightCardWrapper.Padding = new Padding(10, 16, 20, 20);
            pnlRightCardWrapper.Size = new Size(664, 609);
            pnlRightCardWrapper.TabIndex = 2;
            // 
            // pnlRightCard
            // 
            pnlRightCard.BackColor = Color.White;
            pnlRightCard.Controls.Add(dgvCategories);
            pnlRightCard.Controls.Add(pnlGridHeader);
            pnlRightCard.Dock = DockStyle.Fill;
            pnlRightCard.Location = new Point(10, 16);
            pnlRightCard.Name = "pnlRightCard";
            pnlRightCard.Padding = new Padding(18);
            pnlRightCard.Size = new Size(634, 573);
            pnlRightCard.TabIndex = 0;
            pnlRightCard.Paint += CardPanel_Paint;
            // 
            // dgvCategories
            // 
            dgvCategories.AllowUserToAddRows = false;
            dgvCategories.AllowUserToDeleteRows = false;
            dgvCategories.AllowUserToResizeRows = false;
            dgvCategories.BackgroundColor = Color.White;
            dgvCategories.BorderStyle = BorderStyle.None;
            dgvCategories.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCategories.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(71, 85, 105);
            dataGridViewCellStyle1.Padding = new Padding(8, 0, 8, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(71, 85, 105);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCategories.ColumnHeadersHeight = 42;
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCategories.Columns.AddRange(new DataGridViewColumn[] { colImage, colCategoryID, colCategoryName, colStatus, colImagePath });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle2.Padding = new Padding(8, 0, 8, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(30, 58, 138);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCategories.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCategories.Dock = DockStyle.Fill;
            dgvCategories.EnableHeadersVisualStyles = false;
            dgvCategories.GridColor = Color.FromArgb(241, 245, 249);
            dgvCategories.Location = new Point(18, 78);
            dgvCategories.MultiSelect = false;
            dgvCategories.Name = "dgvCategories";
            dgvCategories.ReadOnly = true;
            dgvCategories.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCategories.RowHeadersVisible = false;
            dgvCategories.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(30, 58, 138);
            dgvCategories.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvCategories.RowTemplate.Height = 52;
            dgvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategories.Size = new Size(598, 477);
            dgvCategories.TabIndex = 1;
            dgvCategories.CellClick += DgvCategories_CellClick;
            dgvCategories.SelectionChanged += DgvCategories_SelectionChanged;
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
            // colCategoryID
            // 
            colCategoryID.DataPropertyName = "CategoryID";
            colCategoryID.HeaderText = "ID";
            colCategoryID.MinimumWidth = 50;
            colCategoryID.Name = "colCategoryID";
            colCategoryID.ReadOnly = true;
            colCategoryID.Width = 60;
            // 
            // colCategoryName
            // 
            colCategoryName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCategoryName.DataPropertyName = "CategoryName";
            colCategoryName.FillWeight = 70F;
            colCategoryName.HeaderText = "Category Name";
            colCategoryName.MinimumWidth = 120;
            colCategoryName.Name = "colCategoryName";
            colCategoryName.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "Status";
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 70;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.Width = 80;
            // 
            // colImagePath
            // 
            colImagePath.DataPropertyName = "CategoryImage";
            colImagePath.HeaderText = "Image Path";
            colImagePath.MinimumWidth = 6;
            colImagePath.Name = "colImagePath";
            colImagePath.ReadOnly = true;
            colImagePath.Visible = false;
            colImagePath.Width = 125;
            // 
            // pnlGridHeader
            // 
            pnlGridHeader.Controls.Add(lblRecordCount);
            pnlGridHeader.Controls.Add(btnRefresh);
            pnlGridHeader.Controls.Add(lblGridTitle);
            pnlGridHeader.Dock = DockStyle.Top;
            pnlGridHeader.Location = new Point(18, 18);
            pnlGridHeader.Name = "pnlGridHeader";
            pnlGridHeader.Size = new Size(598, 60);
            pnlGridHeader.TabIndex = 0;
            // 
            // lblRecordCount
            // 
            lblRecordCount.AutoSize = true;
            lblRecordCount.Font = new Font("Segoe UI", 8.5F);
            lblRecordCount.ForeColor = Color.FromArgb(100, 116, 139);
            lblRecordCount.Location = new Point(2, 32);
            lblRecordCount.Name = "lblRecordCount";
            lblRecordCount.Size = new Size(125, 20);
            lblRecordCount.TabIndex = 2;
            lblRecordCount.Text = "Loading records...";
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
            btnRefresh.Location = new Point(485, 12);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 34);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "🔄 Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += BtnRefresh_Click;
            // 
            // lblGridTitle
            // 
            lblGridTitle.AutoSize = true;
            lblGridTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblGridTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblGridTitle.Location = new Point(8, 8);
            lblGridTitle.Name = "lblGridTitle";
            lblGridTitle.Size = new Size(112, 28);
            lblGridTitle.TabIndex = 0;
            lblGridTitle.Text = "Categories";
            // 
            // frmCategory
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(1084, 681);
            Controls.Add(pnlRightCardWrapper);
            Controls.Add(pnlLeftCardWrapper);
            Controls.Add(pnlTopHeader);
            Font = new Font("Segoe UI", 9.75F);
            ForeColor = Color.FromArgb(30, 41, 59);
            MinimumSize = new Size(960, 640);
            Name = "frmCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Category Management";
            Load += FrmCategory_Load;
            pnlTopHeader.ResumeLayout(false);
            pnlTopHeader.PerformLayout();
            pnlLeftCardWrapper.ResumeLayout(false);
            pnlLeftCard.ResumeLayout(false);
            pnlCardBody.ResumeLayout(false);
            pnlCardBody.PerformLayout();
            pnlCardHeader.ResumeLayout(false);
            pnlCardHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPreview).EndInit();
            pnlImageButtons.ResumeLayout(false);
            pnlCardFooter.ResumeLayout(false);
            pnlButtons.ResumeLayout(false);
            pnlRightCardWrapper.ResumeLayout(false);
            pnlRightCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            pnlGridHeader.ResumeLayout(false);
            pnlGridHeader.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
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
