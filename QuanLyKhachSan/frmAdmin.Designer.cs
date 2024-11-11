namespace QuanLyKhachSan
{
    partial class frmAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.tabAccount = new System.Windows.Forms.TabPage();
            this.panel9 = new System.Windows.Forms.Panel();
            this.numTypeAccount = new System.Windows.Forms.NumericUpDown();
            this.txtPassAccount = new System.Windows.Forms.TextBox();
            this.lblPassAccount = new System.Windows.Forms.Label();
            this.btnNewAccount = new System.Windows.Forms.Button();
            this.btnFixAccount = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.txtNameAccount = new System.Windows.Forms.TextBox();
            this.lblTypeAccount = new System.Windows.Forms.Label();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.lblNameAccount = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dtgAccount = new System.Windows.Forms.DataGridView();
            this.tabRoom = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.numRoomCategory = new System.Windows.Forms.NumericUpDown();
            this.btnNewRoom = new System.Windows.Forms.Button();
            this.btnFixRoom = new System.Windows.Forms.Button();
            this.lblRoomCategory = new System.Windows.Forms.Label();
            this.btnDeleteRoom = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtRoomStatus = new System.Windows.Forms.TextBox();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.txtIdRoom = new System.Windows.Forms.TextBox();
            this.lblRoomStatus = new System.Windows.Forms.Label();
            this.lblRoomName = new System.Windows.Forms.Label();
            this.lblIdRoom = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtgRoom = new System.Windows.Forms.DataGridView();
            this.tabCategory = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtgCategory = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtNameCategory = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnFix = new System.Windows.Forms.Button();
            this.txtIdCategory = new System.Windows.Forms.TextBox();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.lblIdCategory = new System.Windows.Forms.Label();
            this.tabAdmin = new System.Windows.Forms.TabControl();
            this.tabAccount.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTypeAccount)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAccount)).BeginInit();
            this.tabRoom.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRoomCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRoom)).BeginInit();
            this.tabCategory.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategory)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAccount
            // 
            this.tabAccount.Controls.Add(this.panel9);
            this.tabAccount.Controls.Add(this.panel8);
            this.tabAccount.Location = new System.Drawing.Point(4, 29);
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccount.Size = new System.Drawing.Size(1046, 606);
            this.tabAccount.TabIndex = 3;
            this.tabAccount.Text = "Tài Khoản";
            this.tabAccount.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.numTypeAccount);
            this.panel9.Controls.Add(this.txtPassAccount);
            this.panel9.Controls.Add(this.lblPassAccount);
            this.panel9.Controls.Add(this.btnNewAccount);
            this.panel9.Controls.Add(this.btnFixAccount);
            this.panel9.Controls.Add(this.btnDeleteAccount);
            this.panel9.Controls.Add(this.btnAddAccount);
            this.panel9.Controls.Add(this.txtDisplayName);
            this.panel9.Controls.Add(this.txtNameAccount);
            this.panel9.Controls.Add(this.lblTypeAccount);
            this.panel9.Controls.Add(this.lblDisplayName);
            this.panel9.Controls.Add(this.lblNameAccount);
            this.panel9.Location = new System.Drawing.Point(660, 9);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(380, 589);
            this.panel9.TabIndex = 1;
            // 
            // numTypeAccount
            // 
            this.numTypeAccount.Location = new System.Drawing.Point(21, 265);
            this.numTypeAccount.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTypeAccount.Name = "numTypeAccount";
            this.numTypeAccount.Size = new System.Drawing.Size(331, 26);
            this.numTypeAccount.TabIndex = 7;
            // 
            // txtPassAccount
            // 
            this.txtPassAccount.Location = new System.Drawing.Point(17, 189);
            this.txtPassAccount.Name = "txtPassAccount";
            this.txtPassAccount.Size = new System.Drawing.Size(335, 26);
            this.txtPassAccount.TabIndex = 5;
            // 
            // lblPassAccount
            // 
            this.lblPassAccount.AutoSize = true;
            this.lblPassAccount.Location = new System.Drawing.Point(17, 161);
            this.lblPassAccount.Name = "lblPassAccount";
            this.lblPassAccount.Size = new System.Drawing.Size(77, 20);
            this.lblPassAccount.TabIndex = 4;
            this.lblPassAccount.Text = "Mật Khẩu";
            // 
            // btnNewAccount
            // 
            this.btnNewAccount.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnNewAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewAccount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNewAccount.Location = new System.Drawing.Point(205, 533);
            this.btnNewAccount.Name = "btnNewAccount";
            this.btnNewAccount.Size = new System.Drawing.Size(147, 41);
            this.btnNewAccount.TabIndex = 11;
            this.btnNewAccount.Text = "Làm Mới";
            this.btnNewAccount.UseVisualStyleBackColor = false;
            this.btnNewAccount.Click += new System.EventHandler(this.btnNewAccount_Click);
            // 
            // btnFixAccount
            // 
            this.btnFixAccount.BackColor = System.Drawing.Color.Orange;
            this.btnFixAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFixAccount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFixAccount.Location = new System.Drawing.Point(21, 533);
            this.btnFixAccount.Name = "btnFixAccount";
            this.btnFixAccount.Size = new System.Drawing.Size(147, 41);
            this.btnFixAccount.TabIndex = 10;
            this.btnFixAccount.Text = "Sửa";
            this.btnFixAccount.UseVisualStyleBackColor = false;
            this.btnFixAccount.Click += new System.EventHandler(this.btnFixAccount_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.BackColor = System.Drawing.Color.Red;
            this.btnDeleteAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAccount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteAccount.Location = new System.Drawing.Point(205, 475);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(147, 41);
            this.btnDeleteAccount.TabIndex = 9;
            this.btnDeleteAccount.Text = "Xóa";
            this.btnDeleteAccount.UseVisualStyleBackColor = false;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAccount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddAccount.Location = new System.Drawing.Point(21, 475);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(147, 41);
            this.btnAddAccount.TabIndex = 8;
            this.btnAddAccount.Text = "Thêm";
            this.btnAddAccount.UseVisualStyleBackColor = false;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Location = new System.Drawing.Point(21, 113);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(331, 26);
            this.txtDisplayName.TabIndex = 3;
            // 
            // txtNameAccount
            // 
            this.txtNameAccount.Location = new System.Drawing.Point(17, 39);
            this.txtNameAccount.Name = "txtNameAccount";
            this.txtNameAccount.Size = new System.Drawing.Size(335, 26);
            this.txtNameAccount.TabIndex = 1;
            // 
            // lblTypeAccount
            // 
            this.lblTypeAccount.AutoSize = true;
            this.lblTypeAccount.Location = new System.Drawing.Point(17, 232);
            this.lblTypeAccount.Name = "lblTypeAccount";
            this.lblTypeAccount.Size = new System.Drawing.Size(114, 20);
            this.lblTypeAccount.TabIndex = 6;
            this.lblTypeAccount.Text = "Loại Tài Khoản";
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.Location = new System.Drawing.Point(17, 82);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(98, 20);
            this.lblDisplayName.TabIndex = 2;
            this.lblDisplayName.Text = "Tên Hiển Thị";
            // 
            // lblNameAccount
            // 
            this.lblNameAccount.AutoSize = true;
            this.lblNameAccount.Location = new System.Drawing.Point(13, 12);
            this.lblNameAccount.Name = "lblNameAccount";
            this.lblNameAccount.Size = new System.Drawing.Size(111, 20);
            this.lblNameAccount.TabIndex = 0;
            this.lblNameAccount.Text = "Tên Tài Khoản";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dtgAccount);
            this.panel8.Location = new System.Drawing.Point(6, 6);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(648, 592);
            this.panel8.TabIndex = 0;
            // 
            // dtgAccount
            // 
            this.dtgAccount.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgAccount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAccount.Location = new System.Drawing.Point(3, 3);
            this.dtgAccount.Name = "dtgAccount";
            this.dtgAccount.RowHeadersWidth = 62;
            this.dtgAccount.RowTemplate.Height = 28;
            this.dtgAccount.Size = new System.Drawing.Size(642, 586);
            this.dtgAccount.TabIndex = 0;
            this.dtgAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAccount_CellClick);
            // 
            // tabRoom
            // 
            this.tabRoom.Controls.Add(this.panel7);
            this.tabRoom.Controls.Add(this.panel6);
            this.tabRoom.Controls.Add(this.panel5);
            this.tabRoom.Location = new System.Drawing.Point(4, 29);
            this.tabRoom.Name = "tabRoom";
            this.tabRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabRoom.Size = new System.Drawing.Size(1046, 606);
            this.tabRoom.TabIndex = 2;
            this.tabRoom.Text = "Phòng";
            this.tabRoom.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnSearch);
            this.panel7.Controls.Add(this.txtSearch);
            this.panel7.Location = new System.Drawing.Point(3, 19);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(585, 37);
            this.panel7.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(358, 1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(154, 35);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(3, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(345, 26);
            this.txtSearch.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.numRoomCategory);
            this.panel6.Controls.Add(this.btnNewRoom);
            this.panel6.Controls.Add(this.btnFixRoom);
            this.panel6.Controls.Add(this.lblRoomCategory);
            this.panel6.Controls.Add(this.btnDeleteRoom);
            this.panel6.Controls.Add(this.btnAddRoom);
            this.panel6.Controls.Add(this.numPrice);
            this.panel6.Controls.Add(this.lblPrice);
            this.panel6.Controls.Add(this.txtRoomStatus);
            this.panel6.Controls.Add(this.txtRoomName);
            this.panel6.Controls.Add(this.txtIdRoom);
            this.panel6.Controls.Add(this.lblRoomStatus);
            this.panel6.Controls.Add(this.lblRoomName);
            this.panel6.Controls.Add(this.lblIdRoom);
            this.panel6.Location = new System.Drawing.Point(591, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(452, 591);
            this.panel6.TabIndex = 0;
            // 
            // numRoomCategory
            // 
            this.numRoomCategory.Location = new System.Drawing.Point(26, 309);
            this.numRoomCategory.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numRoomCategory.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRoomCategory.Name = "numRoomCategory";
            this.numRoomCategory.Size = new System.Drawing.Size(173, 26);
            this.numRoomCategory.TabIndex = 5;
            this.numRoomCategory.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnNewRoom
            // 
            this.btnNewRoom.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnNewRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewRoom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNewRoom.Location = new System.Drawing.Point(256, 527);
            this.btnNewRoom.Name = "btnNewRoom";
            this.btnNewRoom.Size = new System.Drawing.Size(173, 42);
            this.btnNewRoom.TabIndex = 13;
            this.btnNewRoom.Text = "Làm Mới";
            this.btnNewRoom.UseVisualStyleBackColor = false;
            this.btnNewRoom.Click += new System.EventHandler(this.btnNewRoom_Click);
            // 
            // btnFixRoom
            // 
            this.btnFixRoom.BackColor = System.Drawing.Color.Orange;
            this.btnFixRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFixRoom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFixRoom.Location = new System.Drawing.Point(26, 527);
            this.btnFixRoom.Name = "btnFixRoom";
            this.btnFixRoom.Size = new System.Drawing.Size(173, 42);
            this.btnFixRoom.TabIndex = 12;
            this.btnFixRoom.Text = "Sửa";
            this.btnFixRoom.UseVisualStyleBackColor = false;
            this.btnFixRoom.Click += new System.EventHandler(this.btnFixRoom_Click);
            // 
            // lblRoomCategory
            // 
            this.lblRoomCategory.AutoSize = true;
            this.lblRoomCategory.Location = new System.Drawing.Point(22, 272);
            this.lblRoomCategory.Name = "lblRoomCategory";
            this.lblRoomCategory.Size = new System.Drawing.Size(108, 20);
            this.lblRoomCategory.TabIndex = 4;
            this.lblRoomCategory.Text = "Mã Danh Mục";
            // 
            // btnDeleteRoom
            // 
            this.btnDeleteRoom.BackColor = System.Drawing.Color.Red;
            this.btnDeleteRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRoom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteRoom.Location = new System.Drawing.Point(256, 470);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.Size = new System.Drawing.Size(173, 42);
            this.btnDeleteRoom.TabIndex = 11;
            this.btnDeleteRoom.Text = "Xóa";
            this.btnDeleteRoom.UseVisualStyleBackColor = false;
            this.btnDeleteRoom.Click += new System.EventHandler(this.btnDeleteRoom_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddRoom.Location = new System.Drawing.Point(26, 470);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(173, 42);
            this.btnAddRoom.TabIndex = 10;
            this.btnAddRoom.Text = "Thêm";
            this.btnAddRoom.UseVisualStyleBackColor = false;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // numPrice
            // 
            this.numPrice.Location = new System.Drawing.Point(256, 309);
            this.numPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(173, 26);
            this.numPrice.TabIndex = 7;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(252, 272);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(84, 20);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Giá Phòng";
            // 
            // txtRoomStatus
            // 
            this.txtRoomStatus.Location = new System.Drawing.Point(26, 227);
            this.txtRoomStatus.Name = "txtRoomStatus";
            this.txtRoomStatus.Size = new System.Drawing.Size(403, 26);
            this.txtRoomStatus.TabIndex = 9;
            // 
            // txtRoomName
            // 
            this.txtRoomName.Location = new System.Drawing.Point(26, 144);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(403, 26);
            this.txtRoomName.TabIndex = 3;
            // 
            // txtIdRoom
            // 
            this.txtIdRoom.Location = new System.Drawing.Point(26, 64);
            this.txtIdRoom.Name = "txtIdRoom";
            this.txtIdRoom.Size = new System.Drawing.Size(403, 26);
            this.txtIdRoom.TabIndex = 1;
            // 
            // lblRoomStatus
            // 
            this.lblRoomStatus.AutoSize = true;
            this.lblRoomStatus.Location = new System.Drawing.Point(22, 190);
            this.lblRoomStatus.Name = "lblRoomStatus";
            this.lblRoomStatus.Size = new System.Drawing.Size(84, 20);
            this.lblRoomStatus.TabIndex = 8;
            this.lblRoomStatus.Text = "Tình Trạng";
            // 
            // lblRoomName
            // 
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.Location = new System.Drawing.Point(22, 111);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(86, 20);
            this.lblRoomName.TabIndex = 2;
            this.lblRoomName.Text = "Tên Phòng";
            // 
            // lblIdRoom
            // 
            this.lblIdRoom.AutoSize = true;
            this.lblIdRoom.Location = new System.Drawing.Point(22, 30);
            this.lblIdRoom.Name = "lblIdRoom";
            this.lblIdRoom.Size = new System.Drawing.Size(76, 20);
            this.lblIdRoom.TabIndex = 0;
            this.lblIdRoom.Text = "ID Phòng";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dtgRoom);
            this.panel5.Location = new System.Drawing.Point(4, 70);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(584, 530);
            this.panel5.TabIndex = 0;
            // 
            // dtgRoom
            // 
            this.dtgRoom.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgRoom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRoom.Location = new System.Drawing.Point(3, 3);
            this.dtgRoom.Name = "dtgRoom";
            this.dtgRoom.RowHeadersWidth = 62;
            this.dtgRoom.RowTemplate.Height = 28;
            this.dtgRoom.Size = new System.Drawing.Size(578, 524);
            this.dtgRoom.TabIndex = 0;
            this.dtgRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgRoom_CellClick);
            // 
            // tabCategory
            // 
            this.tabCategory.Controls.Add(this.panel4);
            this.tabCategory.Controls.Add(this.panel3);
            this.tabCategory.Location = new System.Drawing.Point(4, 29);
            this.tabCategory.Name = "tabCategory";
            this.tabCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tabCategory.Size = new System.Drawing.Size(1046, 606);
            this.tabCategory.TabIndex = 1;
            this.tabCategory.Text = "Danh Mục";
            this.tabCategory.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtgCategory);
            this.panel4.Location = new System.Drawing.Point(7, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(536, 592);
            this.panel4.TabIndex = 1;
            // 
            // dtgCategory
            // 
            this.dtgCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCategory.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCategory.Location = new System.Drawing.Point(3, 3);
            this.dtgCategory.Name = "dtgCategory";
            this.dtgCategory.RowHeadersWidth = 62;
            this.dtgCategory.RowTemplate.Height = 28;
            this.dtgCategory.Size = new System.Drawing.Size(530, 586);
            this.dtgCategory.TabIndex = 0;
            this.dtgCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCategory_CellClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.txtNameCategory);
            this.panel3.Controls.Add(this.btnNew);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.btnFix);
            this.panel3.Controls.Add(this.txtIdCategory);
            this.panel3.Controls.Add(this.lblCategoryName);
            this.panel3.Controls.Add(this.lblIdCategory);
            this.panel3.Location = new System.Drawing.Point(549, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(491, 594);
            this.panel3.TabIndex = 0;
            // 
            // txtNameCategory
            // 
            this.txtNameCategory.Location = new System.Drawing.Point(18, 128);
            this.txtNameCategory.Name = "txtNameCategory";
            this.txtNameCategory.Size = new System.Drawing.Size(452, 26);
            this.txtNameCategory.TabIndex = 3;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNew.Location = new System.Drawing.Point(288, 538);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(182, 41);
            this.btnNew.TabIndex = 7;
            this.btnNew.Text = "Làm Mới";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(288, 467);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(182, 41);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(18, 467);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(182, 41);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnFix
            // 
            this.btnFix.BackColor = System.Drawing.Color.Orange;
            this.btnFix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFix.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFix.Location = new System.Drawing.Point(17, 538);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(182, 41);
            this.btnFix.TabIndex = 6;
            this.btnFix.Text = "Sửa";
            this.btnFix.UseVisualStyleBackColor = false;
            this.btnFix.Click += new System.EventHandler(this.btnFix_Click);
            // 
            // txtIdCategory
            // 
            this.txtIdCategory.Location = new System.Drawing.Point(17, 46);
            this.txtIdCategory.Name = "txtIdCategory";
            this.txtIdCategory.Size = new System.Drawing.Size(456, 26);
            this.txtIdCategory.TabIndex = 1;
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCategoryName.Location = new System.Drawing.Point(14, 93);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(113, 20);
            this.lblCategoryName.TabIndex = 2;
            this.lblCategoryName.Text = "Tên Danh Mục";
            // 
            // lblIdCategory
            // 
            this.lblIdCategory.AutoSize = true;
            this.lblIdCategory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblIdCategory.Location = new System.Drawing.Point(13, 15);
            this.lblIdCategory.Name = "lblIdCategory";
            this.lblIdCategory.Size = new System.Drawing.Size(103, 20);
            this.lblIdCategory.TabIndex = 0;
            this.lblIdCategory.Text = "ID Danh Mục";
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.tabCategory);
            this.tabAdmin.Controls.Add(this.tabRoom);
            this.tabAdmin.Controls.Add(this.tabAccount);
            this.tabAdmin.Location = new System.Drawing.Point(1, 1);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(1054, 639);
            this.tabAdmin.TabIndex = 0;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 640);
            this.Controls.Add(this.tabAdmin);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin - KHÁCH SẠN PEACE";
            this.Load += new System.EventHandler(this.frmAdmin_Load_1);
            this.tabAccount.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTypeAccount)).EndInit();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAccount)).EndInit();
            this.tabRoom.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRoomCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRoom)).EndInit();
            this.tabCategory.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategory)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabAdmin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabAccount;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.NumericUpDown numTypeAccount;
        private System.Windows.Forms.TextBox txtPassAccount;
        private System.Windows.Forms.Label lblPassAccount;
        private System.Windows.Forms.Button btnNewAccount;
        private System.Windows.Forms.Button btnFixAccount;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.TextBox txtNameAccount;
        private System.Windows.Forms.Label lblTypeAccount;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.Label lblNameAccount;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridView dtgAccount;
        private System.Windows.Forms.TabPage tabRoom;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.NumericUpDown numRoomCategory;
        private System.Windows.Forms.Button btnNewRoom;
        private System.Windows.Forms.Button btnFixRoom;
        private System.Windows.Forms.Label lblRoomCategory;
        private System.Windows.Forms.Button btnDeleteRoom;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtRoomStatus;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.TextBox txtIdRoom;
        private System.Windows.Forms.Label lblRoomStatus;
        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.Label lblIdRoom;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dtgRoom;
        private System.Windows.Forms.TabPage tabCategory;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dtgCategory;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtNameCategory;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnFix;
        private System.Windows.Forms.TextBox txtIdCategory;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Label lblIdCategory;
        private System.Windows.Forms.TabControl tabAdmin;
    }
}