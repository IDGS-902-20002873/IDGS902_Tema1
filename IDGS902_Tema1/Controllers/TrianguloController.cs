using IDGS902_Tema1.Models;
using IDGS902_Tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS902_Tema1.Controllers
{
    public class TrianguloController : Controller
    {
        // GET: Triangulo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Calcular(Triangulo t)
        {
            var ope1 = new TrianguloServices();
            ViewBag.Res = ope1.CalcularArea(t);
            ViewBag.Tipo = ope1.TipoTriangulo(t);
            return View(t);
        }
    }
}