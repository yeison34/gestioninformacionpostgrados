using Entities.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using static System.Net.WebRequestMethods;

namespace digiturnopro.Controllers.Login
{
    public class LoginController : Controller
    {
       
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginModel model) {
            try {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                if (model.UserName == "123" && model.Password == "12345678")
                {
                    FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1,model.UserName,DateTime.Now,DateTime.Now.AddMinutes(3),true, "",FormsAuthentication.FormsCookiePath);
                    HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(ticket)) {
                        HttpOnly = true,
                    };
                    Response.Cookies.Add(cookie);
                    string returnUrl = Request.QueryString["ReturnUrl"];

                    // Verificar si el ReturnUrl es una URL local válida
                    if (string.IsNullOrEmpty(returnUrl) || !Url.IsLocalUrl(returnUrl))
                    {
                        // Si el ReturnUrl no es válido o está vacío, redirigir a la página de inicio
                        return Redirect(Url.Action("Index", "Home"));
                    }

                    // Redirigir a la URL especificada en ReturnUrl
                    return Redirect(returnUrl);
                }
                else {
                    ViewBag.mensaje = "Usuario o Contraseña Incorrecta";
                }
            }
            catch (Exception ex) {
                throw;
            }
            return View(model);
        }
    }
}