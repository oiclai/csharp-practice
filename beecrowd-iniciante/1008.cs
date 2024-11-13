using System; 

class URI {

    static void Main(string[] args) { 

        int numFuncionario = int.Parse(Console.ReadLine());
        int numHTrabalhadas = int.Parse(Console.ReadLine());
        float valorPorHora = float.Parse(Console.ReadLine());
        
        float salario = (numHTrabalhadas * valorPorHora);
        
        Console.WriteLine($"NUMBER = {numFuncionario}\nSALARY = U$ {salario:F2}");

    }

}