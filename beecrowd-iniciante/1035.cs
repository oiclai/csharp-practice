using System; 

class URI {

    static void Main(string[] args) { 

        string[] valores = Console.ReadLine().Split(' ');
        int A = int.Parse(valores[0]);
        int B = int.Parse(valores[1]);
        int C = int.Parse(valores[2]);
        int D = int.Parse(valores[3]);

        if ((A>=0) && (B>=0) && (C>=0) && (D>=0) && A%2==0 && (B>C && D>A && C+D>A+B)){
            Console.WriteLine("Valores aceitos");
        }
        else {
          Console.WriteLine("Valores nao aceitos");
        }
    }

}