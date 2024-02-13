using HostelReservation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelReservation.Application.Contracts
{
    public interface ICustomer
    {
        Customer SerachByName(string name);
    }
}
