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
using Wanderer_Game.Model;
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
        Enemies enemies;
        GameSetup gameSetup;
        Text text;

        public MainWindow()
        {
            InitializeComponent();
            FoxDraw foxDraw = new FoxDraw(canvas);

            gameSetup = new GameSetup(canvas, 300);

            enemies = new Enemies();
            player = new Player(enemies, canvas, Images.heroDown);

            text = new Text(canvas, player);

            graphics = new Graphics(canvas, foxDraw, enemies, text, player);

            Characters.AddToList(player);


            enemies.Add(new Enemy(player, canvas, Images.boss, 9, 9, true));
            enemies.Add(new Enemy(player, canvas, Images.skeleton, 0, 5));
            enemies.Add(new Enemy(player, canvas, Images.skeleton, 4, 3));
            enemies.Add(new Enemy(player, canvas, Images.skeleton, 7, 8));

            graphics.Refresh();
        }

        private void WindowKeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.Key == Key.Left)
            {
                player.Move("left");
                graphics.Refresh();
            }

            if (e.Key == Key.Right)
            {
                player.Move("right");
                graphics.Refresh();
            }

            if (e.Key == Key.Up)
            {
                player.Move("up");
                graphics.Refresh();
            }

            if (e.Key == Key.Down)
            {
                player.Move("down");
                graphics.Refresh();
            }

            enemies.Move();
        }
    }
}
