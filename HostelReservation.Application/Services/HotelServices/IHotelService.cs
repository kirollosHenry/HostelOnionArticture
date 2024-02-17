using HostelReservation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelReservation.Applications.Services.HotelServices
{
    public interface IHotelService
    {
        public List<Hotel> GetAllHotel();

        public Hotel GetHotelByID(int HotelId);

        public Hotel CreateHotel(Hotel hotel);

        public Hotel UpdateHotel(Hotel hotel);

        public Hotel DeleteHotel(int hotelId);

       
    }
}
