using System;

namespace montecarlos
{
    public class one
    {
        public void k()
        {
            double a = 8.5, b = 5, x, y, s;
            int n = 100000;
            int k = 0;

            Random rand = new Random();
            for (int i = 1; i < n; i++)
            {
                x = rand.NextDouble() * a;
                y = rand.NextDouble() * b;

                if ((0 < y) && ((y < Math.Sin(x))))
                {
                    k = k + 1;
                }

            }
            s = a * b * k / n;
            Console.WriteLine(s);
        }
    }
    public class two
    {
        public void k()
        {
            double a = 8.5, b = 5, x, y, s;
            int n = 100000;
            int k = 0;

            Random rand = new Random();
            for (int i = 1; i < n; i++)
            {
                x = rand.NextDouble() * a;
                y = rand.NextDouble() * b;

                if ((x / 2 < y) && ((y < (x * (8 - x)) / 2)))
                {
                    k = k + 1;
                }

            }
            s = a * b * k / n;
            Console.WriteLine(s);
        }
    }
    public class three
    {
        public void k()
        {
            double a = 8.5, b = 5, x, y, s;
            int n = 100000;
            int k = 0;

            Random rand = new Random();
            for (int i = 1; i < n; i++)
            {
                x = rand.NextDouble() * a;
                y = rand.NextDouble() * b;

                if ((6 > y) && ((y > ((x - 6) * (x - 6)) / 6)))
                {
                    k = k + 1;
                }

            }
            s = a * b * k / n;
            Console.WriteLine(s);
        }
    }
    public class four
    {
        public void k()
        {
            double a = 8.5, b = 5, x, y, s;
            int n = 100000;
            int k = 0;

            Random rand = new Random();
            for (int i = 1; i < n; i++)
            {
                x = rand.NextDouble() * a;
                y = rand.NextDouble() * b;

                if ((x / 5 < y) && ((y < (x * (12 - x)) / 9)))
                {
                    k = k + 1;
                }

            }
            s = a * b * k / n;
            Console.WriteLine(s);
        }
    }
    public class five
    {
        public void k()
        {
            double a = 8.5, b = 5, x, y, s;
            int n = 100000;
            int k = 0;

            Random rand = new Random();
            for (int i = 1; i < n; i++)
            {
                x = rand.NextDouble() * a;
                y = rand.NextDouble() * b;

                if (((8 - x) / 8 < y) && ((y < (x * (8 - x)) / 4)))
                {
                    k = k + 1;
                }

            }
            s = a * b * k / n;
            Console.WriteLine(s);
        }
    }
    public class six
    {
        public void k()
        {
            double a = 8.5, b = 5, x, y, s;
            int n = 100000;
            int k = 0;

            Random rand = new Random();
            for (int i = 1; i < n; i++)
            {
                x = rand.NextDouble() * a;
                y = rand.NextDouble() * b;

                if ((((x - 2) * (x - 2)) / 2 > y) && ((y > Math.Sin(x))))
                {
                    k = k + 1;
                }

            }
            s = a * b * k / n;
            Console.WriteLine(s);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 8.5, b = 5, x, y, s;
            int n = 1000;
            int k = 0;
            Random rand = new Random();
            for (int i = 1; i < n; i++)
            {
                x = rand.NextDouble() * a;
                y = rand.NextDouble() * b;
                if ((x / 3 < y) && (y < x * (10 - x) / 5))
                {
                    k = k + 1;
                }
            }
            s = a * b * k / n;
            Console.WriteLine(s);

            one one = new one();
            one.k();
            two two = new two();
            two.k();
            three three = new three();
            three.k();
            four four = new four();
            four.k();
            five five = new five();
            five.k();
            six six = new six();
            six.k();
        }
    }
}