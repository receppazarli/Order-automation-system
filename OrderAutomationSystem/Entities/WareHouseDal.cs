using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomationSystem.Entities
{
    public class WareHouseDal
    {
        public List<WareHouse> GetAll()
        {
            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                return context.WareHouses.ToList();
            }
        }

        public void Add(WareHouse wareHouse)
        {
            using (OrderAutomationSystemContext context=new OrderAutomationSystemContext())
            {
                var entity = context.Entry(wareHouse);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(WareHouse wareHouse)
        {
            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                var entity = context.Entry(wareHouse);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(WareHouse wareHouse)
        {
            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                var entity = context.Entry(wareHouse);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
