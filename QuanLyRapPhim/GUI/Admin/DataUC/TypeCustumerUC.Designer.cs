namespace QuanLyRapPhim.GUI.Admin.DataUC
{
    partial class TypeCustumerUC
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
            this.pnl_viewKH = new System.Windows.Forms.Panel();
            this.dgv_typeCustomer = new System.Windows.Forms.DataGridView();
            this.MaLoaiKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaGiam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txb_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_maLoaiKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_tenLoai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_giaGiam = new System.Windows.Forms.TextBox();
            this.grb_customer = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_customerCount = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_viewKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_typeCustomer)).BeginInit();
            this.panel1.SuspendLayout();
            this.grb_customer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_viewKH
            // 
            this.pnl_viewKH.Controls.Add(this.dgv_typeCustomer);
            this.pnl_viewKH.Location = new System.Drawing.Point(463, 390);
            this.pnl_viewKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_viewKH.Name = "pnl_viewKH";
            this.pnl_viewKH.Size = new System.Drawing.Size(607, 335);
            this.pnl_viewKH.TabIndex = 2;
            // 
            // dgv_typeCustomer
            // 
            this.dgv_typeCustomer.AllowUserToDeleteRows = false;
            this.dgv_typeCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_typeCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiKH,
            this.TenLoaiKH,
            this.GiaGiam});
            this.dgv_typeCustomer.Location = new System.Drawing.Point(0, 0);
            this.dgv_typeCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_typeCustomer.Name = "dgv_typeCustomer";
            this.dgv_typeCustomer.ReadOnly = true;
            this.dgv_typeCustomer.RowHeadersWidth = 51;
            this.dgv_typeCustomer.Size = new System.Drawing.Size(603, 331);
            this.dgv_typeCustomer.TabIndex = 0;
            this.dgv_typeCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dsKH_CellClick);
            // 
            // MaLoaiKH
            // 
            this.MaLoaiKH.DataPropertyName = "MaLoaiKH";
            this.MaLoaiKH.HeaderText = "Mã Loại ";
            this.MaLoaiKH.MinimumWidth = 6;
            this.MaLoaiKH.Name = "MaLoaiKH";
            this.MaLoaiKH.ReadOnly = true;
            this.MaLoaiKH.Width = 125;
            // 
            // TenLoaiKH
            // 
            this.TenLoaiKH.DataPropertyName = "TenLoaiKH";
            this.TenLoaiKH.HeaderText = "Tên loại";
            this.TenLoaiKH.MinimumWidth = 6;
            this.TenLoaiKH.Name = "TenLoaiKH";
            this.TenLoaiKH.ReadOnly = true;
            this.TenLoaiKH.Width = 125;
            // 
            // GiaGiam
            // 
            this.GiaGiam.DataPropertyName = "GiamGia";
            this.GiaGiam.HeaderText = "Giá giảm";
            this.GiaGiam.MinimumWidth = 6;
            this.GiaGiam.Name = "GiaGiam";
            this.GiaGiam.ReadOnly = true;
            this.GiaGiam.Width = 125;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(206, 28);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(87, 46);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Yellow;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(408, 28);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(87, 46);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Red;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(313, 28);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(87, 46);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txb_search
            // 
            this.txb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_search.Location = new System.Drawing.Point(525, 38);
            this.txb_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txb_search.Multiline = true;
            this.txb_search.Name = "txb_search";
            this.txb_search.Size = new System.Drawing.Size(405, 27);
            this.txb_search.TabIndex = 4;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(938, 34);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(119, 37);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.txb_search);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Location = new System.Drawing.Point(151, 282);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1256, 91);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Loại KH";
            // 
            // txb_maLoaiKH
            // 
            this.txb_maLoaiKH.Enabled = false;
            this.txb_maLoaiKH.Location = new System.Drawing.Point(173, 80);
            this.txb_maLoaiKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txb_maLoaiKH.Name = "txb_maLoaiKH";
            this.txb_maLoaiKH.Size = new System.Drawing.Size(265, 30);
            this.txb_maLoaiKH.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(448, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên loại KH";
            // 
            // txb_tenLoai
            // 
            this.txb_tenLoai.Location = new System.Drawing.Point(581, 85);
            this.txb_tenLoai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txb_tenLoai.Name = "txb_tenLoai";
            this.txb_tenLoai.Size = new System.Drawing.Size(265, 30);
            this.txb_tenLoai.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(869, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giá giảm";
            // 
            // txb_giaGiam
            // 
            this.txb_giaGiam.Location = new System.Drawing.Point(993, 80);
            this.txb_giaGiam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txb_giaGiam.Name = "txb_giaGiam";
            this.txb_giaGiam.Size = new System.Drawing.Size(224, 30);
            this.txb_giaGiam.TabIndex = 7;
            // 
            // grb_customer
            // 
            this.grb_customer.Controls.Add(this.txb_giaGiam);
            this.grb_customer.Controls.Add(this.label4);
            this.grb_customer.Controls.Add(this.txb_tenLoai);
            this.grb_customer.Controls.Add(this.label2);
            this.grb_customer.Controls.Add(this.txb_maLoaiKH);
            this.grb_customer.Controls.Add(this.label1);
            this.grb_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_customer.Location = new System.Drawing.Point(155, 98);
            this.grb_customer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grb_customer.Name = "grb_customer";
            this.grb_customer.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grb_customer.Size = new System.Drawing.Size(1260, 145);
            this.grb_customer.TabIndex = 0;
            this.grb_customer.TabStop = false;
            this.grb_customer.Text = "Thông tin loại khách hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(482, 32);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tổng số khách hàng của hệ thống:";
            // 
            // lb_customerCount
            // 
            this.lb_customerCount.AutoSize = true;
            this.lb_customerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_customerCount.ForeColor = System.Drawing.Color.Brown;
            this.lb_customerCount.Location = new System.Drawing.Point(534, 12);
            this.lb_customerCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_customerCount.Name = "lb_customerCount";
            this.lb_customerCount.Size = new System.Drawing.Size(116, 32);
            this.lb_customerCount.TabIndex = 4;
            this.lb_customerCount.Text = "label11";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lb_customerCount);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(412, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(704, 59);
            this.panel2.TabIndex = 5;
            // 
            // TypeCustumerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_viewKH);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grb_customer);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TypeCustumerUC";
            this.Size = new System.Drawing.Size(1557, 729);
            this.pnl_viewKH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_typeCustomer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grb_customer.ResumeLayout(false);
            this.grb_customer.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_viewKH;
        private System.Windows.Forms.DataGridView dgv_typeCustomer;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox txb_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_maLoaiKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_tenLoai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_giaGiam;
        private System.Windows.Forms.GroupBox grb_customer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_customerCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaGiam;
        private System.Windows.Forms.Panel panel2;
    }
}
