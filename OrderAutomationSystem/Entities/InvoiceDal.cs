using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomationSystem.Entities
{
    public class InvoiceDal
    {
        public List<Invoice> GetAll()
        {
            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                return context.Invoices.ToList();
            }
        }

        public void Add(Invoice invoice)
        {
            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                var entity = context.Entry(invoice);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(Invoice invoice)
        {
            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                var entity = context.Entry(invoice);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Invoice invoice)
        {
            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                var entity = context.Entry(invoice);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public decimal Ödemeler()
        {
            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                return context.Invoices.Sum(p => p.Total);
            }
        }

        public List<Invoice> FaturaListe()
        {
            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                return context.Invoices.OrderByDescending(p => p.InvoiceId).Take(5).ToList();
            }
        }

        //public List<Invoice> FaturaListe2()
        //{
        //    using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
        //    {return context.Invoices.
        //    }
        //}
    }
}
