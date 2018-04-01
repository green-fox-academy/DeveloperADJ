using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wanderer_Refactor.Model.Characters;
using Wanderer_Refactor.View;

namespace Wanderer_Refactor.Controller
{
    public class PlayerController
    {
        private PlayerModel playerModel;
        private PlayerView playerView;

        public PlayerController(PlayerModel playerModel, PlayerView playerView)
        {
            this.playerModel = playerModel;
            this.playerView = playerView;
        }
    }
}
