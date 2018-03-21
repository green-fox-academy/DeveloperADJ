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
    public class Graphics
    {
        FoxDraw foxDraw;
        Canvas canvas;
        Enemies enemies;
        Status Stats;
        Player player;

        public Graphics(Canvas canvas, FoxDraw foxDraw, Enemies enemies, Status Stats, Player player)
        {
            this.canvas = canvas;
            this.foxDraw = foxDraw;
            this.enemies = enemies;
            this.Stats = Stats;
            this.player = player;
        }

        public void DrawLevel(string level)
        {
            double xOffset = 0;
            double yOffset = 0;

            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    DrawTile(new Point(0 + xOffset, 0 + yOffset), Tile.GetTileType(Levels.level1, y, x));
                    xOffset += canvas.Width / 10;
                }
                xOffset = 0;
                yOffset += canvas.Width / 10;
            }
        }

        public void Refresh()
        {
            canvas.Children.Clear();

            if (!player.isDead)
            {
                DrawLevel(Levels.level1);

                foreach (var character in Characters.GetList())
                {
                    DrawCharacter(character);
                }

                foreach (var enemy in enemies.GetList())
                {
                    DrawCharacter(enemy);
                }
            }
                DrawStats();
        }

        public void DrawCharacter(Character character)
        {
            Image characterImage = new Image();
            characterImage.Source = new BitmapImage(new Uri(character.GetImage(), UriKind.RelativeOrAbsolute));
            characterImage.Width = canvas.Width / 10;
            characterImage.Height = canvas.Width / 10;
            foxDraw.AddImage(characterImage, character.GetPosition().X, character.GetPosition().Y);
        }

        public void DrawTile(Point startPoint, char tileType)
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

        public void DrawStats()
        {
            canvas.Children.Add(Stats.content);
            Canvas.SetTop(Stats.content, canvas.Width);
        }

    }
}

