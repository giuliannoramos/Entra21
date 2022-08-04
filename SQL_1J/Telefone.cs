using System;
using System.Collections.Generic;
using System.Text;

namespace SQL_1J
{
    public class Telefone
    {
        public Pessoa Nome { get; set; }
        public int IdTelefone { get; set; }
        public Pessoa Id { get; set; }        
        public string Ddd { get; set; }
        public string Numero { get; set; }
        
        public Telefone(){}

        public Telefone(Pessoa id, string ddd, string numero)
        {
            Id = id;
            Ddd = ddd;
            Numero = numero;
        }

        public Telefone(Pessoa nome, int idTelefone, Pessoa id, string ddd, string numero)
        {
            Nome = nome;
            IdTelefone = idTelefone;
            Id = id;
            Ddd = ddd;
            Numero = numero;
        }

        public Telefone(int idTelefone, string ddd, string numero) 
        {
            IdTelefone = idTelefone;
            Ddd = ddd;
            Numero = numero;
        }
        
    }
}
