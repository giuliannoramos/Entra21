using System;

namespace Lista_5_Exercicio_1
{
    //    1. Faça um programa(usando funções) que receba 3 notas de 10
    //alunos:

    //a.O programa deve calcular a média, descartando a menor nota
    //de cada aluno.Ao final, deve mostrar a maior e a menor nota
    //(de cada aluno).

    //b.Mostre também uma média geral da turma, a nota mais alta e
    //a nota mais baixa.

    class Program
    {
        static void Main(string[] args)
        {

            string[] aluno = new string[10] { "Aluno1", "Aluno2", "Aluno3", "Aluno4", "Aluno5", "Aluno6", "Aluno7", "Aluno8", "Aluno9", "Aluno10" };

            Console.WriteLine($" Insira as 3 notas dos 10 alunos: ");
            double[] nota1 = new double[10];
            double[] nota2 = new double[10];
            double[] nota3 = new double[10];

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                nota1[i] = random.NextDouble() * 10;
                Console.WriteLine($"{aluno[i]} tirou {nota1[i]}");
                nota2[i] = random.NextDouble() * 10;
                Console.WriteLine($"{aluno[i]} tirou {nota2[i]}");
                nota3[i] = random.NextDouble() * 10;
                Console.WriteLine($"{aluno[i]} tirou {nota3[i]}");

                //Console.WriteLine($" A primeira nota de {aluno[i]} foi: ");
                //nota1[i] = Convert.ToDouble(Console.ReadLine());

                //Console.WriteLine($" A segunda nota de {aluno[i]} foi: ");
                //nota2[i] = Convert.ToDouble(Console.ReadLine());

                //Console.WriteLine($" A terceira e última nota de {aluno[i]} foi: ");
                //nota3[i] = Convert.ToDouble(Console.ReadLine());
            }

            double[] MaiorIndividual = MaiorNotaIndividual(nota1, nota2, nota3);
            double[] MenorIndividual = MenorNotaIndividual(nota1, nota2, nota3);
            double[] MediaIndividual = MediaNotaIndividual(nota1, nota2, nota3, MenorIndividual, MaiorIndividual, aluno);
            MediaGeral(MediaIndividual);
            MenorNotaGeral(nota1, nota2, nota3);
            MaiorNotaGeral(MaiorIndividual);

        }

        static double[] MenorNotaIndividual(double[] nota1, double[] nota2, double[] nota3)
        {
            double[] MenorNotaIndividual = new double[10];

            for (int i = 0; i < 10; i++)
            {
                if (nota1[i] <= nota2[i] && nota1[i] <= nota3[i])
                {
                    MenorNotaIndividual[i] = nota1[i];
                }
                else if (nota2[i] <= nota1[i] && nota2[i] <= nota3[i])
                {
                    MenorNotaIndividual[i] = nota2[i];
                }
                else if (nota3[i] <= nota2[i] && nota3[i] <= nota1[i])
                {
                    MenorNotaIndividual[i] = nota3[i];
                }
            }
            return MenorNotaIndividual;
        }

        static double[] MaiorNotaIndividual(double[] nota1, double[] nota2, double[] nota3)
        {
            double[] MaiorNotaIndividual = new double[10];

            for (int i = 0; i < 10; i++)
            {
                if (nota1[i] >= nota2[i] && nota1[i] >= nota3[i])
                {
                    MaiorNotaIndividual[i] = nota1[i];
                }
                else if (nota2[i] >= nota1[i] && nota2[i] >= nota3[i])
                {
                    MaiorNotaIndividual[i] = nota2[i];
                }
                else if (nota3[i] >= nota2[i] && nota3[i] >= nota1[i])
                {
                    MaiorNotaIndividual[i] = nota3[i];
                }
            }
            return MaiorNotaIndividual;
        }

        static double[] MediaNotaIndividual(double[] nota1, double[] nota2, double[] nota3, double[] MenorIndividual, double[] MaiorIndividual, string[] aluno)
        {
            double[] MediaNotaIndividual = new double[10];


            for (int i = 0; i < 10; i++)
            {
                if (nota1[i] <= nota2[i] && nota1[i] <= nota3[i])
                {
                    MediaNotaIndividual[i] = (nota2[i] + nota3[i]) / 2;
                    Console.WriteLine($" A média das notas do {aluno[i]} descartando sua menor nota é {MediaNotaIndividual[i]}.");
                }
                else if (nota2[i] <= nota1[i] && nota2[i] <= nota3[i])
                {
                    MediaNotaIndividual[i] = (nota1[i] + nota3[i]) / 2;
                    Console.WriteLine($" A média das notas do {aluno[i]} descartando sua menor nota é {MediaNotaIndividual[i]}.");
                }
                else if (nota3[i] <= nota1[i] && nota3[i] <= nota2[i])
                {
                    MediaNotaIndividual[i] = (nota2[i] + nota1[i]) / 2;
                    Console.WriteLine($" A média das notas do {aluno[i]} descartando sua menor nota é {MediaNotaIndividual[i]}.");
                }

            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($" A MAIOR nota de {aluno[i]} é {MaiorIndividual[i]}.");
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($" A MENOR nota de {aluno[i]} é {MenorIndividual[i]}.");
            }

            return MediaNotaIndividual;
        }

        static double MediaGeral(double[] MediaIndividual)
        {
            double MediaGeral = 0;

            for (int i = 0; i < 10; i++)
            {
                MediaGeral = MediaIndividual[i] + MediaIndividual[i] / 20;
            }

            Console.WriteLine($" A MÉDIA GERAL DA TURMA é {MediaGeral}.");

            return MediaGeral;
        }

        static double MenorNotaGeral(double[] nota1, double[] nota2, double[] nota3)
        {
            double MenorNotaGeral = 0;

            for (int i = 0; i < nota1.Length; i++)
            {
                if (nota1[i] <= nota2[i] && nota1[i] <= nota3[i] && nota1[i] <= MenorNotaGeral)
                {
                    MenorNotaGeral = nota1[i];
                }
                else if (nota2[i] <= nota1[i] && nota2[i] <= nota3[i] && nota2[i] <= MenorNotaGeral)
                {
                    MenorNotaGeral = nota2[i];
                }
                else if (nota3[i] <= nota1[i] && nota3[i] <= nota2[i] && nota3[i] <= MenorNotaGeral)
                {
                    MenorNotaGeral = nota3[i];
                }
            }

            Console.WriteLine($" A MENOR NOTA DA TURMA é {MenorNotaGeral}.");

            return MenorNotaGeral;
        }

        static double MaiorNotaGeral(double[] MaiorIndividual)
        {
            double condicao = 0;

            for (int i = 0; i < 10; i++)
            {
                for (int u = i; u < 10; u++)
                {
                    if (MaiorIndividual[i] > MaiorIndividual[u])
                    {
                        condicao = MaiorIndividual[i];
                    }
                }
            }

            Console.WriteLine($" A MAIOR NOTA DA TURMA é {condicao}.");

            return condicao;
        }

    }
}
