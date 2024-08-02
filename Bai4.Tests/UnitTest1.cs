using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bai4.Tests
{
    [TestFixture]
    public class BaiLamTests
    {
        public BaiLam baiLam;

        [SetUp]
        public void SetUp()
        {
            baiLam = new BaiLam();
        }

        [Test]
        public void CalculateAverage_PositiveNumbers_ReturnsCorrectAverage()
        {
            var numbers = new List<double> { 1.0, 2.0, 3.0, 4.0, 5.0 };
            double result = baiLam.CalculateAverage(numbers);
            Assert.AreEqual(3.0, result);
        }

        [Test]
        public void CalculateAverage_NegativeNumbers_ReturnsCorrectAverage()
        {
            var numbers = new List<double> { -1.0, -2.0, -3.0, -4.0, -5.0 };
            double result = baiLam.CalculateAverage(numbers);
            Assert.AreEqual(-3.0, result);
        }

        [Test]
        public void CalculateAverage_PositiveAndNegativeNumbers_ReturnsCorrectAverage()
        {
            var numbers = new List<double> { -1.0, 0.0, 1.0 };
            double result = baiLam.CalculateAverage(numbers);
            Assert.AreEqual(0.0, result);
        }

        [Test]
        public void CalculateAverage_SingleNumber_ReturnsThatNumber()
        {
            var numbers = new List<double> { 42.0 };
            double result = baiLam.CalculateAverage(numbers);
            Assert.AreEqual(42.0, result);
        }

        [Test]
        public void CalculateAverage_IncludingZero_ReturnsCorrectAverage()
        {
            var numbers = new List<double> { 0.0, 0.0, 0.0 };
            double result = baiLam.CalculateAverage(numbers);
            Assert.AreEqual(0.0, result);
        }

        [Test]
        public void CalculateAverage_EmptyList_ThrowsArgumentException()
        {
            var numbers = new List<double>();
            Assert.Throws<ArgumentException>(() => baiLam.CalculateAverage(numbers));
        }

        [Test]
        public void CalculateAverage_NullList_ThrowsArgumentException()
        {
            List<double> numbers = null;
            Assert.Throws<ArgumentException>(() => baiLam.CalculateAverage(numbers));
        }

        [Test]
        public void CalculateAverage_FloatingPointNumbers_ReturnsCorrectAverage()
        {
            var numbers = new List<double> { 1.5, 2.5, 3.5 };
            double result = baiLam.CalculateAverage(numbers);
            Assert.AreEqual(2.5, result, 0.0001);
        }

        [Test]
        public void CalculateAverage_LargeNumbers_ReturnsCorrectAverage()
        {
            var numbers = new List<double> { 1000000.0, 2000000.0, 3000000.0 };
            double result = baiLam.CalculateAverage(numbers);
            Assert.AreEqual(2000000.0, result);
        }

        [Test]
        public void CalculateAverage_SmallNumbers_ReturnsCorrectAverage()
        {
            var numbers = new List<double> { 0.0001, 0.0002, 0.0003 };
            double result = baiLam.CalculateAverage(numbers);
            Assert.AreEqual(0.0002, result, 0.000001);
        }

    }
}
