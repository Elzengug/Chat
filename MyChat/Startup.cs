using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyChat.Startup))]
namespace MyChat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
