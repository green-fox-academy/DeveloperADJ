using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using Wanderer_Game.Controller;

namespace Wanderer_Game.Model
{
    public class Text
    {
        public TextBlock playerStatus;
        public TextBlock enemyStatus;
        Player player;

        public Text(Player player)
        {
            this.player = player;

            playerStatus = new TextBlock
            {
                Text = "",
                Foreground = Brushes.White,
                FontSize = 10,
            };

            enemyStatus = new TextBlock
            {
                Text = "",
                Foreground = Brushes.Red,
                FontSize = 10
            };
        }

        public string StatusText(Character character)
        {
            string statusString = $"{character.name}";

            if (character is Player)
            {
                statusString += $"| Level: {player.level}";
            }

            statusString += $"| HP: {character.currentHP}/{character.maxHP} | DP: {character.defense} | SP: {character.attack}\n\n";

            return statusString;
        }

        public void LevelUp()
        {
            playerStatus.Text += $"\n{player.name} is now level {player.level}!";
            playerStatus.Text += "\n\nPress spacebar to continue..";
        }

        public void ResetText()
        {
            playerStatus.Text = "";
            enemyStatus.Text = "";
        }
    }
}
