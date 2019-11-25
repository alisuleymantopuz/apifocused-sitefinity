using SitefinityWebApp.Domain.Core;
using System;
using System.Linq;

namespace SitefinityWebApp.Domain.Page
{
    public class PageMetaService : IPageMetaService
    {
        private readonly IPageManagerProvider _pageManagerProvider;
        private readonly IPageMetaBuilder _pageMetaBuilder;

        public PageMetaService(IPageManagerProvider pageManagerProvider, IPageMetaBuilder pageMetaBuilder)
        {
            _pageManagerProvider = pageManagerProvider;
            _pageMetaBuilder = pageMetaBuilder;
        }

        public PageMeta GetPageMeta(string pageId)
        {
            var node = _pageManagerProvider.Get().GetPageNodes().FirstOrDefault(n => n.Id == Guid.Parse(pageId));

            return _pageMetaBuilder.Build(node);
        }
    }
}