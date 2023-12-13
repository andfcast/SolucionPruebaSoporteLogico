using System;

namespace PosicionMatriz
{
    internal class Program
    {
        static int[] arrNumeros = { 1, 2, -1, 1, 0, 1, 2, -1, -1, -2 };        
        static void Main(string[] args)
        {
            if (arrNumeros.Length % 2 != 0) {
                Console.ReadLine();
                return;
            }                
            int x = 0; 
            int y = 0;

            for (int i = 0; i < arrNumeros.Length - 1; i += 2) {
                x = x + arrNumeros[i];
                if (x < 0)
                {
                    x = 0;
                }
                if (x > 3)
                {
                    x = 3;
                }
                y = y + arrNumeros[i + 1];
                if (y < 0)
                {
                    y = 0;
                }
                if (y > 3)
                {
                    y = 3;
                }
            }

            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (i == x && j == y)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write("O");
                    }

                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
