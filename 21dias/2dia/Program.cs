using System;

namespace _1dia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            var soma = num1 + num2;

            Console.WriteLine($"Digite o valor da soma dos números {num1} + {num2}: ");
            int achoSoma = Convert.ToInt32(Console.ReadLine());

            if (achoSoma == soma)
            {
                Console.WriteLine("Você é muito bom em matemática, está correto!");
            }
            else
            {
                Console.WriteLine("tsc tsc precisando praticar matemática");
            }
            Console.WriteLine($"A soma dos números é: {soma}");
        }
    }
}
