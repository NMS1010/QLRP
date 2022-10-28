using QuanLyRapPhim.DAO;
using QuanLyRapPhim.DTO;
using QuanLyRapPhim.Utils.FormControls;
using System;
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
    public partial class ProjectorUC : UserControl
    {
        private List<Control> controls = new List<Control>();

        public ProjectorUC()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            foreach (var c in grb_projector.Controls)
            {
                controls.Add(c as Control);
            }
        }

        public void LoadData(string keyword = null)
        {
            string error = "";
            DataTable projectorDT;
            if (keyword == null || keyword == "")
            {
                projectorDT = ProjectorDAO.GetAllProjector(ref error);
            }
            else
            {
                projectorDT = ProjectorDAO.Search(keyword, ref error);
            }
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }

            dgv_projector.DataSource = projectorDT;
            GetRowChecked();
        }

        private void Fill(int selectedRowIndex)
        {
            txb_prjectorId.Text = dgv_projector.Rows[selectedRowIndex].Cells["MaMay"].Value?.ToString().Trim();
            txb_projectorName.Text = dgv_projector.Rows[selectedRowIndex].Cells["LoaiMay"].Value?.ToString().Trim();
            txb_price.Text = dgv_projector.Rows[selectedRowIndex].Cells["Gia"].Value?.ToString().Trim();
        }

        private void GetRowChecked()
        {
            int selectedRowIndex = -1;
            try
            {
                selectedRowIndex = dgv_projector.SelectedCells[0].RowIndex;
            }
            catch
            {
                return;
            }
            if (selectedRowIndex > dgv_projector.Rows.Count - 2)
            {
                ClearControls.ClearContent(controls);
                return;
            }
            Fill(selectedRowIndex);
        }

        private void dgv_projector_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetRowChecked();
        }

        private Projector GetProjector()
        {
            Projector projector = new Projector()
            {
                Price = Decimal.TryParse(txb_price.Text, out decimal res) ? res : 0,
                Type = txb_projectorName.Text,
            };
            if (string.IsNullOrEmpty(projector.Price.ToString()) || string.IsNullOrEmpty(projector.Type.ToString()))
                return null;
            return projector;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txb_prjectorId.Text))
            {
                ClearControls.ClearContent(controls);
                return;
            }
            Projector projector = GetProjector();
            if (projector == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            string error = "";
            int result = ProjectorDAO.Insert(projector, ref error);
            if (result <= 0 || !string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            MessageBox.Show("Thêm máy chiếu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
            GetRowChecked();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            string error = "";
            dr = MessageBox.Show("Bạn có thật sự muốn xóa không ?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.Cancel) return;
            int projectorId = Int32.Parse(txb_prjectorId.Text);
            int result = ProjectorDAO.Delete(projectorId, ref error);
            if (result <= 0 || !string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            LoadData();
            GetRowChecked();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txb_prjectorId.Text))
            {
                MessageBox.Show("Lưu không thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Projector projector = new Projector()
            {
                Id = Int32.Parse(txb_prjectorId.Text),
                Price = Decimal.TryParse(txb_price.Text, out decimal res) ? res : 0,
                Type = txb_projectorName.Text,
            };
            string error = "";
            int result = ProjectorDAO.Update(projector, ref error);
            if (result <= 0 || !string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            MessageBox.Show("Cập nhật ghế thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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