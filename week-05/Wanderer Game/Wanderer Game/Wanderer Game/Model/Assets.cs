using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wanderer_Game.Model
{
    public static class Assets
    {

        static private string assetsFolder = @"C:\Users\Arno\Desktop\DeveloperADJ\week-05\Wanderer Game\Wanderer Game\Wanderer Game\Assets\";

        public static class Images {
            public static string boss = assetsFolder + "boss.png";
            public static string floor = assetsFolder + "floor.png";
            public static string heroDown = assetsFolder + "hero-down.png";
            public static string heroLeft = assetsFolder + "hero-left.png";
            public static string heroRight = assetsFolder + "hero-right.png";
            public static string heroUp = assetsFolder + "hero-up.png";
            public static string skeleton = assetsFolder + "skeleton.png";
            public static string wall = assetsFolder + "wall.png";
        }

        public static class TextFiles {
            public static string level1 = assetsFolder + "level1.txt";
        }

    }
}
