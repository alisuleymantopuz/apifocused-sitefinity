
using System;
using Telerik.Sitefinity.Utilities.TypeConverters;

namespace SitefinityWebApp.Domain.Core
{
    public class TypeResolutionServiceProvider : ITypeResolutionServiceProvider
    {
        public Type Get(string name)
        {
            return TypeResolutionService.ResolveType(name);
        }
    }
}
