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
            // and draws a line from that point to the center of the canvas.
            // Draw 3 lines with that function. Use loop for that.

            var centre = new Point(canvas.Width / 2, canvas.Height / 2);

            DrawToCenterFrom(300, 500, centre, foxDraw);
            DrawToCenterFrom(10, 30, centre, foxDraw);
            DrawToCenterFrom(600, 300, centre, foxDraw);
            DrawToCenterFrom(0, 100, centre, foxDraw);


        }

        public static void DrawToCenterFrom(double x, double y, Point centre, FoxDraw foxDraw)
        {

            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(new Point(x, y), centre);

        }


    }
}