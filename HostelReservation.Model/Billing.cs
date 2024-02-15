using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelReservation.Model
{
    public class Billings
    {
        public int  BillingId { get; set; }

        public  double Price { get; set; }

         public double Deposit { get; set; }
        
        public  int NumberOFDays { get; set; }

        public int CustomerId { get; set; }

        public Customer Cusromer { get; set; }
    }
}
