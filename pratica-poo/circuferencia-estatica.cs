using System;
using System.Globalization;
// membros estaticos == membro da classe (e nao da instancia)
namespace Course {
    class Program {
        static double PI = 3.14;
        public static void Main(string[] args) {
            Console.Write("Entre o raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);  
            double circ = Circunferencia(raio);
            deouble volume = Volume(raio);
            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume:" + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("valor de PI: " + PI.ToString("F2", CultureInfo.InvariantCulture));
        }

        public static double Circunferencia(double raio) {
            return 2.0 * PI * raio;
        }

        public static double Volume(double raio) {
            return 4.0 / 3.0 * PI * raio * raio * raio;
        }
    }
}