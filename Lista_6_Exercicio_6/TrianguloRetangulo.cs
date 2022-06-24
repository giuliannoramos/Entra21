using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_6_Exercicio_6
{
    public class TrianguloRetangulo : IFiguraGeometrica
    {
        public double CalcularArea { get; }
        public int NumeroTotalDeLados { get; set; }
        public double Perimetro { get; set; }
        public double ComprimentoLado { get; set; }
    }
}
