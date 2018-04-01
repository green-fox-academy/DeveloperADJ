using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wanderer_Refactor.Model.Characters
{
    public class PlayerModel : CharacterModel
    {
        public PlayerModel() : base(20, 20, 5, 0, 0, false)
        {
        }

        public override void BasicAttack()
        {
            throw new NotImplementedException();
        }
    }
}
