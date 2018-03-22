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
        public bool isBoss;
        public Enemy(string name, Player player, Canvas canvas, string image, int gridPositionX, int gridPositionY, bool isBoss = false, int currentHP = 10, int maxHP = 10, int attack = 2, int defense = 0) : base(name, canvas, image, gridPositionX, gridPositionY, currentHP, maxHP, attack, defense)
        {
            this.name = name;
            this.player = player;
            this.canvas = canvas;
            this.image = isBoss ? Images.boss : Images.skeleton;
            this.gridPositionX = gridPositionX;
            this.gridPositionY = gridPositionY;
            this.currentHP = currentHP;
            this.maxHP = maxHP;
            this.attack = attack;
            this.isBoss = isBoss;
            this.defense = defense;
        }

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

