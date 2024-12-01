using System;

namespace URI
{
	public class Program
	{
		public static void Main(string[] args)
		{
		  string [] horas = Console.ReadLine().Split(" ");
		  int horaInicial = int.Parse(horas[0]);
		  int horaFinal = int.Parse(horas[1]);
		  int duracaoTotal = 1;
		  if (horaFinal <= horaInicial){
		    duracaoTotal = (horaFinal+24) - horaInicial;
		  }else {
		    duracaoTotal = horaFinal - horaInicial;
		  }
		  Console.WriteLine("O JOGO DUROU {0} HORA(S)", duracaoTotal);
		}
	}
}