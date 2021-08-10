using ControlMesas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControlMesas.Controllers
{
    public class HomeController : Controller
    {
        private ControlMesasContext db = new ControlMesasContext();

        public ActionResult Index(string message = "")
        {
            ViewBag.Message = message;

            return View();
        }

        [Authorize]
        public ActionResult Dashboard()
        {
            ViewBag.User = Session["user"];
            ViewBag.Zones = db.Zonas.ToList();

            return View();
        }
    }
}