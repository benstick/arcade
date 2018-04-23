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
    public partial class mainmenu : Form
    {
        public mainmenu()
        {
            InitializeComponent();
        }

        private void mainmenu_Load(object sender, EventArgs e)
        {
            this.Opacity = 1.0;
            FadeinTimer.Start();
            DuckhuntDemo.Enabled = false;
        }

        //fade in intro screen timer
        private void FadeinTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity <= 1.0)
            {
                this.Opacity += 0.025;
            }

            if (this.Opacity >= 1.0)
            {
                label1.Visible = true;
                ExitLabel.Visible = true;
                FadeinTimer.Stop();
            }

        }

        //press to start
        private void mainmenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.Opacity == 1.0)
            {
                this.Opacity = 1.01;
                BackgroundImage = null;//remove intro background
                //enable and visable buttons to games
                DuckhuntDemo.Enabled = true;
                DuckhuntDemo.Visible = true;

                FlappyCopterDemo.Enabled = true;
                FlappyCopterDemo.Visible = true;

                NoNameDemo.Enabled = true;
                NoNameDemo.Visible = true;

                //disable labels of guide
                label1.Visible = false;
                ExitLabel.Visible = false;

                //change background image to menu
            }
        }

        //press to start lable
        private void label1_Click(object sender, EventArgs e)
        {

        }

        //exit menu
        private void mainmenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Application.Exit();
        }

        //

        //to other games
        private void DuckhuntDemo_Click(object sender, EventArgs e)
        {
            Duckhunt duckhunt = new Duckhunt();
            if (Application.OpenForms["duckhunt"] == null)
            {
                this.WindowState = FormWindowState.Minimized;
                duckhunt.Show();
                duckhunt.Activate();
            }
            else
            {
                duckhunt.Activate();
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void FlappyCopterDemo_Click(object sender, EventArgs e)
        {
            FlappyCopter copter = new FlappyCopter();
            if (Application.OpenForms["FlappyCopter"] == null)
            {
                this.WindowState = FormWindowState.Minimized;
                copter.Show();
                copter.Activate();
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
                Application.OpenForms["FlappyCopter"].BringToFront();
                copter.Activate();
            }
        }

        private void NoNameDemo_Click(object sender, EventArgs e)
        {
            NoName noName = new NoName();
            if (Application.OpenForms["NoName"] == null)
            {
                this.WindowState = FormWindowState.Minimized;
                noName.Show();
                noName.Activate();
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
                noName.Activate();
            }
        }

        //tool bar
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made with Photo Shop");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
