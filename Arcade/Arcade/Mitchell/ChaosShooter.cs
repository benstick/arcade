using System;
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
using System.Collections;
using System.Media;
using System.IO;

namespace Arcade
{
    public partial class NoName : Form
    {
        //random number
        Random random = new Random();

        //add player
        PlayerControl player = new PlayerControl();

        //add stat
        int Score=0;
        int FPS = 0;

        //add walls
        List<PictureBox> Walls = new List<PictureBox>();

        //add projectiles
        Vector2dObject Enemyprojectile = new Vector2dObject();

        //add flyingEnemy
        FlyEnemy Flyenemies = new FlyEnemy();
        uint flyenemiesNumber;

        //add groundEnemy
        GroundEnemy GroundEnemies = new GroundEnemy();
        uint groundenemiesNumber;

        //form check
        bool Intro = true;
        public bool exit = false;

        //sound player
        private SoundPlayer sndPlayer = null;

        public NoName()
        {
            InitializeComponent();
        }

        void HowToPlay(Timer timer)
        {
            timer.Stop();
            DialogResult dr = MessageBox.Show("Move : WASD\nShoot: left click\nExit: Escape\nClick \"OK\" to start", "How to play", MessageBoxButtons.OK);
            if (dr == DialogResult.OK)
            {
                Intro = false;
                timer.Start();
            }
        }

        void Lose(Timer timer)
        {
            timer.Stop();
            DialogResult dr = MessageBox.Show("Final Score : " +Score , "No Health!", MessageBoxButtons.OK);
            if (dr == DialogResult.OK)
            {
                //
            }
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

            //setup walls
            Walls.Add(WallLeft);
            Walls.Add(WallRight);
            Walls.Add(WallTop);
            Walls.Add(ground);

            //setup fly enemies;
            flyenemiesNumber = 10;

            //setup ground enemies
            groundenemiesNumber = 10;

            //setup timer
            GameloopTimer.Interval = (int)TargetElapsedTime.TotalMilliseconds;
            GameloopTimer.Tick += Tick;
            GameloopTimer.Start();
            FPSTimer.Start();

            //setup background music
            playAudio(Properties.Resources.NoNameBackgroundMusic, true);

        }

        private void playAudio(Stream stream, bool playOnLoop)
        {
            if (sndPlayer != null)
            {
                sndPlayer.Stop();
                sndPlayer.Dispose();
                sndPlayer = null;
            }

            if (stream == null) return;

            sndPlayer = new SoundPlayer(stream);

            if (playOnLoop)
            {
                sndPlayer.Dispose();
                sndPlayer.PlayLooping();
            }
            else
            {
                sndPlayer.Dispose();
                sndPlayer.Play();
            }
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
                //tell player how to play in messagebox then start if player clicks "OK"
                if(Intro==true) HowToPlay(GameloopTimer);
                //create fly enemy
                for (int i = Flyenemies.flyEnemies.Count; i < flyenemiesNumber; i++)
                {
                    Flyenemies.position = new Vector2((float)random.Next(0, 800), -60.0f);
                    Flyenemies.TargetPos = player.ufo.position + player.ufo._size / 2;
                    Flyenemies.accelAmount = 50.0f;
                    Flyenemies.Health = 100;
                    Flyenemies.image = Properties.Resources.flight1;
                    Flyenemies.CreateEnemy();
                }

                //create ground enemy
                for (int i = GroundEnemies.groundEnemies.Count; i < groundenemiesNumber; i++)
                {
                    int rand = random.Next(1,1000);
                    if(rand>=500) GroundEnemies.position = new Vector2(ground.Location.X+ground.Width-random.Next(1,200), ground.Location.Y);
                    else if(rand<500) GroundEnemies.position = new Vector2(ground.Location.X+random.Next(0,200), ground.Location.Y);

                    GroundEnemies.TargetPos = player.ufo.position + player.ufo._size / 2;
                    GroundEnemies.accelAmount = 30.0f;
                    GroundEnemies.Health = 50;
                    GroundEnemies.image = Properties.Resources.soldier;
                    GroundEnemies.CreateEnemy();
                }

                //game control
                this.KeyDown += ExitForm;
                this.KeyDown += player.KeyBoard_KeyDown;
                this.KeyUp += player.KeyBoard_KeyUp;
                this.MouseDown += player.MouseButton_Down;
                this.MouseUp += player.MouseButton_Up;
                player.MousePosition = this.PointToClient(MousePosition);
                player.firerate += dt;

                //colider check
                //(player, ground)
                if (ufo.Bounds.IntersectsWith(ground.Bounds))//landed on ground
                {
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
                for (int i = 0; i < Flyenemies.flyEnemiesPictureBoxes.Count; i++)
                {
                    if (Flyenemies.flyEnemiesPictureBoxes[i].Bounds.IntersectsWith(ufo.Bounds))
                    {
                        player.ufo.Health -= 20;
                        Flyenemies.flyEnemiesPictureBoxes[i].Dispose();
                        Flyenemies.flyEnemiesPictureBoxes.RemoveAt(i);
                        Flyenemies.flyEnemies.RemoveAt(i);
                    }
                }
                //(player projectiles, fly enemy)
                for (int i = 0; i < player.projectilepictureBoxes.Count; i++)
                {
                    for (int j = 0; j < Flyenemies.flyEnemies.Count; j++)
                    {
                        if (player.projectilepictureBoxes[i].Bounds.IntersectsWith(Flyenemies.flyEnemiesPictureBoxes[j].Bounds))
                        {
                            Flyenemies.flyEnemies[j].Health -= player.projectiles[i].Damage;
                            ScoreLabel.Text = "Score : " + (Score += 50).ToString();

                            if (Flyenemies.flyEnemies[j].Health <= 0)
                            {
                                ScoreLabel.Text = "Score : " + (Score += 100).ToString();
                                Flyenemies.flyEnemiesPictureBoxes[j].Dispose();
                                Flyenemies.flyEnemiesPictureBoxes.RemoveAt(j);
                                Flyenemies.flyEnemies.RemoveAt(j);
                            }
                            player.projectilepictureBoxes[i].Dispose();
                            player.projectilepictureBoxes.RemoveAt(i);
                            player.projectiles.RemoveAt(i);
                            break;
                        }
                    }
                }
                //(player projectiles, ground enemy)
                for (int i = 0; i < player.projectilepictureBoxes.Count; i++)
                {
                    for (int j = 0; j < GroundEnemies.groundEnemies.Count; j++)
                    {
                        if (player.projectilepictureBoxes[i].Bounds.IntersectsWith(GroundEnemies.groundEnemiesPictureBoxes[j].Bounds))
                        {
                            GroundEnemies.groundEnemies[j].Health -= player.projectiles[i].Damage;
                            ScoreLabel.Text = "Score : " + (Score += 50).ToString();

                            if (GroundEnemies.groundEnemies[j].Health <= 0)
                            {
                                ScoreLabel.Text = "Score : " + (Score += 100).ToString();
                                GroundEnemies.groundEnemiesPictureBoxes[j].Dispose();
                                GroundEnemies.groundEnemiesPictureBoxes.RemoveAt(j);
                                GroundEnemies.groundEnemies.RemoveAt(j);
                            }
                            player.projectilepictureBoxes[i].Dispose();
                            player.projectilepictureBoxes.RemoveAt(i);
                            player.projectiles.RemoveAt(i);
                            break;
                        }
                    }
                }

                //(ground enemy, ground)
                for (int i = 0; i < GroundEnemies.groundEnemiesPictureBoxes.Count; i++)
                {
                    if (GroundEnemies.groundEnemiesPictureBoxes[i].Bounds.IntersectsWith(ground.Bounds))
                    {
                        GroundEnemies.groundEnemies[i].position.Y = ground.Location.Y- GroundEnemies.groundEnemiesPictureBoxes[i].Height;

                    }
                }


                //update game objects
                //player
                player.ufo.Update(dt);
                player.Fire();
                if (player.ufo.Health < 0) HealthBarFrontColor.Width = 0;
                else HealthBarFrontColor.Width = player.ufo.Health;
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
                //ground enemies
                for (int i = 0; i < GroundEnemies.groundEnemies.Count; i++)
                {
                    GroundEnemies.groundEnemies[i].TargetPos = player.ufo.position + player.ufo._size / 2;
                    GroundEnemies.groundEnemies[i].Update(dt);
                    if (GroundEnemies.groundEnemies[i].position.X >= 0 || GroundEnemies.groundEnemies[i].position.X < 800 + GroundEnemies.groundEnemiesPictureBoxes[i].Width)
                    {
                        GroundEnemies.groundEnemies[i].isFiring = true;
                        GroundEnemies.groundEnemies[i].Fire(Enemyprojectile.projectiles, Enemyprojectile.projectilepictureBoxes);
                    }
                    GroundEnemies.groundEnemies[i].firerate += dt;
                }

                //all enemies projectile
                for (int i = 0; i < Enemyprojectile.projectiles.Count; i++) Enemyprojectile.projectiles[i].Update(dt);




                //draw
                //player
                ufo.Location = player.ufo.ToPoint(player.ufo.position);//player position
                player.ufo.RotateImage(ufo, Properties.Resources.ufo1, player.ufo.facingDegrees);//player rotation

                //player projectile
                for (int i = 0; i < player.projectiles.Count; i++)
                {

                    player.projectiles[i].Draw(player.projectilepictureBoxes[i]);
                    this.Controls.Add(player.projectilepictureBoxes[i]);
                }

                //fly enemy
                for (int i = 0; i < Flyenemies.flyEnemiesPictureBoxes.Count; i++)
                {
                    Flyenemies.flyEnemies[i].image = Properties.Resources.flight1;
                    Flyenemies.flyEnemies[i].Draw(Flyenemies.flyEnemiesPictureBoxes[i]);
                    this.Controls.Add(Flyenemies.flyEnemiesPictureBoxes[i]);
                }

                //ground enemy
                for (int i = 0; i < GroundEnemies.groundEnemiesPictureBoxes.Count; i++)
                {
                    GroundEnemies.groundEnemies[i].image = Properties.Resources.soldier;
                    GroundEnemies.groundEnemies[i].Draw(GroundEnemies.groundEnemiesPictureBoxes[i]);
                    this.Controls.Add(GroundEnemies.groundEnemiesPictureBoxes[i]);
                }

                //all enemies projectiles
                for (int i = 0; i < Enemyprojectile.projectiles.Count; i++)
                {
                    Enemyprojectile.projectiles[i].Draw(Enemyprojectile.projectilepictureBoxes[i]);
                    this.Controls.Add(Enemyprojectile.projectilepictureBoxes[i]);
                }

                //end of the game
                Lose(GameloopTimer);

                //vsync?
                Invalidate();

                //cooldown for cpu
                System.Threading.Thread.Sleep(1);
                FPS++;

                //test
            }

        }

        void ExitForm(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }

        private void FPSTimer_Tick(object sender, EventArgs e)
        {
            FPSLabel.Text = "FPS : " + FPS.ToString();
            FPS = 0;
        }

        private void NoName_FormClosing(object sender, FormClosingEventArgs e)
        {
            sndPlayer.Stop();
            Form form = Application.OpenForms["MainMenu"];
            form.WindowState = FormWindowState.Normal;
            form.Activate();
            
        }
    }
}

//refrence for frame rate control
//https://blogs.msdn.microsoft.com/shawnhar/2010/12/06/when-winforms-met-game-loop/
