﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Wanderer_Game.Model;
using Wanderer_Game.View;

namespace Wanderer_Game.Controller
{
    public class Player : Character
    {
        public Player(Canvas canvas, string image, int gridPositionX = 0, int gridPositionY = 0):base(canvas, image, gridPositionX, gridPositionY)
        {
            this.canvas = canvas;
            this.image = image;
        }
    }
}
