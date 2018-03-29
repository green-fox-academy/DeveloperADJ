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
        int stageCounter;

        public Animator(Player player, Draw graphics, int stageCounter)
        {
            this.player = player;
            this.graphics = graphics;
            this.stageCounter = stageCounter;
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

        public async void AnimateEnemy()
        {
            int timeBetweenFrames = 150;

            if (Enemies.enemies.Count > 0)
            {

                for (int i = 0; i < Enemies.enemies.Count; i++)
                {
                    if (!Enemies.enemies[i].isBoss)
                    {
                        try
                        {
                            await Task.Delay(timeBetweenFrames);
                            Enemies.enemies[i].SetImage(Images.enemy[0]);
                            graphics.Refresh();

                            await Task.Delay(timeBetweenFrames);
                            Enemies.enemies[i].SetImage(Images.enemy[1]);
                            graphics.Refresh();

                            await Task.Delay(timeBetweenFrames);
                            Enemies.enemies[i].SetImage(Images.enemy[2]);
                            graphics.Refresh();

                            await Task.Delay(timeBetweenFrames);
                            Enemies.enemies[i].SetImage(Images.enemy[3]);
                            graphics.Refresh();
                        }
                        catch { }
                    }
                    else
                    {
                        await Task.Delay(timeBetweenFrames);
                        if (Enemies.enemies.Count > 0)
                        {
                            Enemies.enemies[i].SetImage(Images.boss[0]);
                            graphics.Refresh();
                        }
                    }
                }
                if (Enemies.enemies.Count > 0)
                {
                    AnimateEnemy();
                } 
            }
        }
    }
}


