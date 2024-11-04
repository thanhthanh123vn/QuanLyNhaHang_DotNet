using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.Object
{
    internal class StockInvoice
    {
        public int StockInvoiceId { get; set; }
        public string SupplierName { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalCost { get; set; }
    }
}
