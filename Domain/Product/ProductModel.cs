using System.Collections.Generic;
using Telerik.Sitefinity.Localization;

namespace SitefinityWebApp.Domain.Product
{
    public class ProductModel
    {
        public string Title { get; set; }
        public decimal? Price { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        public static Dictionary<string, string> GetLabels()
        {
            return new Dictionary<string, string>
                        {
                { "Title", Res.Get<ProductModelResources>().ProductsTitle },
                            { "Description", Res.Get<ProductModelResources>().ProductsDescription },
                            { "Price", Res.Get<ProductModelResources>().ProductsPrice },
                            { "ImageURL", Res.Get<ProductModelResources>().ProductsImageURL }
            };
        }
    }
}