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
    public partial class TypeCustumerUC : UserControl
    {
        private string error = "";
        private List<Control> controls = new List<Control>();

        public TypeCustumerUC()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            foreach (var c in grb_customer.Controls)
            {
                controls.Add(c as Control);
            }
        }

        private void Fill(int selectedRowIndex)
        {
            txb_maLoaiKH.Text = dgv_typeCustomer.Rows[selectedRowIndex].Cells["MaLoaiKH"].Value?.ToString();
            txb_tenLoai.Text = dgv_typeCustomer.Rows[selectedRowIndex].Cells["TenLoaiKH"].Value?.ToString();
            txb_giaGiam.Text = dgv_typeCustomer.Rows[selectedRowIndex].Cells["GiaGiam"].Value?.ToString();
        }

        private void GetRowChecked()
        {
            int selectedRowIndex = -1;
            try
            {
                selectedRowIndex = dgv_typeCustomer.SelectedCells[0].RowIndex;
            }
            catch
            {
                return;
            }
            if (selectedRowIndex > dgv_typeCustomer.Rows.Count - 2)
            {
                ClearControls.ClearContent(controls);
                return;
            }
            Fill(selectedRowIndex);
        }

        private TypeCustomer GetTypeCustomer()
        {
            if (string.IsNullOrEmpty(txb_tenLoai.Text) || string.IsNullOrEmpty(txb_giaGiam.Text))
                return null;
            TypeCustomer typeCustomer = new TypeCustomer()
            {
                Name = txb_tenLoai.Text,
                Price = Math.Round(double.TryParse(txb_giaGiam.Text, out double res) ? res : 1, 2),
            };

            return typeCustomer;
        }

        public void LoadData()
        {
            DataTable result = TypeCustomerDAO.GetAllTypeCustomer(ref error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            dgv_typeCustomer.DataSource = result;
            GetRowChecked();
            lb_customerCount.Text = CustomerDAO.GetAllCustomer(ref error)?.Rows?.Count.ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txb_maLoaiKH.Text))
            {
                txb_maLoaiKH.ResetText();
                txb_tenLoai.ResetText();
                txb_giaGiam.ResetText();
                return;
            }
            TypeCustomer typeCustomer = GetTypeCustomer();
            if (typeCustomer == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            int result = TypeCustomerDAO.Insert(typeCustomer, ref error);
            if (result <= 0 || !string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            MessageBox.Show("Thêm loại KH thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
            GetRowChecked();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có thật sự muốn xóa không ?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.Cancel) return;
            int typeCustomerId = Int32.Parse(txb_maLoaiKH.Text);
            int result = TypeCustomerDAO.Delete(typeCustomerId, ref error);
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
            if (string.IsNullOrEmpty(txb_maLoaiKH.Text))
            {
                MessageBox.Show("Lưu không thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            TypeCustomer typeCustomer = new TypeCustomer()
            {
                TypeCustomerId = Int32.Parse(txb_maLoaiKH.Text),
                Name = txb_tenLoai.Text,
                Price = (double.TryParse(txb_maLoaiKH.Text, out double res) ? res : 2),
            };
            int result = TypeCustomerDAO.Update(typeCustomer, ref error);
            if (result <= 0 || !string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            MessageBox.Show("Cập nhậtloại khách hàng thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
            GetRowChecked();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            DataTable result = TypeCustomerDAO.Search(txb_search.Text, ref error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            dgv_typeCustomer.DataSource = result;
            GetRowChecked();
        }

        private void dgv_dsKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetRowChecked();
        }
    }
}