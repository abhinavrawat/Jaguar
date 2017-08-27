using System;
using Eventrust.Manager.Contract;
using Eventrust.Repository.Contract;

namespace Eventrust.Manager.Implementation
{
    internal class UserManager : IUserManager
    {
        IUowRepository _uowRepository;

        public UserManager(IUowRepository uowRepository)
        {
            _uowRepository = uowRepository;
        }

        public void Get()
        {
            throw new NotImplementedException();
        }
    }
}
