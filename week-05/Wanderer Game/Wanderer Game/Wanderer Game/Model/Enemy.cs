using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Wanderer_Game.Model;
using Wanderer_Game.View;

namespace Wanderer_Game.Controller
{
    public class Enemy : Character
    {
        Player player;

        public Enemy(Player player, Canvas canvas, string image, int gridPositionX, int gridPositionY, bool isBoss = false, int attack = 2, int defense = 0) : base(canvas, image, gridPositionX, gridPositionY, attack, defense)
        {
            this.player = player;
            this.canvas = canvas;
            this.image = isBoss ? Images.boss : Images.skeleton;
            this.gridPositionX = gridPositionX;
            this.gridPositionY = gridPositionY;
            this.attack = attack;
            this.defense = defense;
        }

        //public void Fight()
        //{
        //    for (int i = 0; i < enemies.GetList().Count; i++)
        //    {
        //        if (enemies.GetList()[i].GetPosition() == this.GetPosition())
        //        {
        //            enemies.GetList().RemoveAt(i);
        //        }
        //    }
        //}

        //public bool EnemyPresent()
        //{
        //    for (int i = 0; i < enemies.GetList().Count; i++)
        //    {
        //        if (enemies.GetList()[i].GetPosition() == this.GetPosition())
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        public void Move(int number)
        {
            int randomNumber = number;

            if (randomNumber == 0)
            {
                    MoveUp();
            }
            else if (randomNumber == 1)
            {
                    MoveRight();
            }
            else if (randomNumber == 2)
            {
                    MoveDown();
            }
            else if (randomNumber == 3)
            {
                    MoveLeft();
            }
        }
    }
}

