namespace QuanLyRapPhim.Admin.DataUC
{
    partial class ShowTimeUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_showTime = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_showTimeStatus = new System.Windows.Forms.ComboBox();
            this.cbx_CinemaRoom = new System.Windows.Forms.ComboBox();
            this.cbx_movieName = new System.Windows.Forms.ComboBox();
            this.dtpicker_date = new System.Windows.Forms.DateTimePicker();
            this.dtpicker_time = new System.Windows.Forms.DateTimePicker();
            this.grp_showTime = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_showTimeId = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.txb_search = new System.Windows.Forms.TextBox();
            this.MaSuatChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_showTime)).BeginInit();
            this.grp_showTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_showTime
            // 
            this.dgv_showTime.AllowUserToDeleteRows = false;
            this.dgv_showTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_showTime.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSuatChieu,
            this.Ngay,
            this.Gio,
            this.TrangThai,
            this.MaPhim,
            this.MaPhong});
            this.dgv_showTime.Location = new System.Drawing.Point(3, 164);
            this.dgv_showTime.Name = "dgv_showTime";
            this.dgv_showTime.ReadOnly = true;
            this.dgv_showTime.Size = new System.Drawing.Size(942, 417);
            this.dgv_showTime.TabIndex = 0;
            this.dgv_showTime.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_showTime_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(271, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Trạng thái";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(271, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(271, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Phim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Giờ";
            // 
            // cbx_showTimeStatus
            // 
            this.cbx_showTimeStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_showTimeStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_showTimeStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_showTimeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_showTimeStatus.FormattingEnabled = true;
            this.cbx_showTimeStatus.Location = new System.Drawing.Point(371, 113);
            this.cbx_showTimeStatus.Name = "cbx_showTimeStatus";
            this.cbx_showTimeStatus.Size = new System.Drawing.Size(142, 28);
            this.cbx_showTimeStatus.TabIndex = 4;
            // 
            // cbx_CinemaRoom
            // 
            this.cbx_CinemaRoom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_CinemaRoom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_CinemaRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_CinemaRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_CinemaRoom.FormattingEnabled = true;
            this.cbx_CinemaRoom.Location = new System.Drawing.Point(371, 69);
            this.cbx_CinemaRoom.Name = "cbx_CinemaRoom";
            this.cbx_CinemaRoom.Size = new System.Drawing.Size(142, 28);
            this.cbx_CinemaRoom.TabIndex = 3;
            // 
            // cbx_movieName
            // 
            this.cbx_movieName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_movieName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_movieName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_movieName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_movieName.FormattingEnabled = true;
            this.cbx_movieName.Location = new System.Drawing.Point(371, 25);
            this.cbx_movieName.Name = "cbx_movieName";
            this.cbx_movieName.Size = new System.Drawing.Size(142, 28);
            this.cbx_movieName.TabIndex = 2;
            // 
            // dtpicker_date
            // 
            this.dtpicker_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpicker_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpicker_date.Location = new System.Drawing.Point(84, 115);
            this.dtpicker_date.Name = "dtpicker_date";
            this.dtpicker_date.Size = new System.Drawing.Size(123, 26);
            this.dtpicker_date.TabIndex = 1;
            // 
            // dtpicker_time
            // 
            this.dtpicker_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpicker_time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpicker_time.Location = new System.Drawing.Point(84, 71);
            this.dtpicker_time.Name = "dtpicker_time";
            this.dtpicker_time.Size = new System.Drawing.Size(123, 26);
            this.dtpicker_time.TabIndex = 0;
            // 
            // grp_showTime
            // 
            this.grp_showTime.Controls.Add(this.label6);
            this.grp_showTime.Controls.Add(this.txb_showTimeId);
            this.grp_showTime.Controls.Add(this.cbx_showTimeStatus);
            this.grp_showTime.Controls.Add(this.label1);
            this.grp_showTime.Controls.Add(this.cbx_CinemaRoom);
            this.grp_showTime.Controls.Add(this.label2);
            this.grp_showTime.Controls.Add(this.label5);
            this.grp_showTime.Controls.Add(this.cbx_movieName);
            this.grp_showTime.Controls.Add(this.dtpicker_time);
            this.grp_showTime.Controls.Add(this.label3);
            this.grp_showTime.Controls.Add(this.label4);
            this.grp_showTime.Controls.Add(this.dtpicker_date);
            this.grp_showTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grp_showTime.Location = new System.Drawing.Point(3, 3);
            this.grp_showTime.Name = "grp_showTime";
            this.grp_showTime.Size = new System.Drawing.Size(620, 155);
            this.grp_showTime.TabIndex = 13;
            this.grp_showTime.TabStop = false;
            this.grp_showTime.Text = "Thông tin suất chiếu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Mã suất chiếu";
            // 
            // txb_showTimeId
            // 
            this.txb_showTimeId.Enabled = false;
            this.txb_showTimeId.Location = new System.Drawing.Point(138, 31);
            this.txb_showTimeId.Name = "txb_showTimeId";
            this.txb_showTimeId.Size = new System.Drawing.Size(100, 26);
            this.txb_showTimeId.TabIndex = 13;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(844, 18);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(86, 38);
            this.btn_add.TabIndex = 14;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(844, 105);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(86, 38);
            this.btn_save.TabIndex = 16;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(844, 61);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(86, 38);
            this.btn_delete.TabIndex = 15;
            this.btn_delete.Text = "Xoá";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(697, 91);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(71, 36);
            this.btn_search.TabIndex = 35;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txb_search
            // 
            this.txb_search.Location = new System.Drawing.Point(658, 39);
            this.txb_search.Multiline = true;
            this.txb_search.Name = "txb_search";
            this.txb_search.Size = new System.Drawing.Size(147, 34);
            this.txb_search.TabIndex = 34;
            // 
            // MaSuatChieu
            // 
            this.MaSuatChieu.DataPropertyName = "MaSuatChieu";
            this.MaSuatChieu.HeaderText = "Mã suất chiếu";
            this.MaSuatChieu.Name = "MaSuatChieu";
            this.MaSuatChieu.ReadOnly = true;
            this.MaSuatChieu.Width = 150;
            // 
            // Ngay
            // 
            this.Ngay.DataPropertyName = "Ngay";
            this.Ngay.HeaderText = "Ngày";
            this.Ngay.Name = "Ngay";
            this.Ngay.ReadOnly = true;
            this.Ngay.Width = 150;
            // 
            // Gio
            // 
            this.Gio.DataPropertyName = "Gio";
            this.Gio.HeaderText = "Giờ";
            this.Gio.Name = "Gio";
            this.Gio.ReadOnly = true;
            this.Gio.Width = 150;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Width = 150;
            // 
            // MaPhim
            // 
            this.MaPhim.DataPropertyName = "MaPhim";
            this.MaPhim.HeaderText = "Mã phim";
            this.MaPhim.Name = "MaPhim";
            this.MaPhim.ReadOnly = true;
            this.MaPhim.Width = 150;
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "Mã phòng";
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.ReadOnly = true;
            this.MaPhong.Width = 150;
            // 
            // ShowTimeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txb_search);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.grp_showTime);
            this.Controls.Add(this.dgv_showTime);
            this.Name = "ShowTimeUC";
            this.Size = new System.Drawing.Size(948, 584);
            this.Load += new System.EventHandler(this.ShowTimeUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_showTime)).EndInit();
            this.grp_showTime.ResumeLayout(false);
            this.grp_showTime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_showTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_showTimeStatus;
        private System.Windows.Forms.ComboBox cbx_CinemaRoom;
        private System.Windows.Forms.ComboBox cbx_movieName;
        private System.Windows.Forms.DateTimePicker dtpicker_date;
        private System.Windows.Forms.DateTimePicker dtpicker_time;
        private System.Windows.Forms.GroupBox grp_showTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb_showTimeId;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txb_search;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSuatChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gio;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
    }
}
