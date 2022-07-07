using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medias_Djalma_prof
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aluno: Matheus Cardoso Pinheiro
            //R.A: 6322095
            //Curso: Análise e Desenvolvimento de Sistemas.
            //Semestre: 1°

            Console.WriteLine("Programa para saber seu conceito de nota.");
            double n1, n2, n3, m;
            string nome;
            Console.Write("Digite o nome do aluno: ");
            nome = Console.ReadLine();
            Console.Write("Digite a nota do trabalho, caso seja nota quebrada, digite em VÍRGULA: ");
            n1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a nota da primeira prova, caso seja nota quebrada, digite em VÍRGULA: ");
            n2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a nota da segunda prova, caso seja nota quebrada, digite em VÍRGULA: ");
            n3 = double.Parse(Console.ReadLine());


            m = (n1 + n2 + n3) / 3;

            Console.WriteLine("\nAluno: " + nome + "\nMédia= " + m);


            if (m >= 8.5)
            {
                Console.WriteLine("Conceito= A.");
            }
            else if (m >= 7.0 && m <= 8.4)
            {
                Console.WriteLine("Conceito= B.");
            }
            else if (m >= 6.0 && m <= 6.9)
            {
                Console.WriteLine("Conceito= C.");
            }
            else if (m >= 0.1 && m <= 5.9)
            {
                Console.WriteLine("Conceito= D.");
            }
            else
                Console.WriteLine("Conceito= E.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
