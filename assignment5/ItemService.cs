using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{
    public class ItemService
    {
        private List<Item> items;

        public void addItem(Item i)
        {
            if (items.Contains(i))
                throw new Exception("Item exists!");
            items.Add(i);
        }

        public void removeItem(string id)
        {
            /*Item i = items.FirstOrDefault(x => x.Id == id);
            if (i == null)
                throw new Exception("Item not found!");
            items.Remove(i);*/

            try
            {
                items.Remove(items.FirstOrDefault(i => i.Id == id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void modifyItem(Item newi)
        {
            removeItem(newi.Id);
            items.Add(newi);
        }

        public List<Item> searchItems(Func<Item, bool> condition)
        {
            return items.Where(condition).OrderBy(i => i.Price).ToList();
        }

        public void sort()
        {
            items.Sort((i1,i2) => string.Compare(i1.Id,i2.Id));
        }
    }
}
