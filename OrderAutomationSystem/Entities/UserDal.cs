using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomationSystem.Entities
{
    public class UserDal
    {

        public List<User> GetAll()
        {
            using (OrderAutomationSystemContext context=new OrderAutomationSystemContext())
            {
                return context.Users.ToList();
            }
        }


        public void add(User user)
        {
            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                var entity = context.Entry(user);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(User user)
        {
            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                var entity = context.Entry(user);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }


    }
}
