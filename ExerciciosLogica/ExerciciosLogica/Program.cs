using System;
using System.Collections.Generic;

using ExercicioLogica;
using ExerciciosLogica.Logica;

namespace ExercicioLogica
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Verificar se o número é crescente ou decrescente", NumeroCrescenteDecrescente.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}