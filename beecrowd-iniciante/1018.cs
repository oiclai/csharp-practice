using System; 

class URI {

    static void Main(string[] args) { 

        int valor = int.Parse(Console.ReadLine());
        int celulas100 = valor/100;
        int resto = valor%100;
        int celulas50 = resto/50;
        resto = resto%50;
        int celulas20 = resto/20;
        resto = resto%20;
        int celulas10 = resto/10;
        resto = resto%10;
        int celulas5 = resto/5;
        resto = resto%5;
        int celulas2 = resto/2;
        resto = resto%2;
        int celulas1 = resto;
        Console.WriteLine(valor);
        Console.WriteLine($"{celulas100} nota(s) de R$ 100,00");
        Console.WriteLine($"{celulas50} nota(s) de R$ 50,00");
        Console.WriteLine($"{celulas20} nota(s) de R$ 20,00");
        Console.WriteLine($"{celulas10} nota(s) de R$ 10,00");
        Console.WriteLine($"{celulas5} nota(s) de R$ 5,00");
        Console.WriteLine($"{celulas2} nota(s) de R$ 2,00");
        Console.WriteLine($"{celulas1} nota(s) de R$ 1,00");

    }

}
