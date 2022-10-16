using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DTO
{
    public class Customer
    {

        public int CustomerId { get; set; }
        public string Name { get; set; }
	    public string Sex { get; set; }
        public DateTime Dob { get; set; }
        public string Address { get; set; }
	    public string PhoneNumber { get; set; }
        public int TypeCustomerId { get; set; }
        public string Email { get; set; }

        public List<int> ServiceIds { get; set; }
    }
}