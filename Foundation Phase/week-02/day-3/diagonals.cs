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

            var topLeftToBottomRight = new FoxDraw(canvas);

            var bottomLeftToTopRight = new FoxDraw(canvas);

            double toolBarHeight = 40; //These are the offsets on my system
            double sideOffSet = 20; //These are the offsets on my system

            // Draw the canvas' diagonals.
            // If it starts from the upper-left corner it should be green, otherwise it should be red.

            var topLeft = new Point(0, 0);
            var topRight = new Point(Width - sideOffSet, 0);

            var bottomLeft = new Point(0, Height - toolBarHeight);
            var bottomRight = new Point(Width - sideOffSet, Height - toolBarHeight);

            topLeftToBottomRight.StrokeColor(Colors.Green);
            bottomLeftToTopRight.StrokeColor(Colors.Red);

            topLeftToBottomRight.DrawLine(topLeft, bottomRight);
            bottomLeftToTopRight.DrawLine(bottomLeft, topRight);


        }
    }
}