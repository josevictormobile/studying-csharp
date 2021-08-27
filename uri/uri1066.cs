using System;

namespace uri
{
    class Uri1066
    {
        public static void Executar()
        {
            int value;
            int evenCount=0;
            int oddCount=0;
            int positiveCount=0;
            int negativeCount=0;

            for(var i=0;i<5;i++)
            {
                    value = Convert.ToInt32(Console.ReadLine());
                    if(value%2==0){evenCount++;}else{oddCount++;}
                    if(value<0){negativeCount++;}else if(value != 0){positiveCount++;}
            }
            Console.WriteLine(evenCount+" valor(es) par(es)");
            Console.WriteLine(oddCount+" valor(es) impar(es)");
            Console.WriteLine(positiveCount+" valor(es) positivo(s)");
            Console.WriteLine(negativeCount+" valor(es) negativo(s)");
        }
    }
}