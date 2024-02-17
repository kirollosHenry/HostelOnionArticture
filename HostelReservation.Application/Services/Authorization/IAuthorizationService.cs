using HostelReservation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelReservation.Applications.Services.Authorization
{
    public  interface IAuthorizationService
    {
        public List<Authorizations> GetAllUser();

        public Authorizations GetUserId(int authorizationId);

        public Authorizations CreateUser(Authorizations authorizationCreate);

        public Authorizations UpdateUser(Authorizations authorizationUpdate);

        public Authorizations DeleteUser(int authorizationId);

        public bool CheckIdentity(Authorizations authorization );

    }
}
