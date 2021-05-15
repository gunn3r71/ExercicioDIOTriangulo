using System;

namespace ExercicioDIOTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            string[] valor = Console.ReadLine().Split();
            a = Convert.ToDouble(valor[0]);
            b = Convert.ToDouble(valor[1]);
            c = Convert.ToDouble(valor[2]);

            if (((a-b) < c && (c < a+b)) && ((a-c) < b && (b < a-c)) && ((b-c) < a && (a < (b+c)))) //complete a condicional
            {
                double Perimetro = a + b + c;
                Console.WriteLine("Perimetro = {0:0.0}", Perimetro); //complete a saida
            }
            else
            {
                double Area = ((a + b) * c) / 2;
                Console.WriteLine("Area = {0:0.0}", Area); //complete a saida
            }
        }
    }
}
