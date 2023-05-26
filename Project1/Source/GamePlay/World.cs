using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TowersKing
{
    public class World
    {
        public Player player;
        public UI ui;
        public List<Enemy> enemies = new List<Enemy>();
        public List<SpawnPoint> spawnPoints = new List<SpawnPoint>();
        public List<Projectile2d> projectiles = new List<Projectile2d>();

        public Texture2D background;

        public Vector2 offset;

        PassObject ResetWorld;

        public World(PassObject RESETWORLD, PassObject CHANGEGAMESTATE)
        {
            ResetWorld = RESETWORLD;

            background = Globals.content.Load<Texture2D>("2d\\background");

            player = new Player("2d\\player", new Vector2(Globals.screenWidth / 2, Globals.screenHeight / 2), new Vector2(100, 100));

            offset = new Vector2(0, 0);

            Globals.passEnemy = AddEnemy;
            Globals.passProjectile = AddProjectile;

            var rnd = new Random();

            var a1 = rnd.Next(491, 982);
            var a2 = rnd.Next(514, 1028);

            spawnPoints.Add(new SpawnPoint("2d\\arena", new Vector2(Globals.screenWidth / 2, Globals.screenHeight / 2), new Vector2(982, 1029)));
            spawnPoints.Add(new SpawnPoint("2d\\arena", new Vector2(a1, a2), new Vector2(0, 0)));
            spawnPoints[spawnPoints.Count - 1].spawnTimer.AddToTimer(5000);

            ui = new UI(ResetWorld);
        }

        public virtual void AddEnemy(object INFO)
        {
            enemies.Add((Enemy)INFO);
        }

        public virtual void AddProjectile(object INFO)
        {
            projectiles.Add((Projectile2d)INFO);
        }

        public virtual void Update()
        {
            player.Update(offset);

            var kstate = Keyboard.GetState();

            if (!player.dead)
            {
                for (int i = 0; i < spawnPoints.Count; i++)
                {
                    spawnPoints[i].Update(offset);
                }

                for (int i = 0; i < projectiles.Count; i++)
                {
                    projectiles[i].Update(offset, enemies.ToList<Unit>());

                    if (projectiles[i].done || player.pos != projectiles[i].pos)
                    {
                        projectiles.RemoveAt(i);
                        i--;
                    }
                }

                for (int i = 0; i < enemies.Count; i++)
                {
                    enemies[i].Update(offset, player);

                    if (enemies[i].dead)
                    {
                        enemies.RemoveAt(i);
                        i--;
                    }
                }
            }
            else
            {
                if (kstate.IsKeyDown(Keys.Enter))
                {
                    ResetWorld(null);
                }
            }

            ui.Update(this);
        }

        public virtual void Draw(Vector2 OFFSET)
        {
            Globals.spriteBatch.Draw(background, new Vector2(0, 0), Color.White);

            for (int i = 0; i < spawnPoints.Count; i++)
            {
                spawnPoints[i].Draw(offset);
            }

            player.Draw(offset);

            for (int i = 0; i < enemies.Count; i++)
            {

                enemies[i].Draw(offset);
            }

            for (int i = 0; i < projectiles.Count; i++)
            {
                projectiles[i].Draw(offset);
            }

            ui.Draw(this);
        }
    }
}