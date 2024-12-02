using System;
using System.Globalization;
namespace Course {
  class Funcionario {
    public string Nome;
    public double SalarioBruto;
    public double Imposto;

    public double SalarioLiquido() {
      return SalarioBruto-Imposto;
    }

    public void AumentarSalario(double porcentagem) {
      SalarioBruto += SalarioBruto * porcentagem / 100.0;
    }
    public override string ToString(){
      return Nome
        + ", $ "
        + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
    }
  }
  class Programa {
    static void Main (string[] args) {
        Funcionario f = new Funcionario();
        Console.Write("Nome: ");
        f.Nome = Console.ReadLine();
        Console.WriteLine("");
        Console.Write("Salario bruto: ");
        f.SalarioBruto = Console.ReadLine();
        Console.WriteLine("");
        Console.Write("Imposto: ");
        f.Imposto = Console.ReadLine();
        WriteLine("");
        Console.WriteLine("Funcionario: " + f);
        Console.Write("Digite a porcentagem para aumentar o salario: ");
        double porcentagem = double.Parse(Console.ReadLine());
        f.AumentarSalario(porcentagem);
        Console.WriteLine("");
        Console.WriteLine("Dados atualizados: " + f);
    }
  }
}