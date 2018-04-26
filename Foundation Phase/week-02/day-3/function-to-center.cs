using System;
using System.Threading;
using System.Threading.Tasks;
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

            Random rng = new Random();
            //var centrePosition = new Point(rng.Next(0, 700), rng.Next(0, 700));

            var centrePosition = new Point(canvas.Width/2, canvas.Height/2);

            AllLinesToCenter(startX, startY, centrePosition);

            void AllLinesToCenter(double x, double y, Point centre)
            {
                //var centre = new Point(canvas.Width / 2, canvas.Height / 2);

                double startPositionX = x;
                double startPositionY = y;

                var startPoint = new Point(0,0);

                //Top Row
                for (int i = 0; i < canvas.Width / 20; i++)
                {
                    startPositionX = i * 20;
                    startPoint = new Point(startPositionX, startPositionY);
                    foxDraw.DrawLine(startPoint, centre);
                    
                }

                //Right Row
                for (int j = 0; j < canvas.Height / 20; j++)
                {
                    startPositionY = j * 20;
                    startPoint = new Point(startPositionX, startPositionY);
                    foxDraw.DrawLine(startPoint, centre);
                }

                //Row bottom
                for (int k = 0; k < canvas.Width / 20; k++)
                {
                    startPositionX = k * 20;
                    startPoint = new Point(startPositionX, startPositionY);
                    foxDraw.DrawLine(startPoint, centre);
                }

                //Row Left
                for (int j = 0; j < canvas.Height / 20; j++)
                {
                    startPositionY = j * 20;
                    startPoint = new Point(0, startPositionY);
                    foxDraw.DrawLine(startPoint, centre);
                }

            }

        }
    }
}