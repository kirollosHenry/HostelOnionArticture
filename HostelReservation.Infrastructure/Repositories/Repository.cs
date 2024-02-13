using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using HostelReservation.Application.Contracts;
using HostelReservation.Context;


namespace HostelReservation.Infrastructure.Repositories
{
    public class Repository<T, TID> : IRepo<T, TID> where T : class
    {
        HostelDbContext? hostelDbContext { get; set; }

        public List<T> GetAllEntity()
        {
            var QueryAllEntity = hostelDbContext!.Set<T>();
            return QueryAllEntity.ToList();
        }

        public T GetEntitybyId(TID id)
        {
            var QueryIdEntity = hostelDbContext!.Set<T>().Find(id);
            return QueryIdEntity!;
        }

        public T CreateEntity(T Entity)
        {
            var QueryCreateEntity = hostelDbContext!.Set<T>().Add(Entity).Entity;
            return QueryCreateEntity;
        }

        public T UpdateEntity(T Entity)
        {
            return hostelDbContext!.Set<T>().Update(Entity).Entity;
        }

        public T DeleteEntity(TID id)
        {
            var EntityToDelete = hostelDbContext!.Set<T>().Find(id);
            if (EntityToDelete != null)
            {
                hostelDbContext.Set<T>().Remove(EntityToDelete);
                hostelDbContext.SaveChanges();
            }
            return EntityToDelete!;
        }

        public int save()
        {
            return hostelDbContext!.SaveChanges();
        }
    }
}
