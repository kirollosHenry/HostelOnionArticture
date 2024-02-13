using HostelReservation.Context;
using HostelReservation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelReservation.Infrastructure.Repositories.HotelRepository
{
    public class HotelRepository:Repository<Hotel,int>
    {
        HostelDbContext _HostelDbContext;
        public HotelRepository(HostelDbContext hostelDbContext) : base(hostelDbContext)
        {
            _HostelDbContext = hostelDbContext;
        }


        //can add more function for Hotel here ...
    }
}
