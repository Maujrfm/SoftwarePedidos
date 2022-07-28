using System;
using SoftwarePedidos.Entities;
using SoftwarePedidos.Entities.Enums;

namespace SoftwarePedidos
{
    class Program
    {
        static void Main(string[] args)
        {
            int MenuOpt = 0;
            do
            {
                Console.WriteLine("Escolha o Menu Desejado: ");
                Console.WriteLine("Abrir uma mesa: 1");
                Console.WriteLine("Incluir pedido em uma mesa: 2");
                Console.WriteLine("Encerrar uma Mesa: 3");
                Console.WriteLine("Sair: 4");
                MenuOpt = int.Parse(Console.ReadLine());
                int opt = 0;
                switch (MenuOpt)
                {
                    case 1:
                        Console.WriteLine("Entre com nome do Produto: ");
                        string productName = Console.ReadLine();
                        /* 
                         Console.WriteLine("Parabens Voce chegou ao Menu 1");
                         Console.WriteLine("Pressione 1 para voltar");
                         Console.WriteLine("Pressione 2 para sair");
                         opt = int.Parse(Console.ReadLine());
                         if (opt == 2)
                         {
                             opt = 3;
                         }
                         MenuOpt = opt;*/
                        break;
                    case 2:
                        opt = 0;
                        Console.WriteLine("Parabens Voce chegou ao Menu 2");
                        Console.WriteLine("Pressione 1 para voltar");
                        Console.WriteLine("Pressione 2 para sair");
                        opt = int.Parse(Console.ReadLine());
                        if (opt == 2)
                        {
                            opt = 3;
                        }
                        MenuOpt = opt;
                        break;
                }
            }
            while (MenuOpt != 4);
        }
    }
}
