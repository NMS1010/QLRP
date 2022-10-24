using QuanLyRapPhim.DAO;
using QuanLyRapPhim.DTO;
using QuanLyRapPhim.Utils.Constants;
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
    public partial class ShowTimeUC : UserControl
    {
        private Hashtable movies;
        private Hashtable cinemaRooms;
        private List<ShowTime> showTimes = new List<ShowTime>();
        private List<Control> controls = new List<Control>();

        public ShowTimeUC()
        {
            InitializeComponent();
            Init();
        }

        private void GetRowChecked()
        {
            int selectedRowIndex = -1;
            try
            {
                selectedRowIndex = dgv_showTime.SelectedCells[0].RowIndex;
            }
            catch
            {
                return;
            }
            if (selectedRowIndex > dgv_showTime.Rows.Count - 2)
            {
                ClearControls.ClearContent(controls);
                return;
            }
            Fill(selectedRowIndex);
        }

        private void Init()
        {
            movies = new Hashtable();
            cinemaRooms = new Hashtable();
            string error = "";
            DataTable movie = MovieDAO.GetAllMovie(ref error);
            DataTable cinemaRoom = RoomDAO.GetAllRoom(ref error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            foreach (DataRow r in movie.Rows)
            {
                int movieId = (int)r["MaPhim"];
                string movieName = r["TenPhim"].ToString();
                movies.Add(movieId, movieName);
                cbx_movieName.Items.Add(movieName);
            }
            foreach (DataRow r in cinemaRoom.Rows)
            {
                int cinemaRoomId = (int)r["MaPhong"];
                string cinemaRoomName = r["TenPhong"].ToString();
                cinemaRooms.Add(cinemaRoomId, cinemaRoomName);
                cbx_CinemaRoom.Items.Add(cinemaRoomName);
            }
            foreach (DictionaryEntry s in STATUS.Status)
            {
                cbx_showTimeStatus.Items.Add(s.Value);
            }
            foreach (var c in grp_showTime.Controls)
            {
                controls.Add(c as Control);
            }
        }

        private void LoadData(string keyword = null)
        {
            string error = "";
            DataTable dt;
            if (keyword == null || keyword == "")
            {
                dt = ShowTimeDAO.GetAllShowTime(ref error);
            }
            else
            {
                dt = ShowTimeDAO.Search(keyword, ref error);
            }
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            showTimes.Clear();
            foreach (DataRow r in dt.Rows)
            {
                ShowTime st = new ShowTime()
                {
                    Id = (int)r["MaSuatChieu"],
                    Time = r["Gio"].ToString(),
                    Day = r["Ngay"].ToString(),
                    Status = (int)r["TrangThai"],
                    IdFilm = (int)r["MaPhim"],
                    IdRoom = (int)r["MaPhong"]
                };
                //r["MaPhim"] = movies[st.IdFilm].ToString();
                //r["MaPhong"] = cinemaRooms[st.IdRoom].ToString();
                showTimes.Add(st);
            }
            dgv_showTime.DataSource = dt;
            GetRowChecked();
        }

        private ShowTime GetShowTime()
        {
            ShowTime st = new ShowTime()
            {
                Time = dtpicker_time.Value.ToShortTimeString(),
                Day = dtpicker_date.Value.ToShortDateString(),
                Status = int.TryParse(STATUS.Status.Keys
                            .OfType<int>()
                            .FirstOrDefault(s =>
                                    STATUS.Status[s].ToString() == cbx_showTimeStatus.Text
                             )
                            .ToString(), out int status) ? status : -1,
                IdFilm = int.TryParse(movies.Keys
                            .OfType<int>()
                            .FirstOrDefault(s =>
                                    movies[s].ToString() == cbx_movieName.Text
                             )
                            .ToString(), out int idFilm) ? idFilm : -1,
                IdRoom = int.TryParse(cinemaRooms.Keys
                            .OfType<int>()
                            .FirstOrDefault(s =>
                                    cinemaRooms[s].ToString() == cbx_CinemaRoom.Text
                             )
                            .ToString(), out int idCinemaRoom) ? idCinemaRoom : -1,
            };

            if (string.IsNullOrEmpty(st.Time) || string.IsNullOrEmpty(st.Day)
                || st.Status == -1 || st.IdFilm == -1 || st.IdRoom == -1)
                return null;
            return st;
        }

        private void Fill(int selectedRowIndex)
        {
            int showTimeID = (int)dgv_showTime.Rows[selectedRowIndex].Cells["MaSuatChieu"].Value;
            ShowTime st = showTimes.FirstOrDefault(s => s.Id == showTimeID);
            if (st == null)
            {
                MessageBox.Show("Có lỗi xảy ra");
                return;
            }
            txb_showTimeId.Text = showTimeID.ToString();
            dtpicker_time.Text = st.Time;
            dtpicker_date.Text = st.Day;
            cbx_showTimeStatus.Text = STATUS.Status[st.Status].ToString();
            cbx_movieName.Text = movies[st.IdFilm].ToString();
            cbx_CinemaRoom.Text = cinemaRooms[st.IdRoom].ToString();
        }

        private void dgv_showTime_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetRowChecked();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txb_showTimeId.Text))
            {
                ClearControls.ClearContent(controls);
                return;
            }
            if (MessageBox.Show("Bạn có muốn thêm suất chiếu này ?", "Thêm", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }
            ShowTime showTime = GetShowTime();
            if (showTime == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            string error = "";
            int count = ShowTimeDAO.Insert(showTime, ref error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            LoadData();
            GetRowChecked();
            showTime.Id = (int)dgv_showTime.Rows[dgv_showTime.Rows.Count - 2].Cells["MaSuatChieu"].Value;
            TicketDAO.GenerateTicket(showTime.Id, showTime.IdRoom, ref error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá suất chiếu này ?", "Xoá", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }
            int showTimeId = int.TryParse(txb_showTimeId.Text, out int res) ? res : 0;
            if (showTimeId == 0)
            {
                MessageBox.Show("Có lỗi xảy ra");
                return;
            }
            string error = "";
            int count = ShowTimeDAO.Delete(showTimeId, ref error);
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
            if (MessageBox.Show("Bạn có muốn lưu thay đổi cho suất chiếu này ?", "Sửa", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }
            ShowTime st = GetShowTime();
            if (st == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            st.Id = int.TryParse(txb_showTimeId.Text, out int res) ? res : 0;
            if (st.Id == 0)
            {
                MessageBox.Show("Mã suất chiếu không hợp lệ");
                return;
            }
            string error = "";
            int count = ShowTimeDAO.Update(st, ref error);

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

        private void ShowTimeUC_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}