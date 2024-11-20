using System;
// ESTUDAR ESSE CODIGO SUADO
class URI {
    public static (string, double, double) Bhaskara(double A, double B, double C){
        double delta = B * B - 4 * A * C;
        if ((A == 0) || (delta < 0)){
            return ("Impossivel calcular", 0, 0);
        }
        else{
            double x1 = (-B + Math.Sqrt(delta)) / (2 * A);
            double x2 = (-B - Math.Sqrt(delta)) / (2 * A);
            return ("Ok", x1, x2); //  tupla com o estado e os valores - o estado esta sendo necessario so pela necessidade de imprimir o "Impossivel Calcular"
        }
    }
    static void Main(string[] args){
        string[] valores = Console.ReadLine().Split(' ');
        double A = double.Parse(valores[0]);
        double B = double.Parse(valores[1]);
        double C = double.Parse(valores[2]);
        var (status, x1, x2) = Bhaskara(A, B, C);

        if (status == "Impossivel calcular"){
            Console.WriteLine(status);
        }
        else{
            Console.WriteLine($"R1 = {x1:F5}");
            Console.WriteLine($"R2 = {x2:F5}");
        }
    }
}