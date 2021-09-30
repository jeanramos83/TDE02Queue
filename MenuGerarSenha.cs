using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TDE02Pratica
{
    public class MenuGerarSenha
    {
        public int contPrioridade { get; set; }
        public int contSemPrioridade { get; set; }

        public Queue myP = new Queue();
        public Queue myS = new Queue();
        public void MenuSenha()
        {
            int menuGerarSenha = 0;

            while (menuGerarSenha != 3)
            {
                Console.Clear();
                Console.WriteLine("------------ MENU GERAR SENHA -----------");
                Console.WriteLine("1 – Gerar senha para fila com prioridade");
                Console.WriteLine("2 – Gerar senha para fila sem prioridade ");
                Console.WriteLine("3 – SAIR");
                Console.Write("DIGITE A OPÇÂO DESEJADA: ");
                menuGerarSenha = int.Parse(Console.ReadLine());
                if (menuGerarSenha == 1)
                {
                    myP.Enqueue(contPrioridade);
                    contPrioridade = contPrioridade + 1;
                    Console.WriteLine("CXP-" + contPrioridade);
                }
                else
                if (menuGerarSenha == 2)
                {
                    myS.Enqueue(contSemPrioridade);
                    contSemPrioridade = contSemPrioridade + 1;
                    Console.WriteLine("CXN-" + contSemPrioridade);
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}