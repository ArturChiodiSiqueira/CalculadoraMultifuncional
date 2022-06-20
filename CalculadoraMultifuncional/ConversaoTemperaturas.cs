using System;
namespace CalculadoraMultifuncional
{
    internal class ConversaoTemperaturas
    {
        public void ConverterTemperatura()
        {
            Console.WriteLine("se a temperatura que deseja converter estiver em °C, °F ou K...");
            Console.WriteLine("informe (1) para °C, (2) para °F ou (3) para K");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:

                    break;
            }
        }
    }
}
