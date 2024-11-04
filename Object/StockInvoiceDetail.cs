using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.Object
{
    internal class StockInvoiceDetail
    {
        public int StockInvoiceDetailId { get; set; }
        public int StockInvoiceId { get; set; }
        public int IngredientId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitCost { get; set; }
    }
}
