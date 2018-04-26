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
            // Reproduce this:
            // [https://github.com/greenfox-academy/teaching-materials/blob/master/workshop/drawing/purple-steps/r3.png]

            var startLocation = new Point(50,50);

            purpleStepGenerator(6, 10, startLocation);

            void purpleStepGenerator(double repetitions, double size, Point start)
            {
                double x = start.X;
                double y = start.Y;

                foxDraw.StrokeColor(Colors.Black);
                foxDraw.FillColor(Colors.Purple);

                for (int i = 0; i < repetitions; i++)
                {
                    foxDraw.DrawRectangle(x, y, size, size);

                    x += size;
                    y += size;

                    size *= 1.5;
                    
                    
                }
                
            }



        }
    }
}