using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    class Calculate
    {
        public float returnResult(int num)
        {
            float result;
            if (num > 0)
            {
                result = (float)Math.Sqrt(num);
                return result;
                
            }
            else {
                result = (float)Math.Pow(num, 2.00);
                return result;
            }
        }
    }
}
