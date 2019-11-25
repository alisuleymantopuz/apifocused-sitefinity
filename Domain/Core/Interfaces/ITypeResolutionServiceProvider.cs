
using System;

namespace SitefinityWebApp.Domain.Core
{
    public interface ITypeResolutionServiceProvider
    {
        Type Get(string name);
    }
}
