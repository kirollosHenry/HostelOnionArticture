using HostelReservation.Applications.Contracts;
using HostelReservation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelReservation.Applications.Services.Reservations
{
    public  interface IReservationService
    {
        public Reservation CreateReservationl(Reservation reservation);
        

        public Reservation DeleteResrvation(int Id);
        

        public List<Reservation> GetAllReservation();
        

        public Reservation GetReservationID(int Id);
        

        public Reservation UpdateReservation(Reservation reservation);
        
    }
}
