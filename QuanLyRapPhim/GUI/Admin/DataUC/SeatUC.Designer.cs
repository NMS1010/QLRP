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
            this.cbx_seatCategory = new System.Windows.Forms.ComboBox();
            this.dgv_seat = new System.Windows.Forms.DataGridView();
            this.MaGhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiGhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaGhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_seat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txb_price
            // 
            this.txb_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_price.Location = new System.Drawing.Point(214, 90);
            this.txb_price.Name = "txb_price";
            this.txb_price.Size = new System.Drawing.Size(124, 26);
            this.txb_price.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Giá tiền";
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(827, 101);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(86, 38);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(827, 57);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(86, 38);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Text = "Xoá";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(827, 14);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(86, 38);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Loại ghế";
            // 
            // cbx_seatCategory
            // 
            this.cbx_seatCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_seatCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_seatCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_seatCategory.FormattingEnabled = true;
            this.cbx_seatCategory.Location = new System.Drawing.Point(214, 29);
            this.cbx_seatCategory.Name = "cbx_seatCategory";
            this.cbx_seatCategory.Size = new System.Drawing.Size(124, 28);
            this.cbx_seatCategory.TabIndex = 2;
            // 
            // dgv_seat
            // 
            this.dgv_seat.AllowUserToDeleteRows = false;
            this.dgv_seat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_seat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGhe,
            this.LoaiGhe,
            this.GiaGhe});
            this.dgv_seat.Location = new System.Drawing.Point(3, 160);
            this.dgv_seat.Name = "dgv_seat";
            this.dgv_seat.ReadOnly = true;
            this.dgv_seat.Size = new System.Drawing.Size(942, 417);
            this.dgv_seat.TabIndex = 2;
            // 
            // MaGhe
            // 
            this.MaGhe.DataPropertyName = "MaGhe";
            this.MaGhe.HeaderText = "Mã ghế";
            this.MaGhe.Name = "MaGhe";
            this.MaGhe.ReadOnly = true;
            this.MaGhe.Width = 300;
            // 
            // LoaiGhe
            // 
            this.LoaiGhe.DataPropertyName = "LoaiGhe";
            this.LoaiGhe.HeaderText = "Loại ghế";
            this.LoaiGhe.Name = "LoaiGhe";
            this.LoaiGhe.ReadOnly = true;
            this.LoaiGhe.Width = 300;
            // 
            // GiaGhe
            // 
            this.GiaGhe.DataPropertyName = "GiaGhe";
            this.GiaGhe.HeaderText = "Giá tiền";
            this.GiaGhe.Name = "GiaGhe";
            this.GiaGhe.ReadOnly = true;
            this.GiaGhe.Width = 300;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.txb_price);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Controls.Add(this.cbx_seatCategory);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(937, 147);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin ghế ngồi";
            // 
            // SeatUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_seat);
            this.Name = "SeatUC";
            this.Size = new System.Drawing.Size(948, 584);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_seat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.ComboBox cbx_seatCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiGhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaGhe;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
