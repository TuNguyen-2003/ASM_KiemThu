using System;

namespace Bai5
{
    public class BaiLam
    {
        public int GetElementAtIndex(int[] array, int index)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), "Mảng không thể là null.");
            }

            if (index < 0 || index >= array.Length)
            {
                throw new IndexOutOfRangeException("Chỉ số nằm ngoài phạm vi của mảng.");
            }

            return array[index];
        }
    }
}
