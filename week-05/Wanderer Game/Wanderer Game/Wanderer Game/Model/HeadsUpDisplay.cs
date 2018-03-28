using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Wanderer_Game.Controller;

namespace Wanderer_Game.Model
{
    public class HeadsUpDisplay
    {
        Canvas canvas;
        public TextBlock playerStatus;
        public TextBlock enemyStatus;
        public TextBlock playerBattle;
        public TextBlock enemyBattle;
        internal UIElement gameOver;

        public HeadsUpDisplay(Canvas canvas)
        {
            this.canvas = canvas;
            playerStatus = new TextBlock
            {
                Text = "",
                Foreground = Brushes.LightBlue,
                FontSize = 15
            };

            enemyStatus = new TextBlock
            {
                Text = "",
                Foreground = Brushes.Orange,
                FontSize = 15
            };

            playerBattle = new TextBlock
            {
                Text = "\n\n",
                Foreground = Brushes.Green,
                FontSize = 15
            };

            enemyBattle = new TextBlock
            {
                Text = "\n\n",
                Foreground = Brushes.Red,
                FontSize = 15
            };

            gameOver = new TextBlock
            {
                Text = "YOU ARE DEAD.",
                Foreground = Brushes.Red,
                FontSize = 50,
            };
        }

        public void ResetBattleLog()
        {
            playerBattle.Text = "\n\n";
            enemyBattle.Text = "\n\n";
            enemyStatus.Text = "";
        }
    }
}
