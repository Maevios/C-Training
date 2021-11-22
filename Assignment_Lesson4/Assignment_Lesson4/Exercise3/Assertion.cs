using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    static class Assertion
    {
        public static bool checkIfNegative(string input, out int num)
        {
            int inputToInt = Convert.ToInt32(input);
            if (inputToInt < 0)
            {
                num = inputToInt;
                return true;
            }
            else
            {
                num = 0;
                return false;
            }
        }
    }
}
