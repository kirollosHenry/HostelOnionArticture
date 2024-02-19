using HostelReservation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelReservation.Applications.Contracts
{
    public interface IBilling:IRepo<Billings,int>
    {
        Billings SerachByName(string name);
        Billings SerachCusromerBillindById(int id);
    }
}
