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

            int angle = 0;


            DrawTrianglesWithWidth(-50, 12);

            void DrawTrianglesWithWidth(int triangleSize, int amountOfBottomTriangles)
            {

                double centreX = ((canvas.Width / 2) - (triangleSize * amountOfBottomTriangles)/2);

                //Where the triangle starts drawing
                var leftPointOfTriangle = new Point(centreX, canvas.Height);

                //Right surface

                var topPointOfTriangle = new Point(leftPointOfTriangle.X + triangleSize * Math.Cos(angle + Math.PI / 3), leftPointOfTriangle.Y + triangleSize * Math.Sin(angle + Math.PI / 3));

                //Left surface
                
                var rightPointOfTriangle = new Point(leftPointOfTriangle.X + triangleSize * Math.Cos(angle), leftPointOfTriangle.Y + triangleSize * Math.Sin(angle));

                foxDraw.DrawLine(leftPointOfTriangle, rightPointOfTriangle);
                foxDraw.DrawLine(leftPointOfTriangle, topPointOfTriangle);
                foxDraw.DrawLine(rightPointOfTriangle, topPointOfTriangle);


                for (int i = 1; i < amountOfBottomTriangles; i++)
                {
                    int shift = triangleSize;

                    leftPointOfTriangle.X += shift;
                    topPointOfTriangle.X += shift;
                    rightPointOfTriangle.X += shift;

                    //Shift the X axis
                    foxDraw.DrawLine(leftPointOfTriangle, topPointOfTriangle);
                    foxDraw.DrawLine(topPointOfTriangle, rightPointOfTriangle);
                    foxDraw.DrawLine(rightPointOfTriangle, leftPointOfTriangle);

                }

                leftPointOfTriangle.Y += triangleSize;
                topPointOfTriangle.Y += triangleSize;
                rightPointOfTriangle.Y += triangleSize;

                leftPointOfTriangle.Y += triangleSize;
                topPointOfTriangle.Y += triangleSize;
                rightPointOfTriangle.Y += triangleSize;


                for (int i = 1; i < amountOfBottomTriangles; i++)
                {
                    int shift = triangleSize;

                    //Shift the X axis
                    foxDraw.DrawLine(leftPointOfTriangle, topPointOfTriangle);
                    foxDraw.DrawLine(topPointOfTriangle, rightPointOfTriangle);
                    foxDraw.DrawLine(rightPointOfTriangle, leftPointOfTriangle);

                }




            }
        }
    }
}
