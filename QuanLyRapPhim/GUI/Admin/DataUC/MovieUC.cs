using QuanLyRapPhim.Admin.DataUC;
using QuanLyRapPhim.DAO;
using QuanLyRapPhim.DTO;
using QuanLyRapPhim.Utils.FormControls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapPhim.Admin.DataUC
{
    public partial class MovieUC : UserControl
    {
        private int idFilmCurrent;
        private Hashtable category;
        private Hashtable actor;
        private string error = "";
        private List<Movie> movies = new List<Movie>();
        private List<Control> controls = new List<Control>();

        private void Init()
        {
            actor = new Hashtable();
            category = new Hashtable();

            DataTable actorDT = ActorDAO.GetAllActor(ref error);
            DataTable categoryDT = CategoryDAO.GetAllCategory(ref error);

            foreach (var c in grb_film.Controls)
            {
                controls.Add(c as Control);
            }

            foreach (DataRow row in actorDT.Rows)
            {
                int actorId = (int)row[0];
                string actorName = (string)row[1];
                actor.Add(actorId, actorName);
                checkLstBox_actor.Items.Add(actorName);
            }

            foreach (DataRow row in categoryDT.Rows)
            {
                int categoryId = (int)row[0];
                string categoryName = (string)row[1];
                category.Add(categoryId, categoryName);
                checkLstBox_category.Items.Add(categoryName);
            }
        }

        public MovieUC()
        {
            InitializeComponent();
            Init();
        }

        public void LoadData(string keyword = null)
        {
            string error = "";
            DataTable dt;
            if (keyword == null || keyword == "")
            {
                dt = MovieDAO.GetAllMovie(ref error);
            }
            else
            {
                dt = MovieDAO.Search(keyword, ref error);
            }
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            dgv_movie.DataSource = dt;
            movies.Clear();
            foreach (DataRow row in dt.Rows)
            {
                Movie movie = new Movie()
                {
                    MovieId = (int)row["MaPhim"],
                    MovieName = row["TenPhim"].ToString(),
                    Time = (double)Convert.ToDecimal(row["ThoiLuong"]),
                    AgeRange = (int)row["LuaTuoi"],
                    StartDate = row["NgayKhoiChieu"].ToString(),
                    EndDate = row["NgayKetThuc"].ToString(),
                    MainDirector = row["DaoDienChinh"].ToString(),
                };
                DataTable actor = MovieDAO.GetActorByFilmId((int)row["MaPhim"], ref error);
                DataTable category = MovieDAO.GetCategoryByFilmId((int)row["MaPhim"], ref error);

                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show(error);
                    return;
                }
                foreach (DataRow r in actor.Rows)
                {
                    movie.ActorIds.Add((int)r["MaDienVien"]);
                }
                foreach (DataRow r in category.Rows)
                {
                    movie.CategoryIds.Add((int)r["MaLoai"]);
                }
                movies.Add(movie);
            }
            GetRowChecked();
        }

        private void GetRowChecked()
        {
            int selectedRowIndex = -1;
            try
            {
                selectedRowIndex = dgv_movie.SelectedCells[0].RowIndex;
                idFilmCurrent = selectedRowIndex;
            }
            catch
            {
                return;
            }
            if (selectedRowIndex > dgv_movie.Rows.Count - 2)
            {
                ClearControls.ClearContent(controls);
                return;
            }
            Fill(selectedRowIndex);
        }

        private void Fill(int selectedRowIndex)
        {
            int movieId = (int)dgv_movie.Rows[selectedRowIndex].Cells["MaPhim"].Value;
            Movie movie = movies.FirstOrDefault(u => u.MovieId == movieId);

            txb_FilmId.Text = movie.MovieId.ToString();
            txb_movieName.Text = movie.MovieName;
            txb_mainDirector.Text = movie.MainDirector;
            txb_ageRate.Text = movie.AgeRange.ToString();
            txb_time.Text = movie.Time.ToString();
            dtpicker_startDate.Text = movie.StartDate.ToString();
            dtpicker_endDate.Text = movie.EndDate.ToString();

            for (int i = 0; i < checkLstBox_actor.Items.Count; i++)
            {
                int actorId = actor.Keys.OfType<int>()
                    .FirstOrDefault(s =>
                        actor[s].ToString() == checkLstBox_actor.Items[i].ToString()
                    );
                bool contain = movie.ActorIds.Any(x => x == actorId);
                if (contain)
                {
                    checkLstBox_actor.SetItemChecked(i, true);
                }
                else
                {
                    checkLstBox_actor.SetItemChecked(i, false);
                }
            }
            for (int i = 0; i < checkLstBox_category.Items.Count; i++)
            {
                int categoryId = category.Keys.OfType<int>()
                    .FirstOrDefault(s =>
                        category[s].ToString() == checkLstBox_category.Items[i].ToString()
                    );
                bool contain = movie.CategoryIds.Any(x => x == categoryId);
                if (contain)
                {
                    checkLstBox_category.SetItemChecked(i, true);
                }
                else
                {
                    checkLstBox_category.SetItemChecked(i, false);
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txb_FilmId.Text))
            {
                ClearControls.ClearContent(controls);
                return;
            }
            if (MessageBox.Show("Bạn có muốn thêm phim này không ?", "Thêm", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }
            Movie movie = GetMovie();
            if (movie == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            string error = "";
            int count = MovieDAO.Insert(movie, ref error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            LoadData();
            GetRowChecked();
        }

        private Movie GetMovie()
        {
            int age;
            Movie movie = new Movie()
            {
                MovieName = txb_movieName.Text,
                Time = (double)(Decimal.TryParse(txb_time.Text, out decimal res) ? res : 0),
                AgeRange = int.TryParse(txb_ageRate.Text, out age) ? age : 0,
                StartDate = dtpicker_startDate.Value.ToString("yyyy-MM-dd"),
                EndDate = dtpicker_endDate.Value.ToString("yyyy-MM-dd"),
                MainDirector = txb_mainDirector.Text
            };
            foreach (var item in checkLstBox_actor.CheckedItems)
            {
                movie.ActorIds.Add(actor.Keys.OfType<int>()
                    .FirstOrDefault(s =>
                        actor[s].ToString() == item.ToString()
                    )
                );
            }
            foreach (var item in checkLstBox_category.CheckedItems)
            {
                movie.CategoryIds.Add(category.Keys.OfType<int>()
                    .FirstOrDefault(s =>
                        category[s].ToString() == item.ToString()
                    )
                );
            }
            if (string.IsNullOrEmpty(movie.MovieName) || string.IsNullOrEmpty(txb_time.Text) || string.IsNullOrEmpty(movie.AgeRange.ToString())
                || string.IsNullOrEmpty(movie.StartDate) || string.IsNullOrEmpty(movie.EndDate) || string.IsNullOrEmpty(movie.MainDirector)
                || movie.CategoryIds.Count == 0 || movie.ActorIds.Count == 0)
                return null;
            return movie;
        }

        private void dgv_movie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgv_movie.SelectedCells[0].RowIndex;
            if (selectedRowIndex > dgv_movie.Rows.Count - 2)
            {
                ClearControls.ClearContent(controls);
                return;
            }
            Fill(selectedRowIndex);
            idFilmCurrent = (int)dgv_movie.Rows[selectedRowIndex].Cells["MaPhim"].Value;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá phim này ?", "Xoá", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }

            string error = "";
            int count = MovieDAO.Delete(idFilmCurrent, ref error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
            }
            ClearControls.ClearContent(controls);
            LoadData();
            GetRowChecked();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn lưu thay đổi cho phim này ?", "Sửa", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }
            Movie movie = GetMovie();
            if (movie == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            movie.MovieId = int.TryParse(txb_FilmId.Text, out int res) ? res : 0;
            if (movie.MovieId == 0)
            {
                MessageBox.Show("Mã phim không hợp lệ");
                return;
            }
            string error = "";
            int count = MovieDAO.Update(movie, ref error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
            }
            LoadData();
            GetRowChecked();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string keyword = txb_search.Text;
            LoadData(keyword);
        }
    }
}