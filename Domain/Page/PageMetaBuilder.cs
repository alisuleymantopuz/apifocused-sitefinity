using Telerik.Sitefinity.Pages.Model;

namespace SitefinityWebApp.Domain.Page
{
    public class PageMetaBuilder : IPageMetaBuilder
    {
        public PageMeta Build(PageNode node)
        {
            var pageMeta = new PageMeta();

            if (node != null)
            {
                pageMeta.PageTitle = node.GetPageData().HtmlTitle;
                pageMeta.PageDescription = node.GetPageData().Description;
            }

            return pageMeta;
        }
    }
}