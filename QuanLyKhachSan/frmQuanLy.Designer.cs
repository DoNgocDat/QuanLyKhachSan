namespace QuanLyKhachSan
{
    partial class frmQuanLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLy));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnChangePass = new System.Windows.Forms.ToolStripMenuItem();
            this.mnLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgBill = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.numSumPrice = new System.Windows.Forms.NumericUpDown();
            this.numNumber = new System.Windows.Forms.NumericUpDown();
            this.numIdRoom = new System.Windows.Forms.NumericUpDown();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dtpDateOut = new System.Windows.Forms.DateTimePicker();
            this.dtpDateIn = new System.Windows.Forms.DateTimePicker();
            this.lblSumPrice = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.IdRoom = new System.Windows.Forms.Label();
            this.lblDateOut = new System.Windows.Forms.Label();
            this.lblDateIn = new System.Windows.Forms.Label();
            this.btnSearchBill = new System.Windows.Forms.Button();
            this.txtSearchBill = new System.Windows.Forms.TextBox();
            this.lblSearchBill = new System.Windows.Forms.Label();
            this.btnEmptyRoom = new System.Windows.Forms.Button();
            this.txtEmptyRoom = new System.Windows.Forms.TextBox();
            this.lblEmptyRoom = new System.Windows.Forms.Label();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnBookRoom = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgRoom = new System.Windows.Forms.DataGridView();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBill)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSumPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdRoom)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnAdmin,
            this.mnFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1028, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnAdmin
            // 
            this.mnAdmin.Name = "mnAdmin";
            this.mnAdmin.Size = new System.Drawing.Size(81, 29);
            this.mnAdmin.Text = "Admin";
            this.mnAdmin.Click += new System.EventHandler(this.mnAdmin_Click);
            // 
            // mnFile
            // 
            this.mnFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnChangePass,
            this.mnLogOut});
            this.mnFile.Name = "mnFile";
            this.mnFile.Size = new System.Drawing.Size(54, 29);
            this.mnFile.Text = "File";
            // 
            // mnChangePass
            // 
            this.mnChangePass.Name = "mnChangePass";
            this.mnChangePass.Size = new System.Drawing.Size(222, 34);
            this.mnChangePass.Text = "Đổi Mật Khẩu";
            this.mnChangePass.Click += new System.EventHandler(this.mnChangePass_Click);
            // 
            // mnLogOut
            // 
            this.mnLogOut.Name = "mnLogOut";
            this.mnLogOut.Size = new System.Drawing.Size(222, 34);
            this.mnLogOut.Text = "Đăng Xuất";
            this.mnLogOut.Click += new System.EventHandler(this.mnLogOut_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgBill);
            this.panel1.Location = new System.Drawing.Point(12, 277);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 355);
            this.panel1.TabIndex = 2;
            // 
            // dtgBill
            // 
            this.dtgBill.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgBill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBill.Location = new System.Drawing.Point(4, 3);
            this.dtgBill.Name = "dtgBill";
            this.dtgBill.RowHeadersWidth = 62;
            this.dtgBill.RowTemplate.Height = 28;
            this.dtgBill.Size = new System.Drawing.Size(586, 349);
            this.dtgBill.TabIndex = 0;
            this.dtgBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgBill_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbbStatus);
            this.panel2.Controls.Add(this.numSumPrice);
            this.panel2.Controls.Add(this.numNumber);
            this.panel2.Controls.Add(this.numIdRoom);
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.dtpDateOut);
            this.panel2.Controls.Add(this.dtpDateIn);
            this.panel2.Controls.Add(this.lblSumPrice);
            this.panel2.Controls.Add(this.lblNumber);
            this.panel2.Controls.Add(this.IdRoom);
            this.panel2.Controls.Add(this.lblDateOut);
            this.panel2.Controls.Add(this.lblDateIn);
            this.panel2.Controls.Add(this.btnSearchBill);
            this.panel2.Controls.Add(this.txtSearchBill);
            this.panel2.Controls.Add(this.lblSearchBill);
            this.panel2.Controls.Add(this.btnEmptyRoom);
            this.panel2.Controls.Add(this.txtEmptyRoom);
            this.panel2.Controls.Add(this.lblEmptyRoom);
            this.panel2.Controls.Add(this.btnPayment);
            this.panel2.Controls.Add(this.btnBookRoom);
            this.panel2.Location = new System.Drawing.Point(611, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 596);
            this.panel2.TabIndex = 3;
            // 
            // cbbStatus
            // 
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Items.AddRange(new object[] {
            "Chưa Thanh Toán",
            "Đã Thanh Toán"});
            this.cbbStatus.Location = new System.Drawing.Point(215, 396);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(159, 28);
            this.cbbStatus.TabIndex = 28;
            // 
            // numSumPrice
            // 
            this.numSumPrice.Location = new System.Drawing.Point(30, 396);
            this.numSumPrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numSumPrice.Name = "numSumPrice";
            this.numSumPrice.Size = new System.Drawing.Size(163, 26);
            this.numSumPrice.TabIndex = 27;
            // 
            // numNumber
            // 
            this.numNumber.Location = new System.Drawing.Point(215, 326);
            this.numNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNumber.Name = "numNumber";
            this.numNumber.Size = new System.Drawing.Size(159, 26);
            this.numNumber.TabIndex = 26;
            this.numNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numIdRoom
            // 
            this.numIdRoom.Location = new System.Drawing.Point(30, 326);
            this.numIdRoom.Name = "numIdRoom";
            this.numIdRoom.Size = new System.Drawing.Size(163, 26);
            this.numIdRoom.TabIndex = 25;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(211, 373);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(84, 20);
            this.lblStatus.TabIndex = 23;
            this.lblStatus.Text = "Tình Trạng";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.Location = new System.Drawing.Point(32, 550);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(163, 43);
            this.btnReset.TabIndex = 21;
            this.btnReset.Text = "Làm Mới";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(215, 550);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(163, 43);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dtpDateOut
            // 
            this.dtpDateOut.Location = new System.Drawing.Point(30, 253);
            this.dtpDateOut.Name = "dtpDateOut";
            this.dtpDateOut.Size = new System.Drawing.Size(246, 26);
            this.dtpDateOut.TabIndex = 16;
            // 
            // dtpDateIn
            // 
            this.dtpDateIn.Location = new System.Drawing.Point(30, 182);
            this.dtpDateIn.Name = "dtpDateIn";
            this.dtpDateIn.Size = new System.Drawing.Size(246, 26);
            this.dtpDateIn.TabIndex = 15;
            // 
            // lblSumPrice
            // 
            this.lblSumPrice.AutoSize = true;
            this.lblSumPrice.Location = new System.Drawing.Point(28, 373);
            this.lblSumPrice.Name = "lblSumPrice";
            this.lblSumPrice.Size = new System.Drawing.Size(79, 20);
            this.lblSumPrice.TabIndex = 14;
            this.lblSumPrice.Text = "Tổng Tiền";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(211, 300);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(78, 20);
            this.lblNumber.TabIndex = 13;
            this.lblNumber.Text = "Số Lượng";
            // 
            // IdRoom
            // 
            this.IdRoom.AutoSize = true;
            this.IdRoom.Location = new System.Drawing.Point(26, 300);
            this.IdRoom.Name = "IdRoom";
            this.IdRoom.Size = new System.Drawing.Size(81, 20);
            this.IdRoom.TabIndex = 12;
            this.IdRoom.Text = "Mã Phòng";
            // 
            // lblDateOut
            // 
            this.lblDateOut.AutoSize = true;
            this.lblDateOut.Location = new System.Drawing.Point(26, 228);
            this.lblDateOut.Name = "lblDateOut";
            this.lblDateOut.Size = new System.Drawing.Size(70, 20);
            this.lblDateOut.TabIndex = 11;
            this.lblDateOut.Text = "Ngày Ra";
            // 
            // lblDateIn
            // 
            this.lblDateIn.AutoSize = true;
            this.lblDateIn.Location = new System.Drawing.Point(26, 157);
            this.lblDateIn.Name = "lblDateIn";
            this.lblDateIn.Size = new System.Drawing.Size(78, 20);
            this.lblDateIn.TabIndex = 10;
            this.lblDateIn.Text = "Ngày Vào";
            // 
            // btnSearchBill
            // 
            this.btnSearchBill.Location = new System.Drawing.Point(282, 104);
            this.btnSearchBill.Name = "btnSearchBill";
            this.btnSearchBill.Size = new System.Drawing.Size(92, 35);
            this.btnSearchBill.TabIndex = 9;
            this.btnSearchBill.Text = "Tìm Kiếm";
            this.btnSearchBill.UseVisualStyleBackColor = true;
            this.btnSearchBill.Click += new System.EventHandler(this.btnSearchBill_Click);
            // 
            // txtSearchBill
            // 
            this.txtSearchBill.Location = new System.Drawing.Point(30, 108);
            this.txtSearchBill.Name = "txtSearchBill";
            this.txtSearchBill.Size = new System.Drawing.Size(246, 26);
            this.txtSearchBill.TabIndex = 8;
            // 
            // lblSearchBill
            // 
            this.lblSearchBill.AutoSize = true;
            this.lblSearchBill.Location = new System.Drawing.Point(26, 83);
            this.lblSearchBill.Name = "lblSearchBill";
            this.lblSearchBill.Size = new System.Drawing.Size(141, 20);
            this.lblSearchBill.TabIndex = 7;
            this.lblSearchBill.Text = "Tìm Kiếm Hóa Đơn";
            // 
            // btnEmptyRoom
            // 
            this.btnEmptyRoom.Location = new System.Drawing.Point(282, 32);
            this.btnEmptyRoom.Name = "btnEmptyRoom";
            this.btnEmptyRoom.Size = new System.Drawing.Size(92, 35);
            this.btnEmptyRoom.TabIndex = 6;
            this.btnEmptyRoom.Text = "Tìm Kiếm";
            this.btnEmptyRoom.UseVisualStyleBackColor = true;
            this.btnEmptyRoom.Click += new System.EventHandler(this.btnEmptyRoom_Click);
            // 
            // txtEmptyRoom
            // 
            this.txtEmptyRoom.Location = new System.Drawing.Point(30, 36);
            this.txtEmptyRoom.Name = "txtEmptyRoom";
            this.txtEmptyRoom.Size = new System.Drawing.Size(246, 26);
            this.txtEmptyRoom.TabIndex = 5;
            // 
            // lblEmptyRoom
            // 
            this.lblEmptyRoom.AutoSize = true;
            this.lblEmptyRoom.Location = new System.Drawing.Point(26, 11);
            this.lblEmptyRoom.Name = "lblEmptyRoom";
            this.lblEmptyRoom.Size = new System.Drawing.Size(202, 20);
            this.lblEmptyRoom.TabIndex = 4;
            this.lblEmptyRoom.Text = "Tìm Kiếm Tình Trạng Phòng";
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.ForestGreen;
            this.btnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPayment.Location = new System.Drawing.Point(215, 505);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(163, 43);
            this.btnPayment.TabIndex = 3;
            this.btnPayment.Text = "Thanh Toán";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnBookRoom
            // 
            this.btnBookRoom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBookRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookRoom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBookRoom.Location = new System.Drawing.Point(30, 505);
            this.btnBookRoom.Name = "btnBookRoom";
            this.btnBookRoom.Size = new System.Drawing.Size(163, 43);
            this.btnBookRoom.TabIndex = 2;
            this.btnBookRoom.Text = "Đặt Phòng";
            this.btnBookRoom.UseVisualStyleBackColor = false;
            this.btnBookRoom.Click += new System.EventHandler(this.btnBookRoom_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgRoom);
            this.panel3.Location = new System.Drawing.Point(12, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(593, 235);
            this.panel3.TabIndex = 4;
            // 
            // dtgRoom
            // 
            this.dtgRoom.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgRoom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRoom.Location = new System.Drawing.Point(4, 3);
            this.dtgRoom.Name = "dtgRoom";
            this.dtgRoom.RowHeadersWidth = 62;
            this.dtgRoom.RowTemplate.Height = 28;
            this.dtgRoom.Size = new System.Drawing.Size(586, 228);
            this.dtgRoom.TabIndex = 0;
            this.dtgRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgRoom_CellClick);
            // 
            // frmQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 644);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý - KHÁCH SẠN PEACE";
            this.Load += new System.EventHandler(this.frmQuanLy_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBill)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSumPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdRoom)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnFile;
        private System.Windows.Forms.ToolStripMenuItem mnChangePass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgBill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnBookRoom;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgRoom;
        private System.Windows.Forms.Button btnSearchBill;
        private System.Windows.Forms.TextBox txtSearchBill;
        private System.Windows.Forms.Label lblSearchBill;
        private System.Windows.Forms.Button btnEmptyRoom;
        private System.Windows.Forms.TextBox txtEmptyRoom;
        private System.Windows.Forms.Label lblEmptyRoom;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DateTimePicker dtpDateOut;
        private System.Windows.Forms.DateTimePicker dtpDateIn;
        private System.Windows.Forms.Label lblSumPrice;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label IdRoom;
        private System.Windows.Forms.Label lblDateOut;
        private System.Windows.Forms.Label lblDateIn;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.NumericUpDown numSumPrice;
        private System.Windows.Forms.NumericUpDown numNumber;
        private System.Windows.Forms.NumericUpDown numIdRoom;
        private System.Windows.Forms.ToolStripMenuItem mnLogOut;
        private System.Windows.Forms.ComboBox cbbStatus;
        private System.Windows.Forms.Button btnExit;
    }
}