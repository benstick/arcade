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
            this.welcomeTitleLabel = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.PictureBox();
            this.welcomeLogo = new System.Windows.Forms.PictureBox();
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
            // welcomeTitleLabel
            // 
            this.welcomeTitleLabel.AutoSize = true;
            this.welcomeTitleLabel.Location = new System.Drawing.Point(12, 9);
            this.welcomeTitleLabel.Name = "welcomeTitleLabel";
            this.welcomeTitleLabel.Size = new System.Drawing.Size(35, 13);
            this.welcomeTitleLabel.TabIndex = 0;
            this.welcomeTitleLabel.Text = "label1";
            this.welcomeTitleLabel.Visible = false;
            this.welcomeTitleLabel.Click += new System.EventHandler(this.welcomeTitleLabel_Click);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.playButton.Image = global::Arcade.Properties.Resources.presstoplay;
            this.playButton.Location = new System.Drawing.Point(314, 304);
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
            this.welcomeLogo.Location = new System.Drawing.Point(314, 74);
            this.welcomeLogo.Name = "welcomeLogo";
            this.welcomeLogo.Size = new System.Drawing.Size(640, 416);
            this.welcomeLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.welcomeLogo.TabIndex = 1;
            this.welcomeLogo.TabStop = false;
            this.welcomeLogo.Click += new System.EventHandler(this.welcomeLogo_Click);
            // 
            // Duckhunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::Arcade.Properties.Resources.grid;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 700);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.welcomeLogo);
            this.Controls.Add(this.welcomeTitleLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Duckhunt";
            this.Text = "Duckhunt";
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
        private System.Windows.Forms.Label welcomeTitleLabel;
        private System.Windows.Forms.PictureBox welcomeLogo;
        private System.Windows.Forms.PictureBox playButton;
    }
}