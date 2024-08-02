using NUnit.Framework;
using Bai2;

namespace Bai2.Tests
{
    [TestFixture]
    public class BaiLamTests
    {
        private BaiLam baiLam;

        [SetUp]
        public void SetUp()
        {
            baiLam = new BaiLam();
        }

        [Test]
        public void Multiply_TwoSmallPositiveNumbers_ReturnsCorrectProduct()
        {
            int a = 2;
            int b = 3;
            int result = baiLam.Multiply(a, b);
            Assert.AreEqual(6, result);
        }

        [Test]
        public void Multiply_TwoSmallNegativeNumbers_ReturnsCorrectProduct()
        {
            int a = -2;
            int b = -3;
            int result = baiLam.Multiply(a, b);
            Assert.AreEqual(6, result);
        }

        [Test]
        public void Multiply_SmallPositiveAndNegativeNumber_ReturnsCorrectProduct()
        {
            int a = 2;
            int b = -3;
            int result = baiLam.Multiply(a, b);
            Assert.AreEqual(-6, result);
        }

        [Test]
        public void Multiply_ZeroAndSmallPositiveNumber_ReturnsZero()
        {
            int a = 0;
            int b = 4;
            int result = baiLam.Multiply(a, b);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Multiply_ZeroAndSmallNegativeNumber_ReturnsZero()
        {
            int a = 0;
            int b = -4;
            int result = baiLam.Multiply(a, b);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Multiply_TwoLargePositiveNumbers_ReturnsCorrectProduct()
        {
            int a = 1000;
            int b = 2000;
            int result = baiLam.Multiply(a, b);
            Assert.AreEqual(2000000, result);
        }

        [Test]
        public void Multiply_TwoLargeNegativeNumbers_ReturnsCorrectProduct()
        {
            int a = -1000;
            int b = -2000;
            int result = baiLam.Multiply(a, b);
            Assert.AreEqual(2000000, result);
        }

        [Test]
        public void Multiply_LargePositiveAndNegativeNumber_ReturnsCorrectProduct()
        {
            int a = 1000;
            int b = -2000;
            int result = baiLam.Multiply(a, b);
            Assert.AreEqual(-2000000, result);
        }

        [Test]
        public void Multiply_LargePositiveNumberAndOne_ReturnsLargePositiveNumber()
        {
            int a = 1000000;
            int b = 1;
            int result = baiLam.Multiply(a, b);
            Assert.AreEqual(1000000, result);
        }

        [Test]
        public void Multiply_LargeNegativeNumberAndOne_ReturnsLargeNegativeNumber()
        {
            int a = -1000000;
            int b = 1;
            int result = baiLam.Multiply(a, b);
            Assert.AreEqual(-1000000, result);
        }

        [Test]
        public void Multiply_SmallNegativeAndNegativeNumber_ReturnsCorrectProduct()
        {
            int a = -2;
            int b = -3;
            int result = baiLam.Multiply(a, b);
            Assert.AreEqual(6, result);
        }
    }
}
