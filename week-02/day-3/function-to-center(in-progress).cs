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
            // create a line drawing function that takes 2 parameters:
            // the x and y coordinates of the line's starting point
            // and draws a line from that point to the center of the canvas.
            // fill the canvas with lines from the edges, every 20 px, to the center.

            double startX = 0;
            double startY = 0;

            
            
                AllLinesToCenter(startX, startY);
            
            void AllLinesToCenter(double x, double y)
            {
                var centre = new Point(canvas.Width / 2, canvas.Height / 2);

                double positionTop = 0;
                double positionRight = 0;
                double positionBottom = 0;
                double positionLeft = 0;


                for (int i = 0; i < canvas.Width / 20; i++)
                {
                    positionTop = i * 20;
                    var startPoint = new Point(positionTop, y);   
                    foxDraw.DrawLine(startPoint, centre);
                }

                /*for (int j = 0; j < canvas.Height; j++)
                {
                    positionRight = j * 20;
                    var startPoint = new Point(Width, positionRight);
                    foxDraw.DrawLine(startPoint, centre);
                }*/


            }

        }
    }
}