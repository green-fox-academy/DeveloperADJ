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

namespace Wanderer_Game.View
{
    public class Graphics
    {
        FoxDraw foxDraw;
        Canvas canvas;
        Player player;

        public Graphics(FoxDraw foxDraw, Canvas canvas, Player player)
        {
            this.foxDraw = foxDraw;
            this.canvas = canvas;
            this.player = player;
        }

        public void DrawEnvironment()
        {
            DrawTiles();
        }

        public void DrawTiles()
        {
            double xOffset = 0;
            double yOffset = 0;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    DrawTile(new Point(0 + xOffset, 0 + yOffset), Tiles.tiles[i, j]);
                    xOffset += canvas.Width / 10;
                }
                xOffset = 0;
                yOffset += canvas.Height / 10;
            }
        }

        

        public void DrawPlayer()
        {
            Image playerSprite = new Image();
            playerSprite.Source = new BitmapImage(new Uri(player.GetImage(), UriKind.RelativeOrAbsolute));
            playerSprite.Width = canvas.Width / 10;
            playerSprite.Height = canvas.Height / 10;
            foxDraw.AddImage(playerSprite, player.GetPosition().X, player.GetPosition().Y);
        }

        public void DrawTile(Point startPoint, int tileType)
        {
            Image tileSprite = new Image();

            if (tileType == 0)
            {
                tileSprite.Source = new BitmapImage(new Uri("./Assets/floor.png", UriKind.RelativeOrAbsolute));
            }
            else
            {
                tileSprite.Source = new BitmapImage(new Uri("./Assets/wall.png", UriKind.RelativeOrAbsolute));
            }

            tileSprite.Width = canvas.Width / 10;
            tileSprite.Height = canvas.Height / 10;
            foxDraw.AddImage(tileSprite, startPoint.X, startPoint.Y);
        }
    }
}

