using System;
using System.Globalization;
namespace Course {
    class Triangulo{
        public double A;
        public double B;
        public double C;
    }
    class Programa {
        static void Main(string[] args) {
            Triangulo x, y;
            y = new Triangulo();
            x = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);   
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);    
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 

            Console.WriteLine("Entre com as medidas do triangulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2.0;
            double AreaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double AreaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));
            
            Console.WriteLine("Area de X = " + AreaX.ToString("F4", CultureInfo.InvariantCulture)); 
            Console.WriteLine("Area de Y = " + AreaY.ToString("F4", CultureInfo.InvariantCulture));

            if (AreaX > AreaY) {
                Console.WriteLine("Maior area: X");
            } else {
                Console.WriteLine("Maior area: Y");
            }

        }
    }
}