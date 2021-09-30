using System;

namespace TDE02Pratica
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuGerarSenha menuGerarSenha = new MenuGerarSenha();
            MenuChamarSenha menuChamarSenha = new MenuChamarSenha();

            int menu = 0;

            while (menu != 3)
            {
                Console.Clear();
                Console.WriteLine("-------- MENU -------");
                Console.WriteLine("1 – Menu Gerar senha");
                Console.WriteLine("2 – Menu Chamar senha");
                Console.WriteLine("3 – SAIR");
                Console.Write("DIGITE A OPÇÂO DESEJADA: ");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Console.Clear();
                        menuGerarSenha.MenuSenha();
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Clear();
                        menuChamarSenha.MenuChamar();
                        Console.ReadLine();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Menu Inválido!!");
                        Console.WriteLine("Informe uma opção correta!!");
                        Console.ReadLine();
                        break;
                }
            }

        }
    }
}
