using System;
using Alura.LeilaoOnline.Core;

namespace Alura.LeilaoOnline.ConsoleApp
{
    class Program
    {
        

        static void Main()
        {
            //LeilaoComVariosLances();
            //LeilaoComApenasUmLance();
            
        }

        public void Verifica(double esperado, double obtido)
        {
            var cor = Console.ForegroundColor;
            if (esperado == obtido)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("TESTE OK");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(
                    $"TESTE FALHOU! Esperado: {esperado}, obtido: {obtido}.");
            }
            Console.ForegroundColor = cor;
        }

    }
}
