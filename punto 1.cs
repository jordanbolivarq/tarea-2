using System;

namespace Tarea_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Encontrar x  ");

            Console.Write("Ingrese b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Ingrese z: ");
            double z = double.Parse(Console.ReadLine());
            Console.Write("Ingrese y: ");
            double y = double.Parse(Console.ReadLine());

            

            double sumaCuadradosT = (Math.Pow(z, 2) + Math.Pow(y, 2));
            double t = Math.Sqrt(sumaCuadradosT);

            double cRadianes = Math.Asin(z / t);
            double c = ((180 / Math.PI) * cRadianes);
            double e = (180 - c);
            double d = (180 - b - e);

            double bRadianes = b * (Math.PI / 180);
            double dRadianes = d * (Math.PI / 180);

            double x = ((t * Math.Sin(bRadianes)) / Math.Sin(dRadianes));

            Console.WriteLine("x = " + x);
        }
    }
}
