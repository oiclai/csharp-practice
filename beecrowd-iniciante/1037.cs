using System; 

class URI {
    
    public static string Intervalo (float numero){
      if (0 <= numero && numero <= 25){
        return "Intervalo [0,25]";
      }
      else if (25 <= numero && numero <= 50){
        return "Intervalo (25,50]";
      }
      else if (50 <= numero && numero <= 75){
        return "Intervalo (50,75]";
      }
      else if (75 <= numero && numero <= 100){
        return "Intervalo (75,100]";
      }
      else{
        return "Fora de intervalo";
      }
    }

    static void Main(string[] args) { 

        float numero = float.Parse(Console.ReadLine());
        var resposta = Intervalo(numero);
        Console.WriteLine(resposta);
    }

}