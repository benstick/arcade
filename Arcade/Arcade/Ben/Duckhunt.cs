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

        private List<PictureBox> ufoList = new List<PictureBox>();
        private SoundPlayer sndPlayer = null;
        private int textCoordY = -300;
        private bool moveWelcomeLogoDown = true;
        private bool gameWon = false;
        private int currentRound = 1;

        //Runs when game is loaded up
        private void Duckhunt_Load(object sender, EventArgs e)
        {
            //Set cursor image
            try
            {
                string Debugfile = Application.StartupPath;
                string CursorPath = Debugfile.Remove(Debugfile.Length - 10, 10);
                this.Cursor = new Cursor(CursorPath + "\\Resources\\DuckHuntReticle.cur");
            }
            catch(Exception ex)
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

        private void welcomeTitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void welcomeTextTimer_Tick(object sender, EventArgs e)
        {
            if (textCoordY < 100 && moveWelcomeLogoDown)
            {
                textCoordY += 2;
                welcomeLogo.Location = new Point(312, textCoordY);
            }
            else if (textCoordY > -302 && !moveWelcomeLogoDown)
            {
                textCoordY -= 2;
                welcomeLogo.Location = new Point(312, textCoordY);
            }
            else if(textCoordY==100)
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
            mainGame();
        }

        //create enemy
        private void createEnemy()
        {
            PictureBox ufo = new PictureBox();
            Random rnd = new Random();
            ufo.Image = Properties.Resources.spaceship;
            ufo.Size = new Size(45, 65);
            //set origin point for object
            ufo.Location = new Point(rnd.Next(0, this.Width - ufo.Size.Width), this.Height - 200);
            ufo.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(ufo);
            ufoList.Add(ufo);
        }

        //displays current round
        private void runRound()
        {
            createEnemy();
        }

        private void mainGame()
        {
            do
            {
                //start round
                for (int i = 0; i <= 10; i++)
                    runRound();

                movingObjects.Enabled = true;
            } while (gameWon);
        }

        private void movingObjects_Tick(object sender, EventArgs e)
        {
            int count = 0;

            for (int i = 0; i < ufoList.Count; i++)
            {
                //check which side of the screen the enemy is on
                if (ufoList[i].Location.X < this.Width / 2)
                    ufoList[i].Location = new Point(ufoList[i].Location.X + 3, ufoList[i].Location.Y - 3);
                else
                    ufoList[i].Location = new Point(ufoList[i].Location.X - 3, ufoList[i].Location.Y - 3);

                count++;
            }
            Console.WriteLine(ufoList[0].Location);
        }

        //stop the music if user is closing the form
        private void Duckhunt_FormClosing(object sender, FormClosingEventArgs e)
        {
            sndPlayer.Stop();
        }
    }
}
