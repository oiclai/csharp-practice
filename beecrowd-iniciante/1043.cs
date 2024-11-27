using System; 

class URI {
    
    public static string AreaOuPerimetro (float a, float b, float c){
      if ((a<b+c) && (b<a+c) && (c<a+b)){
        float perimetro = a + b + c;
        return $"Perimetro = {perimetro:F1}";
      }
      else{
        float area = ((a+b)*c)/2f;
        return $"Area = {area:F1}";
      }
    }
    
    
    static void Main(string[] args) { 

        string [] valores = Console.ReadLine().Split(' ');
        float a = float.Parse(valores[0]);
        float b = float.Parse(valores[1]);
        float c = float.Parse(valores[2]);
        var resultado = AreaOuPerimetro(a, b, c);
        Console.WriteLine(resultado);
        
    }

}
