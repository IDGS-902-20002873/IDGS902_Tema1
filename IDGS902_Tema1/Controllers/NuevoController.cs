using IDGS902_Tema1.Models;
using IDGS902_Tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS902_Tema1.Controllers
{
    public class NuevoController : Controller
    {
        // GET: Nuevo
        public ActionResult Vista()
        {
            return View();
        }
        
        public ActionResult OperasBas(String n1, String n2, String opera)
        {
            if (Convert.ToInt16(opera) == 1)
            {
                int res = Convert.ToInt16(n1) + Convert.ToInt16(n2);
                ViewBag.Res = Convert.ToString(res);
            }
            else if (Convert.ToInt16(opera) == 2){
                int res = Convert.ToInt16(n1) - Convert.ToInt16(n2);
                ViewBag.res = Convert.ToString(res);
            }
            else if (Convert.ToInt16(opera) == 3)
            {
                int res = Convert.ToInt16(n1) * Convert.ToInt16(n2);
                ViewBag.res = Convert.ToString(res);
            }
            else if (Convert.ToInt16(opera) == 4)
            {
                int res = Convert.ToInt16(n1) / Convert.ToInt16(n2);
                ViewBag.res = Convert.ToString(res);
            }
            
            return View();
        }

        public ActionResult OperasBas2(Calculos op)
        {
            var model = new Calculos();

            if (op.Opera == 1)
            {
                model.Res = op.Num1 + op.Num2;
                ViewBag.Res = model.Res;
            }
            else if (op.Opera == 2)
            {
                model.Res = op.Num1 - op.Num2;
                ViewBag.Res = model.Res;
            }
            else if (op.Opera == 3)
            {
                model.Res = op.Num1 * op.Num2;
                ViewBag.Res = model.Res;
            }
            else if (op.Opera == 4)
            {
                model.Res = op.Num1 / op.Num2;
                ViewBag.Res = model.Res;
            }

            return View(model);
        }
        public ActionResult Distancia(Distancia dis)
        {
            var model = new Distancia();
            model.Res = (int)dis.CalcularDistancia(dis.X1, dis.Y1, dis.X2, dis.Y2);
            return View(model);
        }
        public ActionResult MuestraPulques()
        {
            var pulques1 = new PulqueServices();
            var model = pulques1.ObtenerPulques();
            return View(model);
        }

        public ActionResult MuestraPulques2()
        {
            var pulques1 = new PulqueServices();
            var model = pulques1.ObtenerPulques();
            return View(model);
        }
    }
}