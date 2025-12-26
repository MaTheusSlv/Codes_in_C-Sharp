using System;
using System.Globalization;

namespace _01_MedidasTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //cria um retângulo na memória
            Retangulo ret = new Retangulo();
            
            //pede a largura e a altura do retângulo
            Console.WriteLine("Entre a largura e altura do retângulo:");
            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //mostra o resultado já calculando com o método do retângulo
            Console.Write("AREA = " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("");
            Console.Write("PERÍMETRO = " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("");
            Console.Write("DIAGONAL = " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
