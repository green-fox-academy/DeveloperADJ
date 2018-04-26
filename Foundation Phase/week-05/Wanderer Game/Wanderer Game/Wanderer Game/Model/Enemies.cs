using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wanderer_Game.Controller;

namespace Wanderer_Game.Model
{
    public class Enemies
    {
        static List<Enemy> enemies = new List<Enemy>();
        Random random = new Random();

        public void Add(Enemy enemy)
        {
            enemies.Add(enemy);
        }

        public void Move()
        {
            foreach (var enemy in enemies)
            {
                int randomNumber = random.Next(0,4);
                enemy.Move(randomNumber);
            }
        }

        public List<Enemy> GetList()
        {
            return enemies;
        }
    }
}
