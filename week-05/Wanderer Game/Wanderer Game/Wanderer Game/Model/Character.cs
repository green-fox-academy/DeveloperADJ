﻿using System;
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

        public int currentHealth;
        public int maximumHealth;

        public int attack;
        public int defense;
        public string name;

        public Character(string name, Canvas canvas, string image, int gridPositionX, int gridPositionY, int currentHealth, int maximumHealth, int attack, int defense)
        {
            this.name = name;
            this.canvas = canvas;

            this.positionX = gridPositionX * (canvas.Width / 10);
            this.positionY = gridPositionY * (canvas.Width / 10);

            this.gridPositionX = gridPositionX;
            this.gridPositionY = gridPositionY;

            this.currentHealth = currentHealth;
            this.maximumHealth = maximumHealth;

            this.image = image;

            this.attack = attack;
            this.defense = defense;
        }

        public void SetImage(string file)
        {
            image = file;
        }

        public Point GetPosition()
        {
            return new Point(positionX, positionY);
        }

        public string GetImage()
        {
            return image;
        }

        public void MoveUp()
        {
            if (!((positionY - canvas.Width / 10) < 0) && Tile.GetTileType(Levels.level1, gridPositionY - 1, gridPositionX) == '0')
            {
                gridPositionY--;
                positionY -= canvas.Width / 10;
            }
        }

        public void MoveLeft()
        {
            if (!(positionX - canvas.Width / 10 < 0) && Tile.GetTileType(Levels.level1, gridPositionY, gridPositionX - 1) == '0')
            {
                gridPositionX--;
                positionX -= canvas.Width / 10;
            }
        }

        public void MoveDown()
        {
            if (!(positionY + canvas.Width / 10 >= canvas.Width) && Tile.GetTileType(Levels.level1, gridPositionY + 1, gridPositionX) == '0')
            {
                gridPositionY++;
                positionY += canvas.Width / 10;
            }
        }

        public void MoveRight()
        {
            if (!(positionX + (canvas.Width / 10) >= canvas.Width) && Tile.GetTileType(Levels.level1, gridPositionY, gridPositionX + 1) == '0')
            {
                gridPositionX++;
                positionX += canvas.Width / 10;
            }
        }
    }
}
