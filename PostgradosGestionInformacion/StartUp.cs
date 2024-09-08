using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

[assembly: OwinStartupAttribute(typeof(PostgradosGestionInformacion.StartUp))]
namespace PostgradosGestionInformacion
{
    public class StartUp
    {
        public void Configuration(IAppBuilder app)
        {
            
           /* app.UseCookieAuthentication(new CooCookieAuthenticationOptions
            {
                ExpireTimeSpan = TimeSpan.FromMinutes(3),
                LoginPath = new PathString("/Login"),
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,

            });*/
        }
    }
}