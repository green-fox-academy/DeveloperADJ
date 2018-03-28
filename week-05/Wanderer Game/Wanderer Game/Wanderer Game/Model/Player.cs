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
        public bool IsInBattle { get { return isInBattle; } set {

            } }
        public bool spaceIsPressed;
        public Enemy targetEnemy;
        public HeadsUpDisplay headsUpDisplay;
        private bool waitingForEnemy;

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
            if (targetEnemy.currentHP > 0)
            {
                TakeDamageFrom(targetEnemy);
                Sound.PlaySoundEffect(Sounds.attack);
                headsUpDisplay.enemyBattle.Text += $"\n{targetEnemy.name} deals {targetEnemy.attack} DMG!\n";
            }
            waitingForEnemy = false;
        }

        public void PerformAttackRound()
        {
            if (!waitingForEnemy)
            {
                PlayerTurn(); 

                EnemyTurn(1000);

                if (currentHP < 1)
                {
                    GameOver();
                    isInBattle = false;
                    isDead = true;
                }
                else if (targetEnemy.currentHP < 1)
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

            if (IsInBattle)
            {
                Sound.PlayMusic(Sounds.battleMusic);
            }
            else
            {
                Sound.PlayMusic(Sounds.mapMusic);
            }
        }

        internal void PerformBasicAttack()
        {
            if (!isDead && isInBattle)
            {
                headsUpDisplay.playerStatus.Text = GetPlayerStats();
                PerformAttackRound();
                Sound.PlaySoundEffect(Sounds.attack);
            }
            else
            {
                headsUpDisplay.playerStatus.Text = "GAME OVER\nStats:\n " + GetPlayerStats();
            }
        }

        internal void PerformHeal()
        {
            if (!isDead && isInBattle)
            {
                headsUpDisplay.playerStatus.Text = GetPlayerStats();
                PerformAttackRound();
            }
            else
            {
                headsUpDisplay.playerStatus.Text = "GAME OVER\nStats:\n " + GetPlayerStats();
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
            currentHP -= enemy.attack;
            SetStatusTextTo(GetPlayerStats());
        }

        private void PlayerTurn()
        {
            DealDamageToEnemy(attack);
            headsUpDisplay.playerBattle.Text += $"\n{name} deals {attack} DMG!\n";
        }

        private void DealDamageToEnemy(int amountOfDamage)
        {
            targetEnemy.currentHP -= amountOfDamage;
        }

        public string GetPlayerStats()
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

            SetStatusTextTo(GetPlayerStats());

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
            maxHP += hpIncrease;
            defense += dpIncrease;
            attack += spIncrease;
        }
    }
}
