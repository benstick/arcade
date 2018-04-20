using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arcade
{
    public partial class FlappyCopter : Form
    {
        int speed = 15;
        int gravity = 5;
        int Score = 0;
        List<PictureBox> Obstacle = new List<PictureBox>();

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

            for (int i = 0; i < Obstacle.Count; i++)
            {
                if (Copter.Bounds.IntersectsWith(Obstacle[i].Bounds)) endGame();
            }

            if (ObstacleBottom.Left < -150)
            {

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
            if(dr==DialogResult.Yes)
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
                gravity = 3;
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

        private void MiddleObstacle1_Click(object sender, EventArgs e)
        {

        }

        private void MiddleObstacle2_Click(object sender, EventArgs e)
        {

        }

        private void SpeedLabel_TextChanged(object sender, EventArgs e)
        {

        }
        private void FlappyCopter_Load(object sender, EventArgs e)
        {

        }

        private void ObstacleTop_Click(object sender, EventArgs e)
        {

        }

        private void Copter_Click(object sender, EventArgs e)
        {
            
        }

        private void ObstacleBottom_Click(object sender, EventArgs e)
        {
           
        }

        private void SkyBounds_Click(object sender, EventArgs e)
        {

        }

        private void Ground_Click(object sender, EventArgs e)
        {
            
        }

        private void ScoreText_Click(object sender, EventArgs e)
        {

        }
    }
}
