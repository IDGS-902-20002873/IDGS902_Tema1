﻿using IDGS902_Tema1.Models;
using IDGS902_Tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS902_Tema1.Controllers
{
    public class ArchivosController : Controller
    {
        // GET: Archivos
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Registrar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registrar(Maestros maes)
        {
            var ope1 = new GuardaServices();
            ope1.GuardarArchivo(maes);
            return View(maes);
        }

        public ActionResult LeerDatos()
        {
            var archivo = new LeerServices();
            ViewBag.Archivo = archivo.LeerArchivo();
            return View();
        }
    }
}