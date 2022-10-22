
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
            this.btn_dataManager = new System.Windows.Forms.Button();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.btn_khachHang = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_employee = new System.Windows.Forms.Button();
            this.btn_sellTicket = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_dataManager
            // 
            this.btn_dataManager.Location = new System.Drawing.Point(99, 8);
            this.btn_dataManager.Name = "btn_dataManager";
            this.btn_dataManager.Size = new System.Drawing.Size(125, 48);
            this.btn_dataManager.TabIndex = 0;
            this.btn_dataManager.Text = "Data Manager";
            this.btn_dataManager.UseVisualStyleBackColor = true;
            this.btn_dataManager.Click += new System.EventHandler(this.btn_dataManager_Click);
            // 
            // pnl_main
            // 
            this.pnl_main.Location = new System.Drawing.Point(13, 75);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(1168, 592);
            this.pnl_main.TabIndex = 1;
            // 
            // btn_khachHang
            // 
            this.btn_khachHang.Location = new System.Drawing.Point(289, 8);
            this.btn_khachHang.Name = "btn_khachHang";
            this.btn_khachHang.Size = new System.Drawing.Size(121, 48);
            this.btn_khachHang.TabIndex = 0;
            this.btn_khachHang.Text = "Khách hàng";
            this.btn_khachHang.UseVisualStyleBackColor = true;
            this.btn_khachHang.Click += new System.EventHandler(this.btn_khachHang_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btn_sellTicket);
            this.panel1.Controls.Add(this.btn_employee);
            this.panel1.Controls.Add(this.btn_khachHang);
            this.panel1.Controls.Add(this.btn_dataManager);
            this.panel1.Location = new System.Drawing.Point(12, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1169, 65);
            this.panel1.TabIndex = 0;
            // 
            // btn_employee
            // 
            this.btn_employee.Location = new System.Drawing.Point(483, 8);
            this.btn_employee.Name = "btn_employee";
            this.btn_employee.Size = new System.Drawing.Size(121, 48);
            this.btn_employee.TabIndex = 1;
            this.btn_employee.Text = "Nhân viên";
            this.btn_employee.UseVisualStyleBackColor = true;
            this.btn_employee.Click += new System.EventHandler(this.btn_employee_Click);
            // 
            // btn_sellTicket
            // 
            this.btn_sellTicket.Location = new System.Drawing.Point(639, 8);
            this.btn_sellTicket.Name = "btn_sellTicket";
            this.btn_sellTicket.Size = new System.Drawing.Size(121, 48);
            this.btn_sellTicket.TabIndex = 2;
            this.btn_sellTicket.Text = "Bán vé";
            this.btn_sellTicket.UseVisualStyleBackColor = true;
            this.btn_sellTicket.Click += new System.EventHandler(this.btn_sellTicket_Click);
            // 
            // frm_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 682);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.panel1);
            this.Name = "frm_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
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

