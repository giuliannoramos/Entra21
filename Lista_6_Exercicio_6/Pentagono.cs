using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_6_Exercicio_6
{
    public class Pentagono : IFiguraGeometrica
    {
        private double tangente36graus = 0.726542528;
        public double CalcularArea 
        { 
            get
            {
                var metadeLado = ComprimentoLado / 2;
                var altura = metadeLado * tangente36graus;
                var areaTriangulo = (metadeLado * altura) / 2;
                return areaTriangulo * 10;
            }
        }
        public int NumeroTotalDeLados
        {
            get
            {
                return 5;
            }
        }
        public double Perimetro 
        {
            get
            {
                return 0;
            }
        }

        public double ComprimentoLado { get; set; }
    }
}
