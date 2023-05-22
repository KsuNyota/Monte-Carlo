using System;
namespace montecarlo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int k;
            double s, x, y;
            Random rand = new Random();
            k = 0;
            n = 1000;
            for (int i = 1; i < n; i++)
            {
                x = rand.NextDouble();
                y = rand.NextDouble();

                if (((x - 1) * (x - 1)) + ((y - 1) * (y - 1)) <= 1)
                {
                    k = k + 1;
                }

            }
            s = 4.0 * k / n;
            Console.Write("Результат pi = ");
            Console.WriteLine(s);
            Console.WriteLine("Точно pi = "+Math.PI);
        }
    }
}