using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomationSystem.Entities
{
    public class ShipperDal
    {
        public List<Shipper> GetAll()
        {
            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                return context.Shippers.ToList();
            }
        }

        public void Add(Shipper shipper)
        {
            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                var entity = context.Entry(shipper);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(Shipper shipper)
        {
            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                var entity = context.Entry(shipper);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Shipper shipper)
        {
            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                var entity = context.Entry(shipper);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
