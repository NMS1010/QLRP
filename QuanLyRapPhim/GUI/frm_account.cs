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
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapPhim
{
    public partial class frm_account : Form
    {
        private Hashtable roles;
        private List<User> users = new List<User>();
        private List<Control> controls = new List<Control>();

        public frm_account()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            roles = new Hashtable();
            string error = "";
            DataTable roleDT = RoleDAO.GetAllRole(ref error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
            }
            foreach (DataRow row in roleDT.Rows)
            {
                int roleId = (int)row[0];
                string roleName = (string)row[1];
                roles.Add(roleId, roleName);
                cklbox_role.Items.Add(roleName);
            }
            foreach (var c in grp_Account.Controls)
            {
                controls.Add(c as Control);
            }
        }

        private User GetUser()
        {
            User user = new User()
            {
                FullName = txb_TenND.Text,
                Gender = cbx_GioiTinh.Text,
                Dob = dtpicker_dob.Value.ToShortDateString(),
                Phone = txb_SDT.Text,
                CCCD = txb_CCCD.Text,
                Email = txt_Email.Text,
                UserName = txb_TenTaiKhoan.Text,
                Password = txb_MatKhau.Text,
                Salary = Decimal.TryParse(txb_Luong.Text, out decimal res) ? res : 0
            };
            foreach (var item in cklbox_role.CheckedItems)
            {
                user.RoleIds.Add(roles.Keys.OfType<int>()
                    .FirstOrDefault(s =>
                        roles[s].ToString() == item.ToString()
                    )
                );
            }
            if (!string.IsNullOrEmpty(user.FullName) || !string.IsNullOrEmpty(user.Gender) || !string.IsNullOrEmpty(user.Phone)
                || !string.IsNullOrEmpty(user.Dob) || !string.IsNullOrEmpty(user.CCCD) || !string.IsNullOrEmpty(user.Email)
                || !string.IsNullOrEmpty(user.UserName) || !string.IsNullOrEmpty(user.Password) || !string.IsNullOrEmpty(txb_Luong.Text)
                || user.RoleIds.Count == 0)
                return null;
            return user;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txb_MaND.Text))
            {
                ClearControls.ClearContent(controls);
                return;
            }
            if (MessageBox.Show("Bạn có muốn thêm tài khoản này ?", "Thêm", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }
            User user = GetUser();
            if (user == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            string error = "";
            int count = UserDAO.Insert(user, ref error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            LoadData();
        }

        private void LoadData(string keyword = null)
        {
            string error = "";
            DataTable dt;
            if (keyword == null || keyword == "")
            {
                dt = UserDAO.GetAllUser(ref error);
            }
            else
            {
                dt = UserDAO.Search(keyword, ref error);
            }
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            dgv_account.DataSource = dt;
            users.Clear();
            foreach (DataRow row in dt.Rows)
            {
                User user = new User()
                {
                    UserId = (int)row["MaND"],
                    FullName = row["TenND"].ToString(),
                    Gender = row["GioiTinh"].ToString(),
                    Dob = row["NgaySinh"].ToString(),
                    Phone = row["SDT"].ToString(),
                    CCCD = row["CCCD"].ToString(),
                    Email = row["Email"].ToString(),
                    UserName = row["TenTaiKhoan"].ToString(),
                    Password = row["MatKhau"].ToString(),
                    Salary = (decimal)row["Luong"]
                };
                DataTable roles = UserDAO.GetRoleByUserId((int)row["MaND"], ref error);
                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show(error);
                    return;
                }
                foreach (DataRow r in roles.Rows)
                {
                    user.RoleIds.Add((int)r["MaVaiTro"]);
                }
                users.Add(user);
            }
        }

        private void frm_account_Load(object sender, EventArgs e)
        {
            LoadData();
            if (dgv_account.SelectedCells.Count == 0)
                return;
            int selectedRowIndex = dgv_account.SelectedCells[0].RowIndex;
            if (selectedRowIndex > dgv_account.Rows.Count - 2)
                return;
            Fill(selectedRowIndex);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
        }

        private void Fill(int selectedRowIndex)
        {
            int userId = (int)dgv_account.Rows[selectedRowIndex].Cells["MaND"].Value;
            User user = users.FirstOrDefault(u => u.UserId == userId);
            if (user == null)
            {
                MessageBox.Show("Có lỗi xảy ra");
                return;
            }
            txb_MaND.Text = user.UserId.ToString();
            txb_CCCD.Text = user.CCCD;
            txb_SDT.Text = user.Phone;
            txb_TenND.Text = user.FullName;
            txt_Email.Text = user.Email;
            txb_MatKhau.Text = user.Password;
            txb_TenTaiKhoan.Text = user.UserName;
            cbx_GioiTinh.Text = user.Gender;
            dtpicker_dob.Text = user.Dob;
            txb_Luong.Text = user.Salary.ToString();
            for (int i = 0; i < cklbox_role.Items.Count; i++)
            {
                int roleId = roles.Keys.OfType<int>()
                    .FirstOrDefault(s =>
                        roles[s].ToString() == cklbox_role.Items[i].ToString()
                    );
                bool contain = user.RoleIds.Any(x => x == roleId);
                if (contain)
                {
                    cklbox_role.SetItemChecked(i, true);
                }
                else
                {
                    cklbox_role.SetItemChecked(i, false);
                }
            }
        }

        private void dgv_account_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgv_account.SelectedCells[0].RowIndex;
            if (selectedRowIndex > dgv_account.Rows.Count - 2)
            {
                ClearControls.ClearContent(controls);
                return;
            }
            Fill(selectedRowIndex);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn lưu thay đổi cho tài khoản này ?", "Sửa", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }
            User user = GetUser();
            if (user == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            user.UserId = int.TryParse(txb_MaND.Text, out int res) ? res : 0;
            if (user.UserId == 0)
            {
                MessageBox.Show("Mã người dùng không hợp lệ");
                return;
            }
            string error = "";
            int count = UserDAO.Update(user, ref error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
            }
            LoadData();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá tài khoản này ?", "Xoá", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }
            int userId = int.TryParse(txb_MaND.Text, out int res) ? res : 0;
            if (userId == 0)
            {
                MessageBox.Show("Có lỗi xảy ra");
                return;
            }
            string error = "";
            int count = UserDAO.Delete(userId, ref error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
            }
            ClearControls.ClearContent(controls);
            LoadData();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string keyword = txb_search.Text;
            LoadData(keyword);
        }
    }
}