using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Encontrar z  ");

            Console.Write("Ingrese d: ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("Ingrese b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Ingrese y: ");
            double y = double.Parse(Console.ReadLine());

            double e = (180 - b - d);
            double c = (180 - e);
            double a = (180 - c - 90);

            double cRadianes = c * (Math.PI / 180);
            double aRadianes = a * (Math.PI / 180);

            double z = (Math.Sin(cRadianes) * (y / (Math.Sin(aRadianes))));

            Console.WriteLine("z = " + z);
        }
    }
}
