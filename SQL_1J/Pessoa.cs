﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SQL_1J
{
    public class Pessoa
    {
        public int Id { get; set; }
        public int Idade
        {
            get
            {
                var idade = DateTime.Now.Year - DataDeNascimento.Year;
                return idade;
            }
        }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Naturalidade { get; set; }
        public DateTime DataDeNascimento { get; set; }

        public Pessoa() { }
        public Pessoa(string nome, string cpf, string rg, string telefone, string endereco, DateTime dataDeNascimento, string naturalidade)
        {
            this.Nome = nome;
            Cpf = cpf;
            Rg = rg;
            Telefone = telefone;
            Endereco = endereco;
            DataDeNascimento = dataDeNascimento;
            Naturalidade = naturalidade;
        }

        public Pessoa(int id, string nome, string cpf, string rg, string telefone, string endereco, string naturalidade, DateTime dataDeNascimento)
        {
            Id = id;
            this.Nome = nome;
            Cpf = cpf;
            Rg = rg;
            Telefone = telefone;
            Endereco = endereco;
            Naturalidade = naturalidade;
            DataDeNascimento = dataDeNascimento;
        }
    }
}
