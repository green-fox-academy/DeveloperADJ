using System;

namespace IO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that takes a number
            // divides ten with it,
            // and prints the result.
            // It should print "fail" if the parameter is 0

            int tenDividedBy(int number)
            {
                return 10 / number;
            }

            int userNumber = 0;

            try
            {
                if (userNumber == 0) {
                    throw new Exception("fail");
                }

                Console.WriteLine(tenDividedBy(userNumber));
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            finally
            {
                Console.Read();
            }
        }
    }
}
