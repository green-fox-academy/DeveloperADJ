using GreenFox;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;


namespace drawing
{


    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            int canvasWidth = Convert.ToInt32(canvas.Width);
            int canvasHeight = Convert.ToInt32(canvas.Height);

            int stepSize = 20;

            DrawGridBottomLeft(stepSize, foxDraw, canvasWidth, canvasHeight);
            DrawGridTopRight(stepSize, foxDraw, canvasWidth, canvasHeight);

            int radius = 250;
            foxDraw.FillColor(Colors.Gray);
            foxDraw.DrawEllipse((canvasWidth/2)-(radius/2), (canvasHeight/2)-(radius/2), radius, radius);
            radius -= 100;
            foxDraw.FillColor(Colors.DarkGray);
            foxDraw.DrawEllipse((canvasWidth / 2) - (radius / 2), (canvasHeight / 2) - (radius / 2), radius, radius);


        }


        public static void DrawGridBottomLeft(int distance, FoxDraw foxDraw, int totalWidth, int totalHeight)
        {
            int stepDistance = distance;
            
            Point Xaxis = new Point(0, totalHeight);
            Point Yaxis = new Point(0, 0);

            foxDraw.DrawLine(Xaxis, Yaxis);

            for (int i = 0; i < totalWidth; i += stepDistance)
            {
                Xaxis.X += stepDistance;
                Yaxis.Y += stepDistance;

                foxDraw.DrawLine(Xaxis, Yaxis);
            }
        }

        public static void DrawGridTopRight(int distance, FoxDraw foxDraw, int totalWidth, int totalHeight)
        {
            int stepDistance = distance;

            Point Xaxis = new Point(0, 0);
            Point Yaxis = new Point(totalWidth, 0);

            foxDraw.DrawLine(Xaxis, Yaxis);

            for (int i = 0; i < totalWidth; i += stepDistance)
            {
                Xaxis.X += stepDistance;
                Yaxis.Y += stepDistance;

                foxDraw.DrawLine(Xaxis, Yaxis);
            }
        }




    }
}