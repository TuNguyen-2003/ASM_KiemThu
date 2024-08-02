using System;
using System.Collections.Generic;
using System.Linq;

namespace Bai4
{
    public class BaiLam
    {

        public double CalculateAverage(List<double> numbers)
        {
            if (numbers == null || !numbers.Any())
            {
                throw new ArgumentException("Danh sách không thể null hoặc rỗng.");
            }
            return numbers.Average();
        }
    }
}
