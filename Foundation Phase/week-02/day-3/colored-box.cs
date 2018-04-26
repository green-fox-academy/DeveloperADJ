using System.Windows;
using System.Windows.Media;
using GreenFox;

namespace drawing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Draw a box that has different colored lines on each edge.

            FoxDraw topLine = new FoxDraw(myCanvas);
            FoxDraw bottomLine = new FoxDraw(myCanvas);

            FoxDraw leftLine = new FoxDraw(myCanvas);
            FoxDraw rightLine = new FoxDraw(myCanvas);

            double margin = 100;

            Point topLeft = new Point(margin, margin);
            Point topRight = new Point(Width - margin, margin);
            Point bottomLeft = new Point(margin, Height - margin);
            Point bottomRight = new Point(Width - margin, Height - margin);

            //top
            topLine.StrokeColor(Colors.Red);
            topLine.DrawLine(topLeft, topRight);

            //bottom
            bottomLine.StrokeColor(Colors.Green);
            bottomLine.DrawLine(bottomLeft, bottomRight);

            //left
            leftLine.StrokeColor(Colors.Blue);
            leftLine.DrawLine(topLeft, bottomLeft);

            //right
            rightLine.StrokeColor(Colors.Yellow);
            rightLine.DrawLine(topRight, bottomRight);
        }

    }




}

