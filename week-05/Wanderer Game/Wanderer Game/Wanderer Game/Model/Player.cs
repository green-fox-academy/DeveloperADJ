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
        public int currentHP;
        public int maxHP;
        public int level;

        public Player(Enemies enemies, Canvas canvas, string image, int currentHP = 10, int maxHP = 10, int level = 1, int gridPositionX = 0, int gridPositionY = 0, int attack = 10, int defense = 10) : base(canvas, image, gridPositionX, gridPositionY, attack, defense)
        {
            this.enemies = enemies;
            this.canvas = canvas;
            this.image = image;
            this.currentHP = currentHP;
            this.maxHP = maxHP;
            this.level = level;
            this.gridPositionX = gridPositionX;
            this.gridPositionY = gridPositionY;
            this.attack = attack;
            this.defense = defense;
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

            bool fightWon = true;

            if (fightWon)
            {
                level++;
                LevelUp();
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

        public void LevelUp()
        {
            Random randomHP = new Random();
            int hpIncrease = randomHP.Next(1,7);

            Random randomDP = new Random();
            int dpIncrease = randomHP.Next(1, 7);

            Random randomSP = new Random();
            int spIncrease = randomHP.Next(1, 7);

            maxHP += hpIncrease;
            defense += dpIncrease;
            attack += spIncrease;
        }
    }
}
