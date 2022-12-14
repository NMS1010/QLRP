using QuanLyRapPhim.DAO;
using QuanLyRapPhim.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapPhim
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string servername = txb_ServerName.Text;
            string dbName = txb_DbName.Text;
            string username = txb_username.Text;
            string password = txb_password.Text;
            if (string.IsNullOrEmpty(servername) || string.IsNullOrEmpty(dbName) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
                return;
            }
            DataProvider.DataBaseName = dbName;
            DataProvider.ServerName = servername;
            DataProvider.UserName = username;
            DataProvider.Password = password;

            string error = "";
            int res = UserDAO.Login(username, password, ref error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            if (res == 0)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
                return;
            }
            frm_menu frm_Menu = new frm_menu();
            Hide();
            frm_Menu.ShowDialog();
            Show();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}