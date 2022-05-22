using System;
using System.Collections.Generic;

namespace Agenda
{
    class Program
    {
        static void Main(string[] args)
        {
            var itens = new ItemDaAgenda[5];

            for (int i = 0; i < 2; i++)
            {
                ItemDaAgenda novoItem;

                Console.Write("Nome: ");
                var nome = Console.ReadLine();

                Console.Write("Telefone: ");
                var telefone = Console.ReadLine();

                Console.Write("Endereço: ");
                var endereco = Console.ReadLine();

                Console.Write("Profissão: ");
                var profissao = Console.ReadLine();

                if (profissao == string.Empty && endereco == string.Empty)
                {
                    novoItem = new ItemDaAgenda(nome, telefone);
                }
                else
                {
                    novoItem = new ItemDaAgenda(nome, telefone, endereco, profissao);
                }

                itens[i] = novoItem;
            }

            for (int i = 0; i < ItemDaAgenda.QuantidadeDeItensNaAgenda; i++)
            {
                var item = itens[i];
                Console.WriteLine($"{item.Nome}, Tel. {item.Telefone}, End. {item.Endereco}, Profissão {item.Profissao}");
            }

            Console.ReadKey();
        }
    }
}
