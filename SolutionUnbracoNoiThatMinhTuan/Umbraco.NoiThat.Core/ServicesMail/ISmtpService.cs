
using Umbraco.NoiThat.Core.ViewModels;

namespace Umbraco.NoiThat.Core.ServicesMail
{
    public interface ISmtpService
    {
        bool SendEmail(ContactViewModel model);
    }
}
