using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment8_v2
{
    public class Order
    {
        private readonly List<OrderDetail> details = new List<OrderDetail>();
        [Key]
        public string OrderId { get; set; }
        [Required]
        public virtual Customer Customer { get; set; }
        [Required]
        public virtual List<OrderDetail> OrderDetails => details;
        [Required]
        public DateTime CreateTime { get; set; }

        public float TotalPrice
        {
            get => OrderDetails.Sum(d => d.ODPrice);
        }

        public override string ToString()
        {
            return $"【订单编号】{this.OrderId} 【顾客姓名】{this.Customer.CustomerName} 【创建时间】{this.CreateTime} 【订单总价】{this.TotalPrice}";
        }

        public void AddDetails(OrderDetail orderDetail)
        {
            if (OrderDetails.Contains(orderDetail))
            {
                throw new ApplicationException($"The goods ({orderDetail.Item.ItemName}) exist in order {OrderId}");
            }
            OrderDetails.Add(orderDetail);
        }
    }

    public class Customer
    {
        [Key]
        public string CustomerId { get; set; }
        [Required]
        public string CustomerName { get; set; }

    }
    public class Item
    {
        [Key]
        public string ItemId { get; set; }
        [Required]
        public string ItemName { get; set; }
        private float price;
        [Required]
        public float Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("the price must >= 0!");
                price = value;
            }
        }
    }

    public class OrderDetail
    {
        [Key]
        public string ODId { get; set; }
        [Required]
        public virtual Item Item { get; set; }
        [Required]
        public int Num { get; set; }
        public float ODPrice { get => Item.Price * Num; }

        public override string ToString()
        {
            return $"【商品名称】{Item.ItemName} 【商品数量】{Num} 【商品总价】{ODPrice}";
        }
    }
}
