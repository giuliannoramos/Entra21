using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_6_Exercicio_6
{
    public interface IFiguraGeometrica
    {
        public double CalcularArea { get; }
        public int NumeroTotalDeLados { get; }
        public double Perimetro { get;}
        public double ComprimentoLado { get; set; }
    }
}
