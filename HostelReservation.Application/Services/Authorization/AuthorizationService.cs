using HostelReservation.Applications.Contracts;
using HostelReservation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelReservation.Applications.Services.Authorization
{
    public class AuthorizationService : IAuthorizationService
    {
        IAuthorizationRepo _IRepo;

        public AuthorizationService(IAuthorizationRepo AuthorizationRepo)
        {
            _IRepo = AuthorizationRepo;
        }

        public Authorizations CheckIdentity(string UserName, string PassWord)
        {
            var CheckUser = _IRepo.CheckIdentity(UserName, PassWord);
            _IRepo.Save();
            return CheckUser;
        }

        public List<Authorizations> GetAllUser()
        {
            var QueryUserList = _IRepo!.GetAllEntity().ToList();
            return QueryUserList;
        }

        public Authorizations CreateUser(Authorizations authorizationCreate)
        {
            var UserCreate = _IRepo!.CreateEntity(authorizationCreate);
            _IRepo.Save();
            return UserCreate;
        }

        public Authorizations GetUserId(int authorizationId)
        {
            if (authorizationId != 0)
                return _IRepo!.GetEntitybyId(authorizationId);
            return null!;
        }

        public Authorizations UpdateUser(Authorizations authorizationUpdate)
        {
            var QueryUpdateUser = _IRepo!.UpdateEntity(authorizationUpdate);
            _IRepo.Save();
            return QueryUpdateUser;
        }

        public Authorizations DeleteUser(int authorizationId)
        {
            if (authorizationId != 0)
            {
                var QueryDeleteUser = _IRepo!.DeleteEntity(authorizationId);
                _IRepo.Save();
                return QueryDeleteUser;
            }
            return null!;
        }
    }
}
