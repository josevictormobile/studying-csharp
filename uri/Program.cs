using System;

namespace uri
{
    class Program
    {
        static void Main(string[] args)
        {
            double soma = 0;
            double entrada = 0;
            int contador = 0;

            for (var i = 0; i < 6; i++)
            {
                entrada = Convert.ToDouble(Console.ReadLine());
                if (entrada >= 0)
                {
                    contador++;
                    soma += entrada;
                }
            }
            double media = soma / contador;
            Console.WriteLine(contador + " valores positivos");
            media = Math.Round(media,1);
            // //Truncando apenas a primeira casa decimal
            // media *= 10;
            // media = Math.Truncate(media);
            // media /= 10;
            Console.WriteLine(media);

        }
    }
}
