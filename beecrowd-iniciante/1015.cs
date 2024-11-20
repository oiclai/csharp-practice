using System;

class Program
{
    static void Main()
    {

        string[] valores1 = Console.ReadLine().Split(' ');
        float x1 = float.Parse(valores1[0]);
        float y1 = float.Parse(valores1[1]);
        string[] valores2 = Console.ReadLine().Split(' ');
        float x2 = float.Parse(valores2[0]);
        float y2 = float.Parse(valores2[1]);

        float calculo = (float)Math.Sqrt(
    (float)Math.Pow((x2 - x1), 2) + 
    (float)Math.Pow((y2 - y1), 2)
    );

        Console.WriteLine(calculo.ToString("F4"));
    }
}