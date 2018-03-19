using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wanderer_Game
{
    public abstract class Character
    {
        protected int currentHP;
        protected int maximumHP;
        protected int attackPower;
        protected int level;

        protected Character(int currentHP, int maximumHP, int attackPower, int level)
        {
            this.currentHP = currentHP;
            this.maximumHP = maximumHP;
            this.attackPower = attackPower;
            this.level = level;
        }

        public abstract void Move(string direction);
        public abstract void Attack();
    }
}
