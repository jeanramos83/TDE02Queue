using System;
using System.Collections.Generic;
using System.Text;

namespace TDE02Pratica
{
    public class MenuChamarSenha : MenuGerarSenha
    {
        public void MenuChamar()
        {
            int menuChamarSenha = 0;

            while (menuChamarSenha != 3)
            {
                Console.Clear();
                Console.WriteLine("------------MENU CHAMAR SENHA------------");
                Console.WriteLine("1 – Chamar senha para fila com prioridade");
                Console.WriteLine("2 – Chamar senha para fila sem prioridade");
                Console.WriteLine("3 – SAIR");
                Console.Write("DIGITE A OPÇÂO DESEJADA: ");
                menuChamarSenha = int.Parse(Console.ReadLine());
                if (menuChamarSenha == 1)
                {
                    Console.WriteLine(myP.Dequeue());
                }
                else
                if (menuChamarSenha == 2)
                {
                    Console.WriteLine(myS.Dequeue());
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
