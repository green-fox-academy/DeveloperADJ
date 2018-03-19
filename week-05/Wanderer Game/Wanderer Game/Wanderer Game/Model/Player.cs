using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wanderer_Game.Controller
{
    class Player : Character
    {
        int currentExp;
        int nextLevelExp;
        
        public Player(int currentHP, int maximumHP, int attackPower, int currentExp, int nextLevelExp, int level):base(currentHP, maximumHP, attackPower, level) 
        {
            this.currentHP = currentHP;
            this.maximumHP = maximumHP;
            this.attackPower = attackPower;
            this.currentExp = currentExp;
            this.nextLevelExp = nextLevelExp;
            this.level = level;
        }

        public override void Attack()
        {
            throw new NotImplementedException();
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }
    }
}
