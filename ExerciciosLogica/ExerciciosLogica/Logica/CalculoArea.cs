using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExerciciosLogica.Logica
{
    class CalculoArea
    {
        public static void Executar()
        {
            double b, a, area, perimetro, diagonal;
            Console.Write("Digite o valor da base: ");
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o valor da altura: ");
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = b * a;
            perimetro = 2 * (b + a);
            diagonal = Math.Sqrt(Math.Pow(b, 2.0) + Math.Pow(a, 2.0));

            Console.WriteLine($"Area = {area.ToString("F4", CultureInfo.InvariantCulture) }");
            Console.WriteLine($"Perimetro = {perimetro.ToString("F4", CultureInfo.InvariantCulture) }");
            Console.WriteLine($"Diagonal = {diagonal.ToString("F4", CultureInfo.InvariantCulture) }");
        }
    }
}
