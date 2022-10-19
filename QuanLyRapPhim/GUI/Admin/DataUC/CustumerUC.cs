using QuanLyRapPhim.DAO;
using QuanLyRapPhim.DTO;
using System;
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
        public CustumerUC()
        {
            InitializeComponent();
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
        }

        private void dgv_dsKH_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txb_maKH.Text = dgv_dsKH.Rows[e.RowIndex].Cells[0].Value.ToString();
            txb_hoTen.Text = dgv_dsKH.Rows[e.RowIndex].Cells[1].Value.ToString();
            txb_gioiTinh.Text = dgv_dsKH.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtp_ngSinh.Text = dgv_dsKH.Rows[e.RowIndex].Cells[3].Value.ToString();
            txb_diaChi.Text = dgv_dsKH.Rows[e.RowIndex].Cells[4].Value.ToString();
            txb_sdt.Text = dgv_dsKH.Rows[e.RowIndex].Cells[5].Value.ToString();
            txb_loaiKH.Text = dgv_dsKH.Rows[e.RowIndex].Cells[6].Value.ToString();
            txb_email.Text = dgv_dsKH.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txb_maKH.Text))
            {
                txb_maKH.ResetText();
                txb_hoTen.ResetText();
                txb_gioiTinh.ResetText();
                txb_diaChi.ResetText();
                txb_sdt.ResetText();
                txb_email.ResetText();
                txb_loaiKH.ResetText();

                return;
            }
            Customer customer = new Customer()
            {
                Name = txb_hoTen.Text,
                Sex = txb_gioiTinh.Text,
                Dob = Convert.ToDateTime(dtp_ngSinh.Text),
                Address = txb_diaChi.Text,
                PhoneNumber = txb_sdt.Text,
                TypeCustomerId = Int32.Parse(txb_loaiKH.Text),
                Email = txb_email.Text
            };
            int result = CustomerDAO.Insert(customer, ref error);
            if (result <= 0 || !string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            MessageBox.Show("Thêm khách hàng thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
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
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txb_maKH.Text))
            {
                MessageBox.Show("Lưu không thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Customer customer = new Customer()
            {
                CustomerId = Int32.Parse(txb_maKH.Text),
                Name = txb_hoTen.Text,
                Sex = txb_gioiTinh.Text,
                Dob = Convert.ToDateTime(dtp_ngSinh.Text),
                Address = txb_diaChi.Text,
                PhoneNumber = txb_sdt.Text,
                TypeCustomerId = Int32.Parse(txb_loaiKH.Text),
                Email = txb_email.Text
            };
            int result = CustomerDAO.Update(customer, ref error);
            if (result <= 0 || !string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            MessageBox.Show("Cập nhật khuyến mãi thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
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
        }
    }
}
