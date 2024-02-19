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
        public int ReservationID { get; set; }

        public DateTime ReservationCheckIn { get; set; }

        public DateTime ReservationCheckOut { get; set; }

        public int  BillingId { get; set; }

        public Billings? Billing { get; set; }

        public int RoomID { get; set; }
       
        public int CustomerID { get; set; }
        
        public Customer? Customer { get; set; }

        public   Room?  Room { get; set; }
    }
}
