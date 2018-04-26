using System;
using System.Windows;
using GreenFox;

namespace drawing
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // Draw a green 10x10 square to the canvas' center.

            double squareSize = 10;

            var center = new Point(canvas.Width/2 - (squareSize/2), canvas.Height/2 - (squareSize/2));

            SquareInTheCenter(squareSize, foxDraw, center);

        }

        public static void SquareInTheCenter(double squareSize, FoxDraw foxDraw, Point center) {

            foxDraw.DrawRectangle(center.X, center.Y, squareSize, squareSize);

        }



    }
}