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
            this.MaMay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiMay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_projector = new System.Windows.Forms.GroupBox();
            this.txb_prjectorId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.txb_search = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_projector)).BeginInit();
            this.grb_projector.SuspendLayout();
            this.SuspendLayout();
            // 
            // txb_price
            // 
            this.txb_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_price.Location = new System.Drawing.Point(537, 96);
            this.txb_price.Margin = new System.Windows.Forms.Padding(4);
            this.txb_price.Name = "txb_price";
            this.txb_price.Size = new System.Drawing.Size(164, 30);
            this.txb_price.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(598, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Giá";
            // 
            // txb_projectorName
            // 
            this.txb_projectorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_projectorName.Location = new System.Drawing.Point(305, 96);
            this.txb_projectorName.Margin = new System.Windows.Forms.Padding(4);
            this.txb_projectorName.Name = "txb_projectorName";
            this.txb_projectorName.Size = new System.Drawing.Size(164, 30);
            this.txb_projectorName.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tên máy";
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(1104, 124);
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
            this.btn_delete.Location = new System.Drawing.Point(1104, 70);
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
            this.btn_add.Location = new System.Drawing.Point(1104, 17);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(115, 47);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dgv_projector
            // 
            this.dgv_projector.AllowUserToDeleteRows = false;
            this.dgv_projector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_projector.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMay,
            this.LoaiMay,
            this.Gia});
            this.dgv_projector.Location = new System.Drawing.Point(4, 197);
            this.dgv_projector.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_projector.Name = "dgv_projector";
            this.dgv_projector.ReadOnly = true;
            this.dgv_projector.RowHeadersWidth = 51;
            this.dgv_projector.Size = new System.Drawing.Size(1256, 513);
            this.dgv_projector.TabIndex = 4;
            this.dgv_projector.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_projector_CellClick);
            // 
            // MaMay
            // 
            this.MaMay.DataPropertyName = "MaMay";
            this.MaMay.HeaderText = "Mã máy chiếu";
            this.MaMay.MinimumWidth = 6;
            this.MaMay.Name = "MaMay";
            this.MaMay.ReadOnly = true;
            this.MaMay.Width = 300;
            // 
            // LoaiMay
            // 
            this.LoaiMay.DataPropertyName = "LoaiMay";
            this.LoaiMay.HeaderText = "Tên máy chiếu";
            this.LoaiMay.MinimumWidth = 6;
            this.LoaiMay.Name = "LoaiMay";
            this.LoaiMay.ReadOnly = true;
            this.LoaiMay.Width = 300;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            this.Gia.Width = 300;
            // 
            // grb_projector
            // 
            this.grb_projector.Controls.Add(this.btn_search);
            this.grb_projector.Controls.Add(this.txb_search);
            this.grb_projector.Controls.Add(this.label4);
            this.grb_projector.Controls.Add(this.txb_prjectorId);
            this.grb_projector.Controls.Add(this.label3);
            this.grb_projector.Controls.Add(this.btn_delete);
            this.grb_projector.Controls.Add(this.txb_price);
            this.grb_projector.Controls.Add(this.btn_save);
            this.grb_projector.Controls.Add(this.label2);
            this.grb_projector.Controls.Add(this.label1);
            this.grb_projector.Controls.Add(this.txb_projectorName);
            this.grb_projector.Controls.Add(this.btn_add);
            this.grb_projector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grb_projector.Location = new System.Drawing.Point(8, 6);
            this.grb_projector.Margin = new System.Windows.Forms.Padding(4);
            this.grb_projector.Name = "grb_projector";
            this.grb_projector.Padding = new System.Windows.Forms.Padding(4);
            this.grb_projector.Size = new System.Drawing.Size(1252, 183);
            this.grb_projector.TabIndex = 19;
            this.grb_projector.TabStop = false;
            this.grb_projector.Text = "Thông tin máy chiếu";
            // 
            // txb_prjectorId
            // 
            this.txb_prjectorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_prjectorId.Location = new System.Drawing.Point(83, 96);
            this.txb_prjectorId.Margin = new System.Windows.Forms.Padding(4);
            this.txb_prjectorId.Name = "txb_prjectorId";
            this.txb_prjectorId.ReadOnly = true;
            this.txb_prjectorId.Size = new System.Drawing.Size(164, 30);
            this.txb_prjectorId.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Mã máy";
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(799, 127);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(200, 32);
            this.btn_search.TabIndex = 26;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txb_search
            // 
            this.txb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_search.Location = new System.Drawing.Point(799, 87);
            this.txb_search.Margin = new System.Windows.Forms.Padding(4);
            this.txb_search.Name = "txb_search";
            this.txb_search.Size = new System.Drawing.Size(200, 30);
            this.txb_search.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(803, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Tìm kiếm máy chiếu";
            // 
            // ProjectorUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grb_projector);
            this.Controls.Add(this.dgv_projector);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProjectorUC";
            this.Size = new System.Drawing.Size(1264, 719);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_projector)).EndInit();
            this.grb_projector.ResumeLayout(false);
            this.grb_projector.PerformLayout();
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
        private System.Windows.Forms.GroupBox grb_projector;
        private System.Windows.Forms.TextBox txb_prjectorId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMay;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiMay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txb_search;
        private System.Windows.Forms.Label label4;
    }
}
