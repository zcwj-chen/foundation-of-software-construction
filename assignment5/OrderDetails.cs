using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{
    public class OrderDetails
    {
        private Item item;
        private int num;
        private decimal price;

        public Item Item { get; set; }
        public int Num { get; set; }
        public decimal Price { get; set; }

        public OrderDetails() { }
        public OrderDetails(Item item, int num)
        {
            this.item = item;
            this.num = num;
            price = item.Price * num;
        }

        public override bool Equals(object obj)
        {
            var other = obj as OrderDetails;
            if (other == null && this == null) return true;
            bool itemEqual = (Item == null && other.Item == null)
                            || Item.Equals(other.Item);
            return other != null
                && itemEqual
                && Num == other.Num
                && Price == other.Price;
        }

        public override string ToString()
        {
            return $"【商品明细】商品名：{item.Name}\t数量：{num}\t总价：{price}\n";
        }
    }
}
