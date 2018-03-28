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
        Draw graphics;
        public Player player;
        Enemies enemies;
        GameSetup gameSetup;
        HeadsUpDisplay headsUpDisplay;
        Animator animator;

        int turnCount = 0;

        public MainWindow()
        {
            InitializeComponent();
            FoxDraw foxDraw = new FoxDraw(canvas);

            gameSetup = new GameSetup(canvas, 500);
            enemies = new Enemies();
            headsUpDisplay = new HeadsUpDisplay(canvas);
            player = new Player(headsUpDisplay, enemies, canvas);
            graphics = new Draw(canvas, foxDraw, enemies, headsUpDisplay, player);

            Characters.AddToList(player);

            enemies.Add(new Enemy("Boss", player, canvas, Images.boss[0], 9, 9, true, 20, 20, 10));
            enemies.Add(new Enemy("SkeletonA", player, canvas, Images.skeleton, 0, 5));
            enemies.Add(new Enemy("SkeletonB", player, canvas, Images.skeleton, 4, 3));
            enemies.Add(new Enemy("SkeletonC", player, canvas, Images.skeleton, 7, 8));

            animator = new Animator(player, graphics);

            graphics.Refresh();
            Sound.PlayMusic(Sounds.mapMusic);
            animator.AnimatePlayer();
            animator.AnimateEnemy();
        }

        private void WindowKeyDown(object sender, KeyEventArgs e)
        {
            if (!player.isInBattle)
            {
                turnCount++;
                Sound.PlaySoundEffect(Sounds.walk);
                player.wasMoving = true;
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

                if (turnCount % 2 == 0)
                {
                    enemies.Move();
                }
            }
            else
            {
                if (e.Key == Key.Q)
                {
                    player.ExecuteCommand("BasicAttack");
                    if (player.targetEnemy.currentHealth < 1)
                    {   
                        graphics.RefreshWithDelay(2000);
                        headsUpDisplay.playerStatus.Text = player.GetStats();
                    }

                    if (player.CurrentHealth < 1)
                    {
                        graphics.GameOverScreen();
                        Sound.PlayMusic(Sounds.gameOver);
                    }
                }

                if (e.Key == Key.W)
                {
                    player.ExecuteCommand("Heal");
                    if (player.targetEnemy.currentHealth < 1)
                    {
                        graphics.RefreshWithDelay(2000);
                        headsUpDisplay.playerStatus.Text = player.GetStats();
                    }

                    if (player.CurrentHealth < 1)
                    {
                        graphics.GameOverScreen();
                        Sound.PlaySoundEffect(Sounds.gameOver);
                        Sound.PlayMusic(Sounds.gameOverMusic);
                    }
                }
            }
        }
    }
}
