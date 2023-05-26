using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace IDGS902_Tema1.Models
{
    public class Distancia
    {
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int X2 { get; set; }
        public int Y2 { get; set; }
        public double Res { get; set; }

        public double CalcularDistancia(double x1, double y1, double x2, double y2)
        {
            this.Res = Convert.ToDouble(Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)));
            return Convert.ToDouble(this.Res);
        }
    }
}