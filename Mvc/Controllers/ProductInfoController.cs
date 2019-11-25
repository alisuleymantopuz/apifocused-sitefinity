using SitefinityWebApp.MVC.Models;
using System;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;

namespace SitefinityWebApp.MVC.Controllers
{
    [ControllerToolboxItem(Name = "ProductInfo_MVC", Title = "Product Info", SectionName = Parts.PageWidgets, CssClass = "sfMvcIcn")]
    public class ProductInfoController : BaseController
    {
        // GET: Product Info
        public ActionResult Index()
        {
            try
            {
                return View(new ProductInfoViewModel() { SelectedId = SelectedId, SelectedItem = SelectedItem, CurrentPageId = this.CurrentPageId });
            }
            catch (ArgumentException)
            {
                return Content("Type {0} doesn't exists!".Arrange("Telerik.Sitefinity.DynamicTypes.Model.Products.Product"));
            }
        }


        public string SelectedId { get; set; }
        public string SelectedItem { get; set; }
    }
}