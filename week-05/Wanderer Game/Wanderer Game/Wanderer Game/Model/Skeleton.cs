using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Wanderer_Game.Model;
using Wanderer_Game.View;

namespace Wanderer_Game.Controller
{
    class Skeleton : Character
    {
        public Skeleton(Canvas canvas, string image, int gridPositionX, int gridPositionY, double positionX, double positionY):base(canvas, image, gridPositionX, gridPositionY)
        {
            image = Assets.Images.skeleton;
        }
    }
}
