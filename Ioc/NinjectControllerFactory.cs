using Ninject;
using System;
using System.Web.Http;
using System.Web.Mvc;
using Telerik.Sitefinity.Frontend.Mvc.Infrastructure.Controllers;

namespace SitefinityWebApp
{
    public class NinjectControllerFactory : FrontendControllerFactory
    {

        private readonly IKernel ninjectKernel;
        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel(new ApplicationModule());
            SetResolvers(ninjectKernel);
        }

        private void SetResolvers(IKernel ninjectKernel)
        {
            NinjectDependencyResolver ninjectResolver = new NinjectDependencyResolver(ninjectKernel);
            DependencyResolver.SetResolver(ninjectResolver);
            GlobalConfiguration.Configuration.DependencyResolver = ninjectResolver;
        }

        protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext, Type controllerType)
        {
            if (controllerType == null)
            {
                return null;
            }

            var resolvedController = this.ninjectKernel.Get(controllerType);
            IController controller = resolvedController as IController; 
            return controller;
        }
    }
}