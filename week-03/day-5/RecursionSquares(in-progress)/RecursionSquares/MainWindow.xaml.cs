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

namespace RecursionSquares
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FoxDraw foxDraw = new FoxDraw(canvas);
            foxDraw.FillColor(Color.FromArgb(0, 0, 0, 0));

            double thirdOfCanvas = canvas.Width / 3;

            TicTac.DrawTop(canvas.Width,             canvas, foxDraw);
            TicTac.DrawTop(canvas.Width / 3,         canvas, foxDraw);
            TicTac.DrawTop(canvas.Width / 3 / 3,     canvas, foxDraw);

            //TicTac.Draw(canvas.Width / 3 / 3 / 3, canvas, foxDraw, offSet + offSet / 3 + offSet / 3);
        }
    }
}
