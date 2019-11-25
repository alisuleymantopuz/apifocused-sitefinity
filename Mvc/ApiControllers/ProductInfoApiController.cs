using SitefinityWebApp.Domain.Product;
using System.Web.Http;

namespace SitefinityWebApp.MVC.ApiControllers
{
    public class ProductInfoApiController : ApiController
    {
        private readonly IProductModelService _productService;

        public ProductInfoApiController(IProductModelService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IHttpActionResult GetProductInfo(string productId)
        {
            var model = _productService.GetProductById(productId);

            var response = new
            {

                Labels = ProductModel.GetLabels(),
                Data = model
            };

            return Ok(response);
        }
    }
}
