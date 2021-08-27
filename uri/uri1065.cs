using System;

namespace uri
{
    class Uri1065
    {
        public static void Executar()
        {
            int value;
            int count=0;
            for (var i = 0; i < 5; i++)
            {
                value = Convert.ToInt32(Console.ReadLine());
                if(value%2==0)
                {
                    count++;
                }
            }
            Console.WriteLine(count+" valores pares");

        }
    }
}