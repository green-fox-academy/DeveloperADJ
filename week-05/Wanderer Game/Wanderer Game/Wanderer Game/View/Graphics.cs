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
        private static double tileSize;
        private static double canvasSize;

        public Graphics(FoxDraw foxDraw, Canvas canvas)
        {
            this.foxDraw = foxDraw;
            this.canvas = canvas;
            tileSize = canvas.Width / 10;
            canvasSize = canvas.Width;
        }

        public void DrawLevel(string level)
        {
            double xOffset = 0;
            double yOffset = 0;

            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    DrawTile(new Point(0 + xOffset, 0 + yOffset), Level.GetTileType(level, y, x));
                    xOffset += tileSize;
                }
                xOffset = 0;
                yOffset += tileSize;
            }
        }

        public void Refresh()
        {
            canvas.Children.Clear();
            DrawLevel(Assets.TextFiles.level1);

            foreach (var character in Characters.GetList())
            {
                DrawCharacter(character);
            }
        }

        public static double GetTileSize()
        {
            return tileSize;
        }

        internal static double GetCanvasSize()
        {
            return canvasSize;
        }

        public void DrawCharacter(Character character)
        {
            Image characterImage = new Image();
            characterImage.Source = new BitmapImage(new Uri(character.GetImage(), UriKind.RelativeOrAbsolute));
            characterImage.Width = tileSize;
            characterImage.Height = tileSize;
            foxDraw.AddImage(characterImage, character.GetPosition().X, character.GetPosition().Y);
        }

        public void DrawTile(Point startPoint, char tileType)
        {
            Image tileImage = new Image();

            if (tileType == '0')
            {
                tileImage.Source = new BitmapImage(new Uri(Assets.Images.floor, UriKind.RelativeOrAbsolute));
            }
            else
            {
                tileImage.Source = new BitmapImage(new Uri(Assets.Images.wall, UriKind.RelativeOrAbsolute));
            }

            tileImage.Width = tileSize;
            tileImage.Height = tileSize;
            foxDraw.AddImage(tileImage, startPoint.X, startPoint.Y);
        }
    }
}

