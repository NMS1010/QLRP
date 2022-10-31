using QuanLyRapPhim.DAO;
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
    public partial class frm_billmanager : Form
    {
        private string error = "";

        public frm_billmanager()
        {
            InitializeComponent();
        }

        private void frm_billmanager_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init(string keyword = null)
        {
            DataTable billDT;
            if (keyword != null)
            {
                billDT = BillDAO.Search(keyword, ref error);
            }
            else
            {
                billDT = BillDAO.GetAllBill(ref error);
            }
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }

            dgv_bill.DataSource = billDT;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Init(txb_search.Text);
        }
    }
}