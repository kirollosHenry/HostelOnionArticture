using HostelReservation.Applications.Contracts;
using HostelReservation.Context;
using HostelReservation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelReservation.Infrastructure.Repositories.AuthorizationRepoistory
{
    public class AuthorizationRepoistory : Repository<Authorizations, int>, IAuthorizationRepo
    {
        HostelDbContext _HostelDbContext;
        public AuthorizationRepoistory(HostelDbContext _hostelDbContext) : base(_hostelDbContext)
        {
            this._HostelDbContext = _hostelDbContext;
        }

        public Authorizations CheckIdentity(string UserName, string PassWord)
        {
           Authorizations User = _HostelDbContext.Set<Authorizations>().FirstOrDefault(a=>a.UserName == UserName && a.Password == PassWord)!;
            if (User != null)
            {
                return User;
            }
            return User!;
        }

        public List<Authorizations> GetReseptions()
        {
            string Role = "Reseption";
            var reseption = _HostelDbContext.Set<Authorizations>().Where(a => a.Role == Role).ToList();
            return reseption;
        }

    }
}
