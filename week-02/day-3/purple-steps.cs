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

            purpleStepGenerator(Colors.Purple, 19, 10, startLocation);


            void purpleStepGenerator(Color color, double repetitions, double size, Point start)
            {
                double x = start.X;
                double y = start.Y;

                foxDraw.FillColor(color);
                foxDraw.DrawRectangle(x, y, size, size);

                for (int i = 0; i < repetitions; i++)
                {
                    x += size;
                    y += size;

                    

                    foxDraw.FillColor(color);
                    foxDraw.DrawRectangle(x, y, size, size);

                }
                
            }



        }
    }
}