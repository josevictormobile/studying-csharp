using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaUmNetFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1;
            double nota2;
            double resultado;
            Console.WriteLine("PROGRAMA DE SOMA");
            Console.WriteLine("-------------------------");
            Console.WriteLine("OLÁ PROFERSSORA VALKIRIA!\n\n");
            Console.WriteLine("DIGITE A PRIMEIRA NOTA:");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("DIGITE A SEGUNDA NOTA:");
            nota2 = Convert.ToDouble(Console.ReadLine());
            resultado = nota1 + nota2;
            Console.WriteLine("O RESULTADO É: "+ resultado);
        }
    }
}
