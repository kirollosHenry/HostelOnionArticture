using HostelReservation.Applications.Contracts;
using HostelReservation.Context;
using HostelReservation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelReservation.Infrastructure.Repositories.ReservationRepositary
{
    public  class ReservationRepositary:Repository<Reservation, int> ,IReservationRepo
    {
        
       HostelDbContext _HostelDbContext;
       public ReservationRepositary(HostelDbContext hostelDbContext) : base(hostelDbContext)
       {
           _HostelDbContext = hostelDbContext;
       }

        public Reservation GetCustomerReservationById(int id)
        {
            var Query = _HostelDbContext.Reservations.FirstOrDefault(s => s.CustomerID == id);
            return Query;
        }
    }
}
