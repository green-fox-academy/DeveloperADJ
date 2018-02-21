using System;
using System.Collections.Generic;
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

            // Create a square drawing function that takes 2 parameters:
            // The square size, and the fill color,
            // and draws a square of that size and color to the center of the canvas.
            // Create a loop that fills the canvas with rainbow colored squares.

            Rainbows(Height, Colors.Blue);



            void Rainbows(double squareSize, Color color)
            {

                var colorsList = new List<Color>();


                for (byte i = 0; i < 20; i += 10)
                {
                    colorsList.Add(Color.FromRgb(i,255,255));
                  
                }

                for (byte j = 0; j < 40; j += 20)
                {
                    colorsList.Add(Color.FromRgb(255, j, 255));


                }

                for (byte k = 0; k < 80; k += 30)
                {
                    colorsList.Add(Color.FromRgb(255, 255, k));
                }





                //Color[] colors = { Colors.Red, Colors.Green, Colors.Blue, Colors.Yellow };

                double centreX = (Width / 2) - (squareSize / 2);
                double centreY = (Height / 2) - (squareSize / 2);

                foxDraw.FillColor(color);

                foxDraw.DrawRectangle(centreX, centreY, squareSize, squareSize);

                

                for (int i = 0; i < colorsList.Count; i++)
                {
                    squareSize /= 1.3;

                    centreX = (Width / 2) - (squareSize / 2);
                    centreY = (Height / 2) - (squareSize / 2);

                    foxDraw.FillColor(colorsList[i]);
                    foxDraw.DrawRectangle(centreX, centreY, squareSize, squareSize);
                }
              


            }










        }
    }
}