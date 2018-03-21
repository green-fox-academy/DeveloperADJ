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
        Canvas canvas;
        public TextBlock text;

        public Text(Canvas canvas, Player player)
        {
            this.canvas = canvas;
            text = new TextBlock
            {
                Text = "",
                Foreground = Brushes.White
            };
        }
    }
}
