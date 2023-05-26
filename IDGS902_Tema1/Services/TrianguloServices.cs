using IDGS902_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS902_Tema1.Services
{
    public class TrianguloServices
    {
        public double CalcularArea(Triangulo t)
        {
            var dis = new Distancia();
            double bas = dis.CalcularDistancia(t.X1, t.Y1, t.X2, t.Y2);
            double alt = Math.Abs(t.Y3 - t.Y1);

            double area = (bas * alt) / 2;
            return area;
        }

        public string TipoTriangulo(Triangulo t)
        {
            var dis = new Distancia();
            double lado1 = Math.Round(dis.CalcularDistancia(t.X1, t.Y1, t.X2, t.Y2),9);
            double lado2 = Math.Round(dis.CalcularDistancia(t.X2, t.Y2, t.X3, t.Y3),9);
            double lado3 = Math.Round(dis.CalcularDistancia(t.X3, t.Y3, t.X1, t.Y1),9);

            if (lado1 + lado2 <= lado3 || lado2 + lado3 <= lado1 || lado3 + lado1 <= lado2)
            {
                return "No es un triangulo";
            }
            else if (Math.Round(lado1) == Math.Round(lado2) && Math.Round(lado2) == Math.Round(lado3))
            {
                return "Triangulo equilatero";
            }
            else if (lado1 == lado2 || lado2 == lado3 || lado3 == lado1)
            {
                return "Triangulo isosceles";
            }
            else
            {
                return "Triangulo escaleno";
            }
        }
    }
}