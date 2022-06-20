using System;

namespace CalculadoraMultifuncional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "### CALCULADORA ###";
            MenuPrincipal();
        }

        public static int MenuPrincipal()
        {
            int opcao;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("          ESTA É UMA CALCULADORA MULTIFUNCIONAL!!\n");
            Console.WriteLine("       DENTRE AS OPÇÕES NO MENU, QUAL DESEJA EXECUTAR?");
            Console.ForegroundColor = ConsoleColor.White;

            do
            {
                Console.WriteLine("\t|°°°°°°°°°°°°° MENU PRINCIPAL °°°°°°°°°°°°°|");
                Console.WriteLine("\t|  opção 0 : sair                          |");
                Console.WriteLine("\t|                                          |");
                Console.WriteLine("\t|  opção 1 : acessar calculadora básica    |");
                Console.WriteLine("\t|  opção 2 : acessar calculadora avançada  |");
                Console.WriteLine("\t|  opção 3 : acessar calculadora de áreas  |");
                Console.WriteLine("\t|__________________________________________|");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n\tinforme a opção desejada no MENU: ");
                Console.ForegroundColor = ConsoleColor.White;
                opcao = int.Parse(Console.ReadLine());

                if (opcao < 0 || opcao > 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\tOPÇÃO INVALIDA! Para voltar ao menu, pressione QUALQUER TECLA!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                    Console.Clear();
                    MenuPrincipal();
                }
                else
                {
                    switch (opcao)
                    {
                        case 0:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nvocê escolheu sair.");
                            Console.ForegroundColor = ConsoleColor.White;
                            opcao = 0;
                            break;

                        case 1:
                            Console.Clear();
                            MenuBasica();
                            break;

                        case 2:
                            Console.Clear();
                            MenuAvancada();
                            break;

                        case 3:
                            Console.Clear();
                            MenuCalculadoraAreas();
                            break;
                    }
                }
                return opcao;
            } while (opcao != 0);
        }

        public static int MenuBasica()
        {
            int opcao;
            OperacaoBasica selecao = new OperacaoBasica();
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine(" DENTRE AS OPÇÕES NO MENU, QUAL DESEJA EXECUTAR?");
            Console.ForegroundColor = ConsoleColor.White;

            do
            {
                Console.WriteLine("\t|°°°°°°°°°°° MENU °°°°°°°°°°°|");
                Console.WriteLine("\t|  opção 0 : sair            |");
                Console.WriteLine("\t|                            |");
                Console.WriteLine("\t|  opção 1 : adição          |");
                Console.WriteLine("\t|  opção 2 : subtração       |");
                Console.WriteLine("\t|  opção 3 : multiplicação   |");
                Console.WriteLine("\t|  opção 4 : divisão         |");
                Console.WriteLine("\t|  opção 5 : radiciação      |");
                Console.WriteLine("\t|  opção 6 : potenciação     |");
                Console.WriteLine("\t|                            |");
                Console.WriteLine("\t|  opção 7 : MENU PRINCIPAL  |");
                Console.WriteLine("\t|____________________________|");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n\tinforme a opção desejada no MENU: ");
                Console.ForegroundColor = ConsoleColor.White;

                opcao = int.Parse(Console.ReadLine());

                if (opcao < 0 || opcao > 7)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\tOPÇÃO INVALIDA! Para voltar ao menu, pressione QUALQUER TECLA!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                    Console.Clear();
                    MenuBasica();
                }
                else
                {
                    switch (opcao)
                    {
                        case 0:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nvocê escolheu sair.");
                            Console.ForegroundColor = ConsoleColor.White;
                            opcao = 0;
                            break;

                        case 1:
                            selecao.SomarValores();
                            Console.Clear();
                            MenuBasica();
                            break;

                        case 2:
                            selecao.SubtrairValores();
                            Console.Clear();
                            MenuBasica();
                            break;

                        case 3:
                            selecao.MutiplicarValores();
                            Console.Clear();
                            MenuBasica();
                            break;

                        case 4:
                            selecao.DividirValores();
                            Console.Clear();
                            MenuBasica();
                            break;

                        case 5:
                            selecao.RadiciarValor();
                            Console.Clear();
                            MenuBasica();
                            break;

                        case 6:
                            selecao.PotenciarValores();
                            Console.Clear();
                            MenuBasica();
                            break;

                        case 7:
                            Console.Clear();
                            MenuPrincipal();
                            break;
                    }
                }
                return opcao;
            } while (opcao != 0);
        }

        public static int MenuAvancada()
        {
            int opcao;
            OperacaoAvancada selecao = new OperacaoAvancada();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" DENTRE AS OPÇÕES NO MENU, QUAL DESEJA EXECUTAR?");
            Console.ForegroundColor = ConsoleColor.White;

            do
            {
                Console.WriteLine("\t|°°°°°°°°°°°° MENU °°°°°°°°°°°°|");
                Console.WriteLine("\t|  opção 0 : sair              |");
                Console.WriteLine("\t|                              |");
                Console.WriteLine("\t|  opção 1 : bhaskara          |");
                Console.WriteLine("\t|  opção 2 : fatorial          |");
                Console.WriteLine("\t|  opção 3 : fibonacci         |");
                Console.WriteLine("\t|  opção 4 : médias aritmética |");
                Console.WriteLine("\t|                              |");
                Console.WriteLine("\t|  opção 5 : MENU PRINCIPAL    |");
                Console.WriteLine("\t|______________________________|");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n\tinforme a opção desejada no MENU: ");
                Console.ForegroundColor = ConsoleColor.White;

                opcao = int.Parse(Console.ReadLine());

                if (opcao < 0 || opcao > 5)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\tOPÇÃO INVALIDA! Para voltar ao menu, pressione QUALQUER TECLA!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                    Console.Clear();
                    MenuAvancada();
                }
                else
                {
                    switch (opcao)
                    {
                        case 0:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nvocê escolheu sair.");
                            Console.ForegroundColor = ConsoleColor.White;
                            opcao = 0;
                            break;

                        case 1:
                            selecao.EquacaoSegundoGrau();
                            Console.Clear();
                            MenuAvancada();
                            break;

                        case 2:
                            selecao.CalcularFatorial();
                            Console.Clear();
                            MenuAvancada();
                            break;

                        case 3:
                            selecao.SequenciaFibonacci();
                            Console.Clear();
                            MenuAvancada();
                            break;

                        case 4:
                            selecao.CalcularMedia();
                            Console.Clear();
                            MenuAvancada();
                            break;

                        case 5:
                            Console.Clear();
                            MenuPrincipal();
                            break;
                    }
                }
                return opcao;
            } while (opcao != 0);
        }
        
        public static int MenuCalculadoraAreas()
        {
            int opcao;
            CalculadoraAreas selecao = new CalculadoraAreas();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("   DENTRE AS OPÇÕES NO MENU, QUAL DESEJA EXECUTAR?");
            Console.ForegroundColor = ConsoleColor.White;

            do
            {
                Console.WriteLine("\t|°°°°°°°°°°°°°° MENU °°°°°°°°°°°°°°|");
                Console.WriteLine("\t|  opção 0 : sair                  |");
                Console.WriteLine("\t|                                  |");
                Console.WriteLine("\t|  opção 1 : área do circulo       |");
                Console.WriteLine("\t|  opção 2 : área do triangulo     |");
                Console.WriteLine("\t|  opção 3 : área do quadrado      |");
                Console.WriteLine("\t|                                  |");
                Console.WriteLine("\t|  opção 4 : comparar circulos     |");
                Console.WriteLine("\t|  opção 5 : comparar triangulos   |");
                Console.WriteLine("\t|  opção 6 : comparar quadrados    |");
                Console.WriteLine("\t|                                  |");
                Console.WriteLine("\t|  opção 7 : MENU PRINCIPAL        |");
                Console.WriteLine("\t|__________________________________|");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n\tinforme a opção desejada no MENU: ");
                Console.ForegroundColor = ConsoleColor.White;

                opcao = int.Parse(Console.ReadLine());

                if (opcao < 0 || opcao > 7)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\tOPÇÃO INVALIDA! Para voltar ao menu, pressione QUALQUER TECLA!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                    Console.Clear();
                    MenuCalculadoraAreas();
                }
                else
                {
                    switch (opcao)
                    {
                        case 0:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nvocê escolheu sair.");
                            Console.ForegroundColor = ConsoleColor.White;
                            opcao = 0;
                            break;

                        case 1:
                            selecao.CalcularCirculo();
                            Console.Clear();
                            MenuCalculadoraAreas();
                            break;

                        case 2:
                            selecao.CalcularTriangulo();
                            Console.Clear();
                            MenuCalculadoraAreas();
                            break;

                        case 3:
                            selecao.CalcularQuadrado();
                            Console.Clear();
                            MenuCalculadoraAreas();
                            break;

                        case 4:
                            selecao.CompararCirculos();
                            Console.Clear();
                            MenuCalculadoraAreas();
                            break;

                        case 5:
                            selecao.CompararTriangulos();
                            Console.Clear();
                            MenuCalculadoraAreas();
                            break;

                        case 6:
                            selecao.CompararQuadrados();
                            Console.Clear();
                            MenuCalculadoraAreas();
                            break;

                        case 7:
                            Console.Clear();
                            MenuPrincipal();
                            break;
                    }
                }
                return opcao;
            } while (opcao != 0);
        }
    }
}
