using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exponenciacao
{
    class Program
    {
        static void Main(string[] args)
        {
            int basee;
            int expoente;
            int total = 1;

            Console.WriteLine("Olá, vamos fazer uma conta exponencial? ");

            Console.Write("Digite o número da base: ");
            basee = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.Write("Digite o número exponencial: ");
            expoente = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            for (int i = 1; i <= expoente; i++)
            {
                total *= basee;
            }

            Console.WriteLine("O valor total da exponenciação: " + total);

            Console.ReadLine();
        }
    }
}
