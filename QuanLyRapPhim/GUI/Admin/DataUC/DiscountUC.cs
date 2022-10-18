using QuanLyRapPhim.DAO;
using QuanLyRapPhim.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapPhim.Admin.DataUC
{
    public partial class DiscountUC : UserControl
    {
        private string error = "";
        public DiscountUC()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            DataTable result = PromotionDAO.GetAllPromotion(ref error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            dgv_discount.DataSource = result;
        }
        private void dgv_discount_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txb_discountId.Text = dgv_discount.Rows[e.RowIndex].Cells[0].Value.ToString();
            txb_codeName.Text = dgv_discount.Rows[e.RowIndex].Cells[1].Value.ToString();
            txb_price.Text = dgv_discount.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txb_discountId.Text))
            {
                txb_discountId.ResetText();
                txb_codeName.ResetText();
                txb_price.ResetText();
                return;
            }
            Promotion promotion = new Promotion()
            {
                Name = txb_codeName.Text,
                ValueOfPromotion = (float)Math.Round(float.Parse(txb_price.Text), 2),
            };
            int result = PromotionDAO.Insert(promotion, ref error);
            if (result <= 0 || !string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            MessageBox.Show("Thêm khuyến mãi thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có thật sự muốn xóa không ?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.Cancel) return;
            int promotionId = Int32.Parse(txb_discountId.Text);
            int result = PromotionDAO.Delete(promotionId, ref error);
            if (result <= 0 || !string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            LoadData();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txb_discountId.Text))
            {
                MessageBox.Show("Lưu không thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Promotion promotion = new Promotion()
            {
                PromotionId = Int32.Parse(txb_discountId.Text),
                Name = txb_codeName.Text,
                ValueOfPromotion = Convert.ToSingle(txb_price.Text)
            };
            int result = PromotionDAO.Update(promotion, ref error);
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
            DataTable result = PromotionDAO.Search(txb_search.Text, ref error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            dgv_discount.DataSource = result;
        }
    }
}
