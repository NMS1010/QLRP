using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DTO
{
	public class Bill
	{
		public int BillId { get; set; }
		public decimal SumCost { get; set; }
		public DateTime InvoiceDate { get; set; }
		public DateTime InvoiceTime { get; set; }
		public int CustomerId { get; set; }
		public int PromotionId { get; set; }
	}
}