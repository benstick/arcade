using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Arcade
{
    public partial class Duckhunt : Form
    {
        public Duckhunt()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        private List<PictureBox> ufoList = new List<PictureBox>();
        private SoundPlayer sndPlayer = null;
        private int textCoordY = -300;
        private bool moveWelcomeLogoDown = true;
        private bool gameWon = false;
        private int currentRound = 1;
        private int score = 0;
        private int speed = 3; //default 3 for starting speed
        private int numOfUfos = 4;

        LocalScoreLeaderBoard scoreLeaderBoard = new LocalScoreLeaderBoard();

        //Runs when game is loaded up
        private void Duckhunt_Load(object sender, EventArgs e)
        {
            //Set cursor image
            try
            {
                string path  = Application.StartupPath;
                this.Cursor = new Cursor(path +"\\DuckHuntReticle.cur");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            playAudio(Properties.Resources.spacehunt_music, true);

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            welcomeTextTimer.Enabled = true;
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

        private void countDownTimer_Tick(object sender, EventArgs e)
        {

        }

        private void welcomeTextTimer_Tick(object sender, EventArgs e)
        {
            if (textCoordY < 100 && moveWelcomeLogoDown)
            {
                textCoordY += 2;
                welcomeLogo.Location = new Point(312, textCoordY);
            }
            else if (textCoordY > -500 && !moveWelcomeLogoDown)
            {
                textCoordY -= 4;
                welcomeLogo.Location = new Point(312, textCoordY);
            }
            else if (textCoordY == 100)
            {
                playButton.Location = new Point(354, 361);
                playButton.Visible = true;
                welcomeTextTimer.Enabled = false;
            }
        }

        private void welcomeLogo_Click(object sender, EventArgs e)
        {

        }

        //runs when the play button is pressed
        private void playButton_Click(object sender, EventArgs e)
        {
            playButton.Location = new Point(354, 700);
            playButton.Visible = false; //might make the game run smoother

            //move welcome logo up
            moveWelcomeLogoDown = false;
            welcomeTextTimer.Enabled = true;

            scoreLabel.Visible = true;
            numOfRoundsLabel.Visible = true;

            mainGame();
        }

        //create enemy
        private void createEnemy()
        {
            PictureBox ufo = new PictureBox();

            ufo.Image = Properties.Resources.ufo;
            ufo.Size = new Size(80, 35);

            ufo.Location = new Point(rnd.Next(-2000, -ufo.Size.Width), rnd.Next(50, this.Height - ufo.Size.Height - 50));
            //make sure ufo isn't in the same position as any other ufos
            if (ufoList.Count > 0)
            {
                for (int i = 0; i < ufoList.Count; i++)
                {
                    while (ufoList[i].Bounds.IntersectsWith(ufo.Bounds))
                    {
                        ufo.Location = new Point(rnd.Next(-2000, -ufo.Size.Width), rnd.Next(50, this.Height - ufo.Size.Height - 50));
                    }
                }
            }

            ufo.SizeMode = PictureBoxSizeMode.StretchImage;
            ufo.BackColor = Color.Transparent;
            ufo.MouseDown += Duckhunt_MouseButtonDown;
            this.Controls.Add(ufo);
            ufoList.Add(ufo);
        }

        //displays current round
        private void runRound()
        {
            //if the round # is divisible by 5, add another ufo to the round and increase speed
            if (currentRound % 5 == 0)
            {
                numOfUfos++;
                speed++;
            }

            //spawn the correct number of ufos
            for (int i = 1; i <= numOfUfos; i++)
                createEnemy();
        }

        private void mainGame()
        {
            do
            {
                runRound();

                movingObjects.Enabled = true;
            } while (gameWon);
        }

        //move objects across the screen
        private void movingObjects_Tick(object sender, EventArgs e)
        {
            int count = 0;

            for (int i = 0; i < ufoList.Count; i++)
            {
                ufoList[i].Location = new Point(ufoList[i].Location.X + speed, ufoList[i].Location.Y);

                //if ufo goes off screen, delete it
                if (ufoList[i].Location.X > this.Width)
                {
                    ufoList[i].Dispose();
                    ufoList.Remove(ufoList[i]);
                    Console.WriteLine("destroyed");

                    //run you lose function
                    movingObjects.Enabled = false;
                    //loseScreen.Visible = true;

                    scoreLeaderBoard.ReadFile("SpaceHunt");
                    scoreLeaderBoard.AddScoreAndName(score);
                    scoreLeaderBoard.OutputFile("SpaceHunt");
                }

                count++;
            }
        }

        //stop the music if user is closing the form
        private void Duckhunt_FormClosing(object sender, FormClosingEventArgs e)
        {
            sndPlayer.Stop();
            Form form = Application.OpenForms["MainMenu"];
            form.WindowState = FormWindowState.Normal;
            form.Activate();
        }

        private void Duckhunt_MouseButtonDown(object sender, MouseEventArgs e)
        {
            //clean up ufoList and remove the picturebox from the control
            PictureBox temp = sender as PictureBox;
            ufoList.Remove(temp);
            this.Controls.Remove(temp);

            //add points to score
            scoreLabel.Text = "Score: " + ++score;

            Console.WriteLine($"Round: {currentRound}  UFO's: {ufoList.Count} Score: {score}"); //print out score for debugging

            //play laser sound
            //playAudio(Properties.Resources.laser_sound, false);

            //possibly add explosion gif here in future for effects

            //all of the ufos have been destroyed
            if (ufoList.Count == 0)
            {
                currentRound++;
                numOfRoundsLabel.Text = "Round: " + currentRound;
                runRound();
            }
        }

        private void scoreLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
