using System; 

class URI {

    static void Main() { 
        string [] dados1 = Console.ReadLine().Split();
        int cod1 = int.Parse(dados1[0]);
        int numPecas1 = int.Parse(dados1[1]);
        float precoPeca1 = float.Parse(dados1[2]);
        string [] dados2 = Console.ReadLine().Split();
        int cod2 = int.Parse(dados2[0]);
        int numPecas2 = int.Parse(dados2[1]);
        float precoPeca2 = float.Parse(dados2[2]);
        
        float compra1 = (numPecas1 * precoPeca1);
        float compra2 = (numPecas2 * precoPeca2);
        float valorTotal = (compra1 + compra2);
        Console.WriteLine($"VALOR A PAGAR: R$ {valorTotal:F2}");
    }

}