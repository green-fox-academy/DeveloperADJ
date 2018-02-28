using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace SharpieSet
{
    class Sharpie
    {
        string sharpieColor;
        double tipWidth;
        public double inkAmount;

        public Sharpie(string sharpieColor, double tipWidth, double inkAmount = 100)
        {
            this.sharpieColor = sharpieColor;
            this.tipWidth = tipWidth;
            this.inkAmount = inkAmount;
        }

        public void Use()
        {
            inkAmount -= tipWidth;
            Console.WriteLine($"You marked with your {sharpieColor} sharpie, you have {inkAmount} ink left.");
        }


    }
}
