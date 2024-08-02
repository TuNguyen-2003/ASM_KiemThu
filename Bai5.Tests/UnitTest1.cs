using NUnit.Framework;
using System;

namespace Bai5.Tests
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
        public void GetElementAtIndex_ValidIndex_ReturnsCorrectElement()
        {
            var array = new int[] { 10, 20, 30, 40, 50 };
            int index = 2;
            int result = baiLam.GetElementAtIndex(array, index);
            Assert.AreEqual(30, result);
        }

        [Test]
        public void GetElementAtIndex_NegativeIndex_ThrowsIndexOutOfRangeException()
        {
            var array = new int[] { 10, 20, 30, 40, 50 };
            int index = -1;
            Assert.Throws<IndexOutOfRangeException>(() => baiLam.GetElementAtIndex(array, index));
        }

        [Test]
        public void GetElementAtIndex_IndexGreaterThanArrayLength_ThrowsIndexOutOfRangeException()
        {
            var array = new int[] { 10, 20, 30, 40, 50 };
            int index = 5;
            Assert.Throws<IndexOutOfRangeException>(() => baiLam.GetElementAtIndex(array, index));
        }

        [Test]
        public void GetElementAtIndex_NullArray_ThrowsArgumentNullException()
        {
            int[] array = null;
            int index = 0;
            Assert.Throws<ArgumentNullException>(() => baiLam.GetElementAtIndex(array, index));
        }

        [Test]
        public void GetElementAtIndex_ZeroIndex_ReturnsFirstElement()
        {
            var array = new int[] { 10, 20, 30, 40, 50 };
            int index = 0;
            int result = baiLam.GetElementAtIndex(array, index);
            Assert.AreEqual(10, result);
        }

        [Test]
        public void GetElementAtIndex_LastIndex_ReturnsLastElement()
        {
            var array = new int[] { 10, 20, 30, 40, 50 };
            int index = 4;
            int result = baiLam.GetElementAtIndex(array, index);
            Assert.AreEqual(50, result);
        }

        [Test]
        public void GetElementAtIndex_SingleElementArray_ReturnsElement()
        {
            var array = new int[] { 100 };
            int index = 0;
            int result = baiLam.GetElementAtIndex(array, index);
            Assert.AreEqual(100, result);
        }

        [Test]
        public void GetElementAtIndex_ArrayWithNegativeNumbers_ReturnsCorrectElement()
        {
            var array = new int[] { -10, -20, -30, -40, -50 };
            int index = 2;
            int result = baiLam.GetElementAtIndex(array, index);
            Assert.AreEqual(-30, result);
        }

        [Test]
        public void GetElementAtIndex_EmptyArray_ThrowsIndexOutOfRangeException()
        {
            var array = new int[] { };
            int index = 0;
            Assert.Throws<IndexOutOfRangeException>(() => baiLam.GetElementAtIndex(array, index));
        }

        [Test]
        public void GetElementAtIndex_ArrayWithLargeNumbers_ReturnsCorrectElement()
        {
            var array = new int[] { int.MaxValue, int.MinValue, 0 };
            int index = 1;
            int result = baiLam.GetElementAtIndex(array, index);
            Assert.AreEqual(int.MinValue, result);
        }
    }
}
