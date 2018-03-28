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

        public Animator(Player player, Draw graphics)
        {
            this.player = player;
            this.graphics = graphics;
        }

        public async void AnimatePlayer()
        {
            int timeBetweenFrames = 150;

            await Task.Delay(timeBetweenFrames);
            player.SetImage(player.facing[0]);
            graphics.Refresh();

            await Task.Delay(timeBetweenFrames);
            player.SetImage(player.facing[1]);
            graphics.Refresh();

            await Task.Delay(timeBetweenFrames);
            player.SetImage(player.facing[2]);
            graphics.Refresh();

            await Task.Delay(timeBetweenFrames);
            player.SetImage(player.facing[3]);
            graphics.Refresh();

            await Task.Delay(timeBetweenFrames);
            player.SetImage(player.facing[4]);
            graphics.Refresh();

            await Task.Delay(timeBetweenFrames);
            player.SetImage(player.facing[5]);
            graphics.Refresh();

            AnimatePlayer();
        }
    }
}


