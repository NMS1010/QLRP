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

namespace QuanLyRapPhim.GUI
{
    public partial class frm_bill : Form
    {
        private ComboBox cbx_loaiKH;
        private ComboBox cbx_khuyenMai;
        private CheckedListBox cklb_dichVu;
        private decimal finalPrice;
        private string error = "";
        private List<string> selectedTickets;
        private List<Promotion> promotions;
        private List<Service> services;
        private List<TypeCustomer> typeCustomers;
        private string customerName;
        private ShowTime showTime;
        private Movie movie;

        public frm_bill(ComboBox kh, ComboBox km, CheckedListBox dv, decimal price, string name, List<string> tickets, List<TypeCustomer> typeCustomers,
            List<Promotion> promotions, List<Service> services, ShowTime st, Movie m)
        {
            InitializeComponent();
            cbx_loaiKH = kh;
            cbx_khuyenMai = km;
            cklb_dichVu = dv;
            finalPrice = price;
            selectedTickets = tickets;
            this.typeCustomers = typeCustomers;
            this.promotions = promotions;
            this.services = services;
            customerName = name;
            showTime = st;
            movie = m;
        }

        private void frm_bill_Load(object sender, EventArgs e)
        {
            lb_filmName.Text = movie.MovieName;
            lb_time.Text = showTime.Time;
            lb_date.Text = Convert.ToDateTime(showTime.Day).ToShortDateString();
            string t = showTime.RoomName + "/";
            selectedTickets.ForEach(x => t += (x + ", "));
            t = t.Remove(t.LastIndexOf(", "));
            lb_roomSeat.Text = t;
            lb_price.Text = finalPrice + " VNĐ";
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            int? typeCustomerId = typeCustomers.Where(x => x.Name == cbx_loaiKH.Text)?.FirstOrDefault()?.TypeCustomerId;

            if (!typeCustomerId.HasValue)
            {
                MessageBox.Show("Có lỗi");
                return;
            }
            Customer user = new Customer()
            {
                Name = customerName,
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
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                return;
            }
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
            foreach (string s in selectedTickets)
            {
                DataTable ticketIdDT = TicketDAO.GetTicketIdBySeatName(s, ref error);
                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show(error);
                    return;
                }
                Ticket t = new Ticket()
                {
                    IdCustomer = customerId,
                    Id = (int)ticketIdDT.Rows[0]["MaVe"]
                };
                count = TicketDAO.UpdateStatus(t, ref error);
                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show(error);
                    return;
                }
            }
            Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}