using System; 

class URI {

    static void Main(string[] args) { 

        float raio = float.Parse(Console.ReadLine());
        const double pi = 3.14159;
        double volume = (4.0/3)*pi*(Math.Pow(raio,3));
        Console.WriteLine($"VOLUME = {volume:F3}");

    }

}