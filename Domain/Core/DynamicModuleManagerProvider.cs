
using Telerik.Sitefinity.DynamicModules;

namespace SitefinityWebApp.Domain.Core
{
    public class DynamicModuleManagerProvider : IDynamicModuleManagerProvider
    {
        public DynamicModuleManager Get(string providerName, string transactionName)
        {
            return DynamicModuleManager.GetManager(providerName, transactionName);
        }
    }
}
