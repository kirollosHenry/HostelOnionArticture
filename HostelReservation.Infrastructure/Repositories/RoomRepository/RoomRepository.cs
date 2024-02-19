using HostelReservation.Applications.Contracts;
using HostelReservation.Context;
using HostelReservation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelReservation.Infrastructure.Repositories.RoomRepository
{
    public class RoomRepository : Repository<Room, int>,IRoom
    {
        HostelDbContext _HostelDbContext;

        public RoomRepository(HostelDbContext _hostelDbContext) : base(_hostelDbContext)
        {
            _HostelDbContext = _hostelDbContext;
        }

        public List<Room> GetAllRoomInHotel(int Hotelid)
        {
            var hotel = _HostelDbContext.Set<Hotel>().Find(Hotelid);
            if (hotel != null)
            {
                var rooms = _HostelDbContext.Set<Room>().Where((r) => r.HotelID == Hotelid).ToList();
                return rooms;
            }
            else { return null; }
        }

        
    }
}
