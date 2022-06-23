using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_6_Exercicio_4
{
    public class Cliente
    {
        public string NomeCliente { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }

        //public Cliente(string NomeCliente, string Cpf, string Endereco)
        //{
        //    this.NomeCliente = NomeCliente;

        //    this.Cpf = Convert.ToUInt64(Cpf).ToString(@"000\.000\.000\-00");

        //    this.Endereco = Endereco;
        //}

        public Cliente()
        { 
        
        }

        public void PreencherDadosCliente()
        {
            Console.WriteLine("Insira o nome do cliente: ");
            NomeCliente = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Insira o CPF: ");
            Cpf = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Insira o endereço: ");
            Endereco = Convert.ToString(Console.ReadLine());
        }

    }
}
