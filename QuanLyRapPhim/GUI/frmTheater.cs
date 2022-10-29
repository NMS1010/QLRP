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
        private List<TypeCustomer> typeCustomers;
        private List<Service> services;
        private List<Promotion> promotions;
        private List<Ticket> tickets;

        private Color disableColor = Color.White;
        private Color enableColor = Color.Yellow;
        private Color orderedColor = Color.Red;

        private List<List<Button>> seats;
        private List<string> boughtTickets;
        private int totalSelectedSeat = 0;
        private List<string> selectedTickets;
        private int totalSeat;
        private string error = "";
        private decimal finalPrice = 0;

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
            typeCustomers = new List<TypeCustomer>();
            services = new List<Service>();
            promotions = new List<Promotion>();
            tickets = new List<Ticket>();
            boughtTickets = new List<string>();
            seats = new List<List<Button>>();
            selectedTickets = new List<string>();
            DateTime t1 = Convert.ToDateTime(showTime.Time);
            lb_thongtin.Text = $"Tên phim: {movie.MovieName} | Phòng chiếu: {showTime.RoomName} | Định dạng: {showTime.ProjectorName}";
            lb_thoigian.Text = $"{Convert.ToDateTime(showTime.Day).ToShortDateString()}|{t1.ToShortTimeString()} - {t1.AddSeconds((double)movie.Time * 60).ToShortTimeString()}";
            DataTable boughtTicketDT = TicketDAO.GetBoughtTicket(showTime.Id, ref error);
            DataTable customerTypeDT = TypeCustomerDAO.GetAllTypeCustomer(ref error);
            DataTable serviceDT = ServiceDAO.GetAllService(ref error);
            DataTable promotionDT = PromotionDAO.GetAllPromotion(ref error);
            DataTable ticketDT = TicketDAO.GetAllTicketByShowTimeId(showTime.Id, ref error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            foreach (DataRow r in customerTypeDT.Rows)
            {
                TypeCustomer typeCustomer = new TypeCustomer()
                {
                    TypeCustomerId = (int)r["MaLoaiKH"],
                    Name = r["TenLoaiKH"].ToString().Trim(),
                    Price = (double)r["GiamGia"]
                };
                typeCustomers.Add(typeCustomer);
                cbx_loaiKH.Items.Add(typeCustomer.Name);
            }
            if (cbx_loaiKH.Items.Count > 0)
                cbx_loaiKH.SelectedIndex = 0;
            foreach (DataRow r in serviceDT.Rows)
            {
                Service service = new Service()
                {
                    ServiceId = (int)r["MaDichVu"],
                    Name = r["TenDichVu"].ToString().Trim(),
                    Price = (decimal)r["Gia"]
                };
                services.Add(service);
                cklb_dichVu.Items.Add(service.Name);
            }
            if (cklb_dichVu.Items.Count > 0)
                cklb_dichVu.SelectedIndex = 0;
            foreach (DataRow r in promotionDT.Rows)
            {
                Promotion promotion = new Promotion()
                {
                    PromotionId = (int)r["MaKM"],
                    ValueOfPromotion = (double)r["GiaTriKM"],
                    Name = r["TenKM"].ToString().Trim()
                };
                promotions.Add(promotion);
                cbx_khuyenMai.Items.Add(promotion.Name);
            }
            if (cbx_khuyenMai.Items.Count > 0)
                cbx_khuyenMai.SelectedIndex = 0;
            foreach (DataRow r in ticketDT.Rows)
            {
                Ticket ticket = new Ticket()
                {
                    Id = (int)r["MaVe"],
                    Seat = r["ViTriGhe"].ToString().Trim(),
                    TotalPrice = (decimal)r["TongGia"]
                };
                tickets.Add(ticket);
            }
            foreach (DataRow r in boughtTicketDT.Rows)
            {
                boughtTickets.Add(r["ViTriGhe"].ToString());
            }
            totalSeat = showTime.Row * showTime.Col;

            GenerateSeats(showTime.Row, showTime.Col);
            lb_ve.Text = $"{totalSeat - boughtTickets.Count}/{totalSeat}";
            txb_ticketPrice.Text = tickets[0].TotalPrice.ToString();
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
            txt_soLuong.Text = selectedTickets.Count.ToString();
            lb_ve.Text = $"{totalSeat - totalSelectedSeat - boughtTickets.Count}/{totalSeat}";
        }

        private void btn_thanhToan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tenKH.Text))
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng");
                return;
            }
            int? typeCustomerId = typeCustomers.Where(x => x.Name == cbx_loaiKH.Text)?.FirstOrDefault()?.TypeCustomerId;

            if (!typeCustomerId.HasValue)
            {
                MessageBox.Show("Có lỗi");
                return;
            }
            Customer user = new Customer()
            {
                Name = txt_tenKH.Text,
                TypeCustomerId = typeCustomerId.Value,
                Address = "null",
                Dob = "2000-01-01",
                Email = "null",
                PhoneNumber = "null",
                Sex = "null"
            };

            int count = CustomerDAO.Insert(user, ref error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            int? promotionId = promotions.Where(x => x.Name == cbx_khuyenMai.Text)?.FirstOrDefault()?.PromotionId;
            if (!promotionId.HasValue)
            {
                MessageBox.Show("Có lỗi");
                return;
            }
            DataTable customerDT = CustomerDAO.GetAllCustomer(ref error);
            int customerId = (int)customerDT.Rows[customerDT.Rows.Count - 1]["MaKH"];
            foreach (var item in cklb_dichVu.CheckedItems)
            {
                services.Where(x => x.Name == item.ToString()).ToList().ForEach(x =>
                {
                    count = CustomerDAO.InsertCustomerService(customerId, x.ServiceId, ref error);
                    if (!string.IsNullOrEmpty(error))
                    {
                        MessageBox.Show(error);
                        return;
                    }
                });
            }
            Bill bill = new Bill()
            {
                CustomerId = customerId,
                PromotionId = promotionId.Value,
                SumCost = finalPrice,
                InvoiceDate = DateTime.Now.ToShortDateString(),
                InvoiceTime = DateTime.Now.ToShortTimeString(),
            };

            count = BillDAO.Insert(bill, ref error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
            MessageBox.Show("Thanh toán thành công");
        }

        private void btn_cal_Click(object sender, EventArgs e)
        {
            double? typeCustomerPrice = typeCustomers.Where(x => x.Name == cbx_loaiKH.Text)?.FirstOrDefault()?.Price;
            double? promotionPrice = promotions.Where(x => x.Name == cbx_khuyenMai.Text)?.FirstOrDefault()?.ValueOfPromotion;
            decimal totalPriceService = 0;
            foreach (var item in cklb_dichVu.CheckedItems)
            {
                services.Where(x => x.Name == item.ToString()).ToList().ForEach(x =>
                {
                    totalPriceService += x.Price;
                });
            }

            decimal totalTicketPrice = decimal.Parse(txb_ticketPrice.Text) * int.Parse(txt_soLuong.Text);
            decimal totalPrice = totalPriceService + (totalTicketPrice - totalTicketPrice * (decimal)typeCustomerPrice);
            txt_tongTien.Text = Math.Round(totalPrice, 0).ToString() + " VNĐ";
            txt_KM.Text = "-" + (promotionPrice.Value * 100).ToString() + "%";
            finalPrice = Math.Round((totalPrice - totalPrice * (decimal)(promotionPrice.Value)), 0);
            txt_tienCanTra.Text = finalPrice.ToString() + " VNĐ";
        }
    }
}