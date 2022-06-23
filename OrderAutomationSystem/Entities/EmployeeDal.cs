using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Utils.Extensions;

namespace OrderAutomationSystem.Entities
{
    public class EmployeeDal
    {
        public List<Employee> GetAll()
        {
            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                return context.Employees.ToList();
            }
        }

        public void Add(Employee employee)
        {
            using (OrderAutomationSystemContext context=new OrderAutomationSystemContext())
            {
                var entity = context.Entry(employee);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(Employee employee)
        {
            using (OrderAutomationSystemContext context=new OrderAutomationSystemContext())
            {
                var entity = context.Entry(employee);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Employee employee)
        {
            using (OrderAutomationSystemContext context=new OrderAutomationSystemContext())
            {
                var entity = context.Entry(employee);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
