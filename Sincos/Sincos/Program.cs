using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sincos
{
    
    internal class Program
    {

        static void Main(string[] args)
        {
            double angleinDegrees = 15;
            double angleinRadians = angleinDegrees * Math.PI / 180;
            var sin = Math.Sin(angleinRadians);  
            var cos = Math.Cos(angleinRadians);
            Console.WriteLine("sin(15\xB0) = " + Math.Round(sin,3));
            Console.WriteLine("cos(15\xB0) = " + Math.Round(cos, 3));

             angleinDegrees = 37;
             angleinRadians = angleinDegrees * Math.PI / 180;
             sin = Math.Sin(angleinRadians);
             cos = Math.Cos(angleinRadians);
            Console.WriteLine("sin(37\xB0) = " + Math.Round(sin, 3));
            Console.WriteLine("cos(37\xB0) = " + Math.Round(cos, 3));

            angleinDegrees = 113;
            angleinRadians = angleinDegrees * Math.PI / 180;
            sin = Math.Sin(angleinRadians);
            cos = Math.Cos(angleinRadians);
            Console.WriteLine("sin(113\xB0) = " + Math.Round(sin, 3));
            Console.WriteLine("cos(113\xB0) = " + Math.Round(cos, 3));

            Console.WriteLine();
            Console.WriteLine("Введите угол в градусах:");
            angleinDegrees = double.Parse(Console.ReadLine());
            angleinRadians = angleinDegrees * Math.PI / 180;
            sin = Math.Sin(angleinRadians);
            cos = Math.Cos(angleinRadians);
            Console.WriteLine("sin(" + angleinDegrees + "\xB0) = " + Math.Round(sin, 3));
            Console.WriteLine("cos(" + angleinDegrees + "\xB0) = " + Math.Round(cos, 3));

            Console.ReadKey();  
        }
    }
}
