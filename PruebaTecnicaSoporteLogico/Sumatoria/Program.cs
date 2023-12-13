using System;
using System.Runtime.CompilerServices;

namespace Sumatoria
{
    internal class Program
    {
        static int[] arrNumeros = { 1, 2, 3, 2, 7, 0 };
        static void Main(string[] args)
        {
            EncontrarSumatoria(10);
            Console.ReadLine();
        }

        private static void EncontrarSumatoria(int total) {
            int primerValor = 0;
            int segundoValor = 0;
            for(int i = 0; i < arrNumeros.Length -1; i++)
            {
                primerValor = arrNumeros[i];
                for (int j = i + 1; j < arrNumeros.Length; j++) {
                    segundoValor = arrNumeros[j];
                    if (primerValor + segundoValor == total){
                        Console.WriteLine(primerValor + " " + segundoValor);
                        j = arrNumeros.Length;
                        i = arrNumeros.Length;
                    }
                }
            }
        }
    }
}
