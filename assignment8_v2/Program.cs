using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Data.Entity;
using System.Linq;
using Google.Protobuf.Reflection;

namespace assignment8_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //添加订单
            using (var context = new OrderContext())
            {
                var order = new Order { OrderId = "o001", CreateTime = DateTime.Now};
                var customer = new Customer { CustomerId = "c001", CustomerName = "AA" };
                var exist = context.Customers.SingleOrDefault(c => c.CustomerId == customer.CustomerId);
                if (exist == null)
                    order.Customer = customer;
                var item1 = new Item { ItemId = "i001", ItemName = "egg", Price = 1.50f };
                var item2 = new Item { ItemId = "i002", ItemName = "milk", Price = 2.50f };
                var od1 = new OrderDetail() { ODId = "od1", Item = item1, Num = 10};
                var od2 = new OrderDetail() { ODId = "od2", Item = item2, Num = 4 };
                order.AddDetails(od1);
                order.AddDetails(od2);
                context.Orders.Add(order);
                context.SaveChanges();
                Console.WriteLine("添加订单：" + order.OrderId);
            }
            using (var context = new OrderContext())
            {
                var order = new Order { OrderId = "o002", CreateTime = DateTime.Now };
                order.Customer = new Customer { CustomerId = "c002", CustomerName = "BB" };
                var item1 = new Item { ItemId = "i003", ItemName = "water", Price = 2.00f };
                var item2 = new Item { ItemId = "i004", ItemName = "orange", Price = 5.00f };
                var od1 = new OrderDetail() { ODId = "od3", Item = item1, Num = 12 };
                var od2 = new OrderDetail() { ODId = "od4", Item = item2, Num = 8 };
                order.AddDetails(od1);
                order.AddDetails(od2);
                context.Orders.Add(order);
                context.SaveChanges();
                Console.WriteLine("添加订单：" + order.OrderId);
            }

            //根据ID查找订单
            using (var context = new OrderContext())
            {
                var order = context.Orders.Include("OrderDetails").Include("Customer")
                    .SingleOrDefault(o => o.OrderId == "o001");
                if (order != null) { Console.WriteLine($"编号o001的订单: " + order.ToString()); }
            }

            //根据总价查找订单
            /*using (var context = new OrderContext())
            {
                var orders = context.Orders.Include("OrderDetails").Include("Customer")
                                .Where(o => o.TotalPrice >= 50.00f)
                                .OrderBy(o => o.OrderId);
                foreach (var order in orders)
                {
                    Console.WriteLine("总价超过50的订单：\n" + order.ToString());
                }
            }*/

            //修改订单
            using (var context = new OrderContext())
            {
                var order = context.Orders.Include("OrderDetails").Include("Customer").FirstOrDefault(o => o.OrderId == "o002");
                if (order != null)
                {
                    order.Customer.CustomerName = "CC";
                }
                context.SaveChanges();
            }

            //删除订单
            using (var context = new OrderContext())
            {
                var order = context.Orders.Include("OrderDetails").Include("Customer").FirstOrDefault(o => o.OrderId == "o002");
                if (order != null) context.Orders.Remove(order);
                context.SaveChanges();
            }
        }
    }
}