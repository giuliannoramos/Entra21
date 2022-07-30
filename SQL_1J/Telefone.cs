using System;
using System.Collections.Generic;
using System.Text;

namespace SQL_1J
{
    public class Telefone
    {
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

        //public Telefone(int idTelefone, string ddd, string numero)
        //{
        //    IdTelefone = idTelefone;
        //    Ddd = ddd;
        //    Numero = numero;
        //}
    }
}
