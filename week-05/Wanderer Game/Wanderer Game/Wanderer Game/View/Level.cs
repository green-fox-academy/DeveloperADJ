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
        //public static int[,] tiles = {
        //    {0,0,0,1,0,1,0,0,0,0},
        //    {0,0,0,1,0,1,0,1,1,0},
        //    {0,1,1,1,0,1,0,1,1,0},
        //    {0,0,0,0,0,0,0,0,0,0},
        //    {1,1,1,1,0,1,1,1,1,0},
        //    {0,1,0,1,0,0,0,0,1,0},
        //    {0,1,0,1,0,1,1,0,1,0},
        //    {0,0,0,0,0,1,1,0,1,0},
        //    {0,1,1,1,0,0,0,0,1,0},
        //    {0,0,0,1,0,1,1,0,1,0}
        //};

        public static string[] tiles;

        void FileToMultiDimensionalArray()
        {

        }

        public static int GetTileType(string path, int i, int j)
        {
            tiles = File.ReadAllLines(path);

            return tiles[i][j];
        }

        public static string one = Assets.TextFiles.level1;
    }
}
