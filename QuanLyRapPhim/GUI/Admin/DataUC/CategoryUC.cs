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
    public partial class CategoryUC : UserControl
    {
        private string error = "";
        private List<Control> controls = new List<Control>();
        public CategoryUC()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            foreach (var c in grb_category.Controls)
            {
                controls.Add(c as Control);
            }
        }

        public void LoadData()
        { 
            DataTable result = CategoryDAO.GetAllCategory(ref error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            } 
            dgv_category.DataSource = result;
            GetRowChecked();
        }
        private void Fill(int selectedRowIndex)
        {

            txb_categoryId.Text = dgv_category.Rows[selectedRowIndex].Cells["MaLoai"].Value?.ToString();
            txb_categoryName.Text = dgv_category.Rows[selectedRowIndex].Cells["TenLoai"].Value?.ToString();
        }
        private void GetRowChecked()
        {
            int selectedRowIndex = -1;
            try
            {
                selectedRowIndex = dgv_category.SelectedCells[0].RowIndex;
            }
            catch
            {
                return;
            }
            if (selectedRowIndex > dgv_category.Rows.Count - 2)
            {
                ClearControls.ClearContent(controls);
                return;
            }
            Fill(selectedRowIndex);
            Fill(selectedRowIndex);
        }
        private Category GetCategory()
        {
            if (string.IsNullOrEmpty(txb_categoryName.Text))
                return null;
            Category category = new Category()
            {
                CategoryName = txb_categoryName.Text
            };

            return category;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txb_categoryId.Text))
            {
                txb_categoryId.ResetText();
                txb_categoryName.ResetText();
                return;
            }
            Category category = GetCategory();
            if (category == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            int result = CategoryDAO.Insert(category, ref error);
            if (result <= 0 || !string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            MessageBox.Show("Thêm thể loại thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
            GetRowChecked();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có thật sự muốn xóa không ?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.Cancel) return;
            int categoryId = Int32.Parse(txb_categoryId.Text);
            int result = CategoryDAO.Delete(categoryId, ref error);
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
            if (string.IsNullOrEmpty(txb_categoryId.Text))
            {
                MessageBox.Show("Lưu không thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Category category = new Category() 
            { 
                CategoryId = Int32.Parse(txb_categoryId.Text),
                CategoryName = txb_categoryName.Text 
            };
            int result = CategoryDAO.Update(category, ref error);
            if (result <= 0 || !string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            MessageBox.Show("Cập nhật thể loại thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
            GetRowChecked();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            DataTable result = CategoryDAO.Search(txb_search.Text, ref error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            dgv_category.DataSource = result;
            GetRowChecked();
        }

        private void dgv_category_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetRowChecked();
        }
    }
}
