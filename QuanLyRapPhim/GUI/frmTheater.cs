using QuanLyRapPhim.DAO;
using QuanLyRapPhim.DTO;
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
    public partial class frmTheater : Form
    {
        private ShowTime showTime;
        private Movie movie;
        private List<TypeCustomer> typeCustomers;
        private List<Service> services;
        private List<Promotion> promotions;
        private List<Ticket> tickets;
        private Dictionary<int, int> serviceQuantity;

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

        private void LoadSeat()
        {
            DataTable boughtTicketDT = TicketDAO.GetBoughtTicket(showTime.Id, ref error);
            DataTable ticketDT = TicketDAO.GetAllTicketByShowTimeId(showTime.Id, ref error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
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
                string seat = r["ViTriGhe"].ToString().Trim();
                if (boughtTickets.Contains(seat)) continue;
                boughtTickets.Add(seat);
            }
            totalSeat = showTime.Row * showTime.Col;

            GenerateSeats(showTime.Row, showTime.Col);
            lb_ve.Text = $"{totalSeat - boughtTickets.Count}/{totalSeat}";
            txb_ticketPrice.Text = tickets[0].TotalPrice.ToString();
        }

        private void ClearContent()
        {
            totalSelectedSeat = 0;
            txt_tenKH.ResetText();
            selectedTickets.Clear();
            txt_soLuong.Text = totalSelectedSeat.ToString();
            txt_tienCanTra.ResetText();
            txt_KM.ResetText();
            txt_tongTien.ResetText();
            for (int i = 0; i < cklb_dichVu.Items.Count; i++)
            {
                cklb_dichVu.SetItemChecked(i, false);
            }
        }

        private void Init()
        {
            serviceQuantity = new Dictionary<int, int>();
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
            DataTable customerTypeDT = TypeCustomerDAO.GetAllTypeCustomer(ref error);
            DataTable serviceDT = ServiceDAO.GetAllService(ref error);
            DataTable promotionDT = PromotionDAO.GetAllPromotion(ref error);
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
            LoadSeat();
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
                    else if (selectedTickets.Contains(seat))
                    {
                        c = enableColor;
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
            txt_soLuong.Text = selectedTickets.Count.ToString();
            lb_ve.Text = $"{totalSeat - totalSelectedSeat - boughtTickets.Count}/{totalSeat}";
            btn_thanhToan.Enabled = false;
        }

        private void btn_thanhToan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tenKH.Text) || string.IsNullOrEmpty(txt_tenKH.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng hoặc chọn vé");
                return;
            }
            frm_bill b = new frm_bill(cbx_loaiKH, cbx_khuyenMai, cklb_dichVu, finalPrice, txt_tenKH.Text,
                selectedTickets, typeCustomers, promotions, services, showTime, movie);
            DialogResult res = b.ShowDialog();
            if (res == DialogResult.OK)
            {
                MessageBox.Show("Thanh toán thành công");
                ClearContent();
            }
            LoadSeat();
            btn_thanhToan.Enabled = false;
        }

        private void Calculate()
        {
            if (cklb_dichVu.CheckedItems.Count != serviceQuantity.Count)
            {
                MessageBox.Show("Vui lòng chọn số lượng sản phẩm");
                return;
            }
            double? typeCustomerPrice = typeCustomers.Where(x => x.Name == cbx_loaiKH.Text)?.FirstOrDefault()?.Price;
            double? promotionPrice = promotions.Where(x => x.Name == cbx_khuyenMai.Text)?.FirstOrDefault()?.ValueOfPromotion;
            decimal totalPriceService = 0;
            foreach (var item in cklb_dichVu.CheckedItems)
            {
                services.Where(x => x.Name == item.ToString()).ToList().ForEach(x =>
                {
                    totalPriceService += (x.Price * serviceQuantity[x.ServiceId]);
                });
            }

            decimal totalTicketPrice = decimal.Parse(txb_ticketPrice.Text) * int.Parse(txt_soLuong.Text);
            decimal totalPrice = totalPriceService + (totalTicketPrice - totalTicketPrice * (decimal)typeCustomerPrice);
            txt_tongTien.Text = Math.Round(totalPrice, 0).ToString() + " VNĐ";
            txt_KM.Text = "-" + (promotionPrice.Value * 100).ToString() + "%";
            finalPrice = Math.Round((totalPrice - totalPrice * (decimal)(promotionPrice.Value)), 0);
            txt_tienCanTra.Text = finalPrice.ToString() + " VNĐ";
            btn_thanhToan.Enabled = true;
        }

        private void btn_cal_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_chooseQuantity_Click(object sender, EventArgs e)
        {
            frm_chooseServiceQuantity chooseServiceQuantity = new frm_chooseServiceQuantity();
            int o = 0;
            foreach (KeyValuePair<int, int> k in serviceQuantity)
            {
                Label lbl = new Label() { Text = services.Find(f => f.ServiceId == k.Key)?.Name, Location = new Point(25, 25 + o) };
                NumericUpDown numericUpDown = new NumericUpDown() { Value = k.Value, Location = new Point(138, 23 + o), Tag = k.Key, Minimum = 1 };
                chooseServiceQuantity.Controls.Add(lbl);
                chooseServiceQuantity.Controls.Add(numericUpDown);
                o += 25;
            }
            Button confirm = new Button() { Text = "Xác nhận", Location = new Point(25, 25 + o) };
            confirm.Click += Confirm_Click;
            chooseServiceQuantity.Controls.Add(confirm);
            chooseServiceQuantity.ShowDialog();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            frm_chooseServiceQuantity f = (frm_chooseServiceQuantity)b.FindForm();
            foreach (Control c in f.Controls)
            {
                if (c is NumericUpDown)
                {
                    serviceQuantity[int.Parse(c.Tag.ToString())] = int.Parse((c as NumericUpDown).Value.ToString());
                }
            }
            f.Close();
        }

        private void cklb_dichVu_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                services.Where(x => x.Name == cklb_dichVu.Items[e.Index].ToString()).ToList().ForEach(x =>
                {
                    if (!serviceQuantity.ContainsKey(x.ServiceId))
                        serviceQuantity.Add(x.ServiceId, 1);
                });
            }
            else
            {
                services.Where(x => x.Name == cklb_dichVu.Items[e.Index].ToString()).ToList().ForEach(x =>
                {
                    serviceQuantity.Remove(x.ServiceId);
                });
            }
            btn_thanhToan.Enabled = false;
        }

        private void cbx_loaiKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_thanhToan.Enabled = false;
        }

        private void cbx_khuyenMai_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_thanhToan.Enabled = false;
        }
    }
}