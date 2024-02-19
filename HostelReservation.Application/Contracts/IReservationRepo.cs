using HostelReservation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HostelReservation.Applications.Contracts
{
    public  interface IReservationRepo : IRepo<Reservation, int>
    {
         public Reservation GetCustomerReservationById(int id);
    }
}
