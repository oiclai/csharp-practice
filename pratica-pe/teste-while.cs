using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main (string[] args){
            Console.Write("Digite um número: ");
            double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (num >= 0.0){
                double raiz = Math.Sqrt(num);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("Digite um número: ");
                num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Número negativo.");
        }
    }    
}
