using System;
using System.Collections.Generic;
using System.Text;

namespace Fibonacci
{
    public class FibonacciGenerator
    {
        public int FibonacciIndexChecker(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            if (n == 1)
            {
                return 1;
            }
            else if (n == 2)
            {
                return 1;
            }
            else
            {
                return FibonacciIndexChecker(n - 1) + FibonacciIndexChecker(n - 2);
            }
        }
    }
}
