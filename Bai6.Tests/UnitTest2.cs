using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6.Tests
{
    internal class UnitTest2
    {
        [TestFixture]
        public class SinhVienPolySearchTests
        {
            public SinhVienPoly sinhVienPoly;

            [SetUp]
            public void SetUp()
            {
                sinhVienPoly = new SinhVienPoly();
                sinhVienPoly.AddSinhVien(new SinhVien("1", "Nguyen A", "C1", "CNTT", "SV01"));
                sinhVienPoly.AddSinhVien(new SinhVien("2", "Nguyen B", "C2", "HTTT", "SV02"));
                sinhVienPoly.AddSinhVien(new SinhVien("3", "Nguyen C", "C3", "CNTT", "SV03"));
            }

            [Test]
            public void FindByMaSV_ExistingMaSV_ReturnsCorrectSinhVien()
            {
                var result = sinhVienPoly.FindByMaSV("SV01");
                Assert.IsNotNull(result);
                Assert.AreEqual("Nguyen A", result.HoTen);
            }

            [Test]
            public void FindByMaSV_NonExistingMaSV_ReturnsNull()
            {
                var result = sinhVienPoly.FindByMaSV("SV999");
                Assert.IsNull(result);
            }

            [Test]
            public void FindByMaSV_EmptyMaSV_ReturnsNull()
            {
                var result = sinhVienPoly.FindByMaSV("");
                Assert.IsNull(result);
            }

            [Test]
            public void FindByMaSV_NullMaSV_ReturnsNull()
            {
                var result = sinhVienPoly.FindByMaSV(null);
                Assert.IsNull(result);
            }

            [Test]
            public void FindByMaSV_SpecialCharacterMaSV_ReturnsNull()
            {
                var result = sinhVienPoly.FindByMaSV("SV#01");
                Assert.IsNull(result);
            }
        }
    }
}
