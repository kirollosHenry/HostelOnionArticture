using HostelReservation.Application.Contracts;
using HostelReservation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelReservation.Application.Services.Billing
{
    public class BillingServices : IBillingServices
    {
        IBilling _billrepo;
        public BillingServices(IBilling repo) 
        {
            _billrepo = repo;
        }
        public Billings CreateBilling(Billings billing)
        {
            var Billing=_billrepo.CreateEntity(billing);
            _billrepo.Save();
            return Billing;
        }

        public Billings DeleteBilling(int billingId)
        {
            var billdelete = _billrepo.DeleteEntity(billingId);
            return billdelete;
        }

        public List<Billings> GetAllBilling()
        {
            return _billrepo.GetAllEntity();
        }

        public Billings GetBillingByID(int billing)
        {
            var Bill=_billrepo.GetEntitybyId(billing);
            return Bill;
        }

        public Billings SerachByName(string name)
        {
            var bill=_billrepo.SerachByName(name);
            return bill;
        }

        public Billings UpdateBilling(Billings billing)
        {
            var billupdate= _billrepo.UpdateEntity(billing);
            _billrepo.Save();
            return billupdate;
        }
    }
}
