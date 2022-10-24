namespace QuanLyRapPhim.Admin.DataUC
{
    partial class CinemaRoomUC
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
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_projector = new System.Windows.Forms.ComboBox();
            this.txb_col = new System.Windows.Forms.TextBox();
            this.txb_row = new System.Windows.Forms.TextBox();
            this.txb_cinemaName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_cinemaRoom = new System.Windows.Forms.DataGridView();
            this.grp_room = new System.Windows.Forms.GroupBox();
            this.cbx_roomStatus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_roomId = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.txb_search = new System.Windows.Forms.TextBox();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoCot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongSoGhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MayChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cinemaRoom)).BeginInit();
            this.grp_room.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Máy chiếu";
            // 
            // cbx_projector
            // 
            this.cbx_projector.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_projector.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_projector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_projector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_projector.FormattingEnabled = true;
            this.cbx_projector.Location = new System.Drawing.Point(113, 110);
            this.cbx_projector.Name = "cbx_projector";
            this.cbx_projector.Size = new System.Drawing.Size(132, 28);
            this.cbx_projector.TabIndex = 24;
            // 
            // txb_col
            // 
            this.txb_col.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_col.Location = new System.Drawing.Point(290, 41);
            this.txb_col.Name = "txb_col";
            this.txb_col.Size = new System.Drawing.Size(128, 26);
            this.txb_col.TabIndex = 16;
            // 
            // txb_row
            // 
            this.txb_row.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_row.Location = new System.Drawing.Point(290, 110);
            this.txb_row.Name = "txb_row";
            this.txb_row.Size = new System.Drawing.Size(128, 26);
            this.txb_row.TabIndex = 15;
            // 
            // txb_cinemaName
            // 
            this.txb_cinemaName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_cinemaName.Location = new System.Drawing.Point(113, 75);
            this.txb_cinemaName.Name = "txb_cinemaName";
            this.txb_cinemaName.Size = new System.Drawing.Size(132, 26);
            this.txb_cinemaName.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(286, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số cột";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(286, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên phòng";
            // 
            // dgv_cinemaRoom
            // 
            this.dgv_cinemaRoom.AllowUserToDeleteRows = false;
            this.dgv_cinemaRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cinemaRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhong,
            this.TenPhong,
            this.SoHang,
            this.SoCot,
            this.TongSoGhe,
            this.MayChieu,
            this.TrangThai});
            this.dgv_cinemaRoom.Location = new System.Drawing.Point(3, 160);
            this.dgv_cinemaRoom.Name = "dgv_cinemaRoom";
            this.dgv_cinemaRoom.ReadOnly = true;
            this.dgv_cinemaRoom.Size = new System.Drawing.Size(942, 417);
            this.dgv_cinemaRoom.TabIndex = 2;
            this.dgv_cinemaRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cinemaRoom_CellClick);
            // 
            // grp_room
            // 
            this.grp_room.Controls.Add(this.cbx_roomStatus);
            this.grp_room.Controls.Add(this.label8);
            this.grp_room.Controls.Add(this.label5);
            this.grp_room.Controls.Add(this.txb_roomId);
            this.grp_room.Controls.Add(this.label6);
            this.grp_room.Controls.Add(this.txb_cinemaName);
            this.grp_room.Controls.Add(this.cbx_projector);
            this.grp_room.Controls.Add(this.txb_row);
            this.grp_room.Controls.Add(this.txb_col);
            this.grp_room.Controls.Add(this.label1);
            this.grp_room.Controls.Add(this.label4);
            this.grp_room.Controls.Add(this.label3);
            this.grp_room.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grp_room.Location = new System.Drawing.Point(3, 3);
            this.grp_room.Name = "grp_room";
            this.grp_room.Size = new System.Drawing.Size(656, 151);
            this.grp_room.TabIndex = 26;
            this.grp_room.TabStop = false;
            this.grp_room.Text = "Thông tin phòng chiếu";
            // 
            // cbx_roomStatus
            // 
            this.cbx_roomStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_roomStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_roomStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_roomStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_roomStatus.FormattingEnabled = true;
            this.cbx_roomStatus.Location = new System.Drawing.Point(467, 41);
            this.cbx_roomStatus.Name = "cbx_roomStatus";
            this.cbx_roomStatus.Size = new System.Drawing.Size(125, 28);
            this.cbx_roomStatus.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(463, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "Trạng thái";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Mã phòng";
            // 
            // txb_roomId
            // 
            this.txb_roomId.Enabled = false;
            this.txb_roomId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_roomId.Location = new System.Drawing.Point(113, 40);
            this.txb_roomId.Name = "txb_roomId";
            this.txb_roomId.Size = new System.Drawing.Size(132, 26);
            this.txb_roomId.TabIndex = 26;
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(849, 54);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(86, 38);
            this.btn_delete.TabIndex = 28;
            this.btn_delete.Text = "Xoá";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(849, 98);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(86, 38);
            this.btn_save.TabIndex = 29;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(849, 11);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(86, 38);
            this.btn_add.TabIndex = 27;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(725, 87);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(71, 36);
            this.btn_search.TabIndex = 35;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txb_search
            // 
            this.txb_search.Location = new System.Drawing.Point(686, 35);
            this.txb_search.Multiline = true;
            this.txb_search.Name = "txb_search";
            this.txb_search.Size = new System.Drawing.Size(147, 34);
            this.txb_search.TabIndex = 34;
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "Mã phòng";
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.ReadOnly = true;
            this.MaPhong.Width = 150;
            // 
            // TenPhong
            // 
            this.TenPhong.DataPropertyName = "TenPhong";
            this.TenPhong.HeaderText = "Tên phòng";
            this.TenPhong.Name = "TenPhong";
            this.TenPhong.ReadOnly = true;
            this.TenPhong.Width = 150;
            // 
            // SoHang
            // 
            this.SoHang.DataPropertyName = "SoHang";
            this.SoHang.HeaderText = "Số hàng";
            this.SoHang.Name = "SoHang";
            this.SoHang.ReadOnly = true;
            // 
            // SoCot
            // 
            this.SoCot.DataPropertyName = "SoCot";
            this.SoCot.HeaderText = "Số cột";
            this.SoCot.Name = "SoCot";
            this.SoCot.ReadOnly = true;
            // 
            // TongSoGhe
            // 
            this.TongSoGhe.DataPropertyName = "TongSoGhe";
            this.TongSoGhe.HeaderText = "Tổng số ghế";
            this.TongSoGhe.Name = "TongSoGhe";
            this.TongSoGhe.ReadOnly = true;
            this.TongSoGhe.Width = 150;
            // 
            // MayChieu
            // 
            this.MayChieu.DataPropertyName = "MaMay";
            this.MayChieu.HeaderText = "Máy chiếu";
            this.MayChieu.Name = "MayChieu";
            this.MayChieu.ReadOnly = true;
            this.MayChieu.Width = 150;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // CinemaRoomUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txb_search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.grp_room);
            this.Controls.Add(this.dgv_cinemaRoom);
            this.Name = "CinemaRoomUC";
            this.Size = new System.Drawing.Size(948, 584);
            this.Load += new System.EventHandler(this.CinemaRoomUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cinemaRoom)).EndInit();
            this.grp_room.ResumeLayout(false);
            this.grp_room.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_cinemaRoom;
        private System.Windows.Forms.TextBox txb_col;
        private System.Windows.Forms.TextBox txb_row;
        private System.Windows.Forms.TextBox txb_cinemaName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbx_projector;
        private System.Windows.Forms.GroupBox grp_room;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txb_search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_roomId;
        private System.Windows.Forms.ComboBox cbx_roomStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoCot;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongSoGhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MayChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}
