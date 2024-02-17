using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelReservation.Model
{
    public class Billings
    {
        public int BillingId { get; set; }

        public decimal? Price { get; set; }

        public decimal? Deposit { get; set; }

        public int? NumberOFDays { get; set; }

        public int? CustomerId { get; set; }

        public Customer Customer { get; set; }
    }
}
