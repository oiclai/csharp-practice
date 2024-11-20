using System;

class URI {

    static void Main(string[] args) { 

        decimal valor = decimal.Parse(Console.ReadLine());
        // cédulas
        int cedulas100 = (int)(valor / 100);
        decimal resto = valor % 100;
        int cedulas50 = (int)(resto / 50);
        resto %= 50;
        int cedulas20 = (int)(resto / 20);
        resto %= 20;
        int cedulas10 = (int)(resto / 10);
        resto %= 10;
        int cedulas5 = (int)(resto / 5);
        resto %= 5;
        int cedulas2 = (int)(resto / 2);
        resto %= 2;
        // moedas
        int moedas1 = (int)(resto / 1);
        resto %= 1;
        resto *= 100; // Trabalhar com centavos para evitar frações
        int moedas050 = (int)(resto / 50);
        resto %= 50;
        int moedas025 = (int)(resto / 25);
        resto %= 25;
        int moedas010 = (int)(resto / 10);
        resto %= 10;
        int moedas005 = (int)(resto / 5);
        resto %= 5;
        int moedas001 = (int)resto;

        Console.WriteLine("NOTAS:");
        Console.WriteLine($"{cedulas100} nota(s) de R$ 100.00");
        Console.WriteLine($"{cedulas50} nota(s) de R$ 50.00");
        Console.WriteLine($"{cedulas20} nota(s) de R$ 20.00");
        Console.WriteLine($"{cedulas10} nota(s) de R$ 10.00");
        Console.WriteLine($"{cedulas5} nota(s) de R$ 5.00");
        Console.WriteLine($"{cedulas2} nota(s) de R$ 2.00");
        Console.WriteLine("MOEDAS:");
        Console.WriteLine($"{moedas1} moeda(s) de R$ 1.00");
        Console.WriteLine($"{moedas050} moeda(s) de R$ 0.50");
        Console.WriteLine($"{moedas025} moeda(s) de R$ 0.25");
        Console.WriteLine($"{moedas010} moeda(s) de R$ 0.10");
        Console.WriteLine($"{moedas005} moeda(s) de R$ 0.05");
        Console.WriteLine($"{moedas001} moeda(s) de R$ 0.01");
    }
}
