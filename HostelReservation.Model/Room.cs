using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelReservation.Model
{
    public class Room
    {
        public int RoomId { get; set; }

        public int RoomRates {  get; set; }

        public int RoomNumberBeds { get; set; }

        public char RoomStatus { get; set; }

        public int HotelID { get; set; }

        public Hotel? hotel { get; set; }

        public int resverationId { get; set; }

        public Reservation reservation { get; set; }
    }
}
