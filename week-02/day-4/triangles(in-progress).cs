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

            DrawPyramidWithWidth(-50, 5);

            void DrawPyramidWithWidth(int triangleSize, int pyramidWidth)
            {
                double centreX = ((canvas.Width / 2) - (triangleSize * pyramidWidth) / 2);

                //Triangle Points

                Dictionary<string, Point> TrianglePoints = new Dictionary<string, Point>();

                var left = new Point(centreX, canvas.Height);
                var top = new Point(left.X + triangleSize * Math.Cos(angle + Math.PI / 3), left.Y + triangleSize * Math.Sin(angle + Math.PI / 3));
                var right = new Point(left.X + triangleSize * Math.Cos(angle), left.Y + triangleSize * Math.Sin(angle));

                void resetXpositions()
                {
                    left.X = centreX;
                    top.X = left.X + triangleSize * Math.Cos(angle + Math.PI / 3);
                    right.X = left.X + triangleSize * Math.Cos(angle);
                }

                void drawOneTriangle()
                {
                    foxDraw.DrawLine(left, top);
                    foxDraw.DrawLine(top, right);
                    foxDraw.DrawLine(right, left);
                }

                void shiftTriangleUp()
                {
                    left.Y += triangleSize;
                    top.Y += triangleSize;
                    right.Y += triangleSize;
                }

                void shiftTriangleRightBy(double multiplier)
                {
                    left.X += (triangleSize*multiplier);
                    top.X += (triangleSize*multiplier);
                    right.X += (triangleSize*multiplier);
                }

                void drawAmountOfTriangles(int number)
                {
                    for (int j = 1; j < number; j++)
                    {
                        shiftTriangleRightBy(1);
                        drawOneTriangle();
                    }
                }

                for (int i = 1; i < pyramidWidth; i++)
                {
                    shiftTriangleUp();
                    resetXpositions();
                    //shiftTriangleRightBy(1);

                    drawAmountOfTriangles(pyramidWidth -i);
                }
            }
        }
    }
}

