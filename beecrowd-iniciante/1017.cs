using System; 

class URI {

    static void Main(string[] args) { 

        int tempoHoras = int.Parse(Console.ReadLine());
        int velMedia = int.Parse(Console.ReadLine());
        
        float calculo = (tempoHoras * velMedia)/12f;
        
        Console.WriteLine($"{calculo:F3}");
    }

}