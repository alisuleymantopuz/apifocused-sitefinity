using Telerik.Sitefinity.Modules.Pages;

namespace SitefinityWebApp.Domain.Core
{
    public class PageManagerProvider : IPageManagerProvider
    {
        public PageManager Get()
        {
            return PageManager.GetManager();
        }
    }
}
