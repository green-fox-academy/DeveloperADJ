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
            // create a square drawing function that takes 2 parameters:
            // the x and y coordinates of the square's top left corner
            // and draws a 50x50 square from that point.
            // draw 3 squares with that function.
            // avoid code duplication.            

            DrawThreeSquaresFrom(150, 200, foxDraw);
            DrawThreeSquaresFrom(50, 100, foxDraw);
            DrawThreeSquaresFrom(90, 300, foxDraw);


        }

        public static void DrawThreeSquaresFrom(double x, double y, FoxDraw foxDraw)
        {
            double squareSize = 50;
            foxDraw.DrawRectangle(x,y,squareSize, squareSize);
        }


    }
}