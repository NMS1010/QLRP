using QuanLyRapPhim.DAO;
using QuanLyRapPhim.DTO;
using QuanLyRapPhim.GUI.Admin.DataUC;
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
    public partial class CinemaRoomUC : UserControl
    {
        private Hashtable projectors = new Hashtable();
        private List<Room> rooms = new List<Room>();
        private List<Control> controls = new List<Control>();

        public CinemaRoomUC()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            string error = "";
            DataTable projectorDT = ProjectorDAO.GetAllProjector(ref error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
            }
            foreach (DataRow row in projectorDT.Rows)
            {
                int projectorId = (int)row[0];
                string typeProjector = (string)row[1];

                projectors.Add(projectorId, typeProjector);
                cbx_projector.Items.Add(typeProjector);
            }
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
            }
            foreach (var c in grp_room.Controls)
            {
                controls.Add(c as Control);
            }
            foreach (DictionaryEntry s in STATUS.Status)
            {
                cbx_roomStatus.Items.Add(s.Value);
            }
        }

        private Room GetRoom()
        {
            int row = int.TryParse(txb_row.Text, out int r) ? r : -1;
            int col = int.TryParse(txb_col.Text, out int c) ? c : -1;
            Room room = new Room()
            {
                Name = txb_roomId.Text,
                Col = col,
                Row = row,
                TotalSeat = col * row,
                Status = int.TryParse(STATUS.Status.Keys
                            .OfType<int>()
                            .FirstOrDefault(s =>
                                    STATUS.Status[s].ToString() == cbx_roomStatus.Text
                             )
                            .ToString(), out int status) ? status : -1,
                IdProjector = int.TryParse(projectors.Keys
                            .OfType<int>()
                            .FirstOrDefault(s =>
                                    projectors[s].ToString() == cbx_projector.Text
                             )
                            .ToString(), out int idFilm) ? idFilm : -1,
            };
            if (!string.IsNullOrEmpty(room.Name)
                || room.Col == -1 || room.Row == -1 || room.IdProjector == -1
                || room.SeatIds.Count == 0)
                return null;
            return room;
        }

        private void LoadData(string keyword = null)
        {
            string error = "";
            DataTable dt;
            if (keyword == null || keyword == "")
            {
                dt = RoomDAO.GetAllRoom(ref error);
            }
            else
            {
                dt = RoomDAO.Search(keyword, ref error);
            }
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            dgv_cinemaRoom.DataSource = dt;
            rooms.Clear();
            foreach (DataRow row in dt.Rows)
            {
                Room room = new Room()
                {
                    Id = (int)row["MaPhong"],
                    Name = (string)row["TenPhong"],
                    IdProjector = (int)row["MaMay"],
                    Row = (int)row["SoHang"],
                    Col = (int)row["SoCot"],
                    Status = (int)row["TrangThai"],
                    TotalSeat = (int)row["TongSoGhe"],
                };

                DataTable typeChair = RoomDAO.GetTypeChairIdByRoomId(room.Id, ref error);
                foreach (DataRow r in typeChair.Rows)
                {
                    room.SeatIds.Add((int)r["MaGhe"]);
                }

                rooms.Add(room);
            }
        }

        private void Fill(int selectedRowIndex)
        {
            int roomId = (int)dgv_cinemaRoom.Rows[selectedRowIndex].Cells["MaPhong"].Value;
            Room room = rooms.FirstOrDefault(r => r.Id == roomId);
            if (room == null)
            {
                MessageBox.Show("Có lỗi xảy ra");
                return;
            }
            txb_roomId.Text = room.Id.ToString();
            txb_cinemaName.Text = room.Name;
            txb_col.Text = room.Col.ToString();
            txb_row.Text = room.Row.ToString();
            cbx_roomStatus.Text = STATUS.Status[room.Status].ToString();
            cbx_projector.Text = projectors[room.IdProjector].ToString();
        }

        private void dgv_cinemaRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgv_cinemaRoom.SelectedCells[0].RowIndex;
            if (selectedRowIndex > dgv_cinemaRoom.Rows.Count - 2)
            {
                ClearControls.ClearContent(controls);
                return;
            }
            Fill(selectedRowIndex);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string keyword = txb_search.Text;
            LoadData(keyword);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txb_roomId.Text))
            {
                ClearControls.ClearContent(controls);
                return;
            }
            if (MessageBox.Show("Bạn có muốn thêm phòng chiếu này ?", "Thêm", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }
            Room room = GetRoom();
            if (room == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            string error = "";
            int count = RoomDAO.Insert(room, ref error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            LoadData();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá phòng chiếu này ?", "Xoá", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }
            int roomId = int.TryParse(txb_roomId.Text, out int res) ? res : 0;
            if (roomId == 0)
            {
                MessageBox.Show("Có lỗi xảy ra");
                return;
            }
            string error = "";
            int count = RoomDAO.Delete(roomId, ref error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
            }
            ClearControls.ClearContent(controls);
            LoadData();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn lưu thay đổi cho phòng chiếu này ?", "Sửa", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }
            Room room = GetRoom();
            if (room == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            room.Id = int.TryParse(txb_roomId.Text, out int res) ? res : 0;
            if (room.Id == 0)
            {
                MessageBox.Show("Mã phòng chiếu không hợp lệ");
                return;
            }
            string error = "";
            int count = RoomDAO.Update(room, ref error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
            }
            LoadData();
        }

        private void CinemaRoomUC_Load(object sender, EventArgs e)
        {
            LoadData();
            if (dgv_cinemaRoom.SelectedCells.Count == 0)
                return;
            int selectedRowIndex = dgv_cinemaRoom.SelectedCells[0].RowIndex;
            if (selectedRowIndex > dgv_cinemaRoom.Rows.Count - 2)
                return;
            Fill(selectedRowIndex);
        }
    }
}