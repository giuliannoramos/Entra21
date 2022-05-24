using System;

namespace Lista_5_Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {

            //int posicao = 1;
            
            int menor = 0;
            int meio = 0;
            int maior = 0;
            int[] media = new int[10];


            //pede nome dos alunos;
            //Console.WriteLine($" Insira os nomes dos 10 alunos: ");
            string[] aluno = new string[10] { "Hugo", "Thiago", "Frederico", "Maurício", "Kelvin", "Felipe", "José", "Douglas", "Pedro", "Gustavo" };
            //for (int i = 0; i < 10; i++)
            //{                
            //    Console.WriteLine($" Aluno {posicao++}: ");
            //    aluno[i] = Convert.ToString(Console.ReadLine());
            //}


            //pede as notas dos alunos;
            Console.WriteLine($" Insira as notas de cada aluno: ");
            int[] nota1 = new int[10];
            int[] nota2 = new int[10];
            int[] nota3 = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($" Insira a primeira nota do aluno: ");
                Console.WriteLine($" {aluno[i]} tirou nota: ");
                nota1[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($" Insira a segunda nota do aluno: ");
                Console.WriteLine($" {aluno[i]} tirou nota: ");
                nota2[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($" Insira a terceira nota do aluno: ");
                Console.WriteLine($" {aluno[i]} tirou nota: ");
                nota3[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] notasOrdenadas = new int[3];

            for (int i = 0; i < 10; i++)
            {
                notasOrdenadas[0] = nota1[i];
                notasOrdenadas[1] = nota2[i];
                notasOrdenadas[2] = nota3[i];
                OrdenarArray(notasOrdenadas);
                nota1[i] = notasOrdenadas[0];
                nota2[i] = notasOrdenadas[1];
                nota3[i] = notasOrdenadas[2];

            }                      
            
                        

        }

        static int[] OrdenarArray(int[] notasOrdenadas)
        {
            bool flag = true;
            int temp;
            int numLength = notasOrdenadas.Length;

            //sorting an array  
            for (int i = 1; (i <= (numLength - 1)) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (numLength - 1); j++)
                {
                    if (notasOrdenadas[j + 1] < notasOrdenadas[j])
                    {
                        temp = notasOrdenadas[j];
                        notasOrdenadas[j] = notasOrdenadas[j + 1];
                        notasOrdenadas[j + 1] = temp;
                        flag = true;
                    }
                }
            }

            return notasOrdenadas;
            // Array.Sort(valor);
        }


    }
}
