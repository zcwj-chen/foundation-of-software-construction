using assignment5;
using System.Security.Cryptography;

namespace assignment5_test
{
    [TestClass]
    public class OrderServiceTest
    {
/*        private Customer c1 = new Customer("AA", "2022111", 20, "female");
        private Customer c2 = new Customer("BB", "2022222", 20, "male");
        private Item i1 = new Item("pen", "6787111", (decimal)5.00);
        private Item i2 = new Item("water", "6787222", (decimal)2.00);*/

        [TestMethod]
        public void addOrderTest()
        {
            OrderService os = new OrderService();
            Order o1 = new Order { OrderId = "1", TotalPrice = 100.0m };
            os.addOrder(o1);
            Assert.IsTrue(os.searchOrders(o => o.OrderId.Equals("1")).Count == 1);
        }

        [TestMethod]
        public void removeOrderTest()
        {
            OrderService os = new OrderService();
            Order o1 = new Order { OrderId = "1", TotalPrice = 100.0m, Customer = new Customer(), Details = new List<OrderDetails>() };
            Order o2 = new Order { OrderId = "2" };
            os.addOrder(o1);
            os.addOrder(o2);
            string removeId = "1";
            os.removeOrder(removeId);
            Assert.IsTrue(os.searchOrders(o => o.OrderId.Equals("1")).Count == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void removeOrderTest2()
        {
            OrderService os = new OrderService();
            os.removeOrder("0");
        }

        [TestMethod]
        public void modifyOrderTest()
        {
            OrderService os = new OrderService();
            Order o1 = new Order { OrderId = "1", TotalPrice = 100.0m };
            os.addOrder(o1);
            Order o2 = new Order { OrderId = "1", TotalPrice = 200.0m };
            os.modifyOrder(o2);
            Assert.IsTrue(os.searchOrders(o => o.TotalPrice == 200.0m).Count == 1
                && os.searchOrders(o=>o.TotalPrice == 100.0m).Count == 0);
        }

        [TestMethod]
        public void sortTest()
        {
            OrderService os = new OrderService();
            Order o1 = new Order { OrderId = "0" };
            Order o2 = new Order { OrderId = "1"};
            Order o3 = new Order { OrderId = "2"};

            os.addOrder(o2);
            os.addOrder(o1);
            os.addOrder(o3);

            os.sort();

            List<string> sortedOrderIds = os.Orders.Select(o => o.OrderId).ToList();
            CollectionAssert.AreEqual(new List<string> { "0", "1", "2" }, sortedOrderIds);
        }
    }
}