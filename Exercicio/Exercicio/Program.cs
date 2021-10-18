using System;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int x = Convert.ToInt32(Console.ReadLine());

            while (count < 6)
            {
                if (x % 2 != 0)
                {
                    Console.WriteLine(x);
                    count++;
                }
                x++;
            }
        }
    }
}
