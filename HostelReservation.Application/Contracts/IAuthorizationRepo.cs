using HostelReservation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelReservation.Applications.Contracts
{
    public interface IAuthorizationRepo  : IRepo<Authorizations, int> 
    {
        public bool CheckIdentity();
    }
}
