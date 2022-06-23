using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomationSystem.Entities
{
    public class Shipper
    {
        public int ShipperId { get; set; }
        public string ShipperName { get; set; }
        public string BankName { get; set; }
        public string Iban { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
    }
}
