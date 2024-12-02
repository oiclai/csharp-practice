using System;
using System.Globalization;
namespace Course {
  class Produto {
    // padrao = nome da classe e dos atributos MAIUSCULAS
    public string Nome;
    public double Preco;
    public int Quantidade;

    public double ValorTotalEmEstoque() {
      return Preco * Quantidade;
    }
  }
  class Programa {
    static void Main (string[] args) {
      Produto p = new Produto(); // instancia (objeto variavel composta
      Console.WriteLine("Entre os dados do produto:");
      Console.Write ("Nome: ");
      p.Nome = Console.ReadLine();
      Console.Write ("Preço: ");
      p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      Console.Write ("Quantidade: ");
      p.Quantidade = int.Parse(Console.ReadLine());

      Console.WriteLine("Dados do Produto: " );
    }
  }
}
