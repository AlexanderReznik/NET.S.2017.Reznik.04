using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExtension.Tests
{
    public class MathsTests
    {
        [TestCase(2, 2, 0.00001)]
        [TestCase(2, 3, 0.00001)]
        [TestCase(2.555, 7, 0.00001)]
        [TestCase(0.0001, 3, 0.00001)]
        public void Sqrt_PositiveTest(double a, int n, double eps)
        {
            Assert.IsTrue(Math.Abs(MathExtension.Maths.Sqrt(a, n, eps) - Math.Pow(a, 1.0/n)) < eps);
        }

        [TestCase(8, 15, -1)]
        [TestCase(8, 0, 1)]
        [TestCase(-8, 15, 0.1)]
        public void Sqrt_ThrowsArgumentOutOfRangeException(double a, int n, double eps)
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => MathExtension.Maths.Sqrt(a, n, eps));
        }
    }
}
