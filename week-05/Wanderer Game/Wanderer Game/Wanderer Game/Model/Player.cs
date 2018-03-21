using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Wanderer_Game.Model;
using Wanderer_Game.View;

namespace Wanderer_Game.Controller
{
    public class Player : Character
    {
        Enemies enemies;

        public int level;
        public bool isDead;
        public bool inBattle;
        Status status;
        public bool spaceIsPressed;

        public Player(string name, Status status, Enemies enemies, Canvas canvas, string image, int currentHP = 20, int maxHP = 20, int level = 1, int gridPositionX = 0, int gridPositionY = 0, int attack = 5, int defense = 2, bool isDead = false) : base(name, canvas, image, gridPositionX, gridPositionY, currentHP, maxHP, attack, defense)
        {
            this.name = name;
            this.status = status;
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
            this.isDead = isDead;
            this.inBattle = false;
            this.spaceIsPressed = false;

            status.content.Text = $"Hero (Level {level}) HP: {currentHP}/{maxHP} | DP: {defense} | SP: {attack}";
        }

        public void CheckForEnemy()
        {
            if (EnemyPresent())
            {
                status.content.Text = "";
                Fight();
            }
        }

        public void Fight()
        {
            inBattle = true;

            for (int i = 0; i < enemies.GetList().Count; i++)
            {
                if (enemies.GetList()[i].GetPosition() == this.GetPosition())
                {
                    var targetEnemy = enemies.GetList()[i];

                    while (currentHP > 0 && targetEnemy.currentHP > 0)
                    {
                        targetEnemy.currentHP -= attack;
                        status.content.Text += $"{name} attacks {targetEnemy.name} [{targetEnemy.currentHP}/{targetEnemy.maxHP}]!\n";

                        if (targetEnemy.currentHP > 0)
                        {
                            currentHP -= targetEnemy.attack;
                            status.content.Text += $"{targetEnemy.name} attacks {name} [{currentHP}/{maxHP}]!!\n";
                        }
                    }

                    if (currentHP < 0)
                    {
                        isDead = true;
                        status.content.Text += "You Died!";
                    }
                    else
                    {
                        status.content.Text += "You won!\n\nPress spacebar to continue..";
                        enemies.GetList().RemoveAt(i);
                        LevelUp();
                    }
                }
            }
        }

        public string GetStatus()
        {
            return $"Hero (Level {level}) HP: {currentHP}/{maxHP} | DP: {defense} | SP: {attack}";
        }

        public bool FightWon()
        {
            return true;
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
            status.content.Text = GetStatus();
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
            int hpIncrease = randomHP.Next(1, 7);

            Random randomDP = new Random();
            int dpIncrease = randomHP.Next(1, 7);

            Random randomSP = new Random();
            int spIncrease = randomHP.Next(1, 7);

            level++;
            maxHP += hpIncrease;
            defense += dpIncrease;
            attack += spIncrease;
        }
    }
}
