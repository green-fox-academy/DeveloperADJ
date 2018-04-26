using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wanderer_Game.Model
{
    public static class Characters
    {
        private static List<Character> characters = new List<Character>();

        public static void AddToList(Character character)
        {
            characters.Add(character);
        }

        public static List<Character> GetList()
        {
            return characters;
        }
    }
}
