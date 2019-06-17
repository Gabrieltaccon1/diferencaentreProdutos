using System;

namespace diferencadeProdutos
{
    class Program
    {
        static void Main(string[] args)
        {

            double valorA, valorB, valorC, valorD, diferença;


            Console.WriteLine("DIGITE O PRIMEIRO VALOR");
            valorA = double.Parse(Console.ReadLine());


            Console.WriteLine("DIGITE O SEGUNDO VALOR");
            valorB = double.Parse(Console.ReadLine());

            Console.WriteLine("DIGITE O TERCEIRO VALOR");
            valorC = double.Parse(Console.ReadLine());


            Console.WriteLine("DIGITE O QUARTO VALOR");
            valorD = double.Parse(Console.ReadLine());


            diferença = ((valorA * valorB) - (valorC * valorD));




            Console.WriteLine("DIFERENÇA = " + diferença.ToString("F0", CultureInfo.InvariantCulture));


        }
    }
}
