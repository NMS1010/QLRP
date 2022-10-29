namespace QuanLyRapPhim.Admin
{
    partial class DataManagerUC
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_movie = new System.Windows.Forms.Button();
            this.btn_category = new System.Windows.Forms.Button();
            this.btn_actor = new System.Windows.Forms.Button();
            this.btn_cinemaRoom = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnScreenTypeUC = new System.Windows.Forms.Button();
            this.pnl_data = new System.Windows.Forms.Panel();
            this.btn_seat = new System.Windows.Forms.Button();
            this.btn_projector = new System.Windows.Forms.Button();
            this.btn_discount = new System.Windows.Forms.Button();
            this.btn_service = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_service);
            this.panel1.Controls.Add(this.btn_discount);
            this.panel1.Controls.Add(this.btn_movie);
            this.panel1.Controls.Add(this.btn_projector);
            this.panel1.Controls.Add(this.btn_seat);
            this.panel1.Controls.Add(this.btn_category);
            this.panel1.Controls.Add(this.btn_actor);
            this.panel1.Controls.Add(this.btn_cinemaRoom);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.btnScreenTypeUC);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 688);
            this.panel1.TabIndex = 0;
            // 
            // btn_movie
            // 
            this.btn_movie.FlatAppearance.BorderSize = 0;
            this.btn_movie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_movie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_movie.ForeColor = System.Drawing.Color.White;
            this.btn_movie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_movie.Location = new System.Drawing.Point(21, 306);
            this.btn_movie.Margin = new System.Windows.Forms.Padding(4);
            this.btn_movie.Name = "btn_movie";
            this.btn_movie.Size = new System.Drawing.Size(253, 66);
            this.btn_movie.TabIndex = 18;
            this.btn_movie.Text = "PHIM";
            this.btn_movie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_movie.UseVisualStyleBackColor = true;
            this.btn_movie.Click += new System.EventHandler(this.btn_movie_Click);
            // 
            // btn_category
            // 
            this.btn_category.FlatAppearance.BorderSize = 0;
            this.btn_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_category.ForeColor = System.Drawing.Color.White;
            this.btn_category.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_category.Location = new System.Drawing.Point(20, 232);
            this.btn_category.Margin = new System.Windows.Forms.Padding(4);
            this.btn_category.Name = "btn_category";
            this.btn_category.Size = new System.Drawing.Size(253, 66);
            this.btn_category.TabIndex = 17;
            this.btn_category.Text = "THỂ LOẠI";
            this.btn_category.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_category.UseVisualStyleBackColor = true;
            this.btn_category.Click += new System.EventHandler(this.btn_category_Click);
            // 
            // btn_actor
            // 
            this.btn_actor.FlatAppearance.BorderSize = 0;
            this.btn_actor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actor.ForeColor = System.Drawing.Color.White;
            this.btn_actor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_actor.Location = new System.Drawing.Point(20, 158);
            this.btn_actor.Margin = new System.Windows.Forms.Padding(4);
            this.btn_actor.Name = "btn_actor";
            this.btn_actor.Size = new System.Drawing.Size(253, 66);
            this.btn_actor.TabIndex = 16;
            this.btn_actor.Text = "DIỄN VIÊN";
            this.btn_actor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_actor.UseVisualStyleBackColor = true;
            this.btn_actor.Click += new System.EventHandler(this.btn_actor_Click);
            // 
            // btn_cinemaRoom
            // 
            this.btn_cinemaRoom.FlatAppearance.BorderSize = 0;
            this.btn_cinemaRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cinemaRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cinemaRoom.ForeColor = System.Drawing.Color.White;
            this.btn_cinemaRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cinemaRoom.Location = new System.Drawing.Point(20, 84);
            this.btn_cinemaRoom.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cinemaRoom.Name = "btn_cinemaRoom";
            this.btn_cinemaRoom.Size = new System.Drawing.Size(253, 66);
            this.btn_cinemaRoom.TabIndex = 15;
            this.btn_cinemaRoom.Text = "PHÒNG CHIẾU";
            this.btn_cinemaRoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cinemaRoom.UseVisualStyleBackColor = true;
            this.btn_cinemaRoom.Click += new System.EventHandler(this.btn_cinemaRoom_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.SidePanel.Location = new System.Drawing.Point(4, 10);
            this.SidePanel.Margin = new System.Windows.Forms.Padding(4);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(13, 66);
            this.SidePanel.TabIndex = 13;
            // 
            // btnScreenTypeUC
            // 
            this.btnScreenTypeUC.FlatAppearance.BorderSize = 0;
            this.btnScreenTypeUC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScreenTypeUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScreenTypeUC.ForeColor = System.Drawing.Color.White;
            this.btnScreenTypeUC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScreenTypeUC.Location = new System.Drawing.Point(20, 10);
            this.btnScreenTypeUC.Margin = new System.Windows.Forms.Padding(4);
            this.btnScreenTypeUC.Name = "btnScreenTypeUC";
            this.btnScreenTypeUC.Size = new System.Drawing.Size(253, 66);
            this.btnScreenTypeUC.TabIndex = 14;
            this.btnScreenTypeUC.Text = "SUẤT CHIẾU";
            this.btnScreenTypeUC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnScreenTypeUC.UseVisualStyleBackColor = true;
            this.btnScreenTypeUC.Click += new System.EventHandler(this.btn_showTime_Click);
            // 
            // pnl_data
            // 
            this.pnl_data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_data.Location = new System.Drawing.Point(289, 5);
            this.pnl_data.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_data.Name = "pnl_data";
            this.pnl_data.Size = new System.Drawing.Size(1263, 686);
            this.pnl_data.TabIndex = 1;
            // 
            // btn_seat
            // 
            this.btn_seat.FlatAppearance.BorderSize = 0;
            this.btn_seat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_seat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seat.ForeColor = System.Drawing.Color.White;
            this.btn_seat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_seat.Location = new System.Drawing.Point(21, 380);
            this.btn_seat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_seat.Name = "btn_seat";
            this.btn_seat.Size = new System.Drawing.Size(253, 66);
            this.btn_seat.TabIndex = 19;
            this.btn_seat.Text = "GHẾ";
            this.btn_seat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_seat.UseVisualStyleBackColor = true;
            this.btn_seat.Click += new System.EventHandler(this.btn_seat_Click);
            // 
            // btn_projector
            // 
            this.btn_projector.FlatAppearance.BorderSize = 0;
            this.btn_projector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_projector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_projector.ForeColor = System.Drawing.Color.White;
            this.btn_projector.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_projector.Location = new System.Drawing.Point(21, 454);
            this.btn_projector.Margin = new System.Windows.Forms.Padding(4);
            this.btn_projector.Name = "btn_projector";
            this.btn_projector.Size = new System.Drawing.Size(253, 66);
            this.btn_projector.TabIndex = 20;
            this.btn_projector.Text = "MÁY CHIẾU";
            this.btn_projector.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_projector.UseVisualStyleBackColor = true;
            this.btn_projector.Click += new System.EventHandler(this.btn_projector_Click);
            // 
            // btn_discount
            // 
            this.btn_discount.FlatAppearance.BorderSize = 0;
            this.btn_discount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_discount.ForeColor = System.Drawing.Color.White;
            this.btn_discount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_discount.Location = new System.Drawing.Point(21, 602);
            this.btn_discount.Margin = new System.Windows.Forms.Padding(4);
            this.btn_discount.Name = "btn_discount";
            this.btn_discount.Size = new System.Drawing.Size(253, 66);
            this.btn_discount.TabIndex = 20;
            this.btn_discount.Text = "KHUYẾN MÃI";
            this.btn_discount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_discount.UseVisualStyleBackColor = true;
            this.btn_discount.Click += new System.EventHandler(this.btn_discount_Click);
            // 
            // btn_service
            // 
            this.btn_service.FlatAppearance.BorderSize = 0;
            this.btn_service.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_service.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_service.ForeColor = System.Drawing.Color.White;
            this.btn_service.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_service.Location = new System.Drawing.Point(21, 528);
            this.btn_service.Margin = new System.Windows.Forms.Padding(4);
            this.btn_service.Name = "btn_service";
            this.btn_service.Size = new System.Drawing.Size(253, 66);
            this.btn_service.TabIndex = 21;
            this.btn_service.Text = "DỊCH VỤ";
            this.btn_service.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_service.UseVisualStyleBackColor = true;
            this.btn_service.Click += new System.EventHandler(this.btn_service_Click);
            // 
            // DataManagerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_data);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DataManagerUC";
            this.Size = new System.Drawing.Size(1570, 703);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_data;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btnScreenTypeUC;
        private System.Windows.Forms.Button btn_cinemaRoom;
        private System.Windows.Forms.Button btn_movie;
        private System.Windows.Forms.Button btn_category;
        private System.Windows.Forms.Button btn_actor;
        private System.Windows.Forms.Button btn_seat;
        private System.Windows.Forms.Button btn_projector;
        private System.Windows.Forms.Button btn_discount;
        private System.Windows.Forms.Button btn_service;
    }
}
