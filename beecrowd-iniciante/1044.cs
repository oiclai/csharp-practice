using System; 

class URI {
    public static string SaoMultiplos (int a, int b){
        if ((a%b == 0) || (b%a ==0)){
            return "Sao Multiplos";
        }
        else{
            return "Nao sao Multiplos";
        }
    }
    static void Main(string[] args) { 
        string [] valores = Console.ReadLine().Split();
        int a = int.Parse(valores[0]);
        int b = int.Parse(valores[1]);
        var resultado = SaoMultiplos(a, b);
        Console.WriteLine(resultado);
        

    }

}
