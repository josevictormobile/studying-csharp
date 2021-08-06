using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDynamics
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, matricula, status;
            double media, n1, n2, n3, n4;
            Console.WriteLine("QUANTOS ALUNOS VOCÊ QUER CADASTRAR?");
            int qtd = Convert.ToInt32(Console.ReadLine());
            List<dynamic> alunos = new List<dynamic>();

            for (int i = 0; i < qtd; i++)
            {
                int indice = i + 1;
                Console.WriteLine("NOME DO ALUNO:");
                nome = Console.ReadLine();
                Console.WriteLine("MATRÍCULA DO ALUNO:");
                matricula = Console.ReadLine();
                Console.WriteLine("INSIRA A PRIMEIRA NOTA: ");
                n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("INSIRA A SEGUNDA NOTA: ");
                n2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("INSIRA A TERCEIRA NOTA: ");
                n3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("INSIRA A QUARTA NOTA: ");
                n4 = Convert.ToInt32(Console.ReadLine());

                media = (n1 + n2 + n3 + n4) / 4;

               // media >= 7 ? status = "aprovado" : status = "reprovado";
               if(media >= 7)
                {
                    status = "aprovado";
                }
                else
                {
                    status = "reprovado";
                }

                alunos.Add(new
                {
                    name = nome,
                    mat = matricula,
                    nota1 = n1,
                    nota2 = n2,
                    nota3 = n3,
                    nota4 = n4,
                    med = media,
                    stat = status
                });

                Console.Clear();
            }

            Console.WriteLine("Segue a lista dos alunos:");
            foreach (var aluno in alunos)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Nome: " + aluno.name);
                Console.WriteLine("Matrícula: " + aluno.mat);
                Console.Write("Notas: " + aluno.nota1 + ",");
                Console.Write(aluno.nota2 + ",");
                Console.Write(aluno.nota3 + ",");
                Console.Write(aluno.nota4);
                Console.WriteLine();
                Console.WriteLine("Média: " + aluno.med);
                Console.WriteLine("Nome: " + aluno.stat);
            }

            Console.WriteLine("------------------------------------");
        }
    }
}