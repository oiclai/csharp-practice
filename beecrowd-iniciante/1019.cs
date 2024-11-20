using System; 

class URI {

    static void Main(string[] args) { 

        int segundos = int.Parse(Console.ReadLine());
        int horas = segundos/3600;
        int resto = segundos%3600;
        int minutos = resto/60;
        resto = resto%60;
        int sobraSegundos = resto;
        
        Console.WriteLine($"{horas}:{minutos}:{sobraSegundos}");

    }

}