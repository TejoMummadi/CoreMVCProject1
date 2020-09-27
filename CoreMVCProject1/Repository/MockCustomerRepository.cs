using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreMVCProject1.Models;

namespace CoreMVCProject1.Repository
{
    public class MockCustomerRepository : ICustomerRepository
    {
        public void AddCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public int EditCustomer(int id, Customer customer)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomer(int id)
        {
            IEnumerable<Customer> customers = GetCustomers();
            return customers.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Customer> GetCustomers()
        {
          return  new List<Customer>
            {
                new Customer { Id=1, FirstName="Arun", LastName="Kumar", BirthDate=Convert.ToDateTime("22/04/1982"), MobileNo="9840654358"},
                new Customer { Id=2, FirstName="Idhaya", LastName="Arun", BirthDate=Convert.ToDateTime("28/08/1991"),MobileNo= "6382072208"},
                new Customer { Id=3, FirstName="Kayalvizhi", LastName="Arun", BirthDate=Convert.ToDateTime("17/07/2017"), MobileNo="9444421029"},
            };            
        }
    }
}
