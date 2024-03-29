using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{
    public class Item
    {
        private string name;
        private string id;
        private decimal price;

        public Item() { }
        public Item(string name, string id, decimal price)
        {
            this.name = name;
            this.id = id;
            this.price = price;
        }

        public string Name { get; set; }
        public string Id { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"【商品】名称：{name}\t货号：{id}\t单价：{price}\n";
        }
        public override bool Equals(object obj)
        {
            var other = obj as Item;
            if (other == null && this == null) return true;
            bool nameEqual = (Name == null && other.Name == null)
                        || Name.Equals(other.Name);
            bool IdEqual = (Id == null && other.Id == null)
                        || Id.Equals(other.Id);
            return other != null 
                && nameEqual
                && IdEqual
                && Price == other.Price;
        }
    }
}
