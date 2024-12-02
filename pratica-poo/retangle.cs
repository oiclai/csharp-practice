using System;
using System.Globalization;
namespace Course {
  class Retangulo {
    public double Largura;
    public double Altura;

    public double Area() {
      return Largura * Altura;
    }

    public double Perimetro() {
      return Largura+Altura+Largura+Altura;
    }
    public double Diagonal() {
      return Math.Sqrt(Largura * Largura + Altura * Altura);
    }
  }
  class Programa {
    static void Main (string[] args) {
        Retangulo r = new Retangulo();
        Console.Write("Entre a largura e altura do retangulo: ");
        string [] medidas = Console.ReadLine().Split(' ');
        r.Largura = int.Parse(medidas[0]);
        r.Altura = int.Parse(medidas[1]);

        Console.WriteLine("AREA = " + r.Area().ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("PERIMETRO = " + r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("DIAGONAL = " + r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
    }
  }
}