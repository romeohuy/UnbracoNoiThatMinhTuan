
using Umbraco.NoiThat.Core.ServicesMail;
using Umbraco.Core;
using Umbraco.Core.Composing;


namespace Umbraco.NoiThat.Core.Composing
{
    public class RegisterServicesComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.Register<ISmtpService, SmtpService>(Lifetime.Singleton);
        }
    }
}
