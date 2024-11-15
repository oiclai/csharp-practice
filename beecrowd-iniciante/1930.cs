using System;
using System.Linq;

namespace URI {
    class Program {
        static void Main(string[] args) {
            int[] reguas = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int aparelhosJuntos = reguas[0];

            for (int i = 1; i < reguas.Length; i++) {
                aparelhosJuntos += (reguas[i] - 1);
            }            

            Console.WriteLine(aparelhosJuntos);
        } 
    }
}

