using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls.WebParts;

namespace IDGS902_Tema1.Controllers
{
    public class NewHomeController : Controller
    {
        // GET: NewHome
        public ActionResult NewIndex()
        {
            ViewBag.Message = "Hola IDGS-902";
            return View();
        }
        public ActionResult OperasBas()
        {
            ViewBag.Title = "OperasBas";
            ViewBag.Message = "Hola IDGS-902";
            return View();
        }
    }
}