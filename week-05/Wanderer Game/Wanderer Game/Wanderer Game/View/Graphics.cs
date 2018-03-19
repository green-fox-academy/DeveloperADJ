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

namespace Wanderer_Game.View
{
    public class Graphics
    {
        static public void DrawEnvironment(FoxDraw foxDraw, Canvas canvas)
        {
            DrawTiles(canvas, foxDraw);
        }

        static public void DrawTiles(Canvas canvas, FoxDraw foxDraw)
        {
            double xOffset = 0;
            double yOffset = 0;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    DrawTile(canvas, foxDraw, new Point(0 + xOffset, 0 + yOffset), Tiles.tiles[i, j]);
                    xOffset += canvas.Width / 10;
                }
                xOffset = 0;
                yOffset += canvas.Height / 10;
            }
        }

        public static void DrawPlayer(FoxDraw foxDraw, Canvas canvas)
        {
            Image playerSprite = new Image();
            playerSprite.Source = new BitmapImage(new Uri("./Assets/hero-down.png", UriKind.RelativeOrAbsolute));
            playerSprite.Width = canvas.Width / 10;
            playerSprite.Height = canvas.Height / 10;
            foxDraw.AddImage(playerSprite, 0, 0);
        }

        static public void DrawTile(Canvas canvas, FoxDraw foxDraw, Point startPoint, int tileType)
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

