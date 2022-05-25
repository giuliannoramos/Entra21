using System;

namespace Lista_4_Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //int posicao = 1;
            int posicao2 = 1;

            double[] media = new double[10];        

            //pede nome dos alunos;
            //Console.WriteLine($" Insira os nomes dos 10 alunos: ");
            string[] aluno = new string[10] { "Gabriel", "Francisco", "Miguel", "Gustavo", "Mateus", "Enzo", "Pedro", "Júlio", "Nicolas", "Fernando" };
            //for (int i = 0; i < 10; i++)
            //{                
            //    Console.WriteLine($" Aluno {posicao++}: ");
            //    aluno[i] = Convert.ToString(Console.ReadLine());
            //}


            //pede nota 1 dos alunos;
            //Console.WriteLine($" Insira a primeira nota de cada aluno: ");
            double[] nota1 = new double[10] { 7, 6.5, 7, 6, 7, 6, 7, 6, 7, 6 };
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($" O aluno {aluno[i]} tirou nota: ");
            //    nota1[i] = Convert.ToInt32(Console.ReadLine());
            //}


            //pede nota 2 dos alunos;
            //Console.WriteLine($" Insira a segunda nota de cada aluno: ");
            double[] nota2 = new double[10] { 7, 6.5, 7, 6, 7, 6, 7, 6, 7, 6 };
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($" O aluno {aluno[i]} tirou nota: ");
            //    nota2[i] = Convert.ToInt32(Console.ReadLine());
            //}


            //pede nota 3 dos alunos;
            //Console.WriteLine($" Insira a terceira nota de cada aluno: ");
            double[] nota3 = new double[10] { 7, 6.5, 7, 6, 7, 6, 7, 6, 7, 6 };
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($" O aluno {aluno[i]} tirou nota: ");
            //    nota3[i] = Convert.ToInt32(Console.ReadLine());
            //}                    
                       

            CalcularMedia(media, nota1, nota2, nota3);
            MostrarPassouRodou(media, posicao2, aluno);


            //mostra os dados
            for (int i = 0; i < 10; i++)
            {                
                Console.WriteLine($" {aluno[i]} tirou {nota1[i]}, {nota2[i]} e {nota3[i]}. Resultando {media[i]} em sua média final. ");
            }


        }

        public static double[] CalcularMedia(double[] media, double[] nota1, double[] nota2, double[] nota3)
        {
            //calcula as medias;
            
            for (int i = 0; i < 10; i++)
            {
                media[i] = (nota1[i] + nota2[i] + nota3[i]) / 3;
            }
            return media;
        }

        public static bool[] MostrarPassouRodou(double[] media, double posicao2, string[] aluno)
        {

            // mostra se passou ou rodou
            bool[] condicao = new bool[10];
            for (int i = 0; i < 10; i++)
            {
                if (media[i] >= 7)
                {
                    condicao[i] = true;
                    Console.WriteLine($" {posicao2++} {aluno[i]} Aprovado ");
                }
                else
                {
                    condicao[i] = false;
                    Console.WriteLine($" {posicao2++} {aluno[i]} Reprovado ");
                }

            }
            return condicao;
        }
               

    }
}
