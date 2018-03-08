using System;
using System.Collections.Generic;
using System.Text;

namespace Sum
{
    class Math
    {
        public int Sum(List<int> operands)
        {
            int totalSum = 0;

            if (operands != null)
            {
                foreach (var operand in operands)
                {
                    totalSum += operand;
                }
            }

            return totalSum;
        }
    }
}
