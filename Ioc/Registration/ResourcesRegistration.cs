using SitefinityWebApp.Domain.Product;
using Telerik.Sitefinity.Localization;

namespace SitefinityWebApp
{
    public static class ResourcesRegistration
    {
        public static void Register()
        {
            Res.RegisterResource<ProductModelResources>();
        }
    }
}