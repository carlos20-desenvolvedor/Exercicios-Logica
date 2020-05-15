using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosLogica.Logica
{
    class NumeroCrescenteDecrescente
    {
        public static void Executar()
        {
            int x, y;
            string[] vet = Console.ReadLine().Split(" ");
            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);

            while (x != y)
            {
                if (x < y)
                {
                    Console.WriteLine("Crescente");
                }
                else
                {
                    Console.WriteLine("Decrescente");
                }
                vet = Console.ReadLine().Split(" ");
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);
            }
        }
    }
}
