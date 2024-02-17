using HostelReservation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelReservation.Applications.Services.CustomerService
{
    public interface ICustomerServices 
    {
        public List<Customer> GetAllCustomer();

        public Customer GetCustomerByID(int Customer);

        public Customer CreateCustomer(Customer customer);

        public Customer UpdateCustomer(Customer customer);

        public Customer DeleteCustomer(int customerId);

        Customer SerachByName(string name);
    }
}
