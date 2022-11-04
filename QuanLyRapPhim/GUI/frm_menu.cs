using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapPhim.GUI
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void btn_manager_Click(object sender, EventArgs e)
        {
            frm_admin frm_Admin = new frm_admin();
            Hide();
            frm_Admin.ShowDialog();
            Show();
        }

        private void btn_seller_Click(object sender, EventArgs e)
        {
            frmSeller frmSeller = new frmSeller();
            this.Hide();
            frmSeller.ShowDialog();
            this.Show();
        }
    }
}