using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FilmReviewWebsite.Startup))]
namespace FilmReviewWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
