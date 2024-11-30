using System;

namespace activitieOne{
    class Program{
        static void Main(string[] args){
           string produto1 = "Computador";
           string produto2 = "Mesa de Escritorio";

           byte idade = 30; int codigo = 5290; char genero = 'M';
           double preco1 = 2100.0; double preco2 = 650.50; double medida = 53.234567;

           Console.WriteLine("Produtos:\n" + produto1 + ", cujo preço é $" + preco1 + "\n" + produto2 + ", cujo preço é $" + preco2);
           Console.WriteLine("Registro: {0} anos de idade, código {1} e gênero {2}", idade, codigo, genero);
           Console.WriteLine("Medida com oito casas decimais: {0}", medida.ToString("F8"));
           Console.WriteLine("Arredondado (treze casas decimais): {0}", medida.ToString("F13"));
           Console.WriteLine("Separador decimal invariant culture: {0}", medida.ToString("F3"));
        }
    }
}