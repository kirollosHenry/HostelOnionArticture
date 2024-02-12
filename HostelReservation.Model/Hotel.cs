using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelReservation.Model
{
    public class Hotel
    {
        public int HotelID {  get; set; }
        public string HotelName {  get; set; }
        public string HotelPhone {  get; set; }
        public int HotelZipCode {  get; set; }
       // List <Room> Rooms {  get; set; }
    }
}
