using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
        public bool isInBattle = false;
        public bool spaceIsPressed;
        public Enemy targetEnemy;
        public HeadsUpDisplay headsUpDisplay;
        private bool waitingForEnemy;

        public int CurrentHealth
        {
            get
            {
                return currentHealth;
            }
            set
            {
                currentHealth = value;
                if (currentHealth < 1)
                {
                    isDead = true;
                }
            }
        }

        public Player(HeadsUpDisplay hud, Enemies enemies, Canvas canvas, int level = 1, bool isDead = false) : base("Hero", canvas, Images.heroDown, 0, 0, 20 + Dice.HealthRoll(), 20 + Dice.HealthRoll(), 5 + Dice.AttackPowerRoll(), 2 + Dice.DefensePowerRoll())
        {
            this.enemies = enemies;
            this.canvas = canvas;
            this.level = level;
            this.isDead = isDead;
            headsUpDisplay = hud;
            isInBattle = false;
            spaceIsPressed = false;
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
            SetIsInBattle(true);

            
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

            headsUpDisplay.enemyStatus.Text = targetEnemy.GetStats();

            if (targetEnemy.isBoss == true)
            {
                Sound.PlayMusic(Sounds.bossBattleMusic);
            }
            else
            {
                Sound.PlayMusic(Sounds.battleMusic);
            }
        }

        public async void EnemyTurn(int milliSeconds)
        {
            waitingForEnemy = true;
            await Task.Delay(milliSeconds);
            if (targetEnemy.currentHealth > 0)
            {
                TakeDamageFrom(targetEnemy);
                Sound.PlaySoundEffect(Sounds.attack);
                headsUpDisplay.enemyBattle.Text += $"\n{targetEnemy.name} deals {targetEnemy.attack} DMG!\n";
            }
            waitingForEnemy = false;
        }

        public void PerformAttackRound(string skill)
        {
            if (!waitingForEnemy)
            {
                PlayerChoosesCommand(skill); 

                EnemyTurn(1000);

                if (currentHealth < 1)
                {
                    GameOver();
                    SetIsInBattle(false);
                    isDead = true;
                }
                else if (targetEnemy.currentHealth < 1)
                {
                    Kill(targetEnemy);
                    LevelUp();
                    SetIsInBattle(false);
                    headsUpDisplay.playerStatus.Text += "\nYou won!\n\nPress spacebar to continue..";
                }
            }
        }

        private void SetIsInBattle(bool state)
        {
            isInBattle = state;

            if (isInBattle)
            {
                Sound.PlayMusic(Sounds.battleMusic);
            }
            else
            {
                Sound.PlayMusic(Sounds.mapMusic);
            }
        }

        internal void ExecuteCommand(string skill)
        {
            if (!isDead && isInBattle)
            {
                headsUpDisplay.playerStatus.Text = GetStats();
                PerformAttackRound(skill);
                //Sound.PlaySoundEffect(Sounds.attack);
            }
            else
            {
                headsUpDisplay.playerStatus.Text = "GAME OVER\nStats:\n " + GetStats();
            }
        }

        internal void PerformHeal()
        {
            if (!isDead && isInBattle)
            {
                headsUpDisplay.playerStatus.Text = GetStats();
                PerformAttackRound("Heal");
            }
            else
            {
                headsUpDisplay.playerStatus.Text = "GAME OVER\nStats:\n " + GetStats();
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

        private void TakeDamageFrom(Enemy enemy)
        {
            currentHealth -= enemy.attack;
            SetStatusTextTo(GetStats());
        }

        private void PlayerChoosesCommand(string skill)
        {
            if (skill == "BasicAttack")
            {
                BasicAttack();
                headsUpDisplay.enemyStatus.Text = targetEnemy.GetStats();
                Sound.PlaySoundEffect(Sounds.attack);
            }
            else if (skill == "Heal")
            {
                Heal();
                Sound.PlaySoundEffect(Sounds.heal);
            }
        }

        private void BasicAttack()
        {
            int actualAttackDamage = attack;
            DealDamageToEnemy(actualAttackDamage);
            headsUpDisplay.playerBattle.Text += $"\n{name} deals {actualAttackDamage} DMG!\n";
        }

        private void Heal()
        {
            int healAmount = 5;
            if (healAmount + currentHealth > maximumHealth)
            {
                currentHealth = maximumHealth;
            }
            else
            {
                currentHealth += healAmount;
            }
            headsUpDisplay.playerBattle.Text += $"\n{name} heals for {healAmount} HP!\n";
        }

        private void DealDamageToEnemy(int amountOfDamage)
        {
            targetEnemy.currentHealth -= amountOfDamage;
        }

        public string GetStats()
        {
            return $"\nHero\nLevel {level}| HP: {currentHealth}/{maximumHealth} | DP: {defense} | SP: {attack}\n(Q): Attack, (W): Heal";
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

            SetStatusTextTo(GetStats());

            if (direction.Equals("up"))
            {
                MoveUp();
                SetPlayerImageTo(Images.heroUp);
            }
            else if (direction.Equals("right"))
            {
                MoveRight();
                SetPlayerImageTo(Images.heroRight);
            }
            else if (direction.Equals("down"))
            {
                MoveDown();

                SetPlayerImageTo(Images.heroDown);
            }
            else if (direction.Equals("left"))
            {
                MoveLeft();

                SetPlayerImageTo(Images.heroLeft);
            }
            CheckForEnemy();
        }

        private void SetStatusTextTo(string newStatusText)
        {
            headsUpDisplay.playerStatus.Text = newStatusText;
        }

        private void SetPlayerImageTo(string selectedImage)
        {
            image = selectedImage;
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
            maximumHealth += hpIncrease;
            defense += dpIncrease;
            attack += spIncrease;
        }
    }
}
