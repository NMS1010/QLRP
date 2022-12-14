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
        private List<Projector> projectors = new List<Projector>();
        private List<Room> rooms = new List<Room>();
        private List<Control> controls = new List<Control>();
        private List<Chair> seats = new List<Chair>();

        public CinemaRoomUC()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            string error = "";
            DataTable projectorDT = ProjectorDAO.GetAllProjector(ref error);
            DataTable chairDT = ChairDAO.GetAllChair(ref error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
            }
            foreach (DataRow row in projectorDT.Rows)
            {
                Projector projector = new Projector()
                {
                    Id = (int)row["MaMay"],
                    Type = row["LoaiMay"].ToString(),
                    Price = (decimal)row["Gia"]
                };
                projectors.Add(projector);
                cbx_projector.Items.Add(row["LoaiMay"].ToString());
            }
            foreach (DataRow row in chairDT.Rows)
            {
                Chair c = new Chair()
                {
                    ChairId = (int)row["MaGhe"],
                    Type = row["LoaiGhe"].ToString(),
                    Price = (decimal)row["GiaGhe"]
                };
                seats.Add(c);
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
            if (cbx_projector.Items.Count > 0)
                cbx_projector.SelectedIndex = 0;
            if (cbx_roomStatus.Items.Count > 0)
                cbx_roomStatus.SelectedIndex = 0;
        }

        private Room GetRoom()
        {
            int row = int.TryParse(txb_row.Text, out int r) ? r : -1;
            int col = int.TryParse(txb_col.Text, out int c) ? c : -1;
            Room room = new Room()
            {
                Name = txb_cinemaName.Text,
                Col = col,
                Row = row,
                TotalSeat = col * row,
                Status = int.TryParse(STATUS.Status.Keys
                            .OfType<int>()
                            .FirstOrDefault(s =>
                                    STATUS.Status[s].ToString() == cbx_roomStatus.Text
                             )
                            .ToString(), out int status) ? status : -1,
                IdProjector = projectors.FirstOrDefault(x => x.Type == cbx_projector.Text).Id
            };
            room.SeatIds.Add(seats.FirstOrDefault(x => x.Type == "1").ChairId);
            if (string.IsNullOrEmpty(room.Name)
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
                //row["MaMay"] = projectors.FirstOrDefault(x => x.Id == room.IdProjector).Type;
                DataTable typeChair = RoomDAO.GetTypeChairIdByRoomId(room.Id, ref error);
                foreach (DataRow r in typeChair.Rows)
                {
                    room.SeatIds.Add((int)r["MaGhe"]);
                }

                rooms.Add(room);
            }
            dgv_cinemaRoom.DataSource = dt;
            //foreach (DataGridViewRow r in dgv_cinemaRoom.Rows)
            //{
            //    r.Cells["MayChieu"].Value = projectors.FirstOrDefault(x => x.Id == (int)r.Cells["MayChieu"].Value).Type;
            //}
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
            txb_roomId.Text = room.Id.ToString().Trim();
            txb_cinemaName.Text = room.Name;
            txb_col.Text = room.Col.ToString().Trim();
            txb_row.Text = room.Row.ToString().Trim();
            cbx_roomStatus.Text = STATUS.Status[room.Status].ToString().Trim();
            cbx_projector.Text = projectors.FirstOrDefault(x => x.Id == room.IdProjector).Type;
        }

        private void GetRowChecked()
        {
            int selectedRowIndex = -1;
            try
            {
                selectedRowIndex = dgv_cinemaRoom.SelectedCells[0].RowIndex;
            }
            catch
            {
                return;
            }
            if (selectedRowIndex > dgv_cinemaRoom.Rows.Count - 2)
            {
                ClearControls.ClearContent(controls);
                return;
            }
            Fill(selectedRowIndex);
        }

        private void dgv_cinemaRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetRowChecked();
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
            GetRowChecked();
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
            GetRowChecked();
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
            GetRowChecked();
        }

        private void CinemaRoomUC_Load(object sender, EventArgs e)
        {
            LoadData();
            if (dgv_cinemaRoom.SelectedCells.Count == 0)
                return;
            GetRowChecked();
        }
    }
}