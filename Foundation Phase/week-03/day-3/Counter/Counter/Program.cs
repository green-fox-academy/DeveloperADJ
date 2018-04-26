using System;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Counter
            Create Counter class
            which has an integer property
            when creating it should have a default value 0 or we can specify it when creating
            we can Add(number) to this counter another whole number
            or we can Add() without parameters just increasing the counter's value by one
            and we can Get() the current value as string
            also we can Reset() the value to the initial value*/

            Counter MyCounter = new Counter();

            MyCounter.Add();
            MyCounter.Add(5);
            MyCounter.Get();
            MyCounter.Reset();
            
            Console.ReadLine();
        }
    }
}
