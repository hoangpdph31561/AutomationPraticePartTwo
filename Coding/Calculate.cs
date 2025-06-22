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
    }
}
