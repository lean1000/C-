﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aula2
{
    public class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("═══════════════");
            Console.WriteLine("leandro 212");
            Console.WriteLine("═══════════════");
            Console.WriteLine(@"
░██████╗███████╗███╗░░██╗░█████╗░░█████╗░
██╔════╝██╔════╝████╗░██║██╔══██╗██╔══██╗
╚█████╗░█████╗░░██╔██╗██║███████║██║░░╚═╝
░╚═══██╗██╔══╝░░██║╚████║██╔══██║██║░░██╗
██████╔╝███████╗██║░╚███║██║░░██║╚█████╔╝
╚═════╝░╚══════╝╚═╝░░╚══╝╚═╝░░╚═╝░╚════╝░");
            Console.WriteLine("═══════════════");
            Console.ResetColor();

            ExibirOpcoesMenu();

        }



        public static void ExibirOpcoesMenu()
        {
            Console.WriteLine("\nDigite 1 para registrar informações");
            Console.WriteLine("\nDigite 2 para registrar informações");
            Console.WriteLine("\nDigite 3 para registrar informações");
            Console.WriteLine("\nDigite 0 para sair");
            Console.WriteLine("\nDigite a opção Escolhida:");           
            int opcaoEscolidanumero = int.Parse(Console.ReadLine());
            
            /*if (opcaoEscolidanumero == 2)
            {
                Console.WriteLine("Você escolheu a opição 2");
            }

            if (opcaoEscolidanumero == 1)
            {
                Console.WriteLine("Você escolheu a opição 1");
            }*/

            switch (opcaoEscolidanumero)
            {
                case 1:
                    CadInfo();
                    Console.WriteLine("Você escolheu a opição 1");
                    Thread.Sleep(3000);
                    Console.Clear();
                    Main();
                    ExibirOpcoesMenu();
                    break;
                case 2:
                    Console.WriteLine("Você escolheu a opição 2");
                    Thread.Sleep(3000);
                    Console.Clear();
                    Main();
                    ExibirOpcoesMenu();
                    break;
                case 3:
                    Console.WriteLine("Você escolheu a opição 3");
                    Thread.Sleep(3000);
                    Console.Clear();
                    Main();
                    ExibirOpcoesMenu();
                    break;
                case 0:
                    Console.Clear();
                    Console.WriteLine("\nSaindo...");
                    Thread.Sleep(3000);

                    break;

                default:
                    Console.WriteLine("\n Você digitou a opção invalida");
                    break;
            }
        }

        private static void CadInfo()
        {
            Console.Clear();
            Console.WriteLine("Cadastre seu lindo nome");
            Console.WriteLine("Digite seu lindo Nome: ");
            string NomeDoUsuario = Console.ReadLine();
            Console.WriteLine($"\n Nome Cadastro com Sucesso!!! {NomeDoUsuario}");
            Thread.Sleep(3000);
            Console.Clear();
            ExibirOpcoesMenu();
            Main();
        }
    }
}
