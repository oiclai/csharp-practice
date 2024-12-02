using System;
using System.Globalization;
namespace Course {
  class Aluno {
    public string Nome;
    public double Nota1, Nota2, Nota3;

    public double NotaFinal() {
      return Nota1 + Nota2 + Nota3;
    }

    public AprovadoOuReprovado(double notafinal) {
      if (notafinal < 60.0) {
        return "REPROVADO\nFALTARAM " + (60.0 - notafinal) + " PONTOS";
      }
      else {
        return "APROVADO";
      }
    }
  }
  class Programa {
    static void Main (string[] args) {
        Aluno a = new Aluno();
        Console.Write("Nome: ");
        a.Nome = Console.ReadLine();
        Console.WriteLine("");
        Console.Write("1ª Nota: ");
        a.Nota1 = Console.ReadLine();
        Console.WriteLine("");
        Console.Write("2ª Nota: ");
        a.Nota2 = Console.ReadLine();
        Console.WriteLine("");
        Console.Write("3ª Nota: ");
        a.Nota3 = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("NOTA FINAL = " + a.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine(a.AprovadoOuReprovado(a.NotaFinal()));
    }
  }
}