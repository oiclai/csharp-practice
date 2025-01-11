using System;
using System.Collections.Generic;

namespace Programa.Iniciante {
    class DhbCalculator {
        public string DecimalToHexadecimal(int number) {
            Dictionary<int, char> hexadecimal = new Dictionary<int, char> {
                { 0, '0' }, { 1, '1' }, { 2, '2' }, { 3, '3' }, { 4, '4' }, { 5, '5' },
                { 6, '6' }, { 7, '7' }, { 8, '8' }, { 9, '9' }, { 10, 'a' }, { 11, 'b' },
                { 12, 'c' }, { 13, 'd' }, { 14, 'e' }, { 15, 'f' }
            };

            List<int> storeRest = new List<int>();
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
            int number = int.Parse(Console.ReadLine());
            DhbCalculator dhbCalculator = new DhbCalculator();
            Console.WriteLine(dhbCalculator.DecimalToHexadecimal(number));
        }
    }
}
