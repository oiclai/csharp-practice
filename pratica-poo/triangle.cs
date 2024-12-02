using System;
using System.Globalization;
namespace Course {
    class Triangulo{
        public double A;
        public double B;
        public double C;

        public double Area() { // metodo
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
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

            double areaX = x.Area();
            double areaY = y.Area();
            
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
