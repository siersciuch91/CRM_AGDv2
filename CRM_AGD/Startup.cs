using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CRM_AGD.Startup))]
namespace CRM_AGD
{
  public partial class Startup
  {
    public static Enum.Module CheckModule = 0;

    public void Configuration(IAppBuilder app)
    {
      ConfigureAuth(app);
    }
  }
}
