using Telerik.Sitefinity.Modules.Pages;

namespace SitefinityWebApp.Domain.Core
{
    public interface IPageManagerProvider
    {
        PageManager Get();
    }
}
