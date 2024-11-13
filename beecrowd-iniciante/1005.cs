using System;

class URI
{
    static void Main(string[] args)
    {
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());

        float media = ((a * 3.5f) + (b * 7.5f))/11f;

        Console.WriteLine($"MEDIA = {media:F5}");
    }
}