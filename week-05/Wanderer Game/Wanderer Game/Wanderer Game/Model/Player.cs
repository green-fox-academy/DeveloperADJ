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
        public bool isInBattle;
        public bool spaceIsPressed;
        public Enemy targetEnemy;
        public HeadsUpDisplay headsUpDisplay;
        public int CurrentHealth
        {
            get
            {
                return currentHP;
            }
            set
            {
                currentHP = value;
                if (currentHP < 1)
                {
                    isDead = true;
                }
            }
        }

        public Player(string name, HeadsUpDisplay hud, Enemies enemies, Canvas canvas, string image, int currentHP = 20, int maxHP = 20, int level = 1, int gridPositionX = 0, int gridPositionY = 0, int attack = 5, int defense = 2, bool isDead = false) : base(name, canvas, image, gridPositionX, gridPositionY, currentHP = 20, maxHP = 20, attack, defense)
        {
            this.name = name;
            this.enemies = enemies;
            this.canvas = canvas;
            this.image = image;
            this.currentHP = currentHP;
            this.maxHP = maxHP;
            this.level = level;
            this.isDead = isDead;
            this.headsUpDisplay = hud;
            isInBattle = false;
            spaceIsPressed = false;

            hud.playerStatus.Text = $"{name} (Level {level}) HP: {currentHP}/{maxHP} | DP: {defense} | SP: {attack}\n";
        }

        public void CheckForEnemy()
        {
            if (EnemyPresent())
            {
                headsUpDisplay.playerStatus.Text = "";
                EnterBattle();
            }
        }

        public void EnterBattle()
        {
            isInBattle = true;
            TargetTheEnemy();
        }

        

        private void TargetTheEnemy()
        {
            for (int i = 0; i < enemies.GetList().Count; i++)
            {
                if (enemies.GetList()[i].GetPosition() == this.GetPosition())
                {
                    targetEnemy = enemies.GetList()[i];
                }
            }
        }

        public void PerformAttackRound()
        {
            PlayerTurn();

            if (targetEnemy.currentHP > 0)
            {
                EnemyTurn();
            }

            if (currentHP < 1)
            {
                GameOver();
                isInBattle = false;
            }
            else if (targetEnemy.currentHP < 1)
            {
                Kill(targetEnemy);
                LevelUp();
                isInBattle = false;
                headsUpDisplay.playerStatus.Text += "\nYou won!\n\nPress spacebar to continue..";
            }
        }

        internal void PerformBasicAttack()
        {
            if (!isDead && isInBattle)
            {
                headsUpDisplay.playerStatus.Text = GetStatus();
                PerformAttackRound();
            }
            else
            {
                headsUpDisplay.playerStatus.Text = "GAME OVER\nStats:\n " + GetStatus();
            }
        }

        private void Kill(Enemy targetEnemy)
        {
            int index = enemies.GetList().IndexOf(targetEnemy);
            enemies.GetList().RemoveAt(index);
        }

        private void GameOver()
        {
            headsUpDisplay.playerStatus.Text += "\nYou Died!";
        }

        private void EnemyTurn()
        {
            currentHP -= targetEnemy.attack;
            headsUpDisplay.enemyBattle.Text += $"\n{targetEnemy.name} deals {targetEnemy.attack} DMG!\n";
        }

        private void PlayerTurn()
        {
            targetEnemy.currentHP -= attack;
            headsUpDisplay.playerBattle.Text += $"\n{name} deals {attack} DMG!\n";
        }

        public string GetStatus()
        {
            return $"\nHero (Level {level}) HP: {currentHP}/{maxHP} | DP: {defense} | SP: {attack}\n";
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
            headsUpDisplay.playerStatus.Text = GetStatus();
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
