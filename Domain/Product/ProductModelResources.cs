using Telerik.Sitefinity.Localization;

namespace SitefinityWebApp.Domain.Product
{
    [ObjectInfo(typeof(ProductModelResources), Name = "ProductsResources", ResourceClassId = "ProductsResources", Title = "ProductsResourcesTitle", Description = "ProductsResourcesDescription")]
    public class ProductModelResources : Resource
    {

        [ResourceEntry("ProductsTitle",

            Value = "Title",

            Description = "phrase: Product Title",

            LastModified = "2019/11/23")]

        public string ProductsTitle
        {

            get
            {

                return this["ProductsTitle"];

            }

        }

        [ResourceEntry("ProductsDescription",

            Value = "Description",

            Description = "phrase: Product Title",

            LastModified = "2019/11/23")]

        public string ProductsDescription
        {

            get
            {

                return this["ProductsDescription"];

            }

        }

        [ResourceEntry("ProductsPrice",

            Value = "Price",

            Description = "phrase: Product Price",

            LastModified = "2019/11/23")]

        public string ProductsPrice
        {

            get
            {

                return this["ProductsPrice"];

            }

        }

        [ResourceEntry("ProductsImageURL",

           Value = "Image Location",

           Description = "phrase: Product Image URL",

           LastModified = "2019/11/23")]

        public string ProductsImageURL
        {

            get
            {

                return this["ProductsImageURL"];

            }

        }


        [ResourceEntry("ProductsResourcesTitle",

           Value = "Products resources",

           Description = "phrase: Product resources title",

           LastModified = "2019/11/23")]

        public string ProductsResourcesTitle
        {

            get
            {

                return this["ProductsResourcesTitle"];

            }

        }


        [ResourceEntry("ProductsResourcesDescription",

            Value = "Keeps the product resources",

            Description = "phrase: Product resources description",

            LastModified = "2019/11/23")]

        public string ProductsResourcesDescription
        {

            get
            {

                return this["ProductsResourcesDescription"];

            }

        }

    }
}