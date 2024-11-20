using System; 

class URI {

    static void Main(string[] args) { 

        int diasVivo = int.Parse(Console.ReadLine());
        // todo ano com 365 dias e todo mês com 30 dias
        int anos = diasVivo/365;
        int resto = diasVivo%365;
        int meses = resto/30;
        resto = resto%30;
        int dias = resto;
        Console.WriteLine($"{anos} ano(s)");
        Console.WriteLine($"{meses} mes(es)");
        Console.WriteLine($"{dias} dia(s)");


    }

}