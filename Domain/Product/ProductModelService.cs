using SitefinityWebApp.Domain.Core;
using System;
using Telerik.Sitefinity.SitefinityExceptions;

namespace SitefinityWebApp.Domain.Product
{
    public class ProductModelService : IProductModelService
    {
        private readonly IDynamicModuleManagerProvider _dynamicModuleManagerProvider;
        private readonly IProductModelBuilder _productBuilder;
        private readonly ITypeResolutionServiceProvider _typeResolutionServiceProvider;

        public ProductModelService(IDynamicModuleManagerProvider dynamicModuleManagerProvider, IProductModelBuilder productBuilder, ITypeResolutionServiceProvider typeResolutionServiceProvider)
        {
            _dynamicModuleManagerProvider = dynamicModuleManagerProvider;
            _productBuilder = productBuilder;
            _typeResolutionServiceProvider = typeResolutionServiceProvider;
        }

        public ProductModel GetProductById(string productId)
        {
            var model = new ProductModel();
            try
            {
                var transactionName = "GetProductInfo";
                var dynamicModuleManager = _dynamicModuleManagerProvider.Get(string.Empty, transactionName);
                var productType = _typeResolutionServiceProvider.Get("Telerik.Sitefinity.DynamicTypes.Model.Products.Product");
                var productID = new Guid(productId);
                var productItem = dynamicModuleManager.GetDataItem(productType, productID);
                return _productBuilder.Build(productItem);
            }
            catch (ItemNotFoundException)
            {
                //logging
            }
            return model;
        }
    }
}
