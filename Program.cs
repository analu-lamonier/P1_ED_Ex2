using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caProvaEx2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fila f = new Fila();

            int i = 0;
            while (i != 5)
            {
                Console.WriteLine("\r\nO que o senhor(a) Deseja fazer?" +
                   "\r\n 1 - Insira um inteiro na Fila" +
                   "\r\n 2 - Remova um inteiro da Fila" +
                   "\r\n 3 - Insira um inteiro APÓS um outro a ser excolhido" +
                   "\r\n 4 - Imprima a Fila" +
                   "\r\n 5 - SAIR\r\n");
                i = Convert.ToInt32(Console.ReadLine());

                if (i == 1)
                {
                    Console.WriteLine("Digite o numero a ser inserido");
                    int n = Convert.ToInt32(Console.ReadLine());
                    f.Insere(n);
                    Console.WriteLine("Número inserido com sucesso!!");
                    Console.ReadLine();

                }
                if (i == 2)
                {           
                    f.Remove();
                    Console.WriteLine("Número removido com sucesso!!");
                    Console.ReadLine();
                }
                if (i == 3)
                {
                    Console.WriteLine("Digite o numero que vai furar a fila");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o numero que vai deixar o outro furar a fila");
                    int t = Convert.ToInt32(Console.ReadLine());
                    f.FuraFila(n, t);

                }
                if (i == 4)
                {
                    Console.WriteLine("Imprimindo Fila:");
                    f.Imprime();
                    Console.ReadLine();
                }
            }
        }
    }
}
