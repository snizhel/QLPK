using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuanLyPhongKham1.Startup))]
namespace QuanLyPhongKham1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
