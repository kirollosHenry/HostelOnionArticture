using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using HostelReservation.Application.Contracts;


namespace HostelReservation.Infrastructure.Repositories
{
    public class Repository<T, TID> : IRepo<T, TID> where T : class
    {
        public List<T> GetAllEntity()
        {
            throw new NotImplementedException();
        }

        public T GetEntitybyId(TID id)
        {
            throw new NotImplementedException();
        }

        public T CreateEntity(T Entity)
        {
            throw new NotImplementedException();
        }

        public T UpdateEntity(T Entity)
        {
            throw new NotImplementedException();
        }

        public T DeleteEntity(TID id)
        {
            throw new NotImplementedException();
        }

        public int save()
        {
            throw new NotImplementedException();
        }
    }
}
