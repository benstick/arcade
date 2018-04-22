﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Numerics;

namespace Arcade
{
    public partial class NoName : Form
    {
        //random number
        Random random = new Random();

        //add player
        PlayerControl player = new PlayerControl();

        //add walls
        List<PictureBox> Walls = new List<PictureBox>();

        //add projectiles
        Vector2dObject Enemyprojectile = new Vector2dObject();

        //add flyingEnemy
        FlyEnemy Flyenemies = new FlyEnemy();
        uint flyenemiesNumber;

        public NoName()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            //setup player
            player.ufo.position = new Vector2(300.0f, 300.0f);
            player.ufo.facingDegrees = 270.0f;
            player.ufo._size.X = ufo.Size.Width;
            player.ufo._size.Y = ufo.Size.Height;
            player.ufo.accelAmount = 200.0f;
            player.ufo.Health = 100;

            //game timer start
            GameloopTimer.Interval = (int)TargetElapsedTime.TotalMilliseconds;
            GameloopTimer.Tick += Tick;
            GameloopTimer.Start();

            //setup walls
            Walls.Add(WallLeft);
            Walls.Add(WallRight);
            Walls.Add(WallTop);
            Walls.Add(ground);

            //setup fly enemies;
            flyenemiesNumber = 5;


        }

        //frame rate control
        Stopwatch stopWatch = Stopwatch.StartNew();

        readonly TimeSpan TargetElapsedTime = TimeSpan.FromTicks(TimeSpan.TicksPerSecond / 60);
        readonly TimeSpan MaxElapsedTime = TimeSpan.FromTicks(TimeSpan.TicksPerSecond / 10);

        TimeSpan accumulatedTime;
        TimeSpan lastTime;

        float dt = 0.01f;

        //main game loop
        void Tick(object sender, EventArgs e)
        {
            TimeSpan currentTime = stopWatch.Elapsed;
            TimeSpan elapsedTime = currentTime - lastTime;
            lastTime = currentTime;

            if (elapsedTime > MaxElapsedTime)
            {
                elapsedTime = MaxElapsedTime;
            }

            accumulatedTime += elapsedTime;

            bool updated = false;

            while (accumulatedTime >= TargetElapsedTime)
            {
                //refresh screen
                Update();

                accumulatedTime -= TargetElapsedTime;

                updated = true;
            }

            if (updated)
            {

                //create fly enemy
                for (int i = Flyenemies.flyEnemies.Count; i < flyenemiesNumber; i++)
                {
                    Flyenemies.position = new Vector2((float)random.Next(0, 800), -60.0f);
                    Flyenemies.TargetPos = player.ufo.position + player.ufo._size / 2;
                    Flyenemies.accelAmount = 20.0f;
                    Flyenemies.Health = 100;
                    Flyenemies.image = Properties.Resources.flight1;
                    Flyenemies.CreateEnemy();
                }

                //game control
                this.KeyDown += player.KeyBoard_KeyDown;
                this.KeyUp += player.KeyBoard_KeyUp;
                this.MouseDown += player.MouseButton_Down;
                this.MouseUp += player.MouseButton_Up;
                player.MousePosition = this.PointToClient(MousePosition);
                player.firerate += dt;

                //colider check
                if (ufo.Bounds.IntersectsWith(ground.Bounds))//landed on ground
                {
                    //make them to a function later
                    player.ufo.gravity = 0.0f;
                    player.ufo.velocity = new Vector2(0, 0);
                    player.ufo.isTurnningLeft = false;
                    player.ufo.isTurnningRight = false;
                    player.ufo.position.Y = ground.Bounds.Top - ufo.Size.Height + 1;
                }
                else
                {
                    player.ufo.gravity = 0.03f;
                }
                //(player projectile, wall)
                for (int j = 0; j < Walls.Count; j++)
                {
                    for (int i = 0; i < player.projectiles.Count; i++)
                    {
                        if (player.projectilepictureBoxes[i].Bounds.IntersectsWith(Walls[j].Bounds))
                        {
                            player.projectilepictureBoxes[i].Dispose();
                            player.projectilepictureBoxes.RemoveAt(i);
                            player.projectiles.RemoveAt(i);
                        }
                    }
                }
                //(enemies projectiles, wall)
                for (int j = 0; j < Walls.Count; j++)
                {
                    for (int i = 0; i < Enemyprojectile.projectiles.Count; i++)
                    {
                        if (Enemyprojectile.projectilepictureBoxes[i].Bounds.IntersectsWith(Walls[j].Bounds))
                        {
                            Enemyprojectile.projectilepictureBoxes[i].Dispose();
                            Enemyprojectile.projectilepictureBoxes.RemoveAt(i);
                            Enemyprojectile.projectiles.RemoveAt(i);
                        }
                    }
                }
                //(enemies projectiles, player)
                for (int i = 0; i < Enemyprojectile.projectiles.Count; i++)
                {
                    if (Enemyprojectile.projectilepictureBoxes[i].Bounds.IntersectsWith(ufo.Bounds))
                    {
                        player.ufo.Health -= Enemyprojectile.projectiles[i].Damage;
                        Enemyprojectile.projectilepictureBoxes[i].Dispose();
                        Enemyprojectile.projectilepictureBoxes.RemoveAt(i);
                        Enemyprojectile.projectiles.RemoveAt(i);
                    }
                }
                //(fly enemy, player)
                for (int i = 0; i < Flyenemies.flyEnemiespictureBoxes.Count; i++)
                {
                    if (Flyenemies.flyEnemiespictureBoxes[i].Bounds.IntersectsWith(ufo.Bounds))
                    {
                        player.ufo.Health -= 20;
                        Flyenemies.flyEnemiespictureBoxes[i].Dispose();
                        Flyenemies.flyEnemiespictureBoxes.RemoveAt(i);
                        Flyenemies.flyEnemies.RemoveAt(i);
                    }
                }
                //(player projectiles, fly enemy)
                for (int i = 0; i < player.projectilepictureBoxes.Count; i++)
                {
                    for (int j = 0; j < Flyenemies.flyEnemiespictureBoxes.Count; j++)
                    {
                        if (player.projectilepictureBoxes[i].Bounds.IntersectsWith(Flyenemies.flyEnemiespictureBoxes[j].Bounds))
                        {
                            Flyenemies.flyEnemies[j].Health -= player.projectiles[i].Damage;
                            player.projectilepictureBoxes[i].Dispose();
                            player.projectilepictureBoxes.RemoveAt(i);
                            player.projectiles.RemoveAt(i);

                            if (Flyenemies.flyEnemies[j].Health <= 0)
                            {
                                Flyenemies.flyEnemiespictureBoxes[j].Dispose();
                                Flyenemies.flyEnemiespictureBoxes.RemoveAt(j);
                                Flyenemies.flyEnemies.RemoveAt(j);
                            }
                        }
                    }
                }


                //update game objects
                player.ufo.Update(dt);
                player.Fire();
                if (player.ufo.Health < 0) HealthBar.Value = 0;
                else HealthBar.Value = player.ufo.Health;
                //player projectils
                for (int i = 0; i < player.projectiles.Count; i++) player.projectiles[i].Update(dt);
                //fly enemies
                for (int i = 0; i < Flyenemies.flyEnemies.Count; i++)
                {
                    Flyenemies.flyEnemies[i].TargetPos = player.ufo.position + player.ufo._size / 2;
                    Flyenemies.flyEnemies[i].Update(dt);
                    if (Flyenemies.flyEnemies[i].position.Y >= 0)
                    {
                        Flyenemies.flyEnemies[i].isFiring = true;
                        Flyenemies.flyEnemies[i].Fire(Enemyprojectile.projectiles, Enemyprojectile.projectilepictureBoxes);
                    }
                    Flyenemies.flyEnemies[i].firerate += dt;
                }
                //all enemies projectile
                for (int i = 0; i < Enemyprojectile.projectiles.Count; i++) Enemyprojectile.projectiles[i].Update(dt);




                //draw
                ufo.Location = player.ufo.ToPoint(player.ufo.position);//player position
                player.ufo.RotateImage(ufo, Properties.Resources.ufo1, player.ufo.facingDegrees);//player rotation

                //player projectile
                for (int i = 0; i < player.projectiles.Count; i++)
                {

                    player.projectiles[i].Draw(player.projectilepictureBoxes[i]);
                    this.Controls.Add(player.projectilepictureBoxes[i]);
                }

                //fly enemy
                for (int i = 0; i < Flyenemies.flyEnemiespictureBoxes.Count; i++)
                {
                    Flyenemies.flyEnemies[i].Draw(Flyenemies.flyEnemiespictureBoxes[i]);
                    this.Controls.Add(Flyenemies.flyEnemiespictureBoxes[i]);

                }

                //all enemies projectiles
                for (int i = 0; i < Enemyprojectile.projectiles.Count; i++)
                {
                    Enemyprojectile.projectiles[i].Draw(Enemyprojectile.projectilepictureBoxes[i]);
                    this.Controls.Add(Enemyprojectile.projectilepictureBoxes[i]);
                }


                //clean screen
                Invalidate();

                //test
            }

            //cooldown for cpu
            System.Threading.Thread.Sleep(1);
        }


    }
}

//refrence for frame rate control
//https://blogs.msdn.microsoft.com/shawnhar/2010/12/06/when-winforms-met-game-loop/