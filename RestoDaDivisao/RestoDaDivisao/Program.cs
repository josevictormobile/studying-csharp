using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoDaDivisao
{
    class Program
    {
        static void Main(string[] args)
        {
            int varia1, varia2, resultado;
            Console.WriteLine("Digite um número: ");
            varia1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite um número: ");
            varia2 = Convert.ToInt32(Console.ReadLine());
            resultado = varia1 % varia2;

            Console.WriteLine("O resto da divisão do primeiro pelo segundo é: " + resultado);
        }
    }
}
