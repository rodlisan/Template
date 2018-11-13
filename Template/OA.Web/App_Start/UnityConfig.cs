using OA.Core.Repositories;
using OA.DataAccess.Repositories;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace OA.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            container.RegisterType<IUserRepository, UserRepository>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}