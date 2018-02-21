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
            // create a square drawing function that takes 1 parameter:
            // the square size
            // and draws a square of that size to the center of the canvas.
            // draw 3 squares with that function.
            // avoid code duplication.

            

            DrawSquareInCenter(50);
            DrawSquareInCenter(100);
            DrawSquareInCenter(150);

            void DrawSquareInCenter(double squareSize)
            {
                var centre = new Point((Width/2)-(squareSize/2), (Height/2) - (squareSize/2));

                foxDraw.FillColor(Color.FromArgb(0,0,0,0));
                foxDraw.DrawRectangle(centre.X, centre.Y, squareSize, squareSize);
            }

        }


    }
}