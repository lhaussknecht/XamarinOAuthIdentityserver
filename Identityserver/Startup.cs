using IdentityServer3.Core.Configuration;
using IdentityServer3.Core.Resources;
using IdentityServer3.Host.Config;
using Owin;
using SelfHost.Config;

namespace SelfHost
{
    internal class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            var factory = new IdentityServerServiceFactory();
            factory
                .UseInMemoryClients(Clients.Get())
                .UseInMemoryScopes(IdentityServer3.Host.Config.Scopes.Get())
                .UseInMemoryUsers(Users.Get());

            var options = new IdentityServerOptions
            {
                SiteName = "IdentityServer3 (self host)",

                SigningCertificate = Certificate.Get(),
                Factory = factory,
            };

            appBuilder.UseIdentityServer(options);
        }
    }
}