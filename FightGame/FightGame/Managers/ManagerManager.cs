using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FightGame.Managers
{
    public static class ManagerManager
    {
        public static void Update()
        {
            EntityManager.Update();
        }

        public static void Draw()
        {
            EntityManager.Draw();
        }
    }
}
