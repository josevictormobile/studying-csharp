using System;

namespace dia3
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Digite \n1 - sair\n2 - continuar \n3 - continuar sem a palavra 'continue':");
                int resposta = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Sábia decisão");
                if (resposta == 1) { break; }
                if (resposta == 2) { continue; }
                Console.WriteLine("Passou por aqui :)");
                Console.WriteLine("Adicionando mais uma linha para testar o build");
            } while (true);
            bool outraresposta = true; // Essa variável não é a mesma da anterior pois está no escopo acima
            if (outraresposta == true)
            {
                Console.WriteLine("Mais uma linha para testar o build");
            }
        }
    }
}
