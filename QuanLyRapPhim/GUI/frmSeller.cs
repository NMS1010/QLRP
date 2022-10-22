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
    public partial class frmSeller : Form
    {
        private Dictionary<int, string> movies;
        private List<Dictionary<int, int>> showtimes;

        public frmSeller()
        {
            InitializeComponent();
        }

        private void frmSeller_Load(object sender, EventArgs e)
        {
        }

        private void Init()
        {
            movies = new Dictionary<int, string>();
            showtimes = new List<Dictionary<int, int>>();
            string error = "";
            DataTable movieDT = MovieDAO.GetMovieByDate(dtpicker_lichChieu.Value.ToShortDateString(), ref error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            foreach (DataRow dr in movieDT.Rows)
            {
                int movieId = (int)dr["MaPhim"];
                string movieName = dr["TenPhim"].ToString();

                cbx_lichChieu_phim.Items.Add(movieName);
                movies.Add(movieId, movieName);
                DataTable showTimeDT = ShowTimeDAO.GetShowTimeByMovie(movieId, ref error);
                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show(error);
                    return;
                }
                foreach (DataRow r in showTimeDT.Rows)
                {
                    Dictionary<int, int> dict = new Dictionary<int, int>();
                    dict.Add(movieId, (int)r["MaSuatChieu"]);
                    showtimes.Add(dict);
                }
            }
        }
    }
}