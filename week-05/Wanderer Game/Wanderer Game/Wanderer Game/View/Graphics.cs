using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using GreenFox;
using Wanderer_Game.Controller;
using Wanderer_Game.Model;

namespace Wanderer_Game.View
{
    public class Draw
    {
        FoxDraw foxDraw;
        Canvas canvas;
        Enemies enemies;
        HeadsUpDisplay headsUpDisplay;
        Player player;
        double tileSize;


        public Draw(Canvas canvas, FoxDraw foxDraw, Enemies enemies, HeadsUpDisplay hud, Player player)
        {
            this.canvas = canvas;
            this.foxDraw = foxDraw;
            this.enemies = enemies;
            this.headsUpDisplay = hud;
            this.player = player;
            tileSize = canvas.Width / 10;
        }

        public void Level(string level)
        {
            double xOffset = 0;
            double yOffset = 0;

            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    Tile(new Point(0 + xOffset, 0 + yOffset), View.Tile.GetTileType(Levels.level1, y, x));
                    xOffset += canvas.Width / 10;
                }
                xOffset = 0;
                yOffset += canvas.Width / 10;
            }
        }

        public async void RefreshWithDelay(int milliSeconds)
        {
            await Task.Delay(milliSeconds);
            headsUpDisplay.ResetBattleLog();
            Refresh();
        }

        public void Refresh()
        {
            canvas.Children.Clear();

            if (!player.isDead)
            {
                Level(Levels.level1);

                if (player.isInBattle)
                {
                    canvas.Children.Clear();
                    BattleScreen();
                }
                else
                {
                    Player(player);

                    foreach (var enemy in enemies.GetList())
                    {
                        Enemy(enemy);
                    }
                }
                DisplayStatus();
                DisplayBattleLog();
            }
            else
            {
                GameOverScreen();
                Sound.PlaySoundEffect(Sounds.gameOver);
            }
        }

        public void GameOverScreen()
        {
            canvas.Children.Clear();
            DisplayGameOverScreen();
        }

        private void DisplayGameOverScreen()
        {
            canvas.Children.Add(headsUpDisplay.gameOver);
            Canvas.SetTop(headsUpDisplay.gameOver, canvas.Width / 2);
            Canvas.SetLeft(headsUpDisplay.gameOver, canvas.Width / 2 - canvas.Width / 4);

        }

        public void Player(Character character)
        {
            Image characterImage = new Image();
            characterImage.Source = new BitmapImage(new Uri(character.GetImage(), UriKind.RelativeOrAbsolute));
            characterImage.Width = canvas.Width / 10;
            characterImage.Height = canvas.Width / 10;
            foxDraw.AddImage(characterImage, character.GetPosition().X, character.GetPosition().Y);
        }

        public void Enemy(Enemy enemy)
        {
            Image characterImage = new Image();
            characterImage.Source = new BitmapImage(new Uri(enemy.GetImage(), UriKind.RelativeOrAbsolute));

            characterImage.Width = canvas.Width / 10;
            characterImage.Height = canvas.Width / 10;
            foxDraw.AddImage(characterImage, enemy.GetPosition().X, enemy.GetPosition().Y);
        }

        public void Tile(Point startPoint, char tileType)
        {
            Image tileImage = new Image();

            if (tileType == '0')
            {
                tileImage.Source = new BitmapImage(new Uri(Images.floor, UriKind.RelativeOrAbsolute));
            }
            else
            {
                tileImage.Source = new BitmapImage(new Uri(Images.wall, UriKind.RelativeOrAbsolute));
            }

            tileImage.Width = canvas.Width / 10;
            tileImage.Height = canvas.Width / 10;
            foxDraw.AddImage(tileImage, startPoint.X, startPoint.Y);
        }

        public void DrawImage(string image, double x, double y, double width, double height)
        {
            Image myImage = new Image();

            myImage.Source = new BitmapImage(new Uri(image, UriKind.RelativeOrAbsolute));

            myImage.Width = width;
            myImage.Height = height;
            foxDraw.AddImage(myImage, x, y);
        }

        public void DisplayStatus()
        {
            canvas.Children.Add(headsUpDisplay.playerStatus);
            canvas.Children.Add(headsUpDisplay.enemyStatus);

            Canvas.SetTop(headsUpDisplay.playerStatus, canvas.Width);
            Canvas.SetTop(headsUpDisplay.enemyStatus, canvas.Width);
            Canvas.SetLeft(headsUpDisplay.enemyStatus, canvas.Width / 2);
        }



        public void DisplayBattleLog()
        {
            double fontSize = headsUpDisplay.enemyBattle.FontSize;

            canvas.Children.Add(headsUpDisplay.playerBattle);
            canvas.Children.Add(headsUpDisplay.enemyBattle);

            Canvas.SetTop(headsUpDisplay.playerBattle, canvas.Width + fontSize * 2);

            Canvas.SetTop(headsUpDisplay.enemyBattle, canvas.Width + fontSize * 3);
            Canvas.SetLeft(headsUpDisplay.enemyBattle, canvas.Width / 2);
        }

        public void BattleScreen()
        {
            canvas.Children.Clear();
            headsUpDisplay.playerStatus.Text = player.GetStats();
            DrawImage(Images.battleScreen, 0, -canvas.Width / 6, canvas.Width, canvas.Width);
            DrawImage(Images.playerBattle[0], canvas.Width / 2 - (canvas.Width / 5), canvas.Width / 2, tileSize, tileSize);
            if (player.targetEnemy.isBoss)
            {
                DrawImage(player.targetEnemy.GetImage(), canvas.Width / 2 + tileSize, canvas.Width / 2 - tileSize, tileSize * 2, tileSize * 2);
            }
            else
            {
                DrawImage(player.targetEnemy.GetImage(), canvas.Width / 2 + (canvas.Width / 5), canvas.Width / 2, tileSize, tileSize);
            }
        }
    }
}