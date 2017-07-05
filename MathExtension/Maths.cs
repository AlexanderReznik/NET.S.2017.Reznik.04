using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExtension
{
    public static class Maths
    {
        /// <summary>
        /// A method to get nth root of a positive real number a. Using Newton's method.
        /// </summary>
        /// <param name="a">A positive real number to get nth root</param>
        /// <param name="n">deegree of a root</param>
        /// <param name="eps">precision</param>
        /// <returns> nth root of a positive real number a</returns>
        public static double Sqrt(double a, int n, double eps = 0.000001)
        {
            CheckoutException(a, n, eps);
            double x0 = a / n;
            double x1 = CalculateNext(a, n, x0);

            while (Math.Abs(x1 - x0) > eps)
            {
                x0 = x1;
                x1 = CalculateNext(a, n, x0);
            }

            return x1;
        }

        private static void CheckoutException(double a, int n, double eps)
        {
            if (a <= 0) throw new ArgumentOutOfRangeException($"{nameof(a)} must be positive");
            if (n < 1) throw new ArgumentOutOfRangeException($"{nameof(a)} must greater than 0");
            if (eps < 0) throw new ArgumentOutOfRangeException($"{nameof(a)} must be positive");
        }

        private static double CalculateNext(double a, int n, double x0)
        {
            return (1.0 / n) * ((n - 1) * x0 + a / Math.Pow(x0, n - 1));
        }
    }
}
