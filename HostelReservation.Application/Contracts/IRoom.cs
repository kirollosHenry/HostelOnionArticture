using HostelReservation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelReservation.Applications.Contracts
{
    public interface IRoom:IRepo<Room,int>
    {
        public List<Room> GetAllRoomInHotel(int Hotelid);
    }
}
