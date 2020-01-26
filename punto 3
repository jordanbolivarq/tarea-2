using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Encontrar y  ");

            Console.Write("Ingrese d: ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("Ingrese w: ");
            double w = double.Parse(Console.ReadLine());
            Console.Write("Ingrese x: ");
            double x = double.Parse(Console.ReadLine());

            double sumaCuadradoT = ((Math.Pow(x, 2)) + (Math.Pow(w, 2)));
            double dRadianes = (d * (Math.PI / 180));
            double t = (Math.Sqrt(sumaCuadradoT - (2 * x * w * (Math.Cos(dRadianes)))));

            double cRadianes = ((Math.Asin((w * Math.Sin(dRadianes)) / t)));
            double c = ((180 / Math.PI) * cRadianes);
            double e = (180 - c);
            double a = (180 - c - 90);

            double aRadianes = a * (Math.PI / 180);
            double y = (t * Math.Sin(aRadianes));

            Console.WriteLine("y = " + y);
        }
    }
}
