using Telerik.Sitefinity.Pages.Model;

namespace SitefinityWebApp.Domain.Page
{
    public interface IPageMetaBuilder
    {
        PageMeta Build(PageNode node);
    }
}