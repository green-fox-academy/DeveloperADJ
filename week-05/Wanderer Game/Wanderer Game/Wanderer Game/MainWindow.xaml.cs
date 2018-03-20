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
using GreenFox;
using Wanderer_Game.Controller;
using Wanderer_Game.View;

namespace Wanderer_Game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Graphics graphics;
        Player player;

        public MainWindow()
        {
            InitializeComponent();
            FoxDraw foxDraw = new FoxDraw(canvas);
            player = new Player(canvas);
            graphics = new Graphics(foxDraw, canvas, player);

            graphics.DrawLevel();
            graphics.DrawPlayer();
        }

        private void WindowKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left)
            {
                player.Move("left");
                Refresh();
            }

            if (e.Key == Key.Right)
            {
                player.Move("right");
                Refresh();
            }

            if (e.Key == Key.Up)
            {
                player.Move("up");
                Refresh();
            }

            if (e.Key == Key.Down)
            {
                player.Move("down");
                Refresh();
            }
        }

        public void Refresh()
        {
            canvas.Children.Clear();
            graphics.DrawLevel();
            graphics.DrawPlayer();
        }
    }
}
