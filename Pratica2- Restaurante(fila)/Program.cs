using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica2__Restaurante_fila_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numCliente = 1;
            int valorInformado;
            Fila pedido = new Fila(100);
            Fila pagamento = new Fila(100);
            Fila encomenda = new Fila(100);
            do {
          
                Console.WriteLine("1 - Inserção de cliente na fila de pedido");
                Console.WriteLine("2 - Remoção de cliente na fila de pedido");
                Console.WriteLine("3 - Remoção de cliente na fila de pagamento");
                Console.WriteLine("4 - Remoção de cliente na fila de encomendas");
                Console.WriteLine("5 - sair");
                valorInformado = int.Parse(Console.ReadLine());

                if (valorInformado == 1)
                {
                    if (pedido.Cheia())
                    {
                        Console.WriteLine("A fila de pedido está cheia!");
                    }
                    pedido.Enfileirar(numCliente);
                    Console.WriteLine("Cliente " + numCliente + " entrou na fila de pedido");
                    numCliente++;
                }
                else if (valorInformado == 2)
                {
                    if (pedido.Vazia())
                    {
                        Console.WriteLine("ERRO: Fila de pedidos está vázia");
                    }
                    int item = pedido.Desenfileirar();
                    pagamento.Enfileirar(item);
                    Console.WriteLine("cliente " + item + " saiu da fila de pedido e entrou na fila de pagamento");
                }
                else if (valorInformado == 3)
                {
                    if (pagamento.Vazia())
                    {
                        Console.WriteLine("ERRO: Fila de pagamentos está vazia");
                    }
                    int item = pagamento.Desenfileirar();
                    encomenda.Enfileirar(item);
                    Console.WriteLine("cliente " + item + " saiu da fila de pagamento e entrou na fila de encomenda");
                }
                else if (valorInformado == 4)
                {
                    if (encomenda.Vazia())
                    {
                        Console.WriteLine("ERRO: Fila de encomenda está vazia");
                    }
                    int item = encomenda.Desenfileirar();
                    Console.WriteLine("cliente " + item + " saiu da loja com o pedido");
                }

            }
            while (valorInformado != 5);

        }
}   }
