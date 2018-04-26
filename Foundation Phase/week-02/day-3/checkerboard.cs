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
            // Fill the canvas with a checkerboard pattern.

            DrawCheckerBoard(8);

            void DrawCheckerBoard(int amountOfSquares)
            {
                double squareSize = canvas.Width / amountOfSquares;


                //Set mainwindow and canvas width and height to 800
                double x = 0 + 10;
                double y = 0 + 30;

                foxDraw.FillColor(Colors.Black);
                foxDraw.StrokeColor(Colors.Black);

                foxDraw.DrawRectangle(x, y, squareSize, squareSize);

                for (int i = 0; i < amountOfSquares; i++)
                {

                    for (int j = 0; j < amountOfSquares; j++)
                    {
                        if (i % 2 == 0)
                        {
                            if (j % 2 == 0)
                                foxDraw.FillColor(Colors.White);
                            else
                                foxDraw.FillColor(Colors.Black);

                            foxDraw.DrawRectangle(x + (j * squareSize), y, squareSize, squareSize);
                        }
                        else
                        {
                            if (j % 2 == 0)
                                foxDraw.FillColor(Colors.Black);
                            else
                                foxDraw.FillColor(Colors.White);

                            foxDraw.DrawRectangle(x + (j * squareSize), y, squareSize, squareSize);
                        }
                    }
                    y += squareSize;
                }
            }
        }
    }
}