using System;
using System.Globalization;

/* 
    p = new Produto();
    ** NA MEMORIA **
    p -> nome = Null | Preco = 0 | Quantidade = 0
*/

namespace Course {
  class Produto {
    // padrao = nome da classe e dos atributos MAIUSCULAS
    public string Nome;
    public double Preco;
    public int Quantidade;

    // Construtor:
    public Produto(string nome, double preco, int quantidade) {
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }
    public double ValorTotalEmEstoque() {
      return Preco * Quantidade;
    }

    public void AdicionarProdutos(int quantidade) {
      Quantidade += quantidade;
    }
    public void RemoverProdutos(int quantidade) {
      Quantidade -= quantidade;
    }
    public override string ToString(){
      return Nome
        + ", $ "
        + Preco.ToString("F2", CultureInfo.InvariantCulture)
        + ", "
        + Quantidade
        + " unidades, Total: $ "
        + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
    }
  }
//   class Programa {
//     static void Main (string[] args) {
//       Produto p = new Produto(); // instancia (objeto variavel composta
//     /*  Console.WriteLine("Entre os dados do produto:");
//       Console.Write ("Nome: ");
//       p.Nome = Console.ReadLine();
//       Console.Write ("Preço: ");
//       p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//       Console.Write ("Quantidade: ");
//       p.Quantidade = int.Parse(Console.ReadLine());

//       Console.WriteLine("Dados do Produto: " +p);

//       Console.WriteLine();
//       Console.Write('Digite o numero de profutos a serem adicionados: ');
//       int quantiaAdd = int.Parse(Console.ReadLine());
//       p.AdicionarProdutos(quantiaAdd);
//       Console.WriteLine();
//       Console.WriteLine("Dados atualizados: " +p);
//       Console.WriteLine();
//       Console.Write('Digite o numero de profutos a serem removidos: ');
//       int quantiaDel = int.Parse(Console.ReadLine());
//       p.RemoverProdutos(quantiaDel);
//       Console.WriteLine();
//       Console.WriteLine("Dados atualizados: " +p);
//     */
//     Console.WriteLine(p);
//     }
//   }
    class Programa {
     static void Main (string[] args) {
    //    Produto p = new Produto("Tv", 500.00, 10); // instancia (objeto variavel composta)
       Console.WriteLine("Entre os dados do produto:");
       Console.Write ("Nome: ");
       string nome = Console.ReadLine(); // variavel aux temporária
       Console.Write ("Preço: ");
       double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // variavel aux temporária
       Console.Write ("Quantidade: ");
       int quantidade = int.Parse(Console.ReadLine()); // variavel aux temporária
       Produto p = new Produto(nome, preco, quantidade);
       Console.WriteLine("Dados do Produto: " +p);
       Console.WriteLine();
       Console.Write('Digite o numero de profutos a serem adicionados: ');
      int quantiaAdd = int.Parse(Console.ReadLine());
       p.AdicionarProdutos(quantiaAdd);
       Console.WriteLine();
       Console.WriteLine("Dados atualizados: " +p);
       Console.WriteLine();
       Console.Write('Digite o numero de profutos a serem removidos: ');
       int quantiaDel = int.Parse(Console.ReadLine());
       p.RemoverProdutos(quantiaDel);
       Console.WriteLine();
       Console.WriteLine("Dados atualizados: " +p);
    
     Console.WriteLine(p);
     }
   }
}
