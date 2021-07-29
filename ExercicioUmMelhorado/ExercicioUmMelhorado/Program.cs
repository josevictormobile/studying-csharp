using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioUmMelhorado
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double media;
            double[] notas = null;
            string[] nomes = null;
            notas = new double[4];
            nomes = new string[5];
            Hashtable tabela = new Hashtable();

            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("Digite o nome do aluno:");
                nome = Console.ReadLine();
                nomes[i] = nome;
                for(int j= 1; j <= 3; j++)
                {
                    Console.WriteLine("Digite a nota "+j+":");
                    notas[j] = Convert.ToDouble(Console.ReadLine());
                }
                media = (notas[1] + notas[2] + notas[3]) / 3;
                tabela.Add(nome,media);
                Console.Clear();
            }
            for(int x=1; x<=4; x++)
            {
                Console.WriteLine("A média do aluno " + nomes[x]+" é :"+tabela[nomes[x]]);
            }
            
        }
    }
}
