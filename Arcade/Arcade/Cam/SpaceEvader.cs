using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace Arcade
{
    public partial class FlappyCopter : Form
    {
        int speed = 15;
        int gravity = 5;
        int Score = 0;
        List<PictureBox> Obstacle = new List<PictureBox>();
        LocalScoreLeaderBoard scoreLeaderBoard = new LocalScoreLeaderBoard();

        //sound player
        private SoundPlayer sndPlayer = null;

        bool jumping = false;

        public FlappyCopter()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            
        }

        void AddObstacle()
        {
            Obstacle.Add(ObstacleTop);
            Obstacle.Add(ObstacleBottom);
            Obstacle.Add(MiddleObstacle1);
            Obstacle.Add(MiddleObstacle2);
            Obstacle.Add(SkyBounds);
            Obstacle.Add(Ground);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            ObstacleTop.Left -= speed;
            ObstacleBottom.Left -= speed;
            MiddleObstacle1.Left -= speed;
            MiddleObstacle2.Left -= speed;
            Copter.Top += gravity;
            SpeedLabel.Text = "Speed: " + speed;
            ScoreText.Text = Score.ToString();
            Random rand = new Random();

            if (
                Copter.Bounds.IntersectsWith(Ground.Bounds) ||
                Copter.Bounds.IntersectsWith(SkyBounds.Bounds) ||
                Copter.Bounds.IntersectsWith(ObstacleBottom.Bounds) ||
                Copter.Bounds.IntersectsWith(ObstacleTop.Bounds) ||
                Copter.Bounds.IntersectsWith(MiddleObstacle1.Bounds) ||
                Copter.Bounds.IntersectsWith(MiddleObstacle2.Bounds)

                )
            {
                endGame();
            }

            if (ObstacleBottom.Left < -150)
            {
                ObstacleBottom.Left = rand.Next(900, 2500); Score++;
                ObstacleBottom.Top = rand.Next(0, 600);
                speed++;
            }
            else if (ObstacleTop.Left < -150)
            {
                ObstacleTop.Left = rand.Next(900, 2500); Score++;
                ObstacleTop.Top = rand.Next(0, 600);
            }
            else if (MiddleObstacle1.Left < -150)
            {
                MiddleObstacle1.Left = rand.Next(900, 2500); Score++;
                MiddleObstacle1.Top = rand.Next(0, 600);
            }
            else if (MiddleObstacle2.Left < -150)
            {
                MiddleObstacle2.Left = rand.Next(900, 2500); Score++;
                MiddleObstacle2.Top = rand.Next(0, 600);
            }

        }
        private void endGame()
        {
            timer1.Stop();
            DialogResult dr = MessageBox.Show("Your final score is:" + Score, "Play again?", MessageBoxButtons.YesNo);
            scoreLeaderBoard.ReadFile("SpaceEvader");
            scoreLeaderBoard.AddScoreAndName(Score);
            scoreLeaderBoard.OutputFile("SpaceEvader");
            if (dr==DialogResult.Yes)
            {
                //reset game
                reset();
            }
            else
            {
                //exit game
                this.Close();
            }

        }
         void reset()
        {
            speed = 15;
            gravity = 7;
            Score = 0;
            Random rand = new Random();
            ObstacleBottom.Left = rand.Next(900, 2500);
            ObstacleBottom.Top = rand.Next(0, 600);
            ObstacleTop.Left = rand.Next(900, 2500);
            ObstacleTop.Top = rand.Next(0, 600);
            MiddleObstacle1.Left = rand.Next(900, 2500);
            MiddleObstacle1.Top = rand.Next(0, 600);
            MiddleObstacle2.Left = rand.Next(900, 2500);
            MiddleObstacle2.Top = rand.Next(0, 600);
            Copter.Location = new Point(16, 201);
            SpeedLabel.Text = "Speed: " + speed;
            Welcome.Visible = true;
            ScoreText.Text = "0";
        }

        private void FinalScore_Click(object sender, EventArgs e)
        {

        }

       
        private void Down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                AddObstacle();
                jumping = true;
                gravity = -5;
            }
        }

        private void Up(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                jumping = false;
                gravity = 4;
            }
        }

        private void EnterKeyPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)&& speed==15)
            {
                timer1.Start();
                Welcome.Visible = false;
            }
            
        }

        private void FlappyCopter_FormClosing(object sender, FormClosingEventArgs e)
        {
            sndPlayer.Stop();
            Form form = Application.OpenForms["MainMenu"];
            form.WindowState = FormWindowState.Normal;
            form.Activate();
        }

        private void FlappyCopter_Load(object sender, EventArgs e)
        {
            //setup background music
            playAudio(Properties.Resources.NoNameBackgroundMusic, true);
        }
    }
}
