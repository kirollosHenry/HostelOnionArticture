using HostelReservation.Applications.Contracts;
using HostelReservation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelReservation.Applications.Services.CustomerService
{
    public class CustomerServices : ICustomerServices
    {
        ICustomer _repo;

        public CustomerServices(ICustomer repo) 
        {
            _repo = repo;        
        }

        public Customer CreateCustomer(Customer customer)
        {
            var Crecustomer = _repo!.CreateEntity(customer);
            _repo.Save();
            return Crecustomer;
        }

        public Customer DeleteCustomer(int customerId)
        {
            var delcustomer= _repo!.DeleteEntity(customerId);
            _repo.Save();
            return delcustomer;
        }

        

        public List<Customer> GetAllCustomer()
        {
            return _repo.GetAllEntity().ToList();
        }

        
        public Customer GetCustomerByID(int Customer)
        {
            var Scustomer=_repo.GetEntitybyId(Customer);
            return Scustomer;
        }

        public IQueryable<Customer> SerachByName(string name)
        {
            var Scustomer=_repo.SerachByName(name);
            return Scustomer;
        }

        public Customer UpdateCustomer(Customer customer)
        {
            var updcutomer=_repo!.UpdateEntity(customer);
            _repo.Save();
            return updcutomer;
        }

        
    }
}
