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
            double nota1, nota2, media;
            string nome;
            Console.WriteLine("Insira o nome do aluno: ");
            nome = Console.ReadLine();
            Console.WriteLine("Insira nota 1: ");
            nota1 = Convert.ToDouble(Console.ReadLine());
            if (nota1 < 0 || nota1 > 10)
            {
                Console.WriteLine("Nota inválida filhão, mas como o professor não quer que use loop, vou continuar contando aqui...");
            }
            Console.WriteLine("Insira nota 2: ");
            nota2 = Convert.ToDouble(Console.ReadLine());
            if (nota2 < 0 || nota2 > 10)
            {
                Console.WriteLine("Nota inválida filhão, mas como o professor não quer que use loop, vou continuar contando aqui...");
            }
            media = (nota1 + nota2) / 2;
            if (media >= 5)
            {
                Console.WriteLine("O aluno " + nome + " foi aprovadasso");
            }
            else if (media < 5)
            {
                Console.WriteLine("O aluno " + nome + " foi a VERGONHA DA PROFISSSON!");
            }
        }
    }
}
