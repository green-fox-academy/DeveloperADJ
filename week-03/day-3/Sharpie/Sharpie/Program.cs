using System;

namespace Sharpie
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Sharpie
            Create Sharpie class
            We should know about each sharpie their Color (which should be a string), Width (which will be a floating point number), InkAmount (another floating point number)
            When creating one, we need to specify the Color and the Width
            Every sharpie is created with a default 100 as InkAmount
            We can Use() the sharpie objects
            which decreases inkAmount*/

            Sharpie PinkSharpie = new Sharpie("pink", 2);


            PinkSharpie.Use();
            Console.ReadLine();
        }
    }
}
