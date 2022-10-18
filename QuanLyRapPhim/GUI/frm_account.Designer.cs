
namespace QuanLyRapPhim
{
    partial class frm_account
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
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.dgv_account = new System.Windows.Forms.DataGridView();
            this.MaND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.grp_Account = new System.Windows.Forms.GroupBox();
            this.dtpicker_dob = new System.Windows.Forms.DateTimePicker();
            this.cklbox_role = new System.Windows.Forms.CheckedListBox();
            this.txb_Luong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txb_MatKhau = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_TenTaiKhoan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_CCCD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_SDT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_GioiTinh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_TenND = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txb_MaND = new System.Windows.Forms.TextBox();
            this.lblStaffID_Account = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txb_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_account)).BeginInit();
            this.grp_Account.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Firebrick;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_delete.Location = new System.Drawing.Point(1069, 159);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(121, 52);
            this.btn_delete.TabIndex = 31;
            this.btn_delete.Text = "XOÁ";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_save.Location = new System.Drawing.Point(1069, 101);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(121, 52);
            this.btn_save.TabIndex = 30;
            this.btn_save.Text = "LƯU";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_add.Location = new System.Drawing.Point(1090, 50);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(121, 52);
            this.btn_add.TabIndex = 28;
            this.btn_add.Text = "THÊM";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(602, 211);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 22);
            this.label11.TabIndex = 24;
            this.label11.Text = "Vai trò:";
            // 
            // dgv_account
            // 
            this.dgv_account.AllowUserToDeleteRows = false;
            this.dgv_account.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_account.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_account.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaND,
            this.TenND,
            this.GioiTinh,
            this.NgaySinh,
            this.SDT,
            this.CCCD,
            this.Email,
            this.TenTaiKhoan,
            this.MatKhau,
            this.Luong});
            this.dgv_account.Location = new System.Drawing.Point(21, 376);
            this.dgv_account.Name = "dgv_account";
            this.dgv_account.ReadOnly = true;
            this.dgv_account.Size = new System.Drawing.Size(1244, 325);
            this.dgv_account.TabIndex = 26;
            this.dgv_account.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_account_CellClick);
            // 
            // MaND
            // 
            this.MaND.DataPropertyName = "MaND";
            this.MaND.HeaderText = "Mã số";
            this.MaND.Name = "MaND";
            this.MaND.ReadOnly = true;
            // 
            // TenND
            // 
            this.TenND.DataPropertyName = "TenND";
            this.TenND.HeaderText = "Họ tên";
            this.TenND.Name = "TenND";
            this.TenND.ReadOnly = true;
            this.TenND.Width = 150;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SĐT";
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // CCCD
            // 
            this.CCCD.DataPropertyName = "CCCD";
            this.CCCD.HeaderText = "CCCD";
            this.CCCD.Name = "CCCD";
            this.CCCD.ReadOnly = true;
            this.CCCD.Width = 150;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 150;
            // 
            // TenTaiKhoan
            // 
            this.TenTaiKhoan.DataPropertyName = "TenTaiKhoan";
            this.TenTaiKhoan.HeaderText = "Tài khoản";
            this.TenTaiKhoan.Name = "TenTaiKhoan";
            this.TenTaiKhoan.ReadOnly = true;
            // 
            // MatKhau
            // 
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "Mật khẩu";
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.ReadOnly = true;
            // 
            // Luong
            // 
            this.Luong.DataPropertyName = "Luong";
            this.Luong.HeaderText = "Lương";
            this.Luong.Name = "Luong";
            this.Luong.ReadOnly = true;
            this.Luong.Width = 150;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(473, 212);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 22);
            this.label9.TabIndex = 23;
            this.label9.Text = "VNĐ";
            // 
            // grp_Account
            // 
            this.grp_Account.BackColor = System.Drawing.Color.Transparent;
            this.grp_Account.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grp_Account.Controls.Add(this.dtpicker_dob);
            this.grp_Account.Controls.Add(this.cklbox_role);
            this.grp_Account.Controls.Add(this.label11);
            this.grp_Account.Controls.Add(this.label9);
            this.grp_Account.Controls.Add(this.txb_Luong);
            this.grp_Account.Controls.Add(this.label8);
            this.grp_Account.Controls.Add(this.txb_MatKhau);
            this.grp_Account.Controls.Add(this.label5);
            this.grp_Account.Controls.Add(this.txb_TenTaiKhoan);
            this.grp_Account.Controls.Add(this.label6);
            this.grp_Account.Controls.Add(this.txt_Email);
            this.grp_Account.Controls.Add(this.label7);
            this.grp_Account.Controls.Add(this.txb_CCCD);
            this.grp_Account.Controls.Add(this.label4);
            this.grp_Account.Controls.Add(this.txb_SDT);
            this.grp_Account.Controls.Add(this.label3);
            this.grp_Account.Controls.Add(this.cbx_GioiTinh);
            this.grp_Account.Controls.Add(this.label1);
            this.grp_Account.Controls.Add(this.label2);
            this.grp_Account.Controls.Add(this.txb_TenND);
            this.grp_Account.Controls.Add(this.lblUsername);
            this.grp_Account.Controls.Add(this.txb_MaND);
            this.grp_Account.Controls.Add(this.lblStaffID_Account);
            this.grp_Account.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Account.Location = new System.Drawing.Point(20, 19);
            this.grp_Account.Margin = new System.Windows.Forms.Padding(2);
            this.grp_Account.Name = "grp_Account";
            this.grp_Account.Padding = new System.Windows.Forms.Padding(2);
            this.grp_Account.Size = new System.Drawing.Size(994, 340);
            this.grp_Account.TabIndex = 25;
            this.grp_Account.TabStop = false;
            this.grp_Account.Text = "Thông tin tài khoản";
            // 
            // dtpicker_dob
            // 
            this.dtpicker_dob.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.dtpicker_dob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpicker_dob.Location = new System.Drawing.Point(144, 92);
            this.dtpicker_dob.Name = "dtpicker_dob";
            this.dtpicker_dob.Size = new System.Drawing.Size(183, 29);
            this.dtpicker_dob.TabIndex = 26;
            // 
            // cklbox_role
            // 
            this.cklbox_role.CheckOnClick = true;
            this.cklbox_role.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.cklbox_role.FormattingEnabled = true;
            this.cklbox_role.Location = new System.Drawing.Point(683, 212);
            this.cklbox_role.Name = "cklbox_role";
            this.cklbox_role.Size = new System.Drawing.Size(156, 94);
            this.cklbox_role.TabIndex = 25;
            // 
            // txb_Luong
            // 
            this.txb_Luong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Luong.Location = new System.Drawing.Point(167, 208);
            this.txb_Luong.Margin = new System.Windows.Forms.Padding(2);
            this.txb_Luong.Name = "txb_Luong";
            this.txb_Luong.Size = new System.Drawing.Size(287, 29);
            this.txb_Luong.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(43, 215);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 22);
            this.label8.TabIndex = 21;
            this.label8.Text = "Tiền lương:";
            // 
            // txb_MatKhau
            // 
            this.txb_MatKhau.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_MatKhau.Location = new System.Drawing.Point(776, 151);
            this.txb_MatKhau.Margin = new System.Windows.Forms.Padding(2);
            this.txb_MatKhau.Name = "txb_MatKhau";
            this.txb_MatKhau.PasswordChar = '*';
            this.txb_MatKhau.Size = new System.Drawing.Size(183, 29);
            this.txb_MatKhau.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(679, 151);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 22);
            this.label5.TabIndex = 19;
            this.label5.Text = "Mật khẩu:";
            // 
            // txb_TenTaiKhoan
            // 
            this.txb_TenTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_TenTaiKhoan.Location = new System.Drawing.Point(461, 151);
            this.txb_TenTaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.txb_TenTaiKhoan.Name = "txb_TenTaiKhoan";
            this.txb_TenTaiKhoan.Size = new System.Drawing.Size(183, 29);
            this.txb_TenTaiKhoan.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(355, 151);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 22);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tài khoản:";
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(144, 151);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(183, 29);
            this.txt_Email.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 151);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 22);
            this.label7.TabIndex = 15;
            this.label7.Text = "Email:";
            // 
            // txb_CCCD
            // 
            this.txb_CCCD.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_CCCD.Location = new System.Drawing.Point(776, 93);
            this.txb_CCCD.Margin = new System.Windows.Forms.Padding(2);
            this.txb_CCCD.Name = "txb_CCCD";
            this.txb_CCCD.Size = new System.Drawing.Size(183, 29);
            this.txb_CCCD.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(679, 93);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "CCCD:";
            // 
            // txb_SDT
            // 
            this.txb_SDT.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_SDT.Location = new System.Drawing.Point(461, 93);
            this.txb_SDT.Margin = new System.Windows.Forms.Padding(2);
            this.txb_SDT.Name = "txb_SDT";
            this.txb_SDT.Size = new System.Drawing.Size(183, 29);
            this.txb_SDT.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(355, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "SĐT:";
            // 
            // cbx_GioiTinh
            // 
            this.cbx_GioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_GioiTinh.FormattingEnabled = true;
            this.cbx_GioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbx_GioiTinh.Location = new System.Drawing.Point(776, 35);
            this.cbx_GioiTinh.Name = "cbx_GioiTinh";
            this.cbx_GioiTinh.Size = new System.Drawing.Size(183, 32);
            this.cbx_GioiTinh.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(679, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Giới tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ngày sinh:";
            // 
            // txb_TenND
            // 
            this.txb_TenND.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_TenND.Location = new System.Drawing.Point(461, 37);
            this.txb_TenND.Margin = new System.Windows.Forms.Padding(2);
            this.txb_TenND.Name = "txb_TenND";
            this.txb_TenND.Size = new System.Drawing.Size(183, 29);
            this.txb_TenND.TabIndex = 5;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(43, 37);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(66, 22);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Mã số:";
            // 
            // txb_MaND
            // 
            this.txb_MaND.Enabled = false;
            this.txb_MaND.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_MaND.Location = new System.Drawing.Point(144, 34);
            this.txb_MaND.Margin = new System.Windows.Forms.Padding(2);
            this.txb_MaND.Name = "txb_MaND";
            this.txb_MaND.ReadOnly = true;
            this.txb_MaND.Size = new System.Drawing.Size(183, 29);
            this.txb_MaND.TabIndex = 2;
            // 
            // lblStaffID_Account
            // 
            this.lblStaffID_Account.AutoSize = true;
            this.lblStaffID_Account.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffID_Account.Location = new System.Drawing.Point(355, 37);
            this.lblStaffID_Account.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStaffID_Account.Name = "lblStaffID_Account";
            this.lblStaffID_Account.Size = new System.Drawing.Size(69, 22);
            this.lblStaffID_Account.TabIndex = 4;
            this.lblStaffID_Account.Text = "Họ tên:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.txb_search);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.grp_Account);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Location = new System.Drawing.Point(21, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1244, 369);
            this.panel1.TabIndex = 32;
            // 
            // txb_search
            // 
            this.txb_search.Location = new System.Drawing.Point(1043, 237);
            this.txb_search.Multiline = true;
            this.txb_search.Name = "txb_search";
            this.txb_search.Size = new System.Drawing.Size(147, 34);
            this.txb_search.TabIndex = 32;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(1082, 289);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(71, 36);
            this.btn_search.TabIndex = 33;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // frm_account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyRapPhim.Properties.Resources.pexels_johannes_plenio_1103970;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1289, 725);
            this.Controls.Add(this.dgv_account);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.panel1);
            this.Name = "frm_account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_account";
            this.Load += new System.EventHandler(this.frm_account_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_account)).EndInit();
            this.grp_Account.ResumeLayout(false);
            this.grp_Account.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgv_account;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grp_Account;
        private System.Windows.Forms.TextBox txb_Luong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txb_MatKhau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_TenTaiKhoan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb_CCCD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_SDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_GioiTinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_TenND;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txb_MaND;
        private System.Windows.Forms.Label lblStaffID_Account;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckedListBox cklbox_role;
        private System.Windows.Forms.DateTimePicker dtpicker_dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaND;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenND;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Luong;
        private System.Windows.Forms.TextBox txb_search;
        private System.Windows.Forms.Button btn_search;
    }
}