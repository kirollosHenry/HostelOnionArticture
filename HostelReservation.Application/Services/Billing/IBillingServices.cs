using HostelReservation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelReservation.Applications.Services.Billing
{
    public interface IBillingServices
    {
        public List<Billings> GetAllBilling();

        public Billings GetBillingByID(int billing);

        public Billings CreateBilling(Billings billing);

        public Billings UpdateBilling(Billings billing);

        public Billings DeleteBilling(int billingId);

        Billings SerachByName(string name);

        public Billings SerachCustomerById(int id);
    }
}
