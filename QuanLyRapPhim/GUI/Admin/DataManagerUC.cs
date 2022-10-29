using QuanLyRapPhim.Admin.DataUC;
using QuanLyRapPhim.DAO;
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
            ShowTimeUC showTimeUC = new ShowTimeUC();
            pnl_data.Controls.Clear();
            pnl_data.Controls.Add(showTimeUC);
        }

        private void btn_showTime_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnScreenTypeUC.Height;
            SidePanel.Top = btnScreenTypeUC.Top;
            ShowTimeUC showTimeUC = new ShowTimeUC();
            pnl_data.Controls.Clear();
            pnl_data.Controls.Add(showTimeUC);
        }

        private void btn_cinemaRoom_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_cinemaRoom.Height;
            SidePanel.Top = btn_cinemaRoom.Top;
            CinemaRoomUC showTimeUC = new CinemaRoomUC();
            pnl_data.Controls.Clear();
            pnl_data.Controls.Add(showTimeUC);
        }

        private void btn_actor_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_actor.Height;
            SidePanel.Top = btn_actor.Top;
            ActorUC showTimeUC = new ActorUC();
            pnl_data.Controls.Clear();
            pnl_data.Controls.Add(showTimeUC);
        }

        private void btn_category_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_category.Height;
            SidePanel.Top = btn_category.Top;
            CategoryUC categoryUC = new CategoryUC();
            pnl_data.Controls.Clear();
            pnl_data.Controls.Add(categoryUC);

            // load data to datagridview
            categoryUC.LoadData();
        }

        private void btn_movie_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_movie.Height;
            SidePanel.Top = btn_movie.Top;
            MovieUC movieUC = new MovieUC();
            pnl_data.Controls.Clear();
            pnl_data.Controls.Add(movieUC);
            movieUC.LoadData();


        }

        private void btn_seat_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_seat.Height;
            SidePanel.Top = btn_seat.Top;
            SeatUC seatUc = new SeatUC();
            pnl_data.Controls.Clear();
            pnl_data.Controls.Add(seatUc);
            seatUc.LoadData();
        }

        private void btn_projector_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_projector.Height;
            SidePanel.Top = btn_projector.Top;
            ProjectorUC projectorUc = new ProjectorUC();
            pnl_data.Controls.Clear();
            pnl_data.Controls.Add(projectorUc);
            projectorUc.LoadData();
        }

        private void btn_service_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_service.Height;
            SidePanel.Top = btn_service.Top;
            ServiceUC serviceUc = new ServiceUC();
            pnl_data.Controls.Clear();
            pnl_data.Controls.Add(serviceUc);
            serviceUc.LoadData();
        }

        private void btn_discount_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_discount.Height;
            SidePanel.Top = btn_discount.Top;
            DiscountUC discountUC = new DiscountUC();
            pnl_data.Controls.Clear();
            pnl_data.Controls.Add(discountUC);

            discountUC.LoadData();
        }

       
    }
}