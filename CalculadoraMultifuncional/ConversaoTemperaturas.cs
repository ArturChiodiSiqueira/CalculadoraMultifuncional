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
            int opcaoConvertida;
            double graus, celsius, farenheit, kelvin;

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("sua temperatura está em °C!!");
                    Console.Write("informe a escala termométrica a ser convertida (1) para °F ou (2) para K: ");
                    opcaoConvertida = int.Parse(Console.ReadLine());
                    if (opcaoConvertida < 1 || opcaoConvertida > 2)
                    {
                        Console.WriteLine("Opção inválida!!");
                    }
                    else if (opcaoConvertida == 1)
                    {
                        Console.WriteLine("°C -> °F");
                        Console.WriteLine("Quantos graus deseja converter?");
                        graus = double.Parse(Console.ReadLine());
                        farenheit = graus * 1.8 + 32;
                        Console.WriteLine(graus + "°C -> °F = " + farenheit.ToString("F2") + "°F");
                    }
                    else
                    {
                        Console.WriteLine("°C -> K");
                        Console.WriteLine("Quantos graus deseja converter?");
                        graus = double.Parse(Console.ReadLine());
                        kelvin = graus + 273;
                        Console.WriteLine(graus + "°C -> K = " + kelvin.ToString("F2") + "K");
                    }
                    break;

                case 2:
                    Console.WriteLine("sua temperatura está em °F!!");
                    Console.Write("informe a escala termométrica a ser convertida (1) para °C ou (2) para K: ");
                    opcaoConvertida = int.Parse(Console.ReadLine());
                    if (opcaoConvertida < 1 || opcaoConvertida > 2)
                    {
                        Console.WriteLine("Opção inválida!!");
                    }
                    else if (opcaoConvertida == 1)
                    {
                        Console.WriteLine("°F -> °C");
                        Console.WriteLine("Quantos graus deseja converter?");
                        graus = double.Parse(Console.ReadLine());
                        celsius = (graus - 32) / 1.8;
                        Console.WriteLine(graus + "°F -> °C = " + celsius.ToString("F2") + "°C");
                    }
                    else
                    {
                        Console.WriteLine("°F -> K");
                        Console.WriteLine("Quantos graus deseja converter?");
                        graus = double.Parse(Console.ReadLine());
                        kelvin = (graus - 32) * (5/9) + 273;
                        Console.WriteLine(graus + "°F -> K = " + kelvin.ToString("F2") + "K");
                    }
                    break;

                case 3:
                    Console.WriteLine("sua temperatura está em K!!");
                    Console.Write("informe a escala termométrica a ser convertida (1) para °C ou (2) para °F: ");
                    opcaoConvertida = int.Parse(Console.ReadLine());
                    if (opcaoConvertida < 1 || opcaoConvertida > 2)
                    {
                        Console.WriteLine("Opção inválida!!");
                    }
                    else if (opcaoConvertida == 1)
                    {
                        Console.WriteLine("K -> °C");
                        Console.WriteLine("Quantos graus deseja converter?");
                        graus = double.Parse(Console.ReadLine());
                        celsius = graus - 273;
                        Console.WriteLine(graus + "K -> °C = " + celsius.ToString("F2") + "°C");
                    }
                    else
                    {
                        Console.WriteLine("K -> °F");
                        Console.WriteLine("Quantos graus deseja converter?");
                        graus = double.Parse(Console.ReadLine());
                        farenheit = (graus - 273) * (1.8) + 32;
                        Console.WriteLine(graus + "K -> °F = " + farenheit.ToString("F2") + "°F");
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}
