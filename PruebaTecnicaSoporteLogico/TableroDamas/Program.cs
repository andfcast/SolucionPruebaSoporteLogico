using System;

namespace TableroDamas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dimension;            
            do
            {                
                Console.WriteLine("Por favor ingrese el tamaño del tablero a crear: (Debe ser un número de 1 a 10)");               
            } while (!Int32.TryParse(Console.ReadLine(), out dimension));
            if (dimension < 1 || dimension > 10) {
                dimension = 7;
            }
            CrearTablero(dimension);
            Console.ReadLine();
        }

        private static void CrearTablero(int n) {            
            int cont = 1;
            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++) {
                    if (cont % 2 == 1)
                        Console.Write("X");
                    else
                        Console.Write("_");
                    cont++;
                }
                Console.WriteLine();
            }
        }
    }
}
