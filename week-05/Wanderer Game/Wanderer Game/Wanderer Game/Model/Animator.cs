using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wanderer_Game.Controller;
using Wanderer_Game.View;

namespace Wanderer_Game.Model
{
    class Animator
    {
        Player player;
        Draw graphics;
        bool shouldTurnOver = true;

        public Animator(Player player, Draw graphics)
        {
            this.player = player;
            this.graphics = graphics;
        }

        public async void SpriteAnimation()
        {
            await Task.Delay(500);
            if (shouldTurnOver)
            {
                player.SetImage(Images.heroLeft);
                shouldTurnOver = false;
                graphics.Refresh();
            }
            else
            {
                player.SetImage(Images.heroRight);
                shouldTurnOver = true;
                graphics.Refresh();
            }
            SpriteAnimation();
        }
    }
}
