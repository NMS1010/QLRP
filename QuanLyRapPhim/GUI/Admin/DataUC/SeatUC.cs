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
    public partial class SeatUC : UserControl
    {
        private List<Control> controls = new List<Control>();
        public SeatUC()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            foreach (var c in grb_seat.Controls)
            {
                controls.Add(c as Control);
            }
           
        }
        public void LoadData()
        {
            string error = "";
            DataTable chairDT;
          
                chairDT = ChairDAO.GetAllChair(ref error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }

            dgv_seat.DataSource = chairDT;
            GetRowChecked();
        }
        private void Fill(int selectedRowIndex)
        {

            txb_SeatId.Text = dgv_seat.Rows[selectedRowIndex].Cells["MaGhe"].Value?.ToString();
            txb_type.Text = dgv_seat.Rows[selectedRowIndex].Cells["LoaiGhe"].Value?.ToString();
            txb_price.Text = dgv_seat.Rows[selectedRowIndex].Cells["GiaGhe"].Value?.ToString();
        }
        private void GetRowChecked()
        {

            int selectedRowIndex = -1;
            try
            {
                selectedRowIndex = dgv_seat.SelectedCells[0].RowIndex;
            }
            catch
            {
                return;
            }
            if (selectedRowIndex > dgv_seat.Rows.Count - 2)
            {
                ClearControls.ClearContent(controls);
                return;
            }
            Fill(selectedRowIndex);
        }
        private Chair GetChair()
        {
            Chair chair = new Chair()
            {
                Price = Decimal.TryParse(txb_price.Text, out decimal res) ? res : 0,
                Type = txb_type.Text,
            };
            if (string.IsNullOrEmpty(chair.Price.ToString()) || string.IsNullOrEmpty(chair.Type.ToString()))
                return null;
            return chair;
        }
        private void dgv_seat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetRowChecked();
        }

        

        
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txb_SeatId.Text))
            {
                MessageBox.Show("Lưu không thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Chair chair = new Chair()
            {
                ChairId = Int32.Parse(txb_SeatId.Text),
                Price = Decimal.TryParse(txb_price.Text, out decimal res) ? res : 0,
                Type = txb_type.Text,
            };
            string error = "";
            int result = ChairDAO.Update(chair, ref error);
            if (result <= 0 || !string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            MessageBox.Show("Cập nhật ghế thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
            GetRowChecked();
        }

      
    }
}
