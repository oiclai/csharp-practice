using System; 

class URI 
{
    static void Main(string[] args) 
    { 
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float c = float.Parse(Console.ReadLine());
        
        float media = ((a * 2f) + (b * 3f) + (c * 5f))/10f;
        Console.WriteLine($"MEDIA = {media:F1}");
    }

}