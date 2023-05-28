using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace TowersKing
{
    public class ActiveItem : Basic2D
    {   
        
        public Vector2 direction;
        public bool done;
        public float hitDist;

        public ActiveItem(string PATH, Vector2 POS, Vector2 DIMS)
            : base(PATH, POS, DIMS)
        {
            done = false;
            hitDist = 10.0f;
        }

        public virtual void Update(Vector2 OFFSET, World WORLD)
        {
            if (HitSomething(WORLD.player))
            {
                if (this.myModel.Name == "2d\\healingstar")
                    if (WORLD.player.health < 5) WORLD.player.health += 1;
                done = true;
            }
                
                
            
        }

        public virtual void HealPlayer(World WORLD)
        {
            if (WORLD.player.health < 5) WORLD.player.health += 1;
        }   

        public virtual bool HitSomething(Player player)
        {
            //Пока что false
            
            if (Globals.GetDistance(pos, player.pos) < hitDist)
                return true;
            

            return false;
        }

    }
}

