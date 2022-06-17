using System;

namespace CalculadoraMultifuncional
{
    internal class OperacaoBasica
    {
        public double Numero1 { get; set; }
        public double Numero2 { get; set; }
        public double Somar { get; set; }
        public double Subtrair { get; set; }
        public double Multiplicar { get; set; }
        public double Dividir { get; set; }
        public double Radiciar { get; set; }
        public double Potenciar { get; set; }

        #region adição
        public void SomarValores()
        {
            Console.WriteLine("\ninforme abaixo os números que deseja somar:");
            Numero1 = double.Parse(Console.ReadLine());
            Numero2 = double.Parse(Console.ReadLine());

            Console.WriteLine("\no programa irá realizar a soma: " + Numero1 + " + " + Numero2);
            Somar = Numero1 + Numero2;

            Console.WriteLine("\nO RESULTADO DA SOMA (" + Numero1 + " + " + Numero2 + ") É: " + Somar);

            Console.WriteLine("\n\n pressione qualquer tecla para retornar ao menu");
            Console.ReadKey();
        }
        #endregion

        #region subtração
        public void SubtrairValores()
        {
            Console.WriteLine("\ninforme abaixo os números que deseja subtrair:");
            Numero1 = double.Parse(Console.ReadLine());
            Numero2 = double.Parse(Console.ReadLine());

            Console.WriteLine("\no programa irá realizar a subtração: " + Numero1 + " - " + Numero2);
            Subtrair = Numero1 - Numero2;

            Console.WriteLine("\nO RESULTADO DA SUBTRAÇÃO (" + Numero1 + " - " + Numero2 + ") É: " + Subtrair);

            Console.WriteLine("\n\n pressione qualquer tecla para retornar ao menu");
            Console.ReadKey();
        }
        #endregion

        #region multiplicação
        public void MutiplicarValores()
        {
            Console.WriteLine("\ninforme abaixo os números que deseja multiplicar:");
            Numero1 = double.Parse(Console.ReadLine());
            Numero2 = double.Parse(Console.ReadLine());

            Console.WriteLine("\no programa irá realizar a multiplicação: " + Numero1 + " * " + Numero2);
            Multiplicar = Numero1 * Numero2;

            Console.WriteLine("\nO RESULTADO DA MULTIPLICAÇÃO (" + Numero1 + " * " + Numero2 + ") É: " + Multiplicar);

            Console.WriteLine("\n\n pressione qualquer tecla para retornar ao menu");
            Console.ReadKey();
        }
        #endregion

        #region divisão
        public void DividirValores()
        {
            Console.WriteLine("\ninforme abaixo os números que deseja dividir:");
            Numero1 = double.Parse(Console.ReadLine());
            Numero2 = double.Parse(Console.ReadLine());

            if (Numero2 == 0.0)
            {
                Console.WriteLine("\nNÃO É POSSÍVEL DIVIDIR POR ZERO!!");
            }
            else
            {
                Console.WriteLine("\nO PROGRAMA IRÁ REALIZAR A DIVISÃO: " + Numero1 + " / " + Numero2);
                Dividir = Numero1 / Numero2;

                Console.WriteLine("\nO RESULTADO DA DIVISÃO (" + Numero1 + " / " + Numero2 + ") É: " + Dividir.ToString("F3"));
            }

            Console.WriteLine("\n\n pressione qualquer tecla para retornar ao menu");
            Console.ReadKey();
        }
        #endregion

        #region radiciação
        public void RadiciarValor()
        {
            Console.WriteLine("\ninforme abaixo o número que deseja extrair a raiz quadrada:");
            Numero1 = double.Parse(Console.ReadLine());

            Console.WriteLine("\no programa irá realizar a radiciação de: " + Numero1);
            Radiciar = Math.Sqrt(Numero1);

            Console.WriteLine("\nA RAIZ DE " + Numero1 + " É: " + Radiciar.ToString("F3"));

            Console.WriteLine("\n\n pressione qualquer tecla para retornar ao menu");
            Console.ReadKey();
        }
        #endregion

        #region petenciação
        public void PotenciarValores()
        {
            Console.WriteLine("\ninforme abaixo o numero que deseja elevar e o expoente:");
            Numero1 = double.Parse(Console.ReadLine());
            Numero2 = double.Parse(Console.ReadLine());

            Console.WriteLine("\no programa irá realizar a potenciação: " + Numero1 + " elevado a " + Numero2);
            Potenciar = Math.Pow(Numero1, Numero2);

            Console.WriteLine("\nO RESULTADO DA POTENCIAÇÃO (" + Numero1 + " elevdo a " + Numero2 + ") É: " + Potenciar.ToString("F3"));

            Console.WriteLine("\n\n pressione qualquer tecla para retornar ao menu");
            Console.ReadKey();
        }
        #endregion'
    }
}
