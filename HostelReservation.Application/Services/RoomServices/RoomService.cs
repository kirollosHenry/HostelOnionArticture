using HostelReservation.Applications.Contracts;
using HostelReservation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelReservation.Applications.Services.RoomServices
{
    public class RoomService : IRoomService
    {
        IRepo<Room, int>? _IRepo;

        public RoomService(IRepo<Room,int> RoomRepo)
        {
            _IRepo = RoomRepo;
        }

        public List<Room> GetAllRooms()
        {
            var QueryRoomList = _IRepo!.GetAllEntity().ToList();
            return QueryRoomList;
        }

        public Room GetRoomByID(int roomId)
        {
            if (roomId != 0)
                return _IRepo!.GetEntitybyId(roomId);
            return null!;
        }

        public Room CreateRoom(Room room)
        {
            var QueryCreateRoom = _IRepo!.CreateEntity(room);
            _IRepo.Save();
            return QueryCreateRoom;
        }

        public Room UpdateRoom(Room room)
        {
            var QueryUpdateRoom = _IRepo!.UpdateEntity(room); 
            _IRepo.Save();
            return QueryUpdateRoom;
        }

        public Room DeleteRoom(int roomId)
        {
            if (roomId != 0)
            {
                var QueryDeleteRoom = _IRepo!.DeleteEntity(roomId);
                _IRepo.Save();
                return QueryDeleteRoom;
            }
            return null!;
        }
    }
}
