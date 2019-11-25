using SitefinityWebApp.MVC.Models;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;

namespace SitefinityWebApp.MVC.Controllers
{
    [ControllerToolboxItem(Name = "PageInfo_MVC", Title = "Page Info", SectionName = Parts.PageWidgets, CssClass = "sfMvcIcn")]
    public class PageInfoController : BaseController
    {
        public ActionResult Index()
        {
            return View(new PageInfoViewModel(this.CurrentPageId));
        }
    }
}