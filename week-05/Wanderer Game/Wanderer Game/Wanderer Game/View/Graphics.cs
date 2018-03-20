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
        Player player;
        double tileSize;


        public Graphics(FoxDraw foxDraw, Canvas canvas, Player player)
        {
            this.foxDraw = foxDraw;
            this.canvas = canvas;
            this.player = player;
            this.tileSize = canvas.Width / 10;
        }

        public void DrawLevel()
        {
            double xOffset = 0;
            double yOffset = 0;

            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    DrawTile(new Point(0 + xOffset, 0 + yOffset), Level.GetTileType(Level.one, y, x));
                    xOffset += tileSize;
                }
                xOffset = 0;
                yOffset += tileSize;
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
                tileSprite.Source = new BitmapImage(new Uri(Assets.Images.floor, UriKind.RelativeOrAbsolute));
            }
            else
            {
                tileSprite.Source = new BitmapImage(new Uri(Assets.Images.wall, UriKind.RelativeOrAbsolute));
            }

            tileSprite.Width = tileSize;
            tileSprite.Height = tileSize;
            foxDraw.AddImage(tileSprite, startPoint.X, startPoint.Y);
        }
    }
}

