using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS902_Tema1.Services
{
    public class LeerServices
    {
    public Array LeerArchivo()
        {
            Array maesDatos = null;
            var datos = HttpContext.Current.Server.MapPath("~/App_Data/datos.txt");
            if(File.Exists(datos))
            {
                maesDatos= File.ReadAllLines(datos);
            }
            return maesDatos;
        }

        public Array LeerTraductor()
        {
            Array traductor = null;
            var datos = HttpContext.Current.Server.MapPath("~/App_Data/traductor.txt");
            if (File.Exists(datos))
            {
                traductor = File.ReadAllLines(datos);
            }
            Console.Write(traductor);
            return traductor;
        }
    }
}