using HostelReservation.Applications.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostelReservation.Model;

namespace HostelReservation.Applications.Services.Reservations
{
    public class Reservationservice(IRepo<Reservation, int> repo)
    {
        IRepo<Reservation, int> _IRepo;
        //public Reservationservice(IRepo<Reservation,int> _repo)
        //{
        //    repo = _repo;
        //}
        public Reservation CreateReservationl(Reservation reservation)
        {
            var CreatReservation = _IRepo.CreateEntity(reservation);
            _IRepo.Save();
            return CreatReservation;
        }

        public Reservation DeleteResrvation(int Id)
        {
            if (Id != 0)
            {
                var DeleteReservation = _IRepo!.DeleteEntity(Id);
                _IRepo.Save();
                return DeleteReservation;
            }
            return null!;
        }

        public List<Reservation> GetAllReservation()
        {
            var ShowReservation = _IRepo.GetAllEntity().ToList();
            return ShowReservation;
        }

        public Reservation GetReservationID(int Id)
        {
            if (Id != 0)
                return _IRepo!.GetEntitybyId(Id);
            return null!;
        }

        public Reservation UpdateReservation(Reservation reservation)
        {
            var UpdateReservation = _IRepo!.UpdateEntity(reservation);
            _IRepo.Save();
            return UpdateReservation;
        }

    }
}
