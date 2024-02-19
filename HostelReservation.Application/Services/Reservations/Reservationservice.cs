using HostelReservation.Applications.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostelReservation.Model;

namespace HostelReservation.Applications.Services.Reservations
{
    public class Reservationservice :IReservationService                               /*(IRepo<Reservation, int> repo)*/
    {
        IReservationRepo _IRepo;
        public Reservationservice(IReservationRepo _repo)
        {
            _IRepo = _repo;
        }
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

        public Reservation GetCustomerReservationById(int id)
        {
            var query= _IRepo.GetCustomerReservationById(id);
            return query;
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
