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
        Vector2 movement = new Vector2();
        Vector2 movementChange;
        KeyboardState ks;
        MouseState ms;
        public Player()
        {
            
            //Difficulty Variables
            health = 100;
            energy = 100;
            moveSpeed = 5;
            //Optional Entity Options
            invulnerable = false;
            //Positional Variables
            angle = 0f;
            position = new Vector2(500, 500);
            state = 0;
            
        }

        public void Update()
        {
            movement = KeyCheck();
            angle = MouseCheck();
            position += movement;
            if (movementChange != new Vector2(0, 0)) 
            {
                if (state == 1) { state = 2; }
                else { state = 1; } 
            }
            else { state = 0; }
            boundBox = new Rectangle((int)position.X, (int)position.Y, 30, 30);
        }

        public Vector2 KeyCheck()
        {
            ks = Keyboard.GetState();
            movementChange = new Vector2();

            if (ks.IsKeyDown(Keys.W) || ks.IsKeyDown(Keys.Up)) { movementChange.Y -= moveSpeed; }
            if (ks.IsKeyDown(Keys.S) || ks.IsKeyDown(Keys.Up)) { movementChange.Y += moveSpeed; }
            if (ks.IsKeyDown(Keys.A) || ks.IsKeyDown(Keys.Up)) { movementChange.X -= moveSpeed; }
            if (ks.IsKeyDown(Keys.D) || ks.IsKeyDown(Keys.Up)) { movementChange.X += moveSpeed; }

            return movementChange;
        }

        public float MouseCheck()
        {
            ms = Mouse.GetState();
            return (float)Math.Atan2((double)ms.Y - position.Y, (double)ms.X - position.X);
        }

        public void Draw()
        {
            Game1.spriteBatch.Draw(Game1.playerTexture,
                boundBox,
                new Rectangle(30 * state, 0, 30, 30),
                Color.White, angle,
                new Vector2(Game1.playerTexture.Width / 2, Game1.playerTexture.Height / 2),
                SpriteEffects.None, 0);
        }
    }
}
