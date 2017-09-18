using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;

namespace MS.Experiences.Web
{
    public static class UnityMvcConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}