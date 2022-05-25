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

            for (int i = 0; i < 10; i++)
            {                
                Console.WriteLine($" A primeira nota de {aluno[i]} foi: ");
                nota1[i] = Convert.ToDouble(Console.ReadLine());
                                
                Console.WriteLine($" A segunda nota de {aluno[i]} foi: ");
                nota2[i] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($" A terceira e última nota de {aluno[i]} foi: ");
                nota3[i] = Convert.ToDouble(Console.ReadLine());
            }
            
            double[] menor = NotaMenorAluno(nota1, nota2, nota3);           
            MediaAluno(nota1, nota2, nota3, menor, aluno);
              
            
        }

        static double[] NotaMenorAluno(double[] nt1, double[] nt2, double[] nt3)
        {
            double[] condicao = new double[10];

            for (int i = 0; i < 10; i++)
            {
                if (nt1[i] <= nt2[i] & nt1[i] <= nt3[i])
                {
                    nt1[i] = condicao[i];                    
                }
                else if (nt2[i] <= nt1[i] & nt2[i] <= nt3[i])
                {
                    nt2[i] = condicao[i];                    
                }
                else if (nt3[i] <= nt2[i] & nt3[i] <= nt1[i])
                {
                    nt3[i] = condicao[i];                   
                }                
            }
            return condicao;
        }

        static double[] MediaAluno(double[] nt1, double[] nt2, double[] nt3, double[] ntMenor, string[] aluno)
        {
            double[] condicao = new double[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($" A menor nota do {aluno[i]} é {ntMenor[i]}.");
            }

            for (int i = 0; i < 10; i++)
            {             
                condicao[i] = (nt1[i] + nt2[i] + nt3[i] - ntMenor[i]) / 2;
                Console.WriteLine($" A média das notas do {aluno[i]} descartando sua menor nota é {condicao[i]}.");
            }
            return condicao;
        }
               
                
    }
}
