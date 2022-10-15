namespace QuanLyRapPhim.Admin.DataUC
{
    partial class DiscountUC
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
            this.label2 = new System.Windows.Forms.Label();
            this.txb_codeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.dgv_discount = new System.Windows.Forms.DataGridView();
            this.MaKhuyenMai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhuyenMai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTriKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_discount)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txb_price
            // 
            this.txb_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_price.Location = new System.Drawing.Point(255, 88);
            this.txb_price.Name = "txb_price";
            this.txb_price.Size = new System.Drawing.Size(124, 26);
            this.txb_price.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Giá trị khuyến mãi";
            // 
            // txb_codeName
            // 
            this.txb_codeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_codeName.Location = new System.Drawing.Point(255, 39);
            this.txb_codeName.Name = "txb_codeName";
            this.txb_codeName.Size = new System.Drawing.Size(124, 26);
            this.txb_codeName.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tên khuyến mãi";
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(831, 105);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(86, 38);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(831, 61);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(86, 38);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Text = "Xoá";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(831, 18);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(86, 38);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // dgv_discount
            // 
            this.dgv_discount.AllowUserToDeleteRows = false;
            this.dgv_discount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_discount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKhuyenMai,
            this.TenKhuyenMai,
            this.GiaTriKM});
            this.dgv_discount.Location = new System.Drawing.Point(3, 160);
            this.dgv_discount.Name = "dgv_discount";
            this.dgv_discount.ReadOnly = true;
            this.dgv_discount.Size = new System.Drawing.Size(942, 417);
            this.dgv_discount.TabIndex = 12;
            // 
            // MaKhuyenMai
            // 
            this.MaKhuyenMai.DataPropertyName = "MaKhuyenMai";
            this.MaKhuyenMai.HeaderText = "Mã khuyến mãi";
            this.MaKhuyenMai.Name = "MaKhuyenMai";
            this.MaKhuyenMai.ReadOnly = true;
            this.MaKhuyenMai.Width = 300;
            // 
            // TenKhuyenMai
            // 
            this.TenKhuyenMai.DataPropertyName = "TenKhuyenMai";
            this.TenKhuyenMai.HeaderText = "Tên khuyến mãi";
            this.TenKhuyenMai.Name = "TenKhuyenMai";
            this.TenKhuyenMai.ReadOnly = true;
            this.TenKhuyenMai.Width = 300;
            // 
            // GiaTriKM
            // 
            this.GiaTriKM.DataPropertyName = "GiaTriKM";
            this.GiaTriKM.HeaderText = "Giá trị khuyến mãi";
            this.GiaTriKM.Name = "GiaTriKM";
            this.GiaTriKM.ReadOnly = true;
            this.GiaTriKM.Width = 300;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txb_price);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.txb_codeName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(942, 151);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khuyến mãi";
            // 
            // DiscountUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_discount);
            this.Name = "DiscountUC";
            this.Size = new System.Drawing.Size(948, 584);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_discount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txb_price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_codeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dgv_discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhuyenMai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhuyenMai;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTriKM;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
