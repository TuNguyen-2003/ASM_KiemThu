using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    public class SinhVien
    {
        public string Id { get; set; }
        public string HoTen { get; set; }
        public string MaLop { get; set; }
        public string TenLop { get; set; }
        public string MaSV { get; set; }

        public SinhVien(string id, string hoTen, string maLop, string tenLop, string maSV)
        {
            Id = id;
            HoTen = hoTen;
            MaLop = maLop;
            TenLop = tenLop;
            MaSV = maSV;
        }
    }

    public class SinhVienPoly
    {
        private List<SinhVien> sinhVienList = new List<SinhVien>();

        public void AddSinhVien(SinhVien sinhVien)
        {
            if (sinhVien == null)
                throw new ArgumentNullException(nameof(sinhVien), "");

            if (string.IsNullOrWhiteSpace(sinhVien.TenLop) || sinhVien.TenLop.Any(c => !char.IsLetterOrDigit(c) && c != ' '))
                throw new ArgumentException("");

            sinhVienList.Add(sinhVien);
        }

        public SinhVien FindByMaSV(string maSV)
        {
            return sinhVienList.FirstOrDefault(sv => sv.MaSV == maSV);
        }
    }
}
