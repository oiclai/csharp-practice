using System;

namespace URI
{
	public class Program
	{
		public static void Main(string[] args)
		{
		  string [] horas = Console.ReadLine().Split(" ");
		  int horaInicial = int.Parse(horas[0]);
		  int minutoInicial = int.Parse(horas[1]);
		  int horaFinal = int.Parse(horas[2]);
		  int minutoFinal = int.Parse(horas[3]);
		  int totalMinutoInicio = horaInicial*60 + minutoInicial;
		  int totalMinutoFinal = horaFinal*60 + minutoFinal;
		  int duracaoMinutos = totalMinutoFinal - totalMinutoInicio;
		  if (duracaoMinutos<=0){
		    duracaoMinutos += 24*60;
		  }
		  int duracaoHoras = duracaoMinutos/60;
		  duracaoMinutos = duracaoMinutos%=60;
		  Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", duracaoHoras, duracaoMinutos);
		}
	}
}