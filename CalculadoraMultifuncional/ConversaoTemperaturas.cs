using System;
namespace CalculadoraMultifuncional
{
    internal class ConversaoTemperaturas
    {
        public void ConverterTemperatura()
        {
            Console.WriteLine("\nse a temperatura que deseja converter estiver em °C, °F ou K...");
            Console.Write("informe (1) para °C, (2) para °F ou (3) para K: ");
            int opcao = int.Parse(Console.ReadLine());
            int opcaoConvertida;
            double graus, celsius, farenheit, kelvin;

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("\nsua temperatura está em °C!!");
                    Console.Write("informe a escala termométrica a ser convertida (1) para °F ou (2) para K: ");
                    opcaoConvertida = int.Parse(Console.ReadLine());
                    if (opcaoConvertida < 1 || opcaoConvertida > 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opção inválida!!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (opcaoConvertida == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\n°C -> °F\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Quantos graus deseja converter? ");
                        graus = double.Parse(Console.ReadLine());
                        farenheit = graus * 1.8 + 32;
                        Console.WriteLine(graus + "°C -> °F = " + farenheit.ToString("F2") + "°F");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\n°C -> K\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Quantos graus deseja converter? ");
                        graus = double.Parse(Console.ReadLine());
                        kelvin = graus + 273;
                        Console.WriteLine(graus + "°C -> K = " + kelvin.ToString("F2") + "K");
                    }
                    break;

                case 2:
                    Console.WriteLine("\nsua temperatura está em °F!!");
                    Console.Write("informe a escala termométrica a ser convertida (1) para °C ou (2) para K: ");
                    opcaoConvertida = int.Parse(Console.ReadLine());
                    if (opcaoConvertida < 1 || opcaoConvertida > 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opção inválida!!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (opcaoConvertida == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\n°F -> °C\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Quantos graus deseja converter? ");
                        graus = double.Parse(Console.ReadLine());
                        celsius = (graus - 32) / 1.8;
                        Console.WriteLine(graus + "°F -> °C = " + celsius.ToString("F2") + "°C");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\n°F -> K\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Quantos graus deseja converter? ");
                        graus = double.Parse(Console.ReadLine());
                        kelvin = (graus - 32) * (5/9) + 273;
                        Console.WriteLine(graus + "°F -> K = " + kelvin.ToString("F2") + "K");
                    }
                    break;

                case 3:
                    Console.WriteLine("\nsua temperatura está em K!!");
                    Console.Write("informe a escala termométrica a ser convertida (1) para °C ou (2) para °F: ");
                    opcaoConvertida = int.Parse(Console.ReadLine());
                    if (opcaoConvertida < 1 || opcaoConvertida > 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opção inválida!!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (opcaoConvertida == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\nK -> °C\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Quantos graus deseja converter? ");
                        graus = double.Parse(Console.ReadLine());
                        celsius = graus - 273;
                        Console.WriteLine(graus + "K -> °C = " + celsius.ToString("F2") + "°C");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\nK -> °F\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Quantos graus deseja converter? ");
                        graus = double.Parse(Console.ReadLine());
                        farenheit = (graus - 273) * (1.8) + 32;
                        Console.WriteLine(graus + "K -> °F = " + farenheit.ToString("F2") + "°F");
                    }
                    break;
            }
            Console.WriteLine("\n\n pressione qualquer tecla para retornar ao menu");
            Console.ReadKey();
        }
    }
}
