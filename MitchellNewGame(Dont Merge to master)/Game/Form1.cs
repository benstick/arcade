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

namespace Game
{
    public partial class Form1 : Form
    {
        //add player
        PlayerControl player = new PlayerControl();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //setup player
            player.ufo.position = new Vector2(300.0f, 300.0f);


            //game timer start
            GameloopTimer.Interval = (int)TargetElapsedTime.TotalMilliseconds;
            GameloopTimer.Tick += Tick;
            GameloopTimer.Start();
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

                //game control
                this.KeyDown += ufo_KeyDown;

                //colider check
                if (ufo.Bounds.IntersectsWith(ground.Bounds))
                {
                    player.ufo.gravity = 0f;
                    player.ufo.position.Y = ground.Bounds.Top - ufo.Size.Height;
                }
                else player.ufo.gravity = 0.02f;

                //update game objects
                player.ufo.Update(dt);

                //draw
                ufo.Location = player.ufo.ToPoint(player.ufo.position);
                

                //clean screen
                Invalidate();

                //test
                Console.WriteLine(player.ufo.facingVector);
            }

            //cooldown for cpu
            System.Threading.Thread.Sleep(1);
        }

        void ufo_KeyDown(object sender, KeyEventArgs e)
        {
            player.ufo_KeyDown(sender, e);
        }

        private void GameloopTimer_Tick(object sender, EventArgs e)
        {

        }

        private void ufo_Click(object sender, EventArgs e)
        {

        }
    }
}

//refrence for game loop code
//https://blogs.msdn.microsoft.com/shawnhar/2010/12/06/when-winforms-met-game-loop/
