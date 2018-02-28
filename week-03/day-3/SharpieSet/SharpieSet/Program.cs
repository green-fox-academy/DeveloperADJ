using System;

namespace SharpieSet
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Sharpie Set
            Reuse your Sharpie class
            Create SharpieSet class
            it contains a list of Sharpie
            Add method CountUsable() -> sharpie is usable if it has ink in it
            Add method RemoveTrash() -> removes all unusable sharpies*/

            SharpieSet.AddSharpieToList(new Sharpie("pink", 2));
            SharpieSet.AddSharpieToList(new Sharpie("red", 2));
            SharpieSet.AddSharpieToList(new Sharpie("blue", 2));
            SharpieSet.AddSharpieToList(new Sharpie("yellow", 2, 0));

            Console.WriteLine($"You have {SharpieSet.Sharpies.Count} sharpies.");

            SharpieSet.CountUsable();

            SharpieSet.RemoveTrash();

            Console.ReadLine();

        }
    }
}
