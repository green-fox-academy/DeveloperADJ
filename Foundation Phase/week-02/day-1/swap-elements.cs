using System;

namespace SwapElements
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `abc`
            //   with the following content: `["first", "second", "third"]`
            // - Swap the first and the third element of `abc`

            string[] abc = new string[3]
            {
                "first","second","third"
            };

            string a = abc[0];
            string c = abc[2];

            abc[0] = c;
            abc[2] = a;

            foreach (string place in abc)
            {
                Console.WriteLine(place);
            }

            Console.ReadLine();
        }
    }
}