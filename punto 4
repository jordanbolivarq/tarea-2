using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Encontrar y  ");

            Console.Write("Ingrese t: ");
            double t = double.Parse(Console.ReadLine());
            Console.Write("Ingrese w: ");
            double w = double.Parse(Console.ReadLine());
            Console.Write("Ingrese c: ");
            double c = double.Parse(Console.ReadLine());

            double sumaCuadradoX = ((Math.Pow(t, 2)) + (Math.Pow(w, 2)));

            double e = (180 - c);
            double eRadianes = e * (Math.PI / 180);

            double dRadianes = (Math.Asin(((Math.Sin(eRadianes)) / w) * (t)));
            double d = ((180 / Math.PI) * dRadianes);

            double b = (180 - d -e);

            double bRadianes = (b * (Math.PI / 180));
            double x = (Math.Sqrt(sumaCuadradoX - (2 * t * w * (Math.Cos(bRadianes)))));

            Console.WriteLine("x = " + x);
        }
    }
}
