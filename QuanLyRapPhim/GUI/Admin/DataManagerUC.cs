using QuanLyRapPhim.Admin.DataUC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapPhim.Admin
{
    public partial class DataManagerUC : UserControl
    {
        public DataManagerUC()
        {
            InitializeComponent();
        }

        private void btn_showTime_Click(object sender, EventArgs e)
        {
            ShowTimeUC showTimeUC = new ShowTimeUC();
            pnl_data.Controls.Clear();
            pnl_data.Controls.Add(showTimeUC);
        }

        private void btn_cinemaRoom_Click(object sender, EventArgs e)
        {
            CinemaRoomUC showTimeUC = new CinemaRoomUC();
            pnl_data.Controls.Clear();
            pnl_data.Controls.Add(showTimeUC);
        }

        private void btn_actor_Click(object sender, EventArgs e)
        {
            ActorUC showTimeUC = new ActorUC();
            pnl_data.Controls.Clear();
            pnl_data.Controls.Add(showTimeUC);
        }

        private void btn_category_Click(object sender, EventArgs e)
        {
            CategoryUC showTimeUC = new CategoryUC();
            pnl_data.Controls.Clear();
            pnl_data.Controls.Add(showTimeUC);
        }

        private void btn_movie_Click(object sender, EventArgs e)
        {
            MovieUC showTimeUC = new MovieUC();
            pnl_data.Controls.Clear();
            pnl_data.Controls.Add(showTimeUC);
        }

        private void btn_seat_Click(object sender, EventArgs e)
        {
            SeatUC showTimeUC = new SeatUC();
            pnl_data.Controls.Clear();
            pnl_data.Controls.Add(showTimeUC);
        }

        private void btn_projector_Click(object sender, EventArgs e)
        {
            ProjectorUC showTimeUC = new ProjectorUC();
            pnl_data.Controls.Clear();
            pnl_data.Controls.Add(showTimeUC);
        }

        private void btn_service_Click(object sender, EventArgs e)
        {
            ServiceUC showTimeUC = new ServiceUC();
            pnl_data.Controls.Clear();
            pnl_data.Controls.Add(showTimeUC);
        }

        private void btn_discount_Click(object sender, EventArgs e)
        {
            DiscountUC showTimeUC = new DiscountUC();
            pnl_data.Controls.Clear();
            pnl_data.Controls.Add(showTimeUC);
        }
    }
}