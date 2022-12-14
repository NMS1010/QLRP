using QuanLyRapPhim.Admin;
using QuanLyRapPhim.GUI;
using QuanLyRapPhim.GUI.Admin.DataUC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapPhim
{
    public partial class frm_admin : Form
    {
        public frm_admin()
        {
            InitializeComponent();
            DataManagerUC dataManagerUC = new DataManagerUC();
            pnl_main.Controls.Clear();
            pnl_main.Controls.Add(dataManagerUC);
        }

        private void btn_dataManager_Click(object sender, EventArgs e)
        {
            DataManagerUC dataManagerUC = new DataManagerUC();
            pnl_main.Controls.Clear();
            pnl_main.Controls.Add(dataManagerUC);
        }

        private void btn_khachHang_Click(object sender, EventArgs e)
        {
            TypeCustumerUC custumerUC = new TypeCustumerUC();
            pnl_main.Controls.Clear();
            custumerUC.Dock = DockStyle.Fill;
            pnl_main.Controls.Add(custumerUC);

            custumerUC.LoadData();
        }

        private void btn_employee_Click(object sender, EventArgs e)
        {
            frm_account employeeForm = new frm_account();
            this.Hide();
            employeeForm.ShowDialog();
            this.Show();
        }

        private void btn_sellTicket_Click(object sender, EventArgs e)
        {
            frmSeller frmSeller = new frmSeller();
            this.Hide();
            frmSeller.ShowDialog();
            this.Show();
        }

        private void btn_revenue_Click(object sender, EventArgs e)
        {
            frm_revenue frm_Revenue = new frm_revenue();
            this.Hide();
            frm_Revenue.ShowDialog();
            this.Show();
        }

        private void btn_bill_Click(object sender, EventArgs e)
        {
            frm_billmanager frm_Billmanager = new frm_billmanager();
            this.Hide();
            frm_Billmanager.ShowDialog();
            this.Show();
        }
    }
}