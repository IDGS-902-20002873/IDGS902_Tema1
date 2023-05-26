using IDGS902_Tema1.Models;
using IDGS902_Tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace IDGS902_Tema1.Controllers
{
    public class TraductorController : Controller
    {
        // GET: Traductor
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Registrar(string result)
        {
            ViewBag.Resultado = result;
            return View();
        }
        [HttpPost]
        public ActionResult Registrar(Traductor traductor)
        {
            var ope1 = new GuardaServices();
            ViewBag.Result = ope1.GuardarPalabra(traductor);
            return View(traductor);
        }

        public ActionResult LeerDatos()
        {
            var archivo = new LeerServices();
            ViewBag.Traductor = archivo.LeerTraductor();
            return View();
        }

        public ActionResult Traducir(Traductor traductor)
        {
            var ope1 = new GuardaServices();
            var result = ope1.LeerTraductor(traductor);
            return RedirectToAction("Registrar", new {result = result});        }
    }
}