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

namespace QuanLyRapPhim
{
    public partial class frm_revenue : Form
    {
        private string error = "";

        public frm_revenue()
        {
            InitializeComponent();
        }

        private void btn_showRevenue_Click(object sender, EventArgs e)
        {
            DataTable revenueDT = RevenueDAO.GetRevenue(cbx_SelectMovie.Text, dtpicker_FromDate.Value.ToString("yyyy-MM-dd")
                , dtpicker_ToDate.Value.ToString("yyyy-MM-dd"), ref error);
            dgv_Revenue.DataSource = revenueDT;
            decimal totalRevenue = 0;
            foreach (DataRow r in revenueDT.Rows)
            {
                totalRevenue += (decimal)r["TongChiPhi"];
            }
            txb_SumRevenue.Text = totalRevenue.ToString();
        }

        private void frm_revenue_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            DataTable movieDT = MovieDAO.GetAllMovie(ref error);
            foreach (DataRow dr in movieDT.Rows)
            {
                cbx_SelectMovie.Items.Add(dr["TenPhim"].ToString());
            }
            if (cbx_SelectMovie.Items.Count > 0)
            {
                cbx_SelectMovie.SelectedIndex = 0;
            }
        }
    }
}