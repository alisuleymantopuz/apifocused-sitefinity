
namespace SitefinityWebApp.MVC.Models
{
    public class PageInfoViewModel : BaseModel
    {
        public PageInfoViewModel(string currentPageId)
        {
            this.CurrentPageId = currentPageId;
        }
    }
}