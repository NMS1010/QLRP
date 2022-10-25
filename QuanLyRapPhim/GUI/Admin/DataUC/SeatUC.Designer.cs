namespace QuanLyRapPhim.Admin.DataUC
{
    partial class SeatUC
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
            this.txb_price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_seat = new System.Windows.Forms.DataGridView();
            this.MaGhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiGhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaGhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_seat = new System.Windows.Forms.GroupBox();
            this.txb_type = new System.Windows.Forms.TextBox();
            this.txb_SeatId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.txb_search = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_seat)).BeginInit();
            this.grb_seat.SuspendLayout();
            this.SuspendLayout();
            // 
            // txb_price
            // 
            this.txb_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_price.Location = new System.Drawing.Point(486, 108);
            this.txb_price.Margin = new System.Windows.Forms.Padding(4);
            this.txb_price.Name = "txb_price";
            this.txb_price.Size = new System.Drawing.Size(164, 30);
            this.txb_price.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(521, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Giá tiền";
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(1103, 124);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(115, 47);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(1103, 70);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(115, 47);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Text = "Xoá";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(1103, 17);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(115, 47);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(321, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Loại ghế";
            // 
            // dgv_seat
            // 
            this.dgv_seat.AllowUserToDeleteRows = false;
            this.dgv_seat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_seat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGhe,
            this.LoaiGhe,
            this.GiaGhe});
            this.dgv_seat.Location = new System.Drawing.Point(4, 197);
            this.dgv_seat.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_seat.Name = "dgv_seat";
            this.dgv_seat.ReadOnly = true;
            this.dgv_seat.RowHeadersWidth = 51;
            this.dgv_seat.Size = new System.Drawing.Size(1256, 513);
            this.dgv_seat.TabIndex = 2;
            this.dgv_seat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_seat_CellClick);
            // 
            // MaGhe
            // 
            this.MaGhe.DataPropertyName = "MaGhe";
            this.MaGhe.HeaderText = "Mã ghế";
            this.MaGhe.MinimumWidth = 6;
            this.MaGhe.Name = "MaGhe";
            this.MaGhe.ReadOnly = true;
            this.MaGhe.Width = 300;
            // 
            // LoaiGhe
            // 
            this.LoaiGhe.DataPropertyName = "LoaiGhe";
            this.LoaiGhe.HeaderText = "Loại ghế";
            this.LoaiGhe.MinimumWidth = 6;
            this.LoaiGhe.Name = "LoaiGhe";
            this.LoaiGhe.ReadOnly = true;
            this.LoaiGhe.Width = 300;
            // 
            // GiaGhe
            // 
            this.GiaGhe.DataPropertyName = "GiaGhe";
            this.GiaGhe.HeaderText = "Giá tiền";
            this.GiaGhe.MinimumWidth = 6;
            this.GiaGhe.Name = "GiaGhe";
            this.GiaGhe.ReadOnly = true;
            this.GiaGhe.Width = 300;
            // 
            // grb_seat
            // 
            this.grb_seat.Controls.Add(this.btn_search);
            this.grb_seat.Controls.Add(this.txb_search);
            this.grb_seat.Controls.Add(this.label4);
            this.grb_seat.Controls.Add(this.txb_type);
            this.grb_seat.Controls.Add(this.txb_SeatId);
            this.grb_seat.Controls.Add(this.label2);
            this.grb_seat.Controls.Add(this.btn_delete);
            this.grb_seat.Controls.Add(this.txb_price);
            this.grb_seat.Controls.Add(this.btn_add);
            this.grb_seat.Controls.Add(this.label1);
            this.grb_seat.Controls.Add(this.label3);
            this.grb_seat.Controls.Add(this.btn_save);
            this.grb_seat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grb_seat.Location = new System.Drawing.Point(11, 9);
            this.grb_seat.Margin = new System.Windows.Forms.Padding(4);
            this.grb_seat.Name = "grb_seat";
            this.grb_seat.Padding = new System.Windows.Forms.Padding(4);
            this.grb_seat.Size = new System.Drawing.Size(1249, 181);
            this.grb_seat.TabIndex = 17;
            this.grb_seat.TabStop = false;
            this.grb_seat.Text = "Thông tin ghế ngồi";
            // 
            // txb_type
            // 
            this.txb_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_type.Location = new System.Drawing.Point(286, 108);
            this.txb_type.Margin = new System.Windows.Forms.Padding(4);
            this.txb_type.Name = "txb_type";
            this.txb_type.Size = new System.Drawing.Size(164, 30);
            this.txb_type.TabIndex = 19;
            // 
            // txb_SeatId
            // 
            this.txb_SeatId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_SeatId.Location = new System.Drawing.Point(76, 108);
            this.txb_SeatId.Margin = new System.Windows.Forms.Padding(4);
            this.txb_SeatId.Name = "txb_SeatId";
            this.txb_SeatId.ReadOnly = true;
            this.txb_SeatId.Size = new System.Drawing.Size(164, 30);
            this.txb_SeatId.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mã ghế";
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(746, 118);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(184, 32);
            this.btn_search.TabIndex = 26;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txb_search
            // 
            this.txb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_search.Location = new System.Drawing.Point(746, 78);
            this.txb_search.Margin = new System.Windows.Forms.Padding(4);
            this.txb_search.Name = "txb_search";
            this.txb_search.Size = new System.Drawing.Size(184, 30);
            this.txb_search.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(775, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Tìm kiếm ghế";
            // 
            // SeatUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grb_seat);
            this.Controls.Add(this.dgv_seat);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SeatUC";
            this.Size = new System.Drawing.Size(1264, 719);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_seat)).EndInit();
            this.grb_seat.ResumeLayout(false);
            this.grb_seat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_seat;
        private System.Windows.Forms.TextBox txb_price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiGhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaGhe;
        private System.Windows.Forms.GroupBox grb_seat;
        private System.Windows.Forms.TextBox txb_SeatId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_type;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txb_search;
        private System.Windows.Forms.Label label4;
    }
}
