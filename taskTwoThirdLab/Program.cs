using System;

namespace taskTwoThirdLab
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите точность: ");
            double precision = double.Parse(Console.ReadLine());

            Console.WriteLine("Сумма равна: " + GetSum(precision));

            Console.ReadLine();
        }

        public static double GetSum(double precision)
        {
            double sum = 0;
            double term;

            for (int n = 0; ; n++)
            {
                term = Math.Pow(-1, n) / GetFactorial(n);

                if (Math.Abs(term) > precision)
                    break;

                sum += term;
            }

            return sum;
        }

        public static int GetFactorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;

            return n * GetFactorial(n - 1);
        }
    }
}