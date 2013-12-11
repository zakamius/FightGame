using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FightGame.Managers
{
    public static class EntityManager
    {
        public static void Update()
        {
            Game1.MainPlayer.Update();
        }

        public static void Draw()
        {
            Game1.MainPlayer.Draw();
        }
    }
}
