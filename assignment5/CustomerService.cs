using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{
    public class CustomerService
    {
        private List<Customer> customers;

        public void addCustomer(Customer c)
        {
            if (customers.Contains(c))
                throw new Exception("Customer exists!");
            customers.Add(c);
        }

        public void removeCustomer(string id)
        {
            /* Customer c = customers.FirstOrDefault(x => x.Id == id);
             if (c == null)
                 throw new Exception("Customer not found!");
             customers.Remove(c);*/

            try
            {
                customers.Remove(customers.FirstOrDefault(c => c.Id == id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void modifyCustomer(Customer newc)
        {
            removeCustomer(newc.Id);
            customers.Add(newc);
        }

        public List<Customer> searchCustomers(Func<Customer, bool> condition)
        {
            return customers.Where(condition).OrderBy(c=>c.Id).ToList();
        }

        public void sort()
        {
            customers.Sort((c1, c2) => string.Compare(c1.Id, c2.Id));
        }
    }
}
