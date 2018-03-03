using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Drawing;

namespace RecursionSquaresNew
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FoxDraw foxDraw = new FoxDraw(myCanvas);
            foxDraw.StrokeColor(Colors.Black);
            foxDraw.FillColor(Color.FromArgb(0,0,0,0));
            DrawCubes(0,0,myCanvas.Width,5,foxDraw);
        }

        double DrawCubes(double startX, double startY, double size, double level, FoxDraw foxDraw)
        {
            if (level == 0)
            {
                return 1;
            }
            else
            {
                DrawTicTac(startX, startY, size, foxDraw);
                DrawCubes(startX , startY + (size / 3.0), size / 3.0, level - 1, foxDraw);
                DrawCubes(startX + (size / 3.0), startY, size / 3.0, level - 1, foxDraw);
                DrawCubes(startX + (size / 3.0) * 2, startY + size / 3.0, size / 3.0, level - 1, foxDraw);
                DrawCubes(startX + (size / 3.0), startY + (size / 3.0) * 2, size / 3.0, level - 1, foxDraw);
                return 1;
            }
        }

        public static void DrawTicTac(double x, double y, double size, FoxDraw foxDraw)
        {
            double thirdOfScreen = size / 3;

            foxDraw.DrawLine(new Point(x, y + thirdOfScreen), new Point(x + size, y + thirdOfScreen));
            foxDraw.DrawLine(new Point(x, y + thirdOfScreen * 2), new Point(x + size, y + thirdOfScreen * 2));
            foxDraw.DrawLine(new Point(x + thirdOfScreen, y), new Point(x + thirdOfScreen, y + size));
            foxDraw.DrawLine(new Point(x + thirdOfScreen * 2, y), new Point(x + thirdOfScreen * 2, y + size));
        }
    }
}
