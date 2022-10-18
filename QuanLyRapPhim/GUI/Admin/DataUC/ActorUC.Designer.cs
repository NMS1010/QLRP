namespace QuanLyRapPhim.Admin.DataUC
{
    partial class ActorUC
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
            this.dgv_actor = new System.Windows.Forms.DataGridView();
            this.MaDienVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDienVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_actorName = new System.Windows.Forms.TextBox();
            this.grp_actor = new System.Windows.Forms.GroupBox();
            this.txb_actorId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.txb_search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_actor)).BeginInit();
            this.grp_actor.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_actor
            // 
            this.dgv_actor.AllowUserToDeleteRows = false;
            this.dgv_actor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_actor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDienVien,
            this.TenDienVien});
            this.dgv_actor.Location = new System.Drawing.Point(3, 160);
            this.dgv_actor.Name = "dgv_actor";
            this.dgv_actor.ReadOnly = true;
            this.dgv_actor.Size = new System.Drawing.Size(942, 417);
            this.dgv_actor.TabIndex = 8;
            this.dgv_actor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_actor_CellClick);
            // 
            // MaDienVien
            // 
            this.MaDienVien.DataPropertyName = "MaDienVien";
            this.MaDienVien.HeaderText = "Mã diễn viên";
            this.MaDienVien.Name = "MaDienVien";
            this.MaDienVien.ReadOnly = true;
            this.MaDienVien.Width = 450;
            // 
            // TenDienVien
            // 
            this.TenDienVien.DataPropertyName = "TenDienVien";
            this.TenDienVien.HeaderText = "Tên diễn viên";
            this.TenDienVien.Name = "TenDienVien";
            this.TenDienVien.ReadOnly = true;
            this.TenDienVien.Width = 450;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tên diễn viên";
            // 
            // txb_actorName
            // 
            this.txb_actorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_actorName.Location = new System.Drawing.Point(253, 95);
            this.txb_actorName.Name = "txb_actorName";
            this.txb_actorName.Size = new System.Drawing.Size(124, 26);
            this.txb_actorName.TabIndex = 16;
            // 
            // grp_actor
            // 
            this.grp_actor.Controls.Add(this.txb_actorId);
            this.grp_actor.Controls.Add(this.label2);
            this.grp_actor.Controls.Add(this.txb_actorName);
            this.grp_actor.Controls.Add(this.label1);
            this.grp_actor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grp_actor.Location = new System.Drawing.Point(3, 4);
            this.grp_actor.Name = "grp_actor";
            this.grp_actor.Size = new System.Drawing.Size(516, 150);
            this.grp_actor.TabIndex = 17;
            this.grp_actor.TabStop = false;
            this.grp_actor.Text = "Thông tin diễn viên";
            // 
            // txb_actorId
            // 
            this.txb_actorId.Enabled = false;
            this.txb_actorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_actorId.Location = new System.Drawing.Point(253, 31);
            this.txb_actorId.Name = "txb_actorId";
            this.txb_actorId.Size = new System.Drawing.Size(124, 26);
            this.txb_actorId.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mã diễn viên";
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(848, 20);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(86, 38);
            this.btn_add.TabIndex = 18;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(848, 63);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(86, 38);
            this.btn_delete.TabIndex = 19;
            this.btn_delete.Text = "Xoá";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(848, 107);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(86, 38);
            this.btn_save.TabIndex = 20;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(654, 89);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(71, 36);
            this.btn_search.TabIndex = 35;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txb_search
            // 
            this.txb_search.Location = new System.Drawing.Point(601, 40);
            this.txb_search.Multiline = true;
            this.txb_search.Name = "txb_search";
            this.txb_search.Size = new System.Drawing.Size(177, 34);
            this.txb_search.TabIndex = 34;
            // 
            // ActorUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txb_search);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dgv_actor);
            this.Controls.Add(this.grp_actor);
            this.Name = "ActorUC";
            this.Size = new System.Drawing.Size(948, 584);
            this.Load += new System.EventHandler(this.ActorUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_actor)).EndInit();
            this.grp_actor.ResumeLayout(false);
            this.grp_actor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_actor;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDienVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDienVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_actorName;
        private System.Windows.Forms.GroupBox grp_actor;
        private System.Windows.Forms.TextBox txb_actorId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txb_search;
    }
}
