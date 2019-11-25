using Ninject.Modules;
using SitefinityWebApp.Domain.Core;
using SitefinityWebApp.Domain.Page;
using SitefinityWebApp.Domain.Product;

namespace SitefinityWebApp
{
    public class ApplicationModule : NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind<IDynamicModuleManagerProvider>().To<DynamicModuleManagerProvider>();
            Kernel.Bind<IPageManagerProvider>().To<PageManagerProvider>();
            Kernel.Bind<ITypeResolutionServiceProvider>().To<TypeResolutionServiceProvider>();

            Kernel.Bind<IPageMetaBuilder>().To<PageMetaBuilder>();
            Kernel.Bind<IPageMetaService>().To<PageMetaService>();


            Kernel.Bind<IProductModelBuilder>().To<ProductModelBuilder>();
            Kernel.Bind<IProductModelService>().To<ProductModelService>();

        }
    }
}