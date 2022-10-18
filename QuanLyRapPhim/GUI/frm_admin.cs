using QuanLyRapPhim.Admin;
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
        }

        private void btn_dataManager_Click(object sender, EventArgs e)
        {
            DataManagerUC dataManagerUC = new DataManagerUC();
            pnl_main.Controls.Clear();
            pnl_main.Controls.Add(dataManagerUC);
        }

        private void btn_khachHang_Click(object sender, EventArgs e)
        {
            CustumerUC custumerUC = new CustumerUC();
            pnl_main.Controls.Clear();
            custumerUC.Dock = DockStyle.Fill;
            pnl_main.Controls.Add(custumerUC);

            custumerUC.LoadData();
        }
    }
}