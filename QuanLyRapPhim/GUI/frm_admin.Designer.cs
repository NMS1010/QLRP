
namespace QuanLyRapPhim
{
    partial class frm_admin
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
            this.pnl_main = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_sellTicket = new System.Windows.Forms.Button();
            this.btn_employee = new System.Windows.Forms.Button();
            this.btn_khachHang = new System.Windows.Forms.Button();
            this.btn_dataManager = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_main
            // 
            this.pnl_main.Location = new System.Drawing.Point(17, 92);
            this.pnl_main.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(1174, 608);
            this.pnl_main.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btn_sellTicket);
            this.panel1.Controls.Add(this.btn_employee);
            this.panel1.Controls.Add(this.btn_khachHang);
            this.panel1.Controls.Add(this.btn_dataManager);
            this.panel1.Location = new System.Drawing.Point(16, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1175, 80);
            this.panel1.TabIndex = 0;
            // 
            // btn_sellTicket
            // 
            this.btn_sellTicket.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_sellTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sellTicket.Image = global::QuanLyRapPhim.Properties.Resources.ticket_removebg_preview;
            this.btn_sellTicket.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_sellTicket.Location = new System.Drawing.Point(856, 8);
            this.btn_sellTicket.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sellTicket.Name = "btn_sellTicket";
            this.btn_sellTicket.Size = new System.Drawing.Size(196, 67);
            this.btn_sellTicket.TabIndex = 2;
            this.btn_sellTicket.Text = "BÁN VÉ";
            this.btn_sellTicket.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_sellTicket.UseVisualStyleBackColor = false;
            this.btn_sellTicket.Click += new System.EventHandler(this.btn_sellTicket_Click);
            // 
            // btn_employee
            // 
            this.btn_employee.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_employee.Image = global::QuanLyRapPhim.Properties.Resources.employee_office_staff_3d735bc691173bb5_256x256;
            this.btn_employee.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_employee.Location = new System.Drawing.Point(615, 8);
            this.btn_employee.Margin = new System.Windows.Forms.Padding(4);
            this.btn_employee.Name = "btn_employee";
            this.btn_employee.Size = new System.Drawing.Size(196, 67);
            this.btn_employee.TabIndex = 1;
            this.btn_employee.Text = "NHÂN VIÊN";
            this.btn_employee.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_employee.UseVisualStyleBackColor = false;
            this.btn_employee.Click += new System.EventHandler(this.btn_employee_Click);
            // 
            // btn_khachHang
            // 
            this.btn_khachHang.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_khachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_khachHang.Image = global::QuanLyRapPhim.Properties.Resources.people_2_512;
            this.btn_khachHang.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_khachHang.Location = new System.Drawing.Point(379, 7);
            this.btn_khachHang.Margin = new System.Windows.Forms.Padding(4);
            this.btn_khachHang.Name = "btn_khachHang";
            this.btn_khachHang.Size = new System.Drawing.Size(196, 68);
            this.btn_khachHang.TabIndex = 0;
            this.btn_khachHang.Text = "KHÁCH HÀNG";
            this.btn_khachHang.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_khachHang.UseVisualStyleBackColor = false;
            this.btn_khachHang.Click += new System.EventHandler(this.btn_khachHang_Click);
            // 
            // btn_dataManager
            // 
            this.btn_dataManager.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_dataManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dataManager.Image = global::QuanLyRapPhim.Properties.Resources.New_Database_icon;
            this.btn_dataManager.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_dataManager.Location = new System.Drawing.Point(139, 7);
            this.btn_dataManager.Margin = new System.Windows.Forms.Padding(4);
            this.btn_dataManager.Name = "btn_dataManager";
            this.btn_dataManager.Size = new System.Drawing.Size(202, 67);
            this.btn_dataManager.TabIndex = 0;
            this.btn_dataManager.Text = "DATA MANAGER";
            this.btn_dataManager.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_dataManager.UseVisualStyleBackColor = false;
            this.btn_dataManager.Click += new System.EventHandler(this.btn_dataManager_Click);
            // 
            // frm_admin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1204, 708);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_dataManager;
        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Button btn_khachHang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_employee;
        private System.Windows.Forms.Button btn_sellTicket;
    }
}

