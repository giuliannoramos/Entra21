using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_6_Exercicio_7
{
    public class Caminhao
    {
        private static int BaseId = 0;
        public int Id { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public Caminhao()
        {
            Id = BaseId;
            BaseId++;
        }
    }
}
