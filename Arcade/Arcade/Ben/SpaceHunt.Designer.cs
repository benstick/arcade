namespace Arcade
{
    partial class Duckhunt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.countDownTimer = new System.Windows.Forms.Timer(this.components);
            this.welcomeTextTimer = new System.Windows.Forms.Timer(this.components);
            this.movingObjects = new System.Windows.Forms.Timer(this.components);
            this.playButton = new System.Windows.Forms.PictureBox();
            this.welcomeLogo = new System.Windows.Forms.PictureBox();
            this.numOfRoundsLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.loseScreen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.playButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.welcomeLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // countDownTimer
            // 
            this.countDownTimer.Interval = 1000;
            this.countDownTimer.Tick += new System.EventHandler(this.countDownTimer_Tick);
            // 
            // welcomeTextTimer
            // 
            this.welcomeTextTimer.Interval = 1;
            this.welcomeTextTimer.Tick += new System.EventHandler(this.welcomeTextTimer_Tick);
            // 
            // movingObjects
            // 
            this.movingObjects.Interval = 1;
            this.movingObjects.Tick += new System.EventHandler(this.movingObjects_Tick);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.playButton.Image = global::Arcade.Properties.Resources.presstoplay;
            this.playButton.Location = new System.Drawing.Point(314, -304);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(563, 186);
            this.playButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.playButton.TabIndex = 2;
            this.playButton.TabStop = false;
            this.playButton.Visible = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // welcomeLogo
            // 
            this.welcomeLogo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.welcomeLogo.Image = global::Arcade.Properties.Resources.spacehuntlogo;
            this.welcomeLogo.Location = new System.Drawing.Point(314, -740);
            this.welcomeLogo.Name = "welcomeLogo";
            this.welcomeLogo.Size = new System.Drawing.Size(640, 416);
            this.welcomeLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.welcomeLogo.TabIndex = 1;
            this.welcomeLogo.TabStop = false;
            // 
            // numOfRoundsLabel
            // 
            this.numOfRoundsLabel.AutoSize = true;
            this.numOfRoundsLabel.BackColor = System.Drawing.Color.Transparent;
            this.numOfRoundsLabel.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfRoundsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(61)))), ((int)(((byte)(142)))));
            this.numOfRoundsLabel.Location = new System.Drawing.Point(1158, 9);
            this.numOfRoundsLabel.Name = "numOfRoundsLabel";
            this.numOfRoundsLabel.Size = new System.Drawing.Size(110, 25);
            this.numOfRoundsLabel.TabIndex = 3;
            this.numOfRoundsLabel.Text = "Round: 1";
            this.numOfRoundsLabel.Visible = false;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold);
            this.scoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(61)))), ((int)(((byte)(142)))));
            this.scoreLabel.Location = new System.Drawing.Point(1029, 9);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(114, 25);
            this.scoreLabel.TabIndex = 4;
            this.scoreLabel.Text = "Score: 0";
            this.scoreLabel.Visible = false;
            // 
            // loseScreen
            // 
            this.loseScreen.BackColor = System.Drawing.Color.Transparent;
            this.loseScreen.Font = new System.Drawing.Font("Magneto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loseScreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(61)))), ((int)(((byte)(142)))));
            this.loseScreen.Location = new System.Drawing.Point(458, 290);
            this.loseScreen.Name = "loseScreen";
            this.loseScreen.Size = new System.Drawing.Size(650, 141);
            this.loseScreen.TabIndex = 5;
            this.loseScreen.Text = "You Lose!";
            this.loseScreen.Visible = false;
            // 
            // Duckhunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::Arcade.Properties.Resources.grid;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 700);
            this.Controls.Add(this.loseScreen);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.numOfRoundsLabel);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.welcomeLogo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Duckhunt";
            this.Text = "Spacehunt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Duckhunt_FormClosing);
            this.Load += new System.EventHandler(this.Duckhunt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.welcomeLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer countDownTimer;
        private System.Windows.Forms.Timer welcomeTextTimer;
        private System.Windows.Forms.Timer movingObjects;
        private System.Windows.Forms.PictureBox welcomeLogo;
        private System.Windows.Forms.PictureBox playButton;
        private System.Windows.Forms.Label numOfRoundsLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label loseScreen;
    }
}