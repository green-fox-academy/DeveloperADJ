using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wanderer_Game.Controller
{
    class Enemy : Character
    {
        public Enemy(int currentHP, int maximumHP, int attackPower, int level):base(currentHP, maximumHP, attackPower, level)
        {
            this.currentHP = currentHP;
            this.maximumHP = maximumHP;
            this.attackPower = attackPower;
            this.level = level;
        }

        public override void Attack()
        {
            throw new NotImplementedException();
        }

        public override void Move(string direction)
        {
            throw new NotImplementedException();
        }
    }
}
