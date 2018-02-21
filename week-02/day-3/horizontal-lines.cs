using System;
using System.Windows;
using System.Windows.Media;
using GreenFox;

namespace drawing
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // Create a line drawing function that takes 2 parameters:
            // The x and y coordinates of the line's starting point
            // and draws a 50 long horizontal line from that point.
            // Draw 3 lines with that function. Use loop for that.

            double length = 50;
            double x = 50;
            double y = 50;

            DrawHorizontalLineFrom(x, y, length, foxDraw);

        }

        public static void DrawHorizontalLineFrom(double x, double y, double length, FoxDraw foxDraw)
        {

            foxDraw.StrokeColor(Colors.Red);
            for (int i = 0; i < 3; i++)
            {
                foxDraw.DrawLine(new Point(x, y + (i*100)), new Point(x + length, y + (i*100)));
            }
            

        }


    }
}