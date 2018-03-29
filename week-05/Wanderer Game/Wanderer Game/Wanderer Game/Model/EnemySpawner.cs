using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Wanderer_Game.Controller;
using Wanderer_Game.View;

namespace Wanderer_Game.Model
{
    public class EnemySpawner
    {
        Player player;
        Canvas canvas;
        Draw graphics;

        public EnemySpawner(Player player, Canvas canvas, Draw graphics)
        {
            this.graphics = graphics;
            this.player = player;
            this.canvas = canvas;
        }

        public void AddEnemiesToMap()
        { 
            string[] level = File.ReadAllLines(Levels.maps[Levels.stageCounter]);

            for (int i = 0; i < level.Length; i++)
            {
                for (int j = 0; j < level[i].Length; j++)
                {
                    if (level[i][j] == 'E') {
                        Enemies.enemies.Add(new Enemy(graphics, $"Enemy {i}", player, canvas, Images.skeleton, j, i));
                    }

                    if (level[i][j] == 'B')
                    {
                        Enemies.enemies.Add(new Enemy(graphics, "Boss", player, canvas, Images.boss[0], j, i, true, 50, 50, 10));
                    }
                }
            }
        }
    }
}
