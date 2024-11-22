using System; 

class URI {
  
    public static float calculoMedia(float nota1, float nota2, float nota3, float nota4) {
      
      return (nota1*2f+nota2*3f+nota3*4f+nota4*1f)/10f;
    }
    public static string analiseNota (float mediaPonderada){
      return mediaPonderada == 7 ? "Aluno aprovado." : mediaPonderada < 5 ? "Aluno reprovado." : (mediaPonderada >= 5 && mediaPonderada <= 6.9) ? "Aluno em Exame." : "a" ;
    }
    public static float calculoMediaNova (float mediaPonderada, float notaAdicionada){
      float teste = (mediaPonderada+notaAdicionada)/2f;
      return teste;
    }
    static void Main(string[] args) { 
// pesos 2, 3, 4 e 1
        string [] notas = Console.ReadLine().Split(' ');
        float nota1 = float.Parse(notas[0]);
        float nota2 = float.Parse(notas[1]);
        float nota3 = float.Parse(notas[2]);
        float nota4 = float.Parse(notas[3]);
        var mediaPonderada = calculoMedia(nota1, nota2, nota3, nota4);
        Console.WriteLine($"Media: {mediaPonderada:F1}");
        
        var resultadoAnalise = analiseNota(mediaPonderada);
        Console.WriteLine(resultadoAnalise);
        if (resultadoAnalise == "Aluno em Exame."){
          float notaAdicionada = float.Parse(Console.ReadLine());
          Console.WriteLine("Nota do exame: {notaAdicionada:F1}");
          var mediaFinal = calculoMediaNova(mediaPonderada, notaAdicionada);
          
          if (mediaFinal>= 5.0){
            Console.WriteLine("Aluno aprovado.\nMedia final: {mediaFinal:F1}");
            
          } else{
            Console.WriteLine("Aluno reprovado.\nMedia final: {mediaFinal:F1}");
          }
          
        }
    }
}