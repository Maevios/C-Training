using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class SwapIntClass
    {
        public void swapInt(ref int num1,ref int num2)
        {
            int num3;

            num3 = num1;
            num1 = num2;
            num2 = num3;

        }
    }
}
