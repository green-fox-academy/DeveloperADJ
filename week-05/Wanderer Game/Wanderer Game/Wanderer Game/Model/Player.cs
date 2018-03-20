using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Wanderer_Game.Model;
using Wanderer_Game.View;

namespace Wanderer_Game.Controller
{
    public class Player : Character
    {
        Enemies enemies;

        public Player(Enemies enemies, Canvas canvas, string image) : base(canvas, image)
        {
            this.enemies = enemies;
            this.canvas = canvas;
            this.image = image;
        }

        public void CheckForEnemy()
        {
            if (EnemyPresent())
            {
                Fight();
            }
        }

        public void Fight()
        {
            for (int i = 0; i < enemies.GetList().Count; i++)
            {
                if (enemies.GetList()[i].GetPosition() == this.GetPosition())
                {
                    enemies.GetList().RemoveAt(i);
                }
            }
        }

        public bool EnemyPresent()
        {
            for (int i = 0; i < enemies.GetList().Count; i++)
            {
                if (enemies.GetList()[i].GetPosition() == this.GetPosition())
                {
                    return true;
                }
            }
            return false;
        }

        public void Move(string direction)
        {
            CheckForEnemy();

            if (direction.Equals("up"))
            {
                MoveUp();

                image = Images.heroUp;
            }
            else if (direction.Equals("right"))
            {
                MoveRight();

                image = Images.heroRight;
            }
            else if (direction.Equals("down"))
            {
                MoveDown();

                image = Images.heroDown;
            }
            else if (direction.Equals("left"))
            {
                MoveLeft();

                image = Images.heroLeft;
            }

            CheckForEnemy();
        }
    }
}
