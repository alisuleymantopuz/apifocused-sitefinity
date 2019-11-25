using SitefinityWebApp.Domain.Page;
using System.Web.Http;

namespace SitefinityWebApp.MVC.ApiControllers
{
    public class PageInfoApiController : ApiController
    {
        private readonly IPageMetaService _pageMetaService;

        public PageInfoApiController(IPageMetaService pageMetaService)
        {
            _pageMetaService = pageMetaService;
        }

        [HttpGet]
        public IHttpActionResult GetPageInfo(string pageId)
        {

            var pageMeta = _pageMetaService.GetPageMeta(pageId);

            var response = new
            {

                Labels = PageMeta.GetLabels(),
                Data = pageMeta
            };

            return Ok(response);
        }
    }
}
