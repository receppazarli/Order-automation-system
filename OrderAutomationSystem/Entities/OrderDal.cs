using DevExpress.Data.ODataLinq.Helpers;
using DevExpress.Data.WcfLinq.Helpers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomationSystem.Entities
{
    public class OrderDal
    {
        public List<Order> GetAll()
        {
            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                return context.Orders.ToList();
            }
        }
        public List<Order> GetAll2()
        {
            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                return context.Orders.Where(p => p.Received == false).ToList();
            }
        }

        public void Add(Order order)
        {
            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                var product = context.Stocks.FirstOrDefault(x => x.StockId == order.StockId);
                product.StockOut = product.StockOut + order.Piece;
                product.UnitInStock = product.StockEntry - product.StockOut;
                StockDal _stockDal = new StockDal();
                _stockDal.Update(product);

                var entity = context.Entry(order);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(Order order)
        {
            using (OrderAutomationSystemContext context=new OrderAutomationSystemContext())
            {
                var entity = context.Entry(order);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
       

        public void Delete(Order order)
        {
            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                order = context.Orders.FirstOrDefault(x => x.OrderId == order.OrderId);
                var product = context.Stocks.FirstOrDefault(x => x.StockId == order.StockId);
                // product.StockEntry = product.StockEntry + _order.Piece;
                product.StockOut = product.StockOut - order.Piece;
                product.UnitInStock = product.StockEntry - product.StockOut;
                StockDal _stockDal = new StockDal();
                _stockDal.Update(product);

                var entity = context.Entry(order);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public decimal? ToplamFiyat()
        {
            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                return context.Orders.Sum(p => p.TotalPrice);
            }
        }

        public int BekleyenSipariş()
        {
            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                return context.Orders.Count(p => p.Received == false);
            }
        }
       

        public int TeslimEdilenSiparişler()
        {
            using (OrderAutomationSystemContext context = new OrderAutomationSystemContext())
            {
                return context.Orders.Count(p => p.Received == true);
            }
        }
    }
}

