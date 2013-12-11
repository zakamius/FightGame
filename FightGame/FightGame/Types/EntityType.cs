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

namespace FightGame.Types
{
    public class EntityType
    {
        //Difficulty Variables
        public int health;
        public int energy;
        public int moveSpeed;

        //Optional Entity Options
        public bool invulnerable = false; 

        //Positional Variables
        public float angle;
        public Vector2 position;
        public Rectangle boundBox;
        public int state;


    }
}
