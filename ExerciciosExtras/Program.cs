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
           double peso, total;
            const double PRECO = 1.5;
            string option;
            Console.WriteLine("VOCÊ QUER PESAR EM KILOGRAMAS OU GRAMAS?(k/g)");
            option = Console.ReadLine();
            Console.WriteLine("DIGITE O PESO DA LENTILHA: ");
            peso = Convert.ToDouble(Console.ReadLine());
            if (option == "g" || option == "G")
            {
                peso = peso / 1000;
            }
            total = peso * PRECO;
            Console.WriteLine("VALOR TOTAL....................." + total);
            Console.WriteLine("PESO ADQUIRIDO..................." + peso);*/

        }
    }
}
