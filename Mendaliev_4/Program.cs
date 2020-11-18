using System;

namespace Mendaliev_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //В зависимости от языка системы дробные числа с точкой не конвертируются из строк
            //поэтому точки вручную заменяем на запятые
            //.Replace(".", ",")

            Console.WriteLine("Введите x: ");
            double x = double.Parse(Console.ReadLine().Replace(".", ","));
            Console.WriteLine("Введите a: ");
            double a = double.Parse(Console.ReadLine().Replace(".", ","));
            Console.WriteLine("Введите n: ");
            double n = double.Parse(Console.ReadLine().Replace(".", ","));

            double sinx = Math.Sin(x);

            double x2N = x * x;
            double summN = 5;
            double sinxN = sinx * sinx;
            int signN = 1;
            double a2N = a * a;

            double L = 0.0;
            for (int i = 0; i < n; i++)
            {
                var val = signN * (x2N + summN) / Math.Sqrt(sinxN + a2N);
                Console.WriteLine(val);
                L += val;
                x2N *= x * x;
                sinxN *= sinx;
                a2N *= a * a;
                signN = -signN;
            }

            Console.WriteLine("L = {0:F}", L);
        }
    }
}
