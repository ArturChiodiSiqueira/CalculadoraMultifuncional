using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraMultifuncional
{
    internal class OperacaoAvancada
    {
        public void EquacaoSegundoGrau()
        {
            double a, b, c, delta, x1, x2;

            Console.WriteLine("\nSENDO A ESTRUTURA BÁSICA DE UMA EQUAÇÃO DE SEGUNDO GRAU: aX² + bX + c = 0");
            Console.WriteLine("informe os números das posições [a], [b] e [c] respectivamente:");

            string[] vetor = Console.ReadLine().Split(' ');

            a = double.Parse(vetor[0]);
            b = double.Parse(vetor[1]);
            c = double.Parse(vetor[2]);

            Console.WriteLine("\nO PROGRAMA IRÁ REALIZAR A EQUAÇÃO (" + a + "X² + " + b + "X + " + c + " = 0)\n");

            delta = (b * b) - (4 * a * c);

            if (a == 0.0 || delta < 0.0)
            {
                Console.WriteLine("IMPOSSIVEL CALCULAR");
            }
            else
            {
                x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
                Console.WriteLine("Os possíveis valores de X são:");
                Console.WriteLine("X1 = " + x1.ToString("F3"));
                Console.WriteLine("X2 = " + x2.ToString("F3"));
            }
            Console.WriteLine("\n\n pressione qualquer tecla para retornar ao menu");
            Console.ReadKey();
        }

        public void CalcularFatorial()
        {
            int numero;
            long resultadoFatorial;

            Console.WriteLine("\nescreva o número  ser calculado o fatorial:");
            numero = int.Parse(Console.ReadLine());

            resultadoFatorial = Fatorial(numero);
            Console.WriteLine("\n O RESULTADO DE " + numero + "! É: " + resultadoFatorial);

            static int Fatorial(int numero)
            {
                if (numero == 0)
                {
                    return 1;
                }
                else
                {
                    return ((numero) * (Fatorial(numero - 1)));
                }
            }
            Console.WriteLine("\n\n pressione qualquer tecla para retornar ao menu");
            Console.ReadKey();
        }
        
        public void SequenciaFibonacci()
        {
            int parada, numeroAnterior;
            int numero = 0, numeroPosterior = 1;

            Console.WriteLine("\ninforme o número de parada:");
            parada = int.Parse(Console.ReadLine());

            Console.WriteLine("\n0\n1");

            for (int i = 0; i < parada; i++)
            {
                numeroAnterior = numero;
                numero = numeroPosterior;
                numeroPosterior = numero + numeroAnterior;
                Console.WriteLine(numeroPosterior);
            }
            Console.WriteLine("\n\n pressione qualquer tecla para retornar ao menu");
            Console.ReadKey();
        }

        public void CalcularMedia()
        {
            int quantidadeNumeros;
            double soma = 0.0, numero, media;

            Console.Write("\ninforme a quantidade de números para realizar a média: ");
            quantidadeNumeros = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantidadeNumeros; i++)
            {
                Console.Write("\tNúmero #{0}: ", i);
                numero = double.Parse(Console.ReadLine());

                soma += numero;
            }
            media = soma / quantidadeNumeros;
            Console.WriteLine("\n A MÉDIA DOS NUMEROS É = " + media.ToString("F3"));

            Console.WriteLine("\n\n pressione qualquer tecla para retornar ao menu");
            Console.ReadKey();
        }
    }
}
