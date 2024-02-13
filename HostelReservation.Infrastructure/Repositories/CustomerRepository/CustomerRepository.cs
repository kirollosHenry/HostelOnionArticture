using HostelReservation.Application.Contracts;

using HostelReservation.Context;
using HostelReservation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelReservation.Infrastructure.Repositories.CustomerRepository
{
    public class CustomerRepository:Repository<Customer,int>,ICustomer
    {
        HostelDbContext HostelDbContext;
        public CustomerRepository(HostelDbContext HostelDbContext):base(HostelDbContext)
        {
            this.HostelDbContext = HostelDbContext;
        }
        
        public Customer SerachByName(string name)
        {
            var customer = HostelDbContext.Set<Customer>().Find(name);
            if (customer == null)
            {
                Console.WriteLine("Not Found");
                return customer;
            }
            return customer;
        }
    }
}
