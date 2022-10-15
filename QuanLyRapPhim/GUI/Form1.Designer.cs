
namespace QuanLyRapPhim
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // btn_dataManager
            // 
            this.btn_dataManager.Location = new System.Drawing.Point(289, 12);
            this.btn_dataManager.Name = "btn_dataManager";
            this.btn_dataManager.Size = new System.Drawing.Size(177, 48);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 682);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.btn_dataManager);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_dataManager;
        private System.Windows.Forms.Panel pnl_main;
    }
}

