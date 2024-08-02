namespace Bai3.Tests
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
        public void Subtract_TwoSmallPositiveNumbers_ReturnsCorrectDifference()
        {
            int a = 5;
            int b = 3;
            int result = baiLam.Subtract(a, b);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Subtract_TwoSmallNegativeNumbers_ReturnsCorrectDifference()
        {
            int a = -5;
            int b = -3;
            int result = baiLam.Subtract(a, b);
            Assert.AreEqual(-2, result);
        }

        [Test]
        public void Subtract_PositiveAndNegativeNumber_ReturnsCorrectDifference()
        {
            int a = 5;
            int b = -3;
            int result = baiLam.Subtract(a, b);
            Assert.AreEqual(8, result);
        }

        [Test]
        public void Subtract_NegativeAndPositiveNumber_ReturnsCorrectDifference()
        {
            int a = -5;
            int b = 3;
            int result = baiLam.Subtract(a, b);
            Assert.AreEqual(-8, result);
        }

        [Test]
        public void Subtract_ZeroAndSmallPositiveNumber_ReturnsNegativeNumber()
        {
            int a = 0;
            int b = 4;
            int result = baiLam.Subtract(a, b);
            Assert.AreEqual(-4, result);
        }

        [Test]
        public void Subtract_ZeroAndSmallNegativeNumber_ReturnsPositiveNumber()
        {
            int a = 0;
            int b = -4;
            int result = baiLam.Subtract(a, b);
            Assert.AreEqual(4, result);
        }

        [Test]
        public void Subtract_TwoLargePositiveNumbers_ReturnsCorrectDifference()
        {
            int a = 10000;
            int b = 5000;
            int result = baiLam.Subtract(a, b);
            Assert.AreEqual(5000, result);
        }

        [Test]
        public void Subtract_TwoLargeNegativeNumbers_ReturnsCorrectDifference()
        {
            int a = -10000;
            int b = -5000;
            int result = baiLam.Subtract(a, b);
            Assert.AreEqual(-5000, result);
        }

        [Test]
        public void Subtract_LargePositiveAndNegativeNumber_ReturnsCorrectDifference()
        {
            int a = 10000;
            int b = -5000;
            int result = baiLam.Subtract(a, b);
            Assert.AreEqual(15000, result);
        }

        [Test]
        public void Subtract_LargeNegativeAndPositiveNumber_ReturnsCorrectDifference()
        {
            int a = -10000;
            int b = 5000;
            int result = baiLam.Subtract(a, b);
            Assert.AreEqual(-15000, result);
        }
    }
}