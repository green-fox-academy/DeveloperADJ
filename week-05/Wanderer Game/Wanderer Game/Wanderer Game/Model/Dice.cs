using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wanderer_Game.Model
{
    public static class Dice
    {
        public static int HealthRoll()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }

        public static int AttackPowerRoll()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }

        public static int DefensePowerRoll()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }

        static Random combatRandom = new Random();

        public static int CombatRoll()
        {
            return combatRandom.Next(1, 7);
        }
    }
}
