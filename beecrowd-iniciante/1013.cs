using System; 

class URI {

    static void Main(string[] args) { 

        int valor = int.Parse(Console.ReadLine());
        int celulas100 = valor/100;
        int resto = valor%100;
        Console.WriteLine(celulas100);

    }

}
