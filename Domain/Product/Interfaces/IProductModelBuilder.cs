using Telerik.Sitefinity.DynamicModules.Model;

namespace SitefinityWebApp.Domain.Product
{
    public interface IProductModelBuilder
    {
        ProductModel Build(DynamicContent dynamicContent);
    }
}
