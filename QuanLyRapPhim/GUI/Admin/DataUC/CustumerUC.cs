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

namespace QuanLyRapPhim.GUI.Admin.DataUC
{
    public partial class CustumerUC : UserControl
    {
        private string error = "";
        private List<Control> controls = new List<Control>();
        Dictionary<int, string> typeCustumers;
        public CustumerUC()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            typeCustumers = new Dictionary<int, string>();
            DataTable typeCustomer = TypeCustomerDAO.GetAllTypeCustomer(ref error);
            foreach (DataRow type in typeCustomer.Rows)
            {
                int typeId = (int)type["MaLoaiKH"];
                string typeName = type["TenLoaiKH"].ToString();
                typeCustumers.Add(typeId, typeName);
                cbx_loaiKH.Items.Add(typeName);
            }
            foreach (var c in grb_customer.Controls)
            {
                controls.Add(c as Control);
            }
        }
        private void Fill(int selectedRowIndex)
        {
            
            txb_maKH.Text = dgv_dsKH.Rows[selectedRowIndex].Cells["MaKH"].Value?.ToString();
            txb_hoTen.Text = dgv_dsKH.Rows[selectedRowIndex].Cells["Ten"].Value?.ToString();
            cbx_gioiTinh.Text = dgv_dsKH.Rows[selectedRowIndex].Cells["GioiTinh"].Value?.ToString();
            dtp_ngSinh.Text = dgv_dsKH.Rows[selectedRowIndex].Cells["NgaySinh"].Value?.ToString();
            txb_diaChi.Text = dgv_dsKH.Rows[selectedRowIndex].Cells["DiaChi"].Value?.ToString();
            txb_sdt.Text = dgv_dsKH.Rows[selectedRowIndex].Cells["SoDienThoai"].Value?.ToString();
            txb_email.Text = dgv_dsKH.Rows[selectedRowIndex].Cells["Email"].Value?.ToString();

            int typeId = Int32.Parse(dgv_dsKH.Rows[selectedRowIndex].Cells["MaLoaiKH"].Value?.ToString());
            cbx_loaiKH.Text = (string)typeCustumers[typeId];
        }
        private void GetRowChecked()
        {
            int selectedRowIndex = -1;
            try
            {
                selectedRowIndex = dgv_dsKH.SelectedCells[0].RowIndex;
            }
            catch
            {
                return;
            }
            if (selectedRowIndex > dgv_dsKH.Rows.Count - 2)
            {
                ClearControls.ClearContent(controls);
                return;
            }
            Fill(selectedRowIndex);
        }
        private Customer GetCustomer()
        {
            if (string.IsNullOrEmpty(txb_hoTen.Text)|| string.IsNullOrEmpty(txb_diaChi.Text) || string.IsNullOrEmpty(txb_sdt.Text))
                return null;
            int typeId = typeCustumers.Keys.FirstOrDefault(s => typeCustumers[s] == cbx_loaiKH.Text);
            Customer customer = new Customer()
            {
                Name = txb_hoTen.Text,
                Sex = cbx_gioiTinh.Text,
                Dob = Convert.ToDateTime(dtp_ngSinh.Text),
                Address = txb_diaChi.Text,
                PhoneNumber = txb_sdt.Text,
                Email = txb_email.Text,
                
                TypeCustomerId = typeId
            };
            return customer;
        }
        public void LoadData()
        {
            DataTable result = CustomerDAO.GetAllCustomer(ref error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            dgv_dsKH.DataSource = result;
            GetRowChecked();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txb_maKH.Text))
            {
                ClearControls.ClearContent(controls);
                return;
            }
            
            Customer customer = GetCustomer();

            if (customer == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            int result = CustomerDAO.Insert(customer, ref error);
            if (result <= 0 || !string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            MessageBox.Show("Thêm khách hàng thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
            GetRowChecked();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có thật sự muốn xóa không ?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.Cancel) return;
            int customerId = Int32.Parse(txb_maKH.Text);
            int result = CustomerDAO.Delete(customerId, ref error);
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
            if (string.IsNullOrEmpty(txb_maKH.Text))
            {
                MessageBox.Show("Lưu không thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Customer customer = GetCustomer();

            if (customer == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            customer.CustomerId = Int32.Parse(txb_maKH.Text);
            int result = CustomerDAO.Update(customer, ref error);
            if (result <= 0 || !string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            MessageBox.Show("Cập nhật khách hàng thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
            GetRowChecked();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            DataTable result = CustomerDAO.Search(txb_search.Text, ref error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            dgv_dsKH.DataSource = result;
            GetRowChecked();
        }

        private void dgv_dsKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetRowChecked();
        }
    }
}
