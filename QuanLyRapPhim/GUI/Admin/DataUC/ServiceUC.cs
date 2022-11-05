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
    public partial class ServiceUC : UserControl
    {
        private List<Control> controls = new List<Control>();

        public ServiceUC()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            foreach (var c in grb_service.Controls)
            {
                controls.Add(c as Control);
            }

        }
        public void LoadData(string keyword = null)
        {
            string error = "";
            DataTable serviceDT;
            if (keyword == null || keyword == "")
            {
                serviceDT = ServiceDAO.GetAllService(ref error);
            }
            else
            {
                serviceDT = ServiceDAO.Search(keyword, ref error);
            }
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            dgv_service.DataSource = serviceDT;
            GetRowChecked();
        }
        private void Fill(int selectedRowIndex)
        {

            txb_serviceId.Text = dgv_service.Rows[selectedRowIndex].Cells["MaDichVu"].Value?.ToString();
            txb_serviceName.Text = dgv_service.Rows[selectedRowIndex].Cells["TenDichVu"].Value?.ToString();
            txb_price.Text = dgv_service.Rows[selectedRowIndex].Cells["Gia"].Value?.ToString();
        }
        private void GetRowChecked()
        {

            int selectedRowIndex = -1;
            try
            {
                selectedRowIndex = dgv_service.SelectedCells[0].RowIndex;
            }
            catch
            {
                return;
            }
            if (selectedRowIndex > dgv_service.Rows.Count - 2)
            {
                ClearControls.ClearContent(controls);
                return;
            }
            Fill(selectedRowIndex);
        }
        private void dgv_service_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetRowChecked();
        }
     

        private Service GetService()
        {
            Service service = new Service()
            {
                Price = Decimal.TryParse(txb_price.Text, out decimal res) ? res : 0,
                Name = txb_serviceName.Text,
            };
            if (string.IsNullOrEmpty(service.Price.ToString()) || string.IsNullOrEmpty(service.Name.ToString()))
                return null;
            return service;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txb_serviceId.Text))
            {
                ClearControls.ClearContent(controls);
                return;
            }
            Service service = GetService();
            if (service == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            string error = "";
            int result = ServiceDAO.Insert(service, ref error);
            if (result <= 0 || !string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            MessageBox.Show("Thêm dịch vụ thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
            GetRowChecked();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            string error = "";
            dr = MessageBox.Show("Bạn có thật sự muốn xóa không ?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.Cancel) return;
            int serviceId = Int32.Parse(txb_serviceId.Text);
            int result = ServiceDAO.Delete(serviceId, ref error);
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
            if (string.IsNullOrEmpty(txb_serviceId.Text))
            {
                MessageBox.Show("Lưu không thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Service service = new Service()
            {
                ServiceId = Int32.Parse(txb_serviceId.Text),
                Price = Decimal.TryParse(txb_price.Text, out decimal res) ? res : 0,
                Name = txb_serviceName.Text,
            };
            string error = "";
            int result = ServiceDAO.Update(service, ref error);
            if (result <= 0 || !string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            MessageBox.Show("Cập nhật dịch vụ thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
