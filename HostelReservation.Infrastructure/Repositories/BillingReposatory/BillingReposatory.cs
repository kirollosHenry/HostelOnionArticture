using HostelReservation.Applications.Contracts;
using HostelReservation.Context;
using HostelReservation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelReservation.Infrastructure.Repositories.BillingReposatory
{
    public class BillingReposatory: Repository<Billings, int>,IBilling
    {
        HostelDbContext HostelDbContext;
    public BillingReposatory(HostelDbContext HostelDbContext) : base(HostelDbContext)
    {
        this.HostelDbContext = HostelDbContext;
    }

        public Billings SerachCusromerBillindById(int id)
        {
            var bill= HostelDbContext.Set<Billings>().FirstOrDefault(s=>s.CustomerId == id);
            return bill;
        }

        Billings IBilling.SerachByName(string name)
        {
            var billing = HostelDbContext.Set<Billings>().Find(name);
            if (billing == null)
            {
                Console.WriteLine("Not Found");
                return billing;
            }
            return billing;
        }
    }
}
