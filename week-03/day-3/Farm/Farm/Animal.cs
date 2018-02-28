using System;
using System.Collections.Generic;
using System.Text;

namespace Farm
{
    class Animal
    {
        public int hungerValue;
        public int thirstValue;

        public Animal(int hungerValue = 50, int thirstValue = 50)
        {
            this.hungerValue = hungerValue;
            this.thirstValue = thirstValue;
        }

        public void eat()
        {
            hungerValue -= 1;
            Console.WriteLine("Ate something, the hungerValue is now " + hungerValue);
        }

        public void drink()
        {
            thirstValue -= 1;
            Console.WriteLine("Drank something, the thirstValue is now " + thirstValue);
        }

        public void play()
        {
            hungerValue += 1;
            thirstValue += 1;
            Console.WriteLine("Played for a while, the thirstValue is " + thirstValue + " and the hungerValue is " + hungerValue);
        }

    }
}
