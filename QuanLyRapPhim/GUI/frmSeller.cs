using QuanLyRapPhim.Admin.DataUC;
using QuanLyRapPhim.DAO;
using QuanLyRapPhim.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace QuanLyRapPhim
{
    public partial class frmSeller : Form
    {
        private List<Movie> movies;
        private List<List<ShowTime>> showtimes;

        public frmSeller()
        {
            InitializeComponent();
        }

        private void frmSeller_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void LoadData()
        {
            string error = "";
            DataTable movieDT = MovieDAO.GetMovieByDate(dtpicker_lichChieu.Value.ToString("yyyy-MM-dd"), ref error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            if (movieDT.Rows.Count == 0)
            {
                movies.Clear();
                showtimes.Clear();
                cbx_lichChieu_phim.Items.Clear();
                return;
            }
            cbx_lichChieu_phim.Items.Clear();
            foreach (DataRow dr in movieDT.Rows)
            {
                Movie movie = new Movie()
                {
                    MovieId = (int)dr["MaPhim"],
                    MovieName = dr["TenPhim"].ToString().Trim(),
                    MainDirector = dr["DaoDienChinh"].ToString().Trim(),
                    AgeRange = (int)dr["LuaTuoi"],
                    StartDate = ((DateTime)dr["NgayKhoiChieu"]).ToShortDateString().Trim(),
                    EndDate = ((DateTime)dr["NgayKetThuc"]).ToShortDateString().Trim(),
                    Time = (double)dr["ThoiLuong"]
                };

                cbx_lichChieu_phim.Items.Add(movie.MovieName);
                movies.Add(movie);
                DataTable showTimeDT = ShowTimeDAO.GetShowTimeByMovie(movie.MovieId, ref error);
                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show(error);
                    return;
                }
                List<ShowTime> showTimeByMovie = new List<ShowTime>();
                foreach (DataRow r in showTimeDT.Rows)
                {
                    ShowTime st = new ShowTime()
                    {
                        Id = (int)r["MaSuatChieu"],
                        IdFilm = (int)r["MaPhim"],
                        IdRoom = (int)r["MaPhong"],
                        Time = r["Gio"].ToString().Trim(),
                        Day = r["Ngay"].ToString().Trim(),
                        FilmName = r["TenPhim"].ToString().Trim(),
                        RoomName = r["TenPhong"].ToString().Trim(),
                        Status = (int)r["TrangThai"],
                        ProjectorName = r["LoaiMay"].ToString().Trim(),
                        Row = (int)r["SoHang"],
                        Col = (int)r["SoCot"],
                    };
                    showTimeByMovie.Add(st);
                }
                showtimes.Add(showTimeByMovie);
            }
            if (cbx_lichChieu_phim.Items.Count > 0)
                cbx_lichChieu_phim.SelectedIndex = 0;
        }

        private void Init()
        {
            movies = new List<Movie>();
            showtimes = new List<List<ShowTime>>();
            LoadData();
        }

        private void cbx_lichChieu_phim_SelectedIndexChanged(object sender, EventArgs e)
        {
            lv_lichChieu.Items.Clear();
            int selectedRow = cbx_lichChieu_phim.SelectedIndex;
            if (selectedRow < 0 || selectedRow > cbx_lichChieu_phim.Items.Count - 1)
                return;
            int stt = 0;
            foreach (ShowTime st in showtimes[selectedRow])
            {
                stt++;
                if (Convert.ToDateTime(st.Day).ToShortDateString() != dtpicker_lichChieu.Value.ToShortDateString())
                    continue;
                string[] row = new string[] { stt.ToString().Trim(), st.FilmName, st.RoomName, st.Time, Convert.ToDateTime(st.Day).ToShortDateString().Trim(), st.Status.ToString().Trim(), st.ProjectorName };
                ListViewItem lvi = new ListViewItem(row);
                lv_lichChieu.Items.Add(lvi);
            }
        }

        private void dtpicker_lichChieu_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void lv_lichChieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_lichChieu.SelectedIndices.Count == 0)
                return;
            int selectedRow = lv_lichChieu.SelectedIndices[0];
            if (selectedRow < 0 || selectedRow > lv_lichChieu.Items.Count - 1)
                return;
            int movieSelectedIndex = cbx_lichChieu_phim.SelectedIndex;
            frmTheater frmTheater = new frmTheater(showtimes[movieSelectedIndex][selectedRow], movies[movieSelectedIndex]);
            this.Hide();
            frmTheater.ShowDialog();
            this.Show();
        }
    }
}