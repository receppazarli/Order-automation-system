using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomationSystem.Entities
{
    public class StockDal
    {
        public List<Stock> GetAll()
        {
            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                return context.Stocks.ToList();
            }
        }

        // deneme için yazdım
        public decimal GetAll2(object key)
        {
            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                //string ad = dbo.Product.FirstOrDefault(p => p.ProductID == 3).ProductName;

                return context.Stocks.FirstOrDefault(p => p.StockId == (int)key).SalePrice;
            }
        }
    

        public string GetAll3(int key)
        {
            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                return context.Stocks.FirstOrDefault(p => p.StockId == (int) key).SalePrice.ToString();
            }
        }

        //look up editler için yazıcam
        public List<Stock> GetAll4()
        {
            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                return context.Stocks.ToList();
            }
        }



        public void Add(Stock stock)
        {
            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                var entity = context.Entry(stock);
                entity.State = EntityState.Added;
                context.SaveChanges();

            }
        }

        public void Update(Stock stock)
        {
            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                var entity = context.Entry(stock);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }


        public void Delete(Stock stock)
        {
            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                var entity = context.Entry(stock);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public decimal ToplamMaliyet()
        {
            using (OrderAutomationSystemContext context=new OrderAutomationSystemContext())
            {
                return context.Stocks.Sum(p => p.TotalCost);
            }
        }

        // look up editler için deneme
        //public List<Stock> GetAll5(Stock stock)
        //{
        //    using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
        //    {
        //        var entity = context.Stocks.Select(x => new
        //        {
        //            Id=x.StockId,
        //            ÜrünAdı=x.StockName
        //        });
        //        entity.ToList();
        //        context.SaveChanges();

        //    }
        //}






    }
}
