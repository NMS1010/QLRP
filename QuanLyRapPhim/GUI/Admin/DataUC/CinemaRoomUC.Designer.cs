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
            this.btn_addSeat = new System.Windows.Forms.Button();
            this.txb_seatQuantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkLstBox_seat = new System.Windows.Forms.CheckedListBox();
            this.txb_col = new System.Windows.Forms.TextBox();
            this.txb_row = new System.Windows.Forms.TextBox();
            this.txb_cinemaRoomName = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_cinemaRoom = new System.Windows.Forms.DataGridView();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoCot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongSoGhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MayChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cinemaRoom)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Máy chiếu";
            // 
            // cbx_projector
            // 
            this.cbx_projector.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_projector.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_projector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_projector.FormattingEnabled = true;
            this.cbx_projector.Location = new System.Drawing.Point(113, 72);
            this.cbx_projector.Name = "cbx_projector";
            this.cbx_projector.Size = new System.Drawing.Size(124, 28);
            this.cbx_projector.TabIndex = 24;
            // 
            // btn_addSeat
            // 
            this.btn_addSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btn_addSeat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_addSeat.Location = new System.Drawing.Point(681, 82);
            this.btn_addSeat.Name = "btn_addSeat";
            this.btn_addSeat.Size = new System.Drawing.Size(49, 25);
            this.btn_addSeat.TabIndex = 23;
            this.btn_addSeat.Text = "Chọn";
            this.btn_addSeat.UseVisualStyleBackColor = true;
            // 
            // txb_seatQuantity
            // 
            this.txb_seatQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_seatQuantity.Location = new System.Drawing.Point(681, 50);
            this.txb_seatQuantity.Name = "txb_seatQuantity";
            this.txb_seatQuantity.Size = new System.Drawing.Size(106, 26);
            this.txb_seatQuantity.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(677, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Số lượng ghế";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(516, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Chọn loại ghế";
            // 
            // checkLstBox_seat
            // 
            this.checkLstBox_seat.FormattingEnabled = true;
            this.checkLstBox_seat.Location = new System.Drawing.Point(520, 50);
            this.checkLstBox_seat.Name = "checkLstBox_seat";
            this.checkLstBox_seat.Size = new System.Drawing.Size(120, 67);
            this.checkLstBox_seat.TabIndex = 17;
            // 
            // txb_col
            // 
            this.txb_col.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_col.Location = new System.Drawing.Point(360, 72);
            this.txb_col.Name = "txb_col";
            this.txb_col.Size = new System.Drawing.Size(106, 26);
            this.txb_col.TabIndex = 16;
            // 
            // txb_row
            // 
            this.txb_row.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_row.Location = new System.Drawing.Point(360, 29);
            this.txb_row.Name = "txb_row";
            this.txb_row.Size = new System.Drawing.Size(106, 26);
            this.txb_row.TabIndex = 15;
            // 
            // txb_cinemaRoomName
            // 
            this.txb_cinemaRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_cinemaRoomName.Location = new System.Drawing.Point(113, 32);
            this.txb_cinemaRoomName.Name = "txb_cinemaRoomName";
            this.txb_cinemaRoomName.Size = new System.Drawing.Size(124, 26);
            this.txb_cinemaRoomName.TabIndex = 14;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(841, 104);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(86, 38);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(841, 60);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(86, 38);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Text = "Xoá";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(841, 17);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(86, 38);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(253, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số cột";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(253, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 32);
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
            this.MayChieu});
            this.dgv_cinemaRoom.Location = new System.Drawing.Point(3, 160);
            this.dgv_cinemaRoom.Name = "dgv_cinemaRoom";
            this.dgv_cinemaRoom.ReadOnly = true;
            this.dgv_cinemaRoom.Size = new System.Drawing.Size(942, 417);
            this.dgv_cinemaRoom.TabIndex = 2;
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
            this.SoHang.Width = 150;
            // 
            // SoCot
            // 
            this.SoCot.DataPropertyName = "SoCot";
            this.SoCot.HeaderText = "Số cột";
            this.SoCot.Name = "SoCot";
            this.SoCot.ReadOnly = true;
            this.SoCot.Width = 150;
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
            this.MayChieu.DataPropertyName = "MayChieu";
            this.MayChieu.HeaderText = "Máy chiếu";
            this.MayChieu.Name = "MayChieu";
            this.MayChieu.ReadOnly = true;
            this.MayChieu.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txb_cinemaRoomName);
            this.groupBox1.Controls.Add(this.cbx_projector);
            this.groupBox1.Controls.Add(this.txb_row);
            this.groupBox1.Controls.Add(this.btn_addSeat);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.txb_col);
            this.groupBox1.Controls.Add(this.txb_seatQuantity);
            this.groupBox1.Controls.Add(this.checkLstBox_seat);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(942, 151);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng chiếu";
            // 
            // CinemaRoomUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_cinemaRoom);
            this.Name = "CinemaRoomUC";
            this.Size = new System.Drawing.Size(948, 584);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cinemaRoom)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_cinemaRoom;
        private System.Windows.Forms.TextBox txb_col;
        private System.Windows.Forms.TextBox txb_row;
        private System.Windows.Forms.TextBox txb_cinemaRoomName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkLstBox_seat;
        private System.Windows.Forms.TextBox txb_seatQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_addSeat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbx_projector;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoCot;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongSoGhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MayChieu;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
