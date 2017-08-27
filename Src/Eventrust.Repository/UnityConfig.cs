using Eventrust.Repository.Contract;
using Eventrust.Repository.Implementation;
using Microsoft.Practices.Unity;

namespace Eventrust.Repository
{
    public class UnityConfig
    {
        public void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IUserRepository, UserRepository>();
        }
    }
}
