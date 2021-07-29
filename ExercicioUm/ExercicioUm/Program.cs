using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioUm
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1;
            double nota2;
            double nota3;
            double media1;
            double media2;
            double media3;
            double media4;
            string aluno1;
            string aluno2;
            string aluno3;
            string aluno4;

            Console.WriteLine("Insira o nome do aluno:");
            aluno1 = Console.ReadLine();
            Console.WriteLine("Insira a primeira nota:");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira a segunda nota:");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira a terceira nota:");
            nota3 = Convert.ToDouble(Console.ReadLine());
            media1 = (nota1 + nota2 + nota3) / 3;
            Console.Clear();
            Console.WriteLine("Insira o nome do aluno:");
            aluno2 = Console.ReadLine();
            Console.WriteLine("Insira a primeira nota:");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira a segunda nota:");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira a terceira nota:");
            nota3 = Convert.ToDouble(Console.ReadLine());
            media2 = (nota1 + nota2 + nota3) / 3;
            Console.Clear();
            Console.WriteLine("Insira o nome do aluno:");
            aluno3 = Console.ReadLine();
            Console.WriteLine("Insira a primeira nota:");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira a segunda nota:");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira a terceira nota:");
            nota3 = Convert.ToDouble(Console.ReadLine());
            media3 = (nota1 + nota2 + nota3) / 3;
            Console.Clear();
            Console.WriteLine("Insira o nome do aluno:");
            aluno4 = Console.ReadLine();
            Console.WriteLine("Insira a primeira nota:");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira a segunda nota:");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira a terceira nota:");
            nota3 = Convert.ToDouble(Console.ReadLine());
            media4 = (nota1 + nota2 + nota3) / 3;
            Console.Clear();
            Console.WriteLine("A média do aluno " + aluno1 + " é: " + media1);
            Console.WriteLine("A média do aluno " + aluno2 + " é: " + media2);
            Console.WriteLine("A média do aluno " + aluno3 + " é: " + media3);
            Console.WriteLine("A média do aluno " + aluno4 + " é: " + media4);
        }
    }
}
