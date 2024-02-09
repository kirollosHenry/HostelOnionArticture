using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelReservation.Model
{
    public class Reservation
    {
 
        /// <summary>
        /// here everything is ok 
        /// </summary>
        public int ReservationID { get; set; }

        public DateTime ReservationCheckIn { get; set; }

        public DateTime ReservationCheckOut { get; set; }

        public int RoomID { get; set; }
       
        public int CustomerID { get; set; }
        
        public object C { get; set; }

        public object Room { get; set; }

    }
}
