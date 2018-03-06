using System;

namespace AircraftCarrier
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCarrier = new Carrier(5000, 300);
            myCarrier.AddAircraft("F16");
            myCarrier.AddAircraft("F16");
            myCarrier.AddAircraft("F16");
            //3 * 8 = 24 ammo
            //720 damage

            //myCarrier.AddAircraft("F35");
            //myCarrier.AddAircraft("F35");
            //myCarrier.AddAircraft("F35");

            Console.WriteLine(myCarrier.GetStatus());
            myCarrier.Fill();
            Console.WriteLine(myCarrier.GetStatus());
            myCarrier.Fill();
            Console.WriteLine(myCarrier.GetStatus());
            myCarrier.Fill();
            Console.WriteLine(myCarrier.GetStatus());

            

            //Console.WriteLine(myCarrier.GetStatus());
            //myCarrier.Fill();
            //Console.WriteLine(myCarrier.GetStatus());


            Console.ReadLine();
        }
    }
}
