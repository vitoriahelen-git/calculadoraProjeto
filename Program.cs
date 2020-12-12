using System;
using Figgle; 

namespace ETEC_PC1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá usuário\n");
            double valorUs;
            double valorUS2;
            string menuUsario = "";
            int contator = 1;

            while(contator > 0) {

                Console.WriteLine("\nMenu de opções\n");
                Console.WriteLine("--------------\n");
                Console.WriteLine("Escolha a operação que deseja executar:");
                Console.WriteLine("1. Soma");
                Console.WriteLine("2. Subtração");
                Console.WriteLine("3. Multiplicação");
                Console.WriteLine("4. Divisão");
                Console.WriteLine("5. Exponeciação");
                Console.WriteLine("6. Radiação");
                Console.WriteLine("X. Sair");
                Console.WriteLine("S. Sobre\n");

                Console.Write("\nDigite a sua opção: ");
                menuUsario = Console.ReadLine();

            switch (menuUsario.ToUpper())
            {
                case "1":
                    Console.WriteLine($"\nOPÇÃO SELECIONADA: Soma \n");
                    Console.WriteLine("Digite os números: \n");
                    Console.Write("Primeiro valor: ");
                    valorUs = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Segundo valor: ");
                    valorUS2 = Convert.ToInt32(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Green; 
                    Console.Write("\nResultado: " + (valorUs + valorUS2) + "\n\n");
                    Console.ResetColor(); 
                    Console.Write("Pressione qualquer tecla para continuar");
                    Console.ReadKey();
                    break;
                case "2":
                    Console.WriteLine($"\nOPÇÃO SELECIONADA: Subtração \n\n");
                    Console.WriteLine("Digite os números: \n");
                    Console.Write("Primeiro valor: ");
                    valorUs = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Segundo valor: ");
                    valorUS2 = Convert.ToInt32(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nResultado: " + (valorUs - valorUS2) + "\n\n");
                    Console.ResetColor();

                    Console.Write("Pressione qualquer tecla para continuar");
                    Console.ReadKey();
                    break;
                case "3":
                    Console.WriteLine($"\nOPÇÃO SELECIONADA: Multiplicação \n\n");
                    Console.WriteLine("Digite os números: \n");
                    Console.Write("Primeiro valor: ");
                    valorUs = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Segundo valor: ");
                    valorUS2 = Convert.ToInt32(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nResultado: " + (valorUs * valorUS2) + "\n\n");
                    Console.ResetColor();

                    Console.Write("Pressione qualquer tecla para continuar");
                    Console.ReadKey();
                    break;
                case "4":
                    Console.WriteLine($"\nOPÇÃO SELECIONADA: Divisão \n");
                    Console.WriteLine("Digite os números: \n");
                    Console.Write("Primeiro valor: ");
                    valorUs = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Segundo valor: ");
                    valorUS2 = Convert.ToInt32(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nResultado: " + (valorUs / valorUS2) + "\n\n");
                    Console.ResetColor();

                    Console.Write("Pressione qualquer tecla para continuar");
                    Console.ReadKey();
                    break;
                case "5":
                    Console.WriteLine($"\nOPÇÃO SELECIONADA: Exponenciação");
                    Console.WriteLine("Digite os números: \n");
                    Console.Write("Primeiro valor: ");
                    valorUs = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite a potencia desejada: ");
                    valorUS2 = Convert.ToDouble(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine("\nResultado: " + (Math.Pow(valorUs, valorUS2)) + "\n\n");
                    Console.ResetColor();

                    Console.Write("Pressione qualquer tecla para continuar");
                    Console.ReadKey();
                    break;
                case "6":
                    Console.WriteLine($"\nOPÇÃO SELECIONADA: Radiação");
                    Console.WriteLine("Digite os némeros: \n"); 
                    Console.Write("Digite a raiz desejada: ");
                    valorUs = Convert.ToInt32(Console.ReadLine()); 
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine("\nResultado: " + Math.Sqrt(valorUs) + "\n\n"); 
                    Console.ResetColor();

                    Console.Write("Pressione qualquer tecla para continuar");
                    Console.ReadKey();
                    break;
                case "X":
                    Console.WriteLine($"\nOPÇÃO SELECIONADA: Sair \n");
                    contator = 0;
                    Console.WriteLine("--Agradeço por ter feito uso do meu programa!\n");
                    break;
                case "S":
                    Console.WriteLine($"\nOPÇÃO SELECIONADA: Sobre\n"); 
                    Console.WriteLine("Nome: Viória Helen Veloso.");
                    Console.WriteLine("Idade: 18 anos"); 
                    Console.WriteLine("Estudante da ETEC Adolpho Brezin, cursando atualmente informática."); 
                    Console.WriteLine("Objetivo: Ampliar os meus conhecimentos na área de programação"); 
                    Console.WriteLine("Link projeto: https://github.com/vitoriahelen-git/calculadoraProjeto\n\n");
                    
                    Console.Write("Pressione qualquer tecla para continuar");
                    Console.ReadKey();
                    break; 
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção inválida!");
                    Console.ResetColor();
                    Console.WriteLine("Pressione uma tecla qualquer para voltar ao Menu.");
                    Console.ReadKey();   
                    break;
                }
            }

            

        }
    }
}
