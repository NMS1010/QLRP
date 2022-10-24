
namespace QuanLyRapPhim
{
    partial class frmSeller
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
            this.gb_chitiet = new System.Windows.Forms.GroupBox();
            this.cbx_lichChieu_phim = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpicker_lichChieu = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lv_lichChieu = new System.Windows.Forms.ListView();
            this.tenphim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phongchieu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.giochieu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LoaiMay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tinhtrang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.Ngay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gb_chitiet.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_chitiet
            // 
            this.gb_chitiet.Controls.Add(this.cbx_lichChieu_phim);
            this.gb_chitiet.Controls.Add(this.label3);
            this.gb_chitiet.Controls.Add(this.dtpicker_lichChieu);
            this.gb_chitiet.Controls.Add(this.label2);
            this.gb_chitiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_chitiet.Location = new System.Drawing.Point(12, 77);
            this.gb_chitiet.Name = "gb_chitiet";
            this.gb_chitiet.Size = new System.Drawing.Size(311, 409);
            this.gb_chitiet.TabIndex = 0;
            this.gb_chitiet.TabStop = false;
            this.gb_chitiet.Text = "Chi tiết";
            // 
            // cbx_lichChieu_phim
            // 
            this.cbx_lichChieu_phim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_lichChieu_phim.FormattingEnabled = true;
            this.cbx_lichChieu_phim.Location = new System.Drawing.Point(6, 106);
            this.cbx_lichChieu_phim.Name = "cbx_lichChieu_phim";
            this.cbx_lichChieu_phim.Size = new System.Drawing.Size(293, 26);
            this.cbx_lichChieu_phim.TabIndex = 3;
            this.cbx_lichChieu_phim.SelectedIndexChanged += new System.EventHandler(this.cbx_lichChieu_phim_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phim:";
            // 
            // dtpicker_lichChieu
            // 
            this.dtpicker_lichChieu.CustomFormat = "dd-MM-yyyy";
            this.dtpicker_lichChieu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpicker_lichChieu.Location = new System.Drawing.Point(6, 48);
            this.dtpicker_lichChieu.Name = "dtpicker_lichChieu";
            this.dtpicker_lichChieu.Size = new System.Drawing.Size(296, 24);
            this.dtpicker_lichChieu.TabIndex = 1;
            this.dtpicker_lichChieu.ValueChanged += new System.EventHandler(this.dtpicker_lichChieu_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thời gian:";
            // 
            // lv_lichChieu
            // 
            this.lv_lichChieu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stt,
            this.tenphim,
            this.phongchieu,
            this.giochieu,
            this.Ngay,
            this.LoaiMay,
            this.tinhtrang});
            this.lv_lichChieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_lichChieu.HideSelection = false;
            this.lv_lichChieu.Location = new System.Drawing.Point(329, 82);
            this.lv_lichChieu.Name = "lv_lichChieu";
            this.lv_lichChieu.Size = new System.Drawing.Size(833, 404);
            this.lv_lichChieu.TabIndex = 1;
            this.lv_lichChieu.UseCompatibleStateImageBehavior = false;
            this.lv_lichChieu.View = System.Windows.Forms.View.Details;
            this.lv_lichChieu.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lv_lichChieu_ItemSelectionChanged);
            // 
            // tenphim
            // 
            this.tenphim.Text = "Tên Phim";
            this.tenphim.Width = 180;
            // 
            // phongchieu
            // 
            this.phongchieu.Text = "Phòng chiếu";
            this.phongchieu.Width = 150;
            // 
            // giochieu
            // 
            this.giochieu.Text = "Giờ chiếu";
            this.giochieu.Width = 150;
            // 
            // LoaiMay
            // 
            this.LoaiMay.Text = "Loại";
            this.LoaiMay.Width = 80;
            // 
            // tinhtrang
            // 
            this.tinhtrang.DisplayIndex = 5;
            this.tinhtrang.Text = "Tình trạng";
            this.tinhtrang.Width = 100;
            // 
            // stt
            // 
            this.stt.Text = "STT";
            this.stt.Width = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(557, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lịch chiếu phim";
            // 
            // Ngay
            // 
            this.Ngay.Text = "Ngày";
            this.Ngay.Width = 120;
            // 
            // frmSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 498);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lv_lichChieu);
            this.Controls.Add(this.gb_chitiet);
            this.Name = "frmSeller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch Chiếu Phim";
            this.Load += new System.EventHandler(this.frmSeller_Load);
            this.gb_chitiet.ResumeLayout(false);
            this.gb_chitiet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_chitiet;
        private System.Windows.Forms.ComboBox cbx_lichChieu_phim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpicker_lichChieu;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListView lv_lichChieu;
        private System.Windows.Forms.ColumnHeader tenphim;
        private System.Windows.Forms.ColumnHeader phongchieu;
        private System.Windows.Forms.ColumnHeader giochieu;
        private System.Windows.Forms.ColumnHeader tinhtrang;
        private System.Windows.Forms.ColumnHeader stt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader LoaiMay;
        private System.Windows.Forms.ColumnHeader Ngay;
    }
}

