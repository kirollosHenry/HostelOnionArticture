using HostelReservation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelReservation.Applications.Services.RoomServices
{
    public interface IRoomService
    {
        public List<Room> GetAllRooms();

        public Room GetRoomByID(int roomId);

        public Room CreateRoom (Room room);

        public Room UpdateRoom (Room room);

        public Room DeleteRoom (int roomId);
    }
}
