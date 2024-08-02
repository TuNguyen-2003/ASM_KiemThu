using NUnit.Framework;
using Bai1;

namespace Bai1.Tests
{
    [TestFixture]
    public class BaiLamTests
    {

        [Test]
        public void Sum_PositiveNumbers_ReturnsCorrectSum()
        {
            var baiLam = new BaiLam();
            int a = 10;
            int b = 20;
            int result = baiLam.Sum(a, b);
            Assert.AreEqual(30, result);
        }

        [Test]
        public void Sum_NegativeNumbers_ReturnsCorrectSum()
        {
            var baiLam = new BaiLam();
            int a = -10;
            int b = -20;
            int result = baiLam.Sum(a, b);
            Assert.AreEqual(-30, result);
        }

        [Test]
        public void Sum_PositiveAndNegativeNumber_ReturnsCorrectSum()
        {
            var baiLam = new BaiLam();
            int a = 15;
            int b = -10;
            int result = baiLam.Sum(a, b);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Sum_MaxIntegerValues_ReturnsCorrectSum()
        {
            var baiLam = new BaiLam();
            int a = int.MaxValue - 1;
            int b = 1;
            int result = baiLam.Sum(a, b);
            Assert.AreEqual(int.MaxValue, result);
        }

        [Test]
        public void Sum_MinIntegerValues_ReturnsCorrectSum()
        {
            var baiLam = new BaiLam();
            int a = int.MinValue + 1;
            int b = -1;
            int result = baiLam.Sum(a, b);
            Assert.AreEqual(int.MinValue, result);
        }

        [Test]
        public void Sum_ZeroAndPositiveNumber_ReturnsCorrectSum()
        {
            var baiLam = new BaiLam();
            int a = 0;
            int b = 25;
            int result = baiLam.Sum(a, b);
            Assert.AreEqual(25, result);
        }

        [Test]
        public void Sum_ZeroAndNegativeNumber_ReturnsCorrectSum()
        {
            var baiLam = new BaiLam();
            int a = 0;
            int b = -25;
            int result = baiLam.Sum(a, b);
            Assert.AreEqual(-25, result);
        }

        [Test]
        public void Sum_SameNumber_ReturnsDoubledValue()
        {
            var baiLam = new BaiLam();
            int a = 5;
            int b = 5;
            int result = baiLam.Sum(a, b);
            Assert.AreEqual(10, result);
        }

        [Test]
        public void Sum_DifferentNumbers_ReturnsCorrectSum()
        {
            var baiLam = new BaiLam();
            int a = 100;
            int b = 200;
            int result = baiLam.Sum(a, b);
            Assert.AreEqual(300, result);
        }
    }
}
