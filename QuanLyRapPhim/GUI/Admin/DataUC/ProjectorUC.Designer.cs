namespace QuanLyRapPhim.Admin.DataUC
{
    partial class ProjectorUC
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
            this.txb_projectorName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.dgv_projector = new System.Windows.Forms.DataGridView();
            this.MaMayChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMayChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_projector)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txb_price
            // 
            this.txb_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_price.Location = new System.Drawing.Point(214, 86);
            this.txb_price.Name = "txb_price";
            this.txb_price.Size = new System.Drawing.Size(124, 26);
            this.txb_price.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Giá";
            // 
            // txb_projectorName
            // 
            this.txb_projectorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_projectorName.Location = new System.Drawing.Point(214, 38);
            this.txb_projectorName.Name = "txb_projectorName";
            this.txb_projectorName.Size = new System.Drawing.Size(124, 26);
            this.txb_projectorName.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tên máy";
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(828, 101);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(86, 38);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(828, 57);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(86, 38);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Text = "Xoá";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(828, 14);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(86, 38);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // dgv_projector
            // 
            this.dgv_projector.AllowUserToDeleteRows = false;
            this.dgv_projector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_projector.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMayChieu,
            this.TenMayChieu,
            this.Gia});
            this.dgv_projector.Location = new System.Drawing.Point(3, 160);
            this.dgv_projector.Name = "dgv_projector";
            this.dgv_projector.ReadOnly = true;
            this.dgv_projector.Size = new System.Drawing.Size(942, 417);
            this.dgv_projector.TabIndex = 4;
            // 
            // MaMayChieu
            // 
            this.MaMayChieu.DataPropertyName = "MaMayChieu";
            this.MaMayChieu.HeaderText = "Mã máy chiếu";
            this.MaMayChieu.Name = "MaMayChieu";
            this.MaMayChieu.ReadOnly = true;
            this.MaMayChieu.Width = 300;
            // 
            // TenMayChieu
            // 
            this.TenMayChieu.DataPropertyName = "TenMayChieu";
            this.TenMayChieu.HeaderText = "Tên máy chiếu";
            this.TenMayChieu.Name = "TenMayChieu";
            this.TenMayChieu.ReadOnly = true;
            this.TenMayChieu.Width = 300;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá";
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            this.Gia.Width = 300;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.txb_price);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txb_projectorName);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(939, 149);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin máy chiếu";
            // 
            // ProjectorUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_projector);
            this.Name = "ProjectorUC";
            this.Size = new System.Drawing.Size(948, 584);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_projector)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txb_projectorName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dgv_projector;
        private System.Windows.Forms.TextBox txb_price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMayChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMayChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
