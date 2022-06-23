using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomationSystem.Entities
{
    public class CountryDal
    {
        
        public List<Country> GetAllCountry(int key)
        {
            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                return context.Countries.Where(p => p.CityId == key).ToList();
            }
        }

    }
}
