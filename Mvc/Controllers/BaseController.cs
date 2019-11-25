using System.Web.Mvc;
using Telerik.Sitefinity.Personalization;
using Telerik.Sitefinity.Web;

namespace SitefinityWebApp.MVC.Controllers
{
    public class BaseController : Controller, IPersonalizable
    {

        protected override void HandleUnknownAction(string actionName)
        {
            this.ActionInvoker.InvokeAction(this.ControllerContext, "Index");
        }

        public string CurrentPageId
        {
            get
            {
                return SiteMapBase.GetCurrentProvider()?.CurrentNode?.Key;
            }

        }
    }
}