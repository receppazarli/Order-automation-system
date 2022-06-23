using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomationSystem.Entities
{
    public class SupplierDal
    {
        public List<Supplier> GetAll()
        {
            using (OrderAutomationSystemContext context=new OrderAutomationSystemContext())
            {
                return context.Suppliers.ToList();
            }
        }

        public void Add(Supplier supplier)
        {
            using (OrderAutomationSystemContext context=new OrderAutomationSystemContext())
            {
                var entity = context.Entry(supplier);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(Supplier supplier)
        {
            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                var entity = context.Entry(supplier);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Supplier supplier)
        {
            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                var entity = context.Entry(supplier);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }


    }
}
