using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    public class Calculate
    {
        public int Sum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        /// <summary>
        /// Kiểm tra số vào là số lẻ hay không
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool CheckSoLe(int n)
        {
            if(n < 0)
            {
                return false;
            }
            else if(n % 2 != 0)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Liệt kê các số từ 1 đến 100 bỏ qua số chia hết cho 5
        /// </summary>
        /// <returns></returns>
        public List<int> GetNumber()
        {
            List<int> lstInt = new List<int>();
            for (int i = 1; i <= 100; i++)
            {
                if(i % 5 !=0)
                {
                    lstInt.Add(i);
                }
            }
            return lstInt;
        }
    }
}
