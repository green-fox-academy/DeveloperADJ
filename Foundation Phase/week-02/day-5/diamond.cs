using GreenFox;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace drawing
{


    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            double totalWidth = (int)canvas.Width;
            double totalHeight = canvas.Height;

            Point topCenterPoint = new Point(totalWidth/2, 0);
            Point topRightPoint = new Point(totalWidth,0);
            Point topLeftPoint = new Point(0,0);

            Point middleCenterPoint = new Point(totalWidth/2, totalHeight/2);
            Point middleRightPoint = new Point(totalWidth, totalHeight/2);
            Point middleLeftPoint = new Point(0, totalHeight/2);

            Point bottomCenterPoint = new Point(totalWidth / 2, totalHeight);
            Point bottomRightPoint = new Point(totalWidth, totalHeight);
            Point bottomLeftPoint = new Point(0, totalHeight);



            ////Lower left
            //DrawGrid(middleLeft, "to-right", middleCenterPoint, "to-bottom", foxDraw, canvas);

            ////Top left
            //DrawGrid(middleLeft, "to-right", middleCenterPoint, "to-top", foxDraw, canvas);

            ////Top right
            //DrawGrid(middleRightPoint, "to-left", middleCenterPoint, "to-top",  foxDraw, canvas);

            ////lower right
            //DrawGrid(middleCenterPoint, "to-right", bottomCenter, "to-top", foxDraw, canvas);


            DrawGrid(middleLeftPoint, "to-right", topCenterPoint, "to-bottom", foxDraw, canvas);
            DrawGrid(middleLeftPoint, "to-right", bottomCenterPoint, "to-top", foxDraw, canvas);
            DrawGrid(middleRightPoint, "to-left", topCenterPoint, "to-bottom", foxDraw, canvas);
            DrawGrid(middleRightPoint, "to-left", bottomCenterPoint, "to-top", foxDraw, canvas);




        }

        public static void DrawGrid(Point startPointXaxis, string directionX, Point startPointYaxis, string directionY, FoxDraw foxDraw, Canvas canvas)
        {
            double totalWidth = canvas.Width;
            double totalHeight = canvas.Height;

            int stepLength = 10;

            int stepsLengthX = stepLength;
            int stepLengthY = stepLength;

            if (directionX == "to-left")
            {
                stepsLengthX = -stepLength;
            }

            if (directionY == "to-top")
            {
                stepLengthY = -stepLength;
            }

            foxDraw.DrawLine(startPointXaxis, startPointYaxis);

            for (int i = 0; i < totalWidth / 2; i += Math.Abs(stepLengthY))
            {
                startPointXaxis.X += stepsLengthX;
                startPointYaxis.Y += stepLengthY;

                foxDraw.DrawLine(startPointXaxis, startPointYaxis);
            }
        }
    }
}