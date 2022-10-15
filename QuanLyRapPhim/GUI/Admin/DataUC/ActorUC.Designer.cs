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
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_actorName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_actor)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(834, 19);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(86, 38);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(834, 62);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(86, 38);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Text = "Xoá";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(834, 106);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(86, 38);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tên diễn viên";
            // 
            // txb_actorName
            // 
            this.txb_actorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_actorName.Location = new System.Drawing.Point(253, 56);
            this.txb_actorName.Name = "txb_actorName";
            this.txb_actorName.Size = new System.Drawing.Size(124, 26);
            this.txb_actorName.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.txb_actorName);
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(942, 150);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin diễn viên";
            // 
            // ActorUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_actor);
            this.Name = "ActorUC";
            this.Size = new System.Drawing.Size(948, 584);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_actor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_actor;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDienVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDienVien;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_actorName;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
