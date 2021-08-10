using ControlMesas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ControlMesas.Controllers
{
    [Authorize]
    public class TableController : Controller
    {
        private ControlMesasContext db = new ControlMesasContext();
        private HttpClient client = new HttpClient();

        public ActionResult Details(int id = 0)
        {
            if (id == 0)
            {
                FormsAuthentication.SignOut();
                return RedirectToAction("Index", "Home", new { message = "El ID de la mesa no puede ser nulo" });
            }
            else
            {
                Mesas mesa = db.Mesas.First(m => m.ID == id);
                List<Categorias> categorias = db.Categorias.ToList();

                ViewBag.Mesa = mesa;
                ViewBag.Categorias = categorias;
                ViewBag.IDUsuario = ((Usuarios)Session["user"]).ID;
                ViewBag.Items = new ResourceController().getItemsByMesa(id);

                return View();
            }
        }
    }
}