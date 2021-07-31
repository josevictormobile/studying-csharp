using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaDois
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            bool continuar = true;
            string resposta;
            do
            {
                Console.WriteLine("A tabuada de qual número você ver meu consagrado?");
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Então toma: ");
                Console.WriteLine("-------------TABUADA DO " + num + " -------------");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(num + " x " + i + " = " + num * i);
                }
                Console.WriteLine("Quer ver outra tabuada?(s/n)");
                resposta = Console.ReadLine();
                if (resposta == "n")
                {
                    continuar = false;
                }


            } while (continuar);
            Console.WriteLine("--------------ISSO É TUDO PESSOAL-------------");
        }
    }
}
