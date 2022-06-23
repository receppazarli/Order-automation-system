using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomationSystem.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public string UserName { get; set; }
        public int StockId { get; set; }
        public int Piece { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public string OrderDate { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string DeliveryAddress { get; set; }
        public string Receiver { get; set; }
        public bool Received { get; set; }
    }
}
