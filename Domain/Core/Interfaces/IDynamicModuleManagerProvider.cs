using Telerik.Sitefinity.DynamicModules;

namespace SitefinityWebApp.Domain.Core
{
    public interface IDynamicModuleManagerProvider
    {
        DynamicModuleManager Get(string providerName, string transactionName);
    }
}
