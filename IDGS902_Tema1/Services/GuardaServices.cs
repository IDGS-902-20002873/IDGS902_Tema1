using IDGS902_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;

namespace IDGS902_Tema1.Services
{
    public class GuardaServices
    {
        public void GuardarArchivo(Maestros maes)
        {
            var nombre = maes.Nombre;
            var apaterno = maes.Apaterno;
            var amaterno = maes.Amaterno;
            var edad = maes.Edad;
            var email = maes.Email;
            var datos = nombre + ","+apaterno+","+amaterno+","+edad+","+email+Environment.NewLine;
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/datos.txt");
            File.WriteAllText(archivo, datos);
        }

        public string GuardarPalabra(Traductor traductor)
        {
            try
            {
                var spanish = traductor.Spanish;
                var english = traductor.English;

                var datos = HttpContext.Current.Server.MapPath("~/App_Data/traductor.txt");

                if (File.Exists(datos))
                {
                    var archivo = File.ReadAllLines(datos);

                    foreach (string linea in archivo)
                    {
                        string[] palabras = linea.Split(',');

                        if (palabras.Length == 2)
                        {
                            string palabraEspañol = palabras[0].Trim();
                            string palabraIngles = palabras[1].Trim();

                            if (spanish.Equals(palabraEspañol, StringComparison.OrdinalIgnoreCase) ||
                                english.Equals(palabraIngles, StringComparison.OrdinalIgnoreCase))
                            {
                                return "La palabra ya existe";
                            }
                        }
                    }
                }

                var data = spanish + ',' + english + Environment.NewLine;

                File.AppendAllText(datos, data);

                return "La palabra se agregó con éxito";
            }
            catch (Exception)
            {
                return "Algo salió mal con el archivo";
            }
        }


        public string LeerTraductor(Traductor traductor)
        {
            try
            {
                var estatus = traductor.Estatus;
                var palabra = traductor.Filtro;
                string palabraTraducida = null;
                string palabraTraducidaE = null;

                Array archivo = null;
                var datos = HttpContext.Current.Server.MapPath("~/App_Data/traductor.txt");
                if (File.Exists(datos))
                {
                    archivo = File.ReadAllLines(datos);
                }

                foreach (string linea in archivo)
                {
                    string[] palabras = linea.Split(',');

                    if (palabras.Length == 2)
                    {
                        string palabraEspañol = palabras[0].Trim();
                        string palabraIngles = palabras[1].Trim();

                        if (palabra.Equals(palabraEspañol, StringComparison.OrdinalIgnoreCase))
                        {
                                palabraTraducida = palabraEspañol;
                                palabraTraducidaE = palabraIngles;
                            if(estatus == "1")
                                return palabraTraducida;
                            else if (estatus == "0")
                                return palabraTraducidaE;
                            
                        }
                        else if (palabra.Equals(palabraIngles, StringComparison.OrdinalIgnoreCase))
                        {
                            palabraTraducida = palabraEspañol;
                            palabraTraducidaE = palabraIngles;
                            if (estatus == "1")
                                return palabraTraducida;
                            else if (estatus == "0")
                                return palabraTraducidaE;

                        }
                    }
                }
                return "La palabra no existe";
            }
            catch (Exception)
            {
                return "Algo salió mal";
                throw;
            }
        }
    }
}