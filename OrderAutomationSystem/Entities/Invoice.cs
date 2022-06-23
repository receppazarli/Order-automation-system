using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomationSystem.Entities
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public decimal TotalInvoice { get; set; }
        public decimal TotalSalary { get; set; }
        public decimal Extra { get; set; }
        public decimal Total { get; set; }
        public string Months { get; set; }
        public string Year { get; set; }
    }

}
