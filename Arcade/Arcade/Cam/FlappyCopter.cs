using System;
using System.Windows.Forms;
using System.Drawing;

namespace Arcade
{
    public partial class Copter : Form
    {
        bool jumping = false;

        int speed = 5;
        int gravity = 5;
        int Inscore = 0;

        
        public Copter()
        {
            InitializeComponent();

            endText1.Text = "Game Over!";
            endText2.Text = "Your score is:" + Inscore;

            endText1.Visible = false;
            endText2.Visible = false;
            restartButton.Visible = false;
        }

        private void FlappyCopter_Load(object sender, EventArgs e)
        {

        }

        private void obstacleTop_Click(object sender, EventArgs e)
        {

        }

        private void flappyCopter_Click(object sender, EventArgs e)
        {

        }

        private void obstacleBottom_Click(object sender, EventArgs e)
        {

        }

        private void ground_Click(object sender, EventArgs e)
        {

        }

        private void scoreText_Click(object sender, EventArgs e)
        {

        }

        private void endText1_Click(object sender, EventArgs e)
        {

        }

        private void endText2_Click(object sender, EventArgs e)
        {

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            obstacleTop.Left -= speed;
            obstacleBottom.Left -= speed;
            flappyCopter.Top += gravity;
            scoreText.Text = "" + Inscore;
            if (flappyCopter.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();
                endText2.Text = "Your score is:" + Inscore;
            }
            else if (flappyCopter.Bounds.IntersectsWith(obstacleBottom.Bounds))
            {
                endGame();
                endText2.Text = "Your score is:" + Inscore;
            }
            else if (flappyCopter.Bounds.IntersectsWith(obstacleTop.Bounds))
            {
                endGame();
            }
                if (obstacleBottom.Left < -80)
                {
                    obstacleBottom.Left = 1000; Inscore += 1;
                speed++;
               
                }
                else if (obstacleTop.Left < -95)
                {
                    obstacleTop.Left = 1100; Inscore += 1;
                
                }
            
        }

        private void inGameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                jumping = true;
                gravity = -5;
            }
        }

        private void keyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                jumping = false;
                gravity = 5;
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            endText1.Visible = true;
            endText2.Visible = true;
            restartButton.Visible = true;
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            gameTimer.Start();
            endText1.Visible = false;
            endText2.Visible = false;
            restartButton.Visible = false;
            flappyCopter.Location = new Point(35, 150);

        }

       

        private void Copter_Load(object sender, EventArgs e)
        {

        }
    }
}
