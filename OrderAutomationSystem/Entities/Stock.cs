using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomationSystem.Entities
{
    public class Stock
    {
        public int StockId { get; set; }
        public string StockName { get; set; }
        public int SupplierId { get; set; }
        public int WarehousesId { get; set; }
        public int StockEntry { get; set; }
        public int StockOut { get; set; }
        public int UnitInStock { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal SalePrice { get; set; }
        public decimal TotalCost { get; set; }
    }
}
