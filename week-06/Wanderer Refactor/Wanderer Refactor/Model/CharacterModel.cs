using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Wanderer_Refactor
{
    public abstract class CharacterModel
    {
        protected int currentHealth;
        protected int maximumHealth;
        protected int strikePoints;
        protected int gridPositionX;
        protected int gridPositionY;
        protected bool isDead = false;

        protected CharacterModel(int currentHealth, int maximumHealth, int strikePoints, int gridPositionX, int gridPositionY, bool isDead)
        {
            this.currentHealth = currentHealth;
            this.maximumHealth = maximumHealth;
            this.strikePoints = strikePoints;
            this.gridPositionX = gridPositionX;
            this.gridPositionY = gridPositionY;
            this.isDead = isDead;
        }

        public Point GetPosition()
        {
            return new Point(gridPositionX, gridPositionY);
        }

        public void MoveUp()
        {
            gridPositionY -= 1;
        }

        public void MoveDown()
        {
            gridPositionY += 1;
        }

        public void MoveLeft()
        {
            gridPositionX -= 1;
        }

        public void MoveRight()
        {
            gridPositionX += 1;
        }

        public abstract void BasicAttack();
    }
}
