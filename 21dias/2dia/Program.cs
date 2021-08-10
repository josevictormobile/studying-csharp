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

            Console.WriteLine($"A soma dos números é: {soma}");
        }
    }
}
