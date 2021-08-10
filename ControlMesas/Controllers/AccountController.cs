using ControlMesas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ControlMesas.Controllers
{
    public class AccountController : Controller
    {
        private ControlMesasContext db = new ControlMesasContext();

        [HttpPost]
        public ActionResult Login(string user, string pass)
        {
            try
            {
                Usuarios usuario = db.Usuarios.First(u => u.Username == user && u.Clave == pass);
                FormsAuthentication.SetAuthCookie(usuario.Nombre, true);
                Session["user"] = usuario;

                return RedirectToAction("Dashboard", "Home");
            }
            catch (InvalidOperationException ex)
            {
                return RedirectToAction("Index", "Home", new { message = "Usuario o clave incorrectos" });
            }
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session["user"] = null;

            return RedirectToAction("Index", "Home");
        }
    }
}