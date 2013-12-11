#region Using Statements
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.GamerServices;
#endregion

namespace FightGame.Entity
{
    public class Player : Types.EntityType
    {

        Player()
        {
            state = 0;
            //Difficulty Variables
            health = 100;
            energy = 100;
            moveSpeed = 5;
            //Optional Entity Options
            invulnerable = false;
            //Positional Variables
            angle = 0f;
            position = new Vector2();
        }


    }
}
