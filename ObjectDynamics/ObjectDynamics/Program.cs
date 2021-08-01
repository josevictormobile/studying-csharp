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
            int qtdAlunos;
            const int QTD_NOTAS = 4;
            List<dynamic> alunos = new List<dynamic>();

            Console.WriteLine("DIGITE A QUANTIDADE DE ALUNOS QUE DESEJA CADASTRAR: ");
            qtdAlunos = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            for(int i=0; i < qtdAlunos; i++)
            {
                int indice = i + 1;
                alunos.Add(new//POR ALGUM MOTIVO ESSE TIPO DE CRIAÇÃO DE OBJETO GERA OBJETOS COM PARÂMETROS QUE NÃO PODEM SER ESCRITOS APENAS LIDOS
                {
                    nome = "",
                    matricula = 0,
                    notas = new List<double>() { 0, 0, 0, 0 },
                    media = 0,
                    status = ""
                });
                Console.WriteLine("ALUNO Nº " + indice + " FOI CRIADO COM SUCESSO!");
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("----------CADASTRO DE ALUNOS----------");
            for (int j=0; j < qtdAlunos;j++)
            {
                Console.WriteLine("INSIRA O NOME DO ALUNO: ");
                alunos[j].nome = Console.ReadLine();
                Console.WriteLine("INSIRA A MATRÍCULA DO ALUNO: ");
                alunos[j].matricula = Convert.ToInt32(Console.ReadLine());
                for(int i=0; i< QTD_NOTAS; i++)
                {
                    int indice = i + 1;
                    Console.WriteLine("INSIRA A "+indice+"º NOTA DO ALUNO: ");
                    alunos[j].notas[i] = Convert.ToDouble(Console.ReadLine());
                    alunos[j].media += alunos[j].notas[i];
                }
                alunos[j].media = alunos[j].media / 4;
                if (alunos[j].media >= 7) { alunos[j].status = "APROVADO"; } else { alunos[j].status = "REPROVADO"; }
            }
            Console.Clear();
            Console.WriteLine("----------RELATÓRIO----------\n\n");
            Console.WriteLine("SEGUE A LISTA DOS ALUNOS: ");
            foreach (var aluno in alunos)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Nome: "+aluno.nome);
                Console.WriteLine("Matrícula: " + aluno.matricula);
                Console.Write("Notas: ");
                foreach(double nota in aluno.notas)
                {
                    Console.Write(nota+", ");
                }
                Console.WriteLine();
                Console.WriteLine("Média: " + aluno.media);
                Console.WriteLine("Status: " + aluno.status);
            }
            Console.WriteLine("------------------------------------");


        }
    }
}
