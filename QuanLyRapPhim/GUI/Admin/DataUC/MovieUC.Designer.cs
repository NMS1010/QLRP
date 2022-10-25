namespace QuanLyRapPhim.Admin.DataUC
{
    partial class MovieUC
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
            this.txb_time = new System.Windows.Forms.TextBox();
            this.txb_ageRate = new System.Windows.Forms.TextBox();
            this.txb_movieName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkLstBox_actor = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkLstBox_category = new System.Windows.Forms.CheckedListBox();
            this.txb_mainDirector = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpicker_endDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpicker_startDate = new System.Windows.Forms.DateTimePicker();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_movie = new System.Windows.Forms.DataGridView();
            this.MaPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LuaTuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKhoiChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaoDienChinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_film = new System.Windows.Forms.GroupBox();
            this.txb_FilmId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txb_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_movie)).BeginInit();
            this.grb_film.SuspendLayout();
            this.SuspendLayout();
            // 
            // txb_time
            // 
            this.txb_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_time.Location = new System.Drawing.Point(212, 186);
            this.txb_time.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txb_time.Name = "txb_time";
            this.txb_time.Size = new System.Drawing.Size(164, 30);
            this.txb_time.TabIndex = 16;
            // 
            // txb_ageRate
            // 
            this.txb_ageRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_ageRate.Location = new System.Drawing.Point(212, 146);
            this.txb_ageRate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txb_ageRate.Name = "txb_ageRate";
            this.txb_ageRate.Size = new System.Drawing.Size(164, 30);
            this.txb_ageRate.TabIndex = 15;
            // 
            // txb_movieName
            // 
            this.txb_movieName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_movieName.Location = new System.Drawing.Point(212, 65);
            this.txb_movieName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txb_movieName.Name = "txb_movieName";
            this.txb_movieName.Size = new System.Drawing.Size(164, 30);
            this.txb_movieName.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(917, 18);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 25);
            this.label8.TabIndex = 25;
            this.label8.Text = "Diễn viên";
            // 
            // checkLstBox_actor
            // 
            this.checkLstBox_actor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.checkLstBox_actor.FormattingEnabled = true;
            this.checkLstBox_actor.Location = new System.Drawing.Point(923, 58);
            this.checkLstBox_actor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkLstBox_actor.Name = "checkLstBox_actor";
            this.checkLstBox_actor.Size = new System.Drawing.Size(169, 94);
            this.checkLstBox_actor.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(445, 117);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = "Thể loại";
            // 
            // checkLstBox_category
            // 
            this.checkLstBox_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.checkLstBox_category.FormattingEnabled = true;
            this.checkLstBox_category.Location = new System.Drawing.Point(613, 102);
            this.checkLstBox_category.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkLstBox_category.Name = "checkLstBox_category";
            this.checkLstBox_category.Size = new System.Drawing.Size(225, 76);
            this.checkLstBox_category.TabIndex = 22;
            // 
            // txb_mainDirector
            // 
            this.txb_mainDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_mainDirector.Location = new System.Drawing.Point(212, 103);
            this.txb_mainDirector.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txb_mainDirector.Name = "txb_mainDirector";
            this.txb_mainDirector.Size = new System.Drawing.Size(164, 30);
            this.txb_mainDirector.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(445, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Ngày kết thúc";
            // 
            // dtpicker_endDate
            // 
            this.dtpicker_endDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpicker_endDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpicker_endDate.Location = new System.Drawing.Point(613, 58);
            this.dtpicker_endDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpicker_endDate.Name = "dtpicker_endDate";
            this.dtpicker_endDate.Size = new System.Drawing.Size(163, 30);
            this.dtpicker_endDate.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(445, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ngày khởi chiếu";
            // 
            // dtpicker_startDate
            // 
            this.dtpicker_startDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpicker_startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpicker_startDate.Location = new System.Drawing.Point(613, 18);
            this.dtpicker_startDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpicker_startDate.Name = "dtpicker_startDate";
            this.dtpicker_startDate.Size = new System.Drawing.Size(163, 30);
            this.dtpicker_startDate.TabIndex = 17;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(1129, 126);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btn_delete.Location = new System.Drawing.Point(1129, 71);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btn_add.Location = new System.Drawing.Point(1129, 18);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(115, 47);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 107);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Đạo diễn chính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Thời lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lứa tuổi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã phim";
            // 
            // dgv_movie
            // 
            this.dgv_movie.AllowUserToDeleteRows = false;
            this.dgv_movie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_movie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhim,
            this.TenPhim,
            this.ThoiLuong,
            this.LuaTuoi,
            this.NgayKhoiChieu,
            this.NgayKetThuc,
            this.DaoDienChinh});
            this.dgv_movie.Location = new System.Drawing.Point(4, 262);
            this.dgv_movie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_movie.Name = "dgv_movie";
            this.dgv_movie.ReadOnly = true;
            this.dgv_movie.RowHeadersWidth = 51;
            this.dgv_movie.Size = new System.Drawing.Size(1256, 448);
            this.dgv_movie.TabIndex = 4;
            this.dgv_movie.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_movie_CellClick);
            // 
            // MaPhim
            // 
            this.MaPhim.DataPropertyName = "MaPhim";
            this.MaPhim.HeaderText = "Mã phim";
            this.MaPhim.MinimumWidth = 6;
            this.MaPhim.Name = "MaPhim";
            this.MaPhim.ReadOnly = true;
            this.MaPhim.Width = 125;
            // 
            // TenPhim
            // 
            this.TenPhim.DataPropertyName = "TenPhim";
            this.TenPhim.HeaderText = "Tên phim";
            this.TenPhim.MinimumWidth = 6;
            this.TenPhim.Name = "TenPhim";
            this.TenPhim.ReadOnly = true;
            this.TenPhim.Width = 150;
            // 
            // ThoiLuong
            // 
            this.ThoiLuong.DataPropertyName = "ThoiLuong";
            this.ThoiLuong.HeaderText = "Thời lượng";
            this.ThoiLuong.MinimumWidth = 6;
            this.ThoiLuong.Name = "ThoiLuong";
            this.ThoiLuong.ReadOnly = true;
            this.ThoiLuong.Width = 125;
            // 
            // LuaTuoi
            // 
            this.LuaTuoi.DataPropertyName = "LuaTuoi";
            this.LuaTuoi.HeaderText = "Lứa tuổi";
            this.LuaTuoi.MinimumWidth = 6;
            this.LuaTuoi.Name = "LuaTuoi";
            this.LuaTuoi.ReadOnly = true;
            this.LuaTuoi.Width = 125;
            // 
            // NgayKhoiChieu
            // 
            this.NgayKhoiChieu.DataPropertyName = "NgayKhoiChieu";
            this.NgayKhoiChieu.HeaderText = "Ngày khởi chiếu";
            this.NgayKhoiChieu.MinimumWidth = 6;
            this.NgayKhoiChieu.Name = "NgayKhoiChieu";
            this.NgayKhoiChieu.ReadOnly = true;
            this.NgayKhoiChieu.Width = 150;
            // 
            // NgayKetThuc
            // 
            this.NgayKetThuc.DataPropertyName = "NgayKetThuc";
            this.NgayKetThuc.HeaderText = "Ngày kết thúc";
            this.NgayKetThuc.MinimumWidth = 6;
            this.NgayKetThuc.Name = "NgayKetThuc";
            this.NgayKetThuc.ReadOnly = true;
            this.NgayKetThuc.Width = 150;
            // 
            // DaoDienChinh
            // 
            this.DaoDienChinh.DataPropertyName = "DaoDienChinh";
            this.DaoDienChinh.HeaderText = "Đạo diễn chính";
            this.DaoDienChinh.MinimumWidth = 6;
            this.DaoDienChinh.Name = "DaoDienChinh";
            this.DaoDienChinh.ReadOnly = true;
            this.DaoDienChinh.Width = 150;
            // 
            // grb_film
            // 
            this.grb_film.Controls.Add(this.btn_search);
            this.grb_film.Controls.Add(this.txb_search);
            this.grb_film.Controls.Add(this.txb_FilmId);
            this.grb_film.Controls.Add(this.label9);
            this.grb_film.Controls.Add(this.btn_add);
            this.grb_film.Controls.Add(this.label8);
            this.grb_film.Controls.Add(this.txb_movieName);
            this.grb_film.Controls.Add(this.checkLstBox_actor);
            this.grb_film.Controls.Add(this.txb_ageRate);
            this.grb_film.Controls.Add(this.label7);
            this.grb_film.Controls.Add(this.btn_save);
            this.grb_film.Controls.Add(this.checkLstBox_category);
            this.grb_film.Controls.Add(this.txb_time);
            this.grb_film.Controls.Add(this.label1);
            this.grb_film.Controls.Add(this.btn_delete);
            this.grb_film.Controls.Add(this.txb_mainDirector);
            this.grb_film.Controls.Add(this.dtpicker_startDate);
            this.grb_film.Controls.Add(this.label3);
            this.grb_film.Controls.Add(this.label2);
            this.grb_film.Controls.Add(this.label6);
            this.grb_film.Controls.Add(this.label5);
            this.grb_film.Controls.Add(this.label4);
            this.grb_film.Controls.Add(this.dtpicker_endDate);
            this.grb_film.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grb_film.Location = new System.Drawing.Point(8, 4);
            this.grb_film.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grb_film.Name = "grb_film";
            this.grb_film.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grb_film.Size = new System.Drawing.Size(1252, 231);
            this.grb_film.TabIndex = 26;
            this.grb_film.TabStop = false;
            this.grb_film.Text = "Thông tin phim";
            // 
            // txb_FilmId
            // 
            this.txb_FilmId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_FilmId.Location = new System.Drawing.Point(212, 26);
            this.txb_FilmId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txb_FilmId.Name = "txb_FilmId";
            this.txb_FilmId.ReadOnly = true;
            this.txb_FilmId.Size = new System.Drawing.Size(164, 30);
            this.txb_FilmId.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(51, 69);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 25);
            this.label9.TabIndex = 26;
            this.label9.Text = "Tên phim";
            // 
            // txb_search
            // 
            this.txb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_search.Location = new System.Drawing.Point(928, 187);
            this.txb_search.Margin = new System.Windows.Forms.Padding(4);
            this.txb_search.Name = "txb_search";
            this.txb_search.Size = new System.Drawing.Size(164, 30);
            this.txb_search.TabIndex = 28;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(1129, 181);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(115, 42);
            this.btn_search.TabIndex = 29;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // MovieUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grb_film);
            this.Controls.Add(this.dgv_movie);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MovieUC";
            this.Size = new System.Drawing.Size(1264, 719);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_movie)).EndInit();
            this.grb_film.ResumeLayout(false);
            this.grb_film.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txb_time;
        private System.Windows.Forms.TextBox txb_ageRate;
        private System.Windows.Forms.TextBox txb_movieName;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_movie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpicker_endDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpicker_startDate;
        private System.Windows.Forms.TextBox txb_mainDirector;
        private System.Windows.Forms.CheckedListBox checkLstBox_category;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox checkLstBox_actor;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn LuaTuoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKhoiChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaoDienChinh;
        private System.Windows.Forms.GroupBox grb_film;
        private System.Windows.Forms.TextBox txb_FilmId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txb_search;
    }
}
