using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Wanderer_Game.Model;
using Wanderer_Game.View;

namespace Wanderer_Game
{
    public class Character
    {
        protected double positionX;
        protected double positionY;

        protected int gridPositionX;
        protected int gridPositionY;

        protected string image;
        protected Canvas canvas;

        protected double tileSize;
        protected double canvasSize;

        protected Character(Canvas canvas, string image, int gridPositionX, int gridPositionY)
        {
            this.canvas = canvas;
            positionX = gridPositionX * tileSize;
            positionY = gridPositionY * tileSize;
            this.gridPositionX = gridPositionX;
            this.gridPositionY = gridPositionY;
            this.image = image;
            tileSize = canvas.Width / 10;
            canvasSize = canvas.Width;
        }

        public void Move(string direction)
        {
            if (direction.Equals("up"))
            {
                image = Assets.Images.heroUp;
                if (!((positionY - tileSize) < 0) && Level.GetTileType(Assets.TextFiles.level1, gridPositionY - 1, gridPositionX) == '0')
                {
                    gridPositionY--;
                    positionY -= tileSize;
                }
            }
            else if (direction.Equals("right"))
            {
                image = Assets.Images.heroRight;
                if (!(positionX + (tileSize) >= canvasSize) && Level.GetTileType(Assets.TextFiles.level1, gridPositionY, gridPositionX + 1) == '0')
                {
                    gridPositionX++;
                    positionX += tileSize;
                }
            }
            else if (direction.Equals("down"))
            {
                image = Assets.Images.heroDown;

                if (!(positionY + tileSize >= canvasSize) && Level.GetTileType(Assets.TextFiles.level1, gridPositionY + 1, gridPositionX) == '0')
                {
                    gridPositionY++;
                    positionY += tileSize;
                }
            }
            else if (direction.Equals("left"))
            {
                image = Assets.Images.heroLeft;

                if (!(positionX - tileSize < 0) && Level.GetTileType(Assets.TextFiles.level1, gridPositionY, gridPositionX - 1) == '0')
                {
                    gridPositionX--;
                    positionX -= tileSize;
                }
            }
        }

        public Point GetPosition()
        {
            return new Point(positionX, positionY);
        }


        public string GetImage()
        {
            return image;
        }
    }
}
