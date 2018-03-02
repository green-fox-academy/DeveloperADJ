using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;


namespace RecursionSquares
{
    class TicTac
    {
        public Point StartPoint;
        public double dimensions;


        public TicTac(double dimensions, Point StartPoint, Canvas canvas, FoxDraw foxDraw)
        {
            this.StartPoint = StartPoint;
            this.dimensions = dimensions;
        }
     
        public static void DrawTop(double dimensions, Canvas canvas, FoxDraw foxDraw)
        {
            double offSet = 0;
            double oneThird = dimensions / 3;
            double twoThirds = (dimensions / 3) * 2;

            foxDraw.DrawLine(new Point(0 + offSet, oneThird), new Point(dimensions + offSet, oneThird));//
            foxDraw.DrawLine(new Point(0 + offSet, twoThirds), new Point(dimensions + offSet, twoThirds));
            foxDraw.DrawLine(new Point(oneThird + offSet, 0), new Point(oneThird + offSet, dimensions));
            foxDraw.DrawLine(new Point(twoThirds + offSet, 0), new Point(twoThirds + offSet, dimensions));
            //foxDraw.DrawRectangle(0,0, dimensions, dimensions);

        }

    }
}
