using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomationSystem.Entities
{
    public class CustomerDal
    {
        public List<Customer> GetAll()
        {
            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                return context.Customers.ToList();
            }
        }

        public void Add(Customer customer)
        {
            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                var entity = context.Entry(customer);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(Customer customer)
        {
            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                var entity = context.Entry(customer);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Customer customer)
        {
            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                var entity = context.Entry(customer);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public int ToplamSayıListeleme()
        {
            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                return context.Customers.Count();
            }
        }
    }
}
