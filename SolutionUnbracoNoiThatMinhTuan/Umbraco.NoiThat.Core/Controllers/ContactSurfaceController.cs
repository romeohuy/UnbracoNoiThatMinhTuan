using System;
using System.Net.Mail;
using System.Web;
using Umbraco.Web.Mvc;
using System.Web.Mvc;
using Umbraco.NoiThat.Core.ServicesMail;
using Umbraco.NoiThat.Core.ViewModels;
using Umbraco.Core.Logging;
using Umbraco.Web;

namespace Umbraco.NoiThat.Core.Controllers
{
    public class ContactSurfaceController : SurfaceController
    {
        private readonly ISmtpService _smtpService;

        public ContactSurfaceController(ISmtpService smtpService)
        {
            _smtpService = smtpService;
        }

        [HttpGet]
        public ActionResult RenderForm()
        {
            ContactViewModel model = new ContactViewModel() { ContactFormId = CurrentPage.Id };
            return PartialView("~/Views/Partials/Contact/contactForm.cshtml", model);
        }

        [HttpPost]
        public ActionResult RenderForm(ContactViewModel model)
        {
            return PartialView("~/Views/Partials/Contact/contactForm.cshtml", model);
        }

        [HttpPost]
        public ActionResult SubmitForm(ContactViewModel model)
        {
            bool success = false;

            if (ModelState.IsValid)
            {
                success = _smtpService.SendEmail(model);
            }

            var contactPage = UmbracoContext.Content.GetById(false, model.ContactFormId);

            return  Json(success ? "Gửi liên hệ thành công." : "Gửi liên hệ thất bại. Vui lòng thử lại.");
        }

    }
}
