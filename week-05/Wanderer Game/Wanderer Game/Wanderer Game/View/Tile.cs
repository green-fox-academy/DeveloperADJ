using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wanderer_Game.Model;

namespace Wanderer_Game.View
{
    class Tile
    {
        public static string[] tiles;

        public static char GetTileType(string path, int y, int x)
        {
            tiles = File.ReadAllLines(path);

            try
            {
                return tiles[y][x];
            }
            catch (Exception)
            {
                return '1';
            }
        }
    }
}
