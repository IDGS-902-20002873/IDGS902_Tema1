using IDGS902_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS902_Tema1.Controllers
{
    public class Pruebas2Controller : Controller
    {
        // GET: Pruebas2
        public ActionResult Index()
        {
            var alumno = new Alumnos()
            {
                Name = "Jimena",
                Edad = 28,
                Email = "jimena@gmail.com",
                Activo = true,
                Inscripcion = new DateTime(2023, 4, 20)
            };
            ViewBag.Alumnos = alumno;
            return View();
        }
        public ActionResult Escuela()
        {
            var alumno = new Alumnos()
            {
                Name = "Jimena",
                Edad = 28,
                Email = "jimena@gmail.com",
                Activo = true,
                Inscripcion = new DateTime(2023, 4, 20)
            };
            ViewBag.Alumnos = alumno;
            return View(alumno);
        }

        public ActionResult CajasDinamicas(String numero)
        {
            ViewBag.Numero = Convert.ToInt16(numero);
            return View();
        }
        public ActionResult Resultado(String [] a)
        {
            int suma = 0;
            List<int> duplicados = new List<int>();

            for (int i = 0; i < a.Length; i++)
            {
                suma += Convert.ToInt16(a[i]);
            }

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (Convert.ToInt16(a[i]) == Convert.ToInt16(a[j]) && !duplicados.Contains(Convert.ToInt16(a[i])))
                    {
                        duplicados.Add(Convert.ToInt16(a[i]));
                    }
                }
            }

            double promedio = (Double) suma / a.Length;

            ViewBag.Duplicados = duplicados;
            ViewBag.Promedio = Convert.ToDouble(promedio);
            ViewBag.Suma = suma;

            return View();
        }
    }
}