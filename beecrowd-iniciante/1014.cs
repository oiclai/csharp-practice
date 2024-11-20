using System; 

class URI {

    static void Main(string[] args) { 

        int distanciaTotal = int.Parse(Console.ReadLine());
        float combustivelGasto = float.Parse(Console.ReadLine());
        float consumoMedio = (distanciaTotal / combustivelGasto);
        Console.WriteLine($"{consumoMedio:F3} km/l");
    }

}