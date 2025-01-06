using System;
using System.Globalization;

namespace Course {
    class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(){ 
        }
        public Produto (string nome, double preco) {
            Nome = nome;
            Preco = preco;
            Quantidade = 0; //ou se tiver algum outro padrao
        }
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
    class Program {
        static void Main(string[] args) {
            
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto p = new Produto(nome, preco, 20);
            Produto p2 = new Produto(nome, preco);
            Produto p3 = new Produto();
            Console.WriteLine();
            Console.Write("Dados do produto: " + p);

            Console.WriteLine();




}