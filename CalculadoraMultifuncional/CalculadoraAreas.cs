using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraMultifuncional
{
    internal class CalculadoraAreas
    {
        #region círculo
        public void CalcularCirculo()
        {
            double areaCirculo, raio;
            Console.WriteLine("\nsabendo que a área do circulo é (PI * r²)");
            Console.WriteLine("Entre com a medida do raio do circulo que deseja calcular:");
            raio = double.Parse(Console.ReadLine());
            areaCirculo = Math.PI * Math.Pow(raio, 2);

            Console.WriteLine("\nA ÁREA DO CIRCULO É: " + areaCirculo.ToString("F3"));

            Console.WriteLine("\n\n pressione qualquer tecla para retornar ao menu");
            Console.ReadKey();
        }

        public void CompararCirculos()
        {
            double raioX, raioY, areaCirculoX, areaCirculoY;

            Console.WriteLine("\nsabendo que a área do circulo é (PI * r²)");
            Console.WriteLine("Entre com a medida do raio do circulo X para calcular a área:");
            raioX = double.Parse(Console.ReadLine());
            areaCirculoX = Math.PI * Math.Pow(raioX, 2);

            Console.WriteLine("\nEntre com a medida do raio do circulo Y para calcular a área:");
            raioY = double.Parse(Console.ReadLine());
            areaCirculoY = Math.PI * Math.Pow(raioY, 2);

            Console.WriteLine("\nA área de X = " + areaCirculoX.ToString("F3"));
            Console.WriteLine("A área de Y = " + areaCirculoY.ToString("F3"));

            if (areaCirculoX > areaCirculoY)
            {
                Console.WriteLine("MAIOR ÁREA: X");
            }
            else if (areaCirculoY > areaCirculoX)
            {
                Console.WriteLine("MAIOR ÁREA: Y");
            }
            else
            {
                Console.WriteLine("AS ÁREAS SÃO IGUAIS!");
            }
            Console.WriteLine("\n\n pressione qualquer tecla para retornar ao menu");
            Console.ReadKey();
        }
        #endregion

        #region triangulo
        public void CalcularTriangulo()
        {
            double ladoA, ladoB, ladoC;
            Console.WriteLine("\nEntre com a medida dos lados (a) (b) (c) do triângulo: ");
            ladoA = double.Parse(Console.ReadLine());
            ladoB = double.Parse(Console.ReadLine());
            ladoC = double.Parse(Console.ReadLine());

            if ((ladoA < ladoB + ladoC) && (ladoB < ladoA + ladoC) && (ladoC < ladoA + ladoB))
            {
                double semiPerimetro = (ladoA + ladoB + ladoC) / 2.0;
                double areaTriangulo = Math.Sqrt(semiPerimetro * (semiPerimetro - ladoA) * (semiPerimetro - ladoB) * (semiPerimetro - ladoC));
                Console.WriteLine("\nA ÁREA DO TRIÂNGULO É: " + areaTriangulo.ToString("F3"));
            }
            else
            {
                Console.Write("\nAS MEDIDAS INFORMADAS NÃO FORMAM UM TRIÂNGULO!!");
            }
            Console.WriteLine("\n\n pressione qualquer tecla para retornar ao menu");
            Console.ReadKey();
        }

        public void CompararTriangulos()
        {
            double xLadoA, xLadoB, xLadoC, yLadoA, yLadoB, yLadoC;

            Console.WriteLine("\nEntre com a medida dos lados (a) (b) (c) do triângulo X: ");
            xLadoA = double.Parse(Console.ReadLine());
            xLadoB = double.Parse(Console.ReadLine());
            xLadoC = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com a medida dos lados (a) (b) (c) do triângulo Y: ");
            yLadoA = double.Parse(Console.ReadLine());
            yLadoB = double.Parse(Console.ReadLine());
            yLadoC = double.Parse(Console.ReadLine());

            double semiPerimetro = (xLadoA + xLadoB + xLadoC) / 2.0;
            double areaTrianguloX = Math.Sqrt(semiPerimetro * (semiPerimetro - xLadoA) * (semiPerimetro - xLadoB) * (semiPerimetro - xLadoC));

            semiPerimetro = (yLadoA + yLadoB + yLadoC) / 2.0;
            double areaTrianguloY = Math.Sqrt(semiPerimetro * (semiPerimetro - yLadoA) * (semiPerimetro - yLadoB) * (semiPerimetro - yLadoC));

            Console.WriteLine("A área de X = " + areaTrianguloX.ToString("F3"));
            Console.WriteLine("A área de Y = " + areaTrianguloY.ToString("F3"));

            if (areaTrianguloX > areaTrianguloY)
            {
                Console.WriteLine("MAIOR ÁREA: X");
            }
            else if (areaTrianguloY > areaTrianguloX)
            {
                Console.WriteLine("MAIOR ÁREA: Y");
            }
            else
            {
                Console.WriteLine("AS ÁREAS SÃO IGUAIS!");
            }
            Console.WriteLine("\n\n pressione qualquer tecla para retornar ao menu");
            Console.ReadKey();
        }
        #endregion

        #region quadrado
        public void CalcularQuadrado()
        {
            double lado1, lado2, areaQuadrado;

            Console.WriteLine("\nEntre com a medida dos lados 1 e 2 do quadrado:");
            lado1 = double.Parse(Console.ReadLine());
            lado2 = double.Parse(Console.ReadLine());

            if (lado1 < 0.0 || lado2 < 0.0)
            {
                Console.WriteLine("\nA ÁREA NÃO PODE SER NEGATIVA!!");
            }
            else
            {
                areaQuadrado = lado1 * lado2;
                Console.WriteLine("\nA ÁREA DO QUADRADO É " + areaQuadrado.ToString("F3"));
            }
            Console.WriteLine("\n\n pressione qualquer tecla para retornar ao menu");
            Console.ReadKey();
        }

        public void CompararQuadrados()
        {
            double xLado1, xLado2, yLado1, yLado2, areaQuadradoX, areaQuadradoY;

            Console.WriteLine("\nEntre com a medida dos lados 1 e 2 do quadrado X: ");
            xLado1 = double.Parse(Console.ReadLine());
            xLado2 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nEntre com a medida dos lados 1 e 2 do quadrado Y: ");
            yLado1 = double.Parse(Console.ReadLine());
            yLado2 = double.Parse(Console.ReadLine());

            areaQuadradoX = xLado1 * xLado2;
            areaQuadradoY = yLado1 * yLado2;

            Console.WriteLine("\nA área de X = " + areaQuadradoX.ToString("F3"));
            Console.WriteLine("A área de Y = " + areaQuadradoY.ToString("F3"));

            if (areaQuadradoX > areaQuadradoY)
            {
                Console.WriteLine("MAIOR ÁREA: X");
            }
            else if (areaQuadradoY > areaQuadradoX)
            {
                Console.WriteLine("MAIOR ÁREA: Y");
            }
            else
            {
                Console.WriteLine("AS ÁREAS SÃO IGUAIS!");
            }
            Console.WriteLine("\n\n pressione qualquer tecla para retornar ao menu");
            Console.ReadKey();
        }
        #endregion
    }
}
