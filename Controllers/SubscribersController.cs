using Crito.Models;
using Crito.Services;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Website.Controllers;

namespace Crito.Controllers
{
    public class SubscribersController : SurfaceController
    {
        private readonly SubscribeFormService _subscribeFormService;

        public SubscribersController(IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider, SubscribeFormService subscribeFormService) : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
        {
            _subscribeFormService = subscribeFormService;
        }


        [HttpPost]
        public IActionResult Index(SubscribeFormModel subscribeFormModel)
        {
            if(!ModelState.IsValid)
            {
                return CurrentUmbracoPage();
            }
            else
            {
                _subscribeFormService?.CreateSubscriber(subscribeFormModel);
                return LocalRedirect(subscribeFormModel.RedirectUrl ?? "/");
            }
        }
    }
}
