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

            // Draw the night sky:
            //  - The background should be black
            //  - The stars can be small squares
            //  - The stars should have random positions on the canvas
            //  - The stars should have random color (some shade of grey)

            double sizeOfStar = 3;
            int amountOfStars = 200;
            foxDraw.BackgroundColor(Colors.Black);

            DrawStars(sizeOfStar, amountOfStars);

            void DrawStars(double size, int amount)
            {
                Random rng = new Random();

                int margin = 10;

                int width = Convert.ToInt32(canvas.Width) - margin;
                int height = Convert.ToInt32(canvas.Height) - margin;

                for (int i = 0; i < amount; i++)
                {
                    byte randomColor = Convert.ToByte(rng.Next(0, 255));
                    foxDraw.FillColor(Color.FromRgb(randomColor, randomColor, randomColor));
                    foxDraw.StrokeColor(Color.FromRgb(randomColor, randomColor, randomColor));
                    foxDraw.DrawEllipse(rng.Next(0,width), rng.Next(0,height), sizeOfStar, sizeOfStar);
                }
            }
        }
    }
}