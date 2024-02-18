using HostelReservation.Applications.Contracts;
using HostelReservation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelReservation.Applications.Services.HotelServices
{
    public class HotelServices : IHotelService
    {
        IRepo<Hotel, int>? _IRepo;
         HotelServices(IRepo<Hotel, int> Irepo)
        {
            _IRepo = Irepo;
        }
        public Hotel CreateHotel(Hotel hotel)
        {
            var CreatHotel = _IRepo.CreateEntity(hotel);
            _IRepo.Save();
            return CreatHotel;
        }

        public Hotel DeleteHotel(int hotelId)
        {
            if (hotelId != 0)
            {
                var DeleteHotel = _IRepo!.DeleteEntity(hotelId);
                _IRepo.Save();
                return DeleteHotel;
            }
            return null!;
        }

        public List<Hotel> GetAllHotel()
        {
            var ShowHotel = _IRepo.GetAllEntity().ToList();
            return ShowHotel;
        }

        public Hotel GetHotelByID(int HotelId)
        {
            if (HotelId != 0)
                return _IRepo!.GetEntitybyId(HotelId);
            return null!;
        }

        public Hotel UpdateHotel(Hotel hotel)
        {
            var UpdateHotel = _IRepo!.UpdateEntity(hotel);
            _IRepo.Save();
            return UpdateHotel;
        }
    }
}
