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
        public bool isBoss = false;
        public Enemy(string name, Player player, Canvas canvas, string image, int gridPositionX, int gridPositionY, bool isBoss = false, int currentHP = 10, int maxHP = 10, int attack = 2, int defense = 0) : base(name, canvas, isBoss ? Images.boss[0] : Images.enemy[0], gridPositionX, gridPositionY, currentHP, maxHP, attack, defense)
        {
            this.name = name;
            this.player = player;
            this.canvas = canvas;
            this.gridPositionX = gridPositionX;
            this.gridPositionY = gridPositionY; 
            this.currentHealth = currentHP;
            this.maximumHealth = maxHP;
            this.attack = attack;
            this.isBoss = isBoss;
            this.defense = defense;
        }

        public string GetStats()
        {
            return $"\n{name}\n HP: {currentHealth}/{maximumHealth} | DP: {defense} | SP: {attack}\n";
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

