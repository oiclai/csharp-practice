using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

        int [] numeros = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int a = numeros [0]; int b = numeros [1]; int c = numeros [2];
        maiorab = (a + b + Math.Abs(a - b)) / 2;
        maiorabc = (maiorab + c + Math.Abs(maiorab - c)) / 2;
        Console.WriteLine($"{maiorabc} eh o maior");
    }

}