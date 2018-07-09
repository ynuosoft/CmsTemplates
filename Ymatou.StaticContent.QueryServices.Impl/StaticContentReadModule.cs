using System.Configuration;
using System.Web;

using Microsoft.Practices.Unity;

using Ymatou.StaticContent.QueryServices;
using Ymatou.StaticContent.QueryServices.Impl;
using Ymatou.Unity.LifetimeManagers;

namespace Ymatou.StaticContent.Module
{
    public static class StaticContentReadModule
    {
        public static void RegisterTypes(IUnityContainer container)
        {
            InjectionConstructor injectionConstructor = new InjectionConstructor(new object[1] { (object)ConfigurationManager.ConnectionStrings["YmatouStaticContentConnectionString"].ConnectionString });
            if (null == HttpContext.Current)
                UnityContainerExtensions.RegisterType<StaticContentQueryDataContext, StaticContentQueryDataContext>(container, (LifetimeManager) new ContainerControlledLifetimeManager(), new InjectionMember[1] {(InjectionMember) injectionConstructor});
            else
                UnityContainerExtensions.RegisterType<StaticContentQueryDataContext, StaticContentQueryDataContext>(container, (LifetimeManager) new HttpContextLifetimeManager<StaticContentQueryDataContext>(), new InjectionMember[1] {(InjectionMember) injectionConstructor});
            UnityContainerExtensions.RegisterType<IStaticContentQueryService, StaticContentQueryService>(container, new InjectionMember[0]);
        }
    }
}