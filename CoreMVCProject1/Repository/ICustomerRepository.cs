using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreMVCProject1.Models;

namespace CoreMVCProject1.Repository
{
    public interface ICustomerRepository
    {      
        IEnumerable<Customer> GetCustomers();
        Customer GetCustomer(int id);
        void AddCustomer(Customer customer);

        int EditCustomer(int id, Customer customer);
    }
}
