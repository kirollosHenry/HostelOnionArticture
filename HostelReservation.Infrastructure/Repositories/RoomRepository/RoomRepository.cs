using HostelReservation.Context;
using HostelReservation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelReservation.Infrastructure.Repositories.RoomRepository
{
    public class RoomRepository : Repository<Room, int>
    {
        HostelDbContext _HostelDbContext;

        public RoomRepository(HostelDbContext _hostelDbContext) : base(_hostelDbContext)
        {
            _HostelDbContext = _hostelDbContext;
        }
    }
}
