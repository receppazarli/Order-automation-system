using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomationSystem.Entities
{
    public class WareHouse
    {
        public int WarehouseId { get; set; }
        public string WarehouseName { get; set; }
        public string BankName { get; set; }
        public string Iban { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
    }
}
