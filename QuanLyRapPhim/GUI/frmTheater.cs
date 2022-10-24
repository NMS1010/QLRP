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

namespace QuanLyRapPhim
{
    public partial class frmTheater : Form
    {
        private ShowTime showTime;
        private Movie movie;
        private Color disableColor = Color.White;
        private Color enableColor = Color.Yellow;
        private Color orderedColor = Color.Red;
        private List<List<Button>> seats;
        private List<string> boughtTickets;
        private int totalSelectedSeat = 0;
        private List<string> selectedTickets;
        private int totalSeat;

        public frmTheater(ShowTime st, Movie m)
        {
            showTime = st;
            movie = m;
            InitializeComponent();
        }

        private void frmTheater_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            boughtTickets = new List<string>();
            seats = new List<List<Button>>();
            selectedTickets = new List<string>();
            DateTime t1 = Convert.ToDateTime(showTime.Time);
            lb_thongtin.Text = $"{movie.MovieName} | {showTime.RoomName}";
            lb_thoigian.Text = $"{showTime.Day} | {t1.ToShortTimeString()} - {t1.AddSeconds((double)movie.Time * 60).ToShortTimeString()}";
            string error = "";
            DataTable boughtTicketDT = TicketDAO.GetBoughtTicket(showTime.Id, ref error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            foreach (DataRow r in boughtTicketDT.Rows)
            {
                boughtTickets.Add(r["ViTriGhe"].ToString());
            }
            totalSeat = showTime.Row * showTime.Col;

            GenerateSeats(showTime.Row, showTime.Col);
        }

        private void GenerateSeats(int row, int col)
        {
            int width = pnl_seat.Width / col;
            int height = pnl_seat.Height / row;
            pnl_seat.Controls.Clear();
            for (int i = 0; i < row; i++)
            {
                List<Button> temp = new List<Button>();
                for (int j = 0; j < col; j++)
                {
                    Color c = disableColor;
                    bool enable = true;
                    string seat = $"{(char)(i + 65)}{j.ToString()}";
                    if (boughtTickets.Contains(seat))
                    {
                        c = orderedColor;
                        enable = false;
                    }
                    Button b = new Button()
                    {
                        Enabled = enable,
                        Width = width,
                        Height = height,
                        Location = new Point(j * width, i * height),
                        BackColor = c,
                        Text = seat
                    };
                    b.Click += chooseSeat_Click;
                    pnl_seat.Controls.Add(b);
                    temp.Add(b);
                }
                seats.Add(temp);
            }
        }

        private void chooseSeat_Click(object sender, EventArgs e)
        {
            Button seat = sender as Button;
            if (seat.Enabled == false)
                return;
            if (seat.BackColor == disableColor)
            {
                seat.BackColor = enableColor;
                totalSelectedSeat += 1;
                selectedTickets.Add(seat.Text);
            }
            else
            {
                seat.BackColor = disableColor;
                totalSelectedSeat -= 1;
                selectedTickets.Remove(seat.Text);
            }
            //UpdateTicketPrice();
        }
    }
}