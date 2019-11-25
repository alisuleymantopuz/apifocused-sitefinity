using System.Collections.Generic;
using Telerik.Sitefinity.Localization;
using Telerik.Sitefinity.Modules.Pages;

namespace SitefinityWebApp.Domain.Page
{
    public class PageMeta
    {
        public string PageTitle { get; set; }
        public string PageDescription { get; set; }

        public static Dictionary<string, string> GetLabels()
        {
            return new Dictionary<string, string>
                        {
                            { "Title", Res.Get<PageResources>("Title") },
                            { "Description", Res.Get<PageResources>("Description")  }
                        };
        }
    }
}