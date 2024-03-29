using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace assignment5
{
    public class Order
    {
        private Customer customer;
        private string orderId;
        private List<OrderDetails> details;
        private decimal totalPrice;

        public Order() { }
        public Order(string id, Customer customer, List<OrderDetails> details)
        {
            orderId = id;
            this.customer = customer;
            this.details = details;
            totalPrice = details.Sum(p => p.Price);
        }

        public string OrderId { get; set; }
        public Customer Customer { get; set; }
        public List<OrderDetails> Details { get; set; }
        public decimal TotalPrice { get; set; }

        public override string ToString()
        {
            return $"【订单】编号：{orderId}\t顾客编号：{customer.Id}\t订单总价：{totalPrice}\n";
        }

        public override bool Equals(object? obj)
        {
            var other = obj as Order;
            bool customerEqual = (Customer == null && other.Customer == null)
                                || Customer.Equals(other.Customer);
            bool detailsEqual = (Details == null && other.Details == null)
                                || Details.Equals(other.Details);
            return other != null
                && other.OrderId.Equals(OrderId)
                && customerEqual
                && TotalPrice == other.TotalPrice
                && detailsEqual;
        }

        /*public int CompareTo(Order o)
        {
            long id1 = long.Parse(this.orderId);
            long id2 = long.Parse(o.orderId);
            if (id1 < id2)
                return -1;
            else if (id1 > id2)
                return 1;
            else return 0;
        }*/
    }
}
