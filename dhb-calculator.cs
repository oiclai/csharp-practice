using System;
using System.Collections.Generic;

namespace Programa.Iniciante {
    class DhbCalculator {
        public string DecimalToHexadecimal(string number) {
            Dictionary<int, char> hexadecimal = new Dictionary<int, char> {
                { 0, '0' }, { 1, '1' }, { 2, '2' }, { 3, '3' }, { 4, '4' }, { 5, '5' },
                { 6, '6' }, { 7, '7' }, { 8, '8' }, { 9, '9' }, { 10, 'a' }, { 11, 'b' },
                { 12, 'c' }, { 13, 'd' }, { 14, 'e' }, { 15, 'f' }
            };
            List<int> storeRest = new List<int>();
            str
            int initialNumber = number;
            while (number > 0) {
                int remainder = number % 16;
                storeRest.Add(remainder);
                number /= 16;
            }
            storeRest.Reverse(); //inverter lista
            string result = "";
            foreach (int value in storeRest) {
                result += hexadecimal[value];
            }
            return $"{initialNumber} {result}";
        }
    }
    class Program {
        static void Main(string[] args) {

            string number = int.Parse(Console.ReadLine());
            Console.WriteLine(@"
            --------- MENU DE OPÇÕES ---------
                [1] Binário para Decimal
                [2] Binário para Hexadecimal
                [3] Decimal para Binário
                [4] Decimal para Hexadecimal
                [5] Hexadecimal para Binário
                [6] Hexadecimal para Decimal
            ----------------------------------
            ");
            Console.Write("Opção: ");
            Console.ReadLine();
            switch (number)
            {
                case 1:
                    Console.WriteLine("Opção 1: Decimal para Hexadecimal");
                    break;
                case 2:
                    Console.WriteLine("Opção 2: Decimal para Binário");
                    break;
                case 3:
                    Console.WriteLine("Opção 3: Outra conversão");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
            DhbCalculator dhbCalculator = new DhbCalculator();
            Console.WriteLine(dhbCalculator.DecimalToHexadecimal(number));
        }
    }
}
