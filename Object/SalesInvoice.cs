using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.Object
{
    internal class SalesInvoice
    {
        public int InvoiceId { get; set; }
        public int? CustomerId { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
