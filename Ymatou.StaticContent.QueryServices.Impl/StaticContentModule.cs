using Microsoft.Practices.Unity;

namespace Ymatou.StaticContent.Module
{
    public static class StaticContentModule
    {
        public static void RegisterTypes(IUnityContainer container)
        {
            //StaticContentCommandModule.RegisterTypes(container);
            StaticContentReadModule.RegisterTypes(container);
        }
    }
} 