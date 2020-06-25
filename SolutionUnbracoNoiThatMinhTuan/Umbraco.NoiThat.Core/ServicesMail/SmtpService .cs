using System;
using System.Net.Mail;
using Umbraco.NoiThat.Core.ViewModels;
using Umbraco.Core.Logging;
using Umbraco.NoiThat.Core.Controllers;
using System.Net;

namespace Umbraco.NoiThat.Core.ServicesMail
{
    public class SmtpService : ISmtpService
    {
        private readonly ILogger _logger;

        public SmtpService(ILogger logger)
        {
            _logger = logger;
        }

        public bool SendEmail(ContactViewModel model)
        {
            try
            {
                var frommail = new MailAddress(System.Configuration.ConfigurationManager.AppSettings["NTMTMail"]);
                var Pass = System.Configuration.ConfigurationManager.AppSettings["EmailPass"];
                var tomail = new MailAddress(System.Configuration.ConfigurationManager.AppSettings["NTMTSupport"]);
                string Title = "Liên hệ từ website Noithatmth.vn";
                string Message = " Họ tên: " + model.Name + " Phone: " + model.Phone + " \n\nEmail: " + model.Email + " \n\nNội dung liên hệ: " + model.Message;
                var smtp = new System.Net.Mail.SmtpClient()
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(frommail.Address, Pass)

                };
                var mess = new MailMessage(frommail, tomail)
                {
                    Subject = Title,
                    Body = Message,
                };
                smtp.Send(mess);
                return true;
            }
            catch (Exception ex)
            {
                _logger.Error(typeof(ContactSurfaceController), ex, "Error sending contact form.");
                return false;
            }
        }
    }
}
