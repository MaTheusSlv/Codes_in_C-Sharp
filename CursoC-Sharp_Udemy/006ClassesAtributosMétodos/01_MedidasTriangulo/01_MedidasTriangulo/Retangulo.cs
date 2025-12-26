using System;

namespace _01_MedidasTriangulo
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;

        //calcula a area
        public double Area()
        {
            return Largura * Altura;
        }

        //calcula o perimetro
        public double Perimetro()
        {
            return (Largura + Altura) * 2;
        }

        //calcula a diagonal
        public double Diagonal()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }
    }
}
