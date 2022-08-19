using MixueShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MixueShop.Logic
{
    public class OrderManage
    {
        MixueProjectContext db=new MixueProjectContext();
        public List<Order> getAllOrders()
        {
            return db.Orders.ToList();

        }
        public List<Order> getAllOrders(int Offset, int Count, string from, string to)
        {
            if(from!=null && to != null)
            {
                DateTime fromDate = Convert.ToDateTime(from);
                DateTime toDate = Convert.ToDateTime(to);
                return db.Orders.Where(o => o.OrderDate >= fromDate && o.OrderDate <= toDate).Skip(Offset - 1).Take(Count).ToList();
            }
            else
            {
                return db.Orders.Skip(Offset - 1).Take(Count).ToList();
            }
            

        }
        public int getNumberOrder(string from, string to)
        {
            if (from != null && to != null)
            {
                DateTime fromDate = Convert.ToDateTime(from);
                DateTime toDate = Convert.ToDateTime(to);
                return db.Orders.Where(o => o.OrderDate >= fromDate && o.OrderDate <= toDate).Count();
            }
            else
            {
                return db.Orders.Count();
            }
        }
    }
}
