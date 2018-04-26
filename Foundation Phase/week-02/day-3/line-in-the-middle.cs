using System.Windows;
using System.Windows.Media;
using GreenFox;

namespace line_in_the_middle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            // draw a red horizontal line to the canvas' middle.
            var redLine = new FoxDraw(canvas);

            redLine.StrokeColor(Colors.Red);

            Point startRedLine = new Point(0, Height/2);
            Point endRedLine = new Point(Width/2, Height/2); 
            
            redLine.DrawLine(startRedLine, endRedLine);

            // draw a green vertical line to the canvas' middle.
            var greenLine = new FoxDraw(canvas);

            greenLine.StrokeColor(Colors.Green
            Point startGreenLine = new Point(Width/2, 0);
            Point endGreenLine = new Point(Width/2, Height/2);

            greenLine.DrawLine(startGreenLine, endGreenLine);


        }

    }




}

);
