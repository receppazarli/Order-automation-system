using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderAutomationSystem.Entities;

namespace OrderAutomationSystem
{
    public class CityDal
    {
        public List<City> GetAll()
        {
            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                return context.Cities.ToList();
            }
        }
    }
}
