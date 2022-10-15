
namespace QuanLyRapPhim
{
    partial class frm_revenue
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
            this.lblSelectMovie = new System.Windows.Forms.Label();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.txb_SumRevenue = new System.Windows.Forms.TextBox();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvRevenue = new System.Windows.Forms.DataGridView();
            this.cbx_SelectMovie = new System.Windows.Forms.ComboBox();
            this.dtpicker_ToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpicker_FromDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelectMovie
            // 
            this.lblSelectMovie.AutoSize = true;
            this.lblSelectMovie.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectMovie.ForeColor = System.Drawing.Color.Black;
            this.lblSelectMovie.Location = new System.Drawing.Point(28, 17);
            this.lblSelectMovie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectMovie.Name = "lblSelectMovie";
            this.lblSelectMovie.Size = new System.Drawing.Size(99, 20);
            this.lblSelectMovie.TabIndex = 50;
            this.lblSelectMovie.Text = "Chọn phim:";
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.BackColor = System.Drawing.Color.Transparent;
            this.lblTongDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongDoanhThu.ForeColor = System.Drawing.Color.Khaki;
            this.lblTongDoanhThu.Location = new System.Drawing.Point(454, 437);
            this.lblTongDoanhThu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(140, 20);
            this.lblTongDoanhThu.TabIndex = 49;
            this.lblTongDoanhThu.Text = "Tổng doanh thu:";
            // 
            // txb_SumRevenue
            // 
            this.txb_SumRevenue.Enabled = false;
            this.txb_SumRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_SumRevenue.Location = new System.Drawing.Point(598, 431);
            this.txb_SumRevenue.Margin = new System.Windows.Forms.Padding(2);
            this.txb_SumRevenue.Name = "txb_SumRevenue";
            this.txb_SumRevenue.Size = new System.Drawing.Size(177, 26);
            this.txb_SumRevenue.TabIndex = 48;
            this.txb_SumRevenue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.BackColor = System.Drawing.Color.Transparent;
            this.lblDenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDenNgay.ForeColor = System.Drawing.Color.Black;
            this.lblDenNgay.Location = new System.Drawing.Point(634, 22);
            this.lblDenNgay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(90, 20);
            this.lblDenNgay.TabIndex = 47;
            this.lblDenNgay.Text = "Đến ngày:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(430, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "Từ ngày:";
            // 
            // dtgvRevenue
            // 
            this.dtgvRevenue.AllowUserToAddRows = false;
            this.dtgvRevenue.AllowUserToDeleteRows = false;
            this.dtgvRevenue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRevenue.Location = new System.Drawing.Point(32, 69);
            this.dtgvRevenue.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvRevenue.Name = "dtgvRevenue";
            this.dtgvRevenue.ReadOnly = true;
            this.dtgvRevenue.Size = new System.Drawing.Size(798, 342);
            this.dtgvRevenue.TabIndex = 45;
            // 
            // cbx_SelectMovie
            // 
            this.cbx_SelectMovie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_SelectMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_SelectMovie.FormattingEnabled = true;
            this.cbx_SelectMovie.Location = new System.Drawing.Point(144, 17);
            this.cbx_SelectMovie.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_SelectMovie.Name = "cbx_SelectMovie";
            this.cbx_SelectMovie.Size = new System.Drawing.Size(263, 28);
            this.cbx_SelectMovie.TabIndex = 42;
            // 
            // dtpicker_ToDate
            // 
            this.dtpicker_ToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpicker_ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpicker_ToDate.Location = new System.Drawing.Point(728, 19);
            this.dtpicker_ToDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpicker_ToDate.Name = "dtpicker_ToDate";
            this.dtpicker_ToDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpicker_ToDate.Size = new System.Drawing.Size(102, 26);
            this.dtpicker_ToDate.TabIndex = 40;
            // 
            // dtpicker_FromDate
            // 
            this.dtpicker_FromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpicker_FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpicker_FromDate.Location = new System.Drawing.Point(511, 19);
            this.dtpicker_FromDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpicker_FromDate.Name = "dtpicker_FromDate";
            this.dtpicker_FromDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpicker_FromDate.Size = new System.Drawing.Size(102, 26);
            this.dtpicker_FromDate.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Khaki;
            this.label2.Location = new System.Drawing.Point(784, 437);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "VND";
            // 
            // frm_revenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::QuanLyRapPhim.Properties.Resources.pexels_johannes_plenio_1103970;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(872, 479);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSelectMovie);
            this.Controls.Add(this.lblTongDoanhThu);
            this.Controls.Add(this.txb_SumRevenue);
            this.Controls.Add(this.lblDenNgay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvRevenue);
            this.Controls.Add(this.cbx_SelectMovie);
            this.Controls.Add(this.dtpicker_ToDate);
            this.Controls.Add(this.dtpicker_FromDate);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frm_revenue";
            this.Text = "frm_revenue";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRevenue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectMovie;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.TextBox txb_SumRevenue;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvRevenue;
        private System.Windows.Forms.ComboBox cbx_SelectMovie;
        private System.Windows.Forms.DateTimePicker dtpicker_ToDate;
        private System.Windows.Forms.DateTimePicker dtpicker_FromDate;
        private System.Windows.Forms.Label label2;
    }
}