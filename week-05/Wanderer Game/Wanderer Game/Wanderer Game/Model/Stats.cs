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
    public class Status
    {
        Canvas canvas;
        public TextBlock content;

        public Status(Canvas canvas)
        {
            this.canvas = canvas;
            content = new TextBlock
            {
                Text = "",
                Foreground = Brushes.White,
                FontSize = 15
            };
        }
    }
}
