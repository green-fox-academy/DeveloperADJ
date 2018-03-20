using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wanderer_Game.Model;

namespace Wanderer_Game.View
{
    class Level
    {
        public static string[] tiles;

        static char tileType;

        public static char GetTileType(string path, int y, int x)
        {
            tiles = File.ReadAllLines(path);

            try
            {
                tileType = tiles[y][x];
                return tileType;
            }
            catch (Exception)
            {

                return '1';
            }
        }
    }
}
