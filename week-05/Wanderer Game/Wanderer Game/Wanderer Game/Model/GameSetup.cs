using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Wanderer_Game.Model
{
    public class GameSetup
    {
        Canvas canvas;
        double MapSize {
            get {
                return MapSize;
            } set {
                canvas.Width = value;
                canvas.Height = value + value;
            }
        }
        int tileSize;

        public GameSetup(Canvas canvas, double MapSize)
        {
            this.canvas = canvas;
            this.MapSize = MapSize;
            tileSize = (int)(MapSize / 10);
        }
    }
}
