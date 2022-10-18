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
    public partial class ActorUC : UserControl
    {
        private List<Actor> actors = new List<Actor>();
        private List<Control> controls = new List<Control>();

        public ActorUC()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            foreach (var c in grp_actor.Controls)
            {
                controls.Add(c as Control);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txb_actorId.Text))
            {
                ClearControls.ClearContent(controls);
                return;
            }
            if (MessageBox.Show("Bạn có muốn thêm diễn viên này ?", "Thêm", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }
            Actor actor = GetActor();
            if (actor == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            string error = "";
            int count = ActorDAO.Insert(actor, ref error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            LoadData();
            GetRowChecked();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá diễn viên này ?", "Xoá", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }
            int actorId = int.TryParse(txb_actorId.Text, out int res) ? res : 0;
            if (actorId == 0)
                return;
            string error = "";
            int count = ActorDAO.Delete(actorId, ref error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
            }
            ClearControls.ClearContent(controls);
            LoadData();
            GetRowChecked();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn lưu thay đổi cho diễn viên này ?", "Sửa", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }
            Actor actor = GetActor();
            if (actor == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            actor.ActorId = int.TryParse(txb_actorId.Text, out int res) ? res : 0;
            if (actor.ActorId == 0)
            {
                MessageBox.Show("Mã diễn viên không hợp lệ");
                return;
            }
            string error = "";
            int count = ActorDAO.Update(actor, ref error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
            }
            LoadData();
            GetRowChecked();
        }

        private void GetRowChecked()
        {
            int selectedRowIndex = dgv_actor.SelectedCells[0].RowIndex;
            if (selectedRowIndex > dgv_actor.Rows.Count - 2)
            {
                ClearControls.ClearContent(controls);
                return;
            }
            Fill(selectedRowIndex);
        }

        private void dgv_actor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetRowChecked();
        }

        private void ActorUC_Load(object sender, EventArgs e)
        {
            LoadData();
            if (dgv_actor.SelectedCells.Count == 0)
                return;
            GetRowChecked();
        }

        private void LoadData(string keyword = null)
        {
            string error = "";
            DataTable dt;
            if (keyword == null)
            {
                dt = ActorDAO.GetAllActor(ref error);
            }
            else
            {
                dt = ActorDAO.Search(keyword, ref error);
            }
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            dgv_actor.DataSource = dt;
            actors.Clear();
            foreach (DataRow row in dt.Rows)
            {
                Actor actor = new Actor()
                {
                    ActorId = (int)row["MaDienVien"],
                    ActorName = (string)row["TenDienVien"],
                };
                actors.Add(actor);
            }
        }

        private void Fill(int selectedRowIndex)
        {
            int actorId = (int)dgv_actor.Rows[selectedRowIndex].Cells["MaDienVien"].Value;
            Actor actor = actors.FirstOrDefault(a => a.ActorId == actorId);
            if (actor == null)
            {
                MessageBox.Show("Có lỗi xảy ra");
                return;
            }
            txb_actorId.Text = actor.ActorId.ToString();
            txb_actorName.Text = actor.ActorName.ToString();
        }

        private Actor GetActor()
        {
            if (string.IsNullOrEmpty(txb_actorName.Text))
                return null;
            Actor actor = new Actor()
            {
                ActorName = txb_actorName.Text
            };

            return actor;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string keyword = txb_search.Text;
            LoadData(keyword);
        }
    }
}