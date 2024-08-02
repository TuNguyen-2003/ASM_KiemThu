namespace Bai6.Tests
{
    public class Tests
    {
        [TestFixture]
        public class SinhVienPolyTests
        {
            public SinhVienPoly sinhVienPoly;

            [SetUp]
            public void SetUp()
            {
                sinhVienPoly = new SinhVienPoly();
            }

            [Test]
            public void AddSinhVien_ValidSinhVien_AddsSuccessfully()
            {
                var sinhVien = new SinhVien("1", "Nguyen A", "C1", "CNTT", "S0V1");
                Assert.DoesNotThrow(() => sinhVienPoly.AddSinhVien(sinhVien));
            }

            [Test]
            public void AddSinhVien_EmptyTenLop_ThrowsArgumentException()
            {
                var sinhVien = new SinhVien("2", "Nguyen B", "C2", "", "SV02");
                Assert.Throws<ArgumentException>(() => sinhVienPoly.AddSinhVien(sinhVien));
            }

            [Test]
            public void AddSinhVien_TenLopWithSpecialCharacter_ThrowsArgumentException()
            {
                var sinhVien = new SinhVien("3", "Nguyen C", "C3", "CNTT@2024", "SV03");
                Assert.Throws<ArgumentException>(() => sinhVienPoly.AddSinhVien(sinhVien));
            }

            [Test]
            public void AddSinhVien_NullSinhVien_ThrowsArgumentNullException()
            {
                SinhVien sinhVien = null;
                Assert.Throws<ArgumentNullException>(() => sinhVienPoly.AddSinhVien(sinhVien));
            }

            [Test]
            public void AddSinhVien_ValidSinhVienWithSpacesInTenLop_AddsSuccessfully()
            {
                var sinhVien = new SinhVien("4", "Nguyen D", "C4", "Khoa CNTT", "SV04");
                Assert.DoesNotThrow(() => sinhVienPoly.AddSinhVien(sinhVien));
            }

            [Test]
            public void AddSinhVien_DuplicateMaSV_AddsSuccessfully()
            {
                var sinhVien1 = new SinhVien("5", "Nguyen E", "C5", "Khoa MT", "SV05");
                var sinhVien2 = new SinhVien("6", "Nguyen F", "C5", "Khoa MT", "SV05");
                sinhVienPoly.AddSinhVien(sinhVien1);
                Assert.DoesNotThrow(() => sinhVienPoly.AddSinhVien(sinhVien2));
            }

            [Test]
            public void AddSinhVien_LongTenLop_ValidAddition()
            {
                var sinhVien = new SinhVien("7", "Nguyen G", "C6", new string('A', 255), "SV06");
                Assert.DoesNotThrow(() => sinhVienPoly.AddSinhVien(sinhVien));
            }

            [Test]
            public void AddSinhVien_TenLopWithWhitespaceOnly_ThrowsArgumentException()
            {
                var sinhVien = new SinhVien("8", "Nguyen H", "C7", "    ", "SV07");
                Assert.Throws<ArgumentException>(() => sinhVienPoly.AddSinhVien(sinhVien));
            }

            [Test]
            public void AddSinhVien_LongId_ValidAddition()
            {
                var sinhVien = new SinhVien(new string('A', 255), "Nguyen I", "C8", "Khoa Thong Tin", "SV08");
                Assert.DoesNotThrow(() => sinhVienPoly.AddSinhVien(sinhVien));
            }

            [Test]
            public void AddSinhVien_InvalidMaSV_ValidAddition()
            {
                var sinhVien = new SinhVien("9", "Nguyen J", "C9", "Khoa KT", "SV09");
                Assert.DoesNotThrow(() => sinhVienPoly.AddSinhVien(sinhVien));
            }

            [Test]
            public void AddSinhVien_DuplicateId_AddsSuccessfully()
            {
                var sinhVien1 = new SinhVien("10", "Nguyen K", "C10", "Khoa DT", "SV10");
                var sinhVien2 = new SinhVien("10", "Nguyen L", "C10", "Khoa DT", "SV11");
                sinhVienPoly.AddSinhVien(sinhVien1);
                Assert.DoesNotThrow(() => sinhVienPoly.AddSinhVien(sinhVien2));
            }
        }
    }
}