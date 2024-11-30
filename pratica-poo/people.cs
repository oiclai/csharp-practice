using System;

namespace atividade {
    class People {
        public string nome;
        public int idade;
    }
    
    class Program {
        static void Main(string[] args) {
            People p1, p2;
            p1 = new People();
            p2 = new People();
            Console.WriteLine("Dados da primeira pessoa");
            Console.Write("Digite o seu nome: ");
            p1.nome = Console.ReadLine();
            Console.Write("Digite a sua idade: ");
            p1.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados da segunda pessoa");
            Console.Write("Digite o seu nome: ");  
            p2.nome = Console.ReadLine();
            Console.Write("Digite a sua idade: ");
            p2.idade = int.Parse(Console.ReadLine());

            if (p1.idade > p2.idade) {
                Console.WriteLine($"Pessoa mais velha: {p1.nome}");
            } else {
                Console.WriteLine($"Pessoa mais velha: {p2.nome}");
            }
        }
    }
}