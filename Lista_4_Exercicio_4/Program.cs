using System;

namespace Lista_4_Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int posicao = 1;
            int posicao2 = 1;

            //pede nome dos alunos;
            Console.WriteLine($" Insira os nomes dos 10 alunos: ");
            string[] aluno = new string[10];
            for (int i = 0; i < 10; i++)
            {                
                Console.WriteLine($" Aluno {posicao++}: ");
                aluno[i] = Convert.ToString(Console.ReadLine());
            }


            //pede nota 1 dos alunos;
            Console.WriteLine($" Insira a primeira nota de cada aluno: ");
            int[] nota1 = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($" O aluno {aluno[i]} tirou nota: ");
                nota1[i] = Convert.ToInt32(Console.ReadLine());
            }


            //pede nota 2 dos alunos;
            Console.WriteLine($" Insira a segunda nota de cada aluno: ");
            int[] nota2 = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($" O aluno {aluno[i]} tirou nota: ");
                nota2[i] = Convert.ToInt32(Console.ReadLine());
            }


            //pede nota 3 dos alunos;
            Console.WriteLine($" Insira a terceira nota de cada aluno: ");
            int[] nota3 = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($" O aluno {aluno[i]} tirou nota: ");
                nota3[i] = Convert.ToInt32(Console.ReadLine());
            }


            //calcula as medias;
            int[] media = new int[10];
            for (int i = 0; i < 10; i++)
            {
                media[i] = (nota1[i] + nota2[i] + nota3[i]) / 3;
            }


            // mostra se passou ou rodou
            bool[] situacao = new bool[10];
            for (int i = 0; i < 10; i++)
            {
                if (media[i] >= 70)
                {                    
                    situacao[i] = true;
                    Console.WriteLine($" {posicao2++} {aluno[i]} Aprovado ");
                }
                else
                {                    
                    situacao[i] = false;
                    Console.WriteLine($" {posicao2++} {aluno[i]} Reprovado ");
                }

            }


            //mostra os dados
            for (int i = 0; i < 10; i++)
            {                
                Console.WriteLine($" {aluno[i]} tirou {nota1[i]}, {nota2[i]} e {nota3[i]}. Resultando {media[i]} em sua média final. ");
            }


        }


    }
}
