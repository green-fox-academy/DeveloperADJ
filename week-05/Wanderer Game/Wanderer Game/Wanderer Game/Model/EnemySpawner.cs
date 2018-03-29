using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Wanderer_Game.Controller;

namespace Wanderer_Game.Model
{
    public class EnemySpawner
    {
        Player player;
        Canvas canvas;

        public EnemySpawner(Player player, Canvas canvas)
        {
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
                        Enemies.enemies.Add(new Enemy("SkeletonA", player, canvas, Images.skeleton, i, j));
                    }
                }
            }
        }



    }
}
