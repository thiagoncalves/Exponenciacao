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
            int base1;
            int expoente;
            int total;

            Console.WriteLine("Olá, vamos fazer uma conta exponencial? ");

            Console.Write("Digite o número da base: ");
            base1 = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.Write("Digite o número exponencial: ");
            expoente = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            total = PegarExponencial(base1, expoente);
           
            Console.WriteLine("O valor total da exponenciação: " + total);

            Console.ReadLine();
        }

        public static int PegarExponencial (int base1, int expoente)
        {
            int total = 1; 

            for (int i = 1; i <= expoente; i++)
            {
                total *= base1;
            }

            return total;
        }
    }

}
