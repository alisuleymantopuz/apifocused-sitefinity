using System.Linq;
using Telerik.Sitefinity.DynamicModules.Model;
using Telerik.Sitefinity.Model;
using Telerik.Sitefinity.RelatedData;

namespace SitefinityWebApp.Domain.Product
{
    public class ProductModelBuilder : IProductModelBuilder
    {
        public ProductModel Build(DynamicContent dynamicContent)
        {
            var model = new ProductModel();

            if (dynamicContent != null)
            {
                model.Title = dynamicContent.GetString("Title");
                model.Description = dynamicContent.GetString("Description");
                model.Price = dynamicContent.GetValue<decimal?>("Price");
                model.ImageUrl = dynamicContent.GetRelatedItems<Telerik.Sitefinity.Libraries.Model.Image>("Image").FirstOrDefault()?.MediaUrl;
            }

            return model;
        }
    }
}
