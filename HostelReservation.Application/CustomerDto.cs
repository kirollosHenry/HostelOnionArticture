using HostelReservation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelReservation.Applications
{
    public  class CustomerDto
    {

        public string Name { get; set; }

        public string? City { get; set; }

        public int Phone { get; set; }

        public DateTime ReservationCheckIn { get; set; }

        public DateTime ReservationCheckOut { get; set; }

        public decimal? Price { get; set; }

        public decimal? Deposit { get; set; }

        public int? NumberOFDays { get; set; }
    }
}
