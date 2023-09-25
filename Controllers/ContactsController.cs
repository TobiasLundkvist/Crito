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
    public class ContactsController : SurfaceController
    {
        public ContactsController(IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider) : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
        {
        }


        [HttpPost]
        public IActionResult Index(ContactForm contactForm)
        {
            if(!ModelState.IsValid)
                return CurrentUmbracoPage();

           
            return LocalRedirect(contactForm.RedirectUrl ?? "/");

            
            
            //using var mail = new MailService();
            // to sender
            //mail.SendAsync(contactForm.Email, "Your request was received.", "Hi your request was received and you will be contacted soon.").ConfigureAwait(false);

            // to us
            //mail.SendAsync("tobias_lundkvist@hotmail.com", $"{contactForm.Name} requested following", contactForm.Message ).ConfigureAwait(false);

        }
    }
}
