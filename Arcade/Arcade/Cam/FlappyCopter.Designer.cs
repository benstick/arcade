namespace Arcade
{
    partial class FlappyCopter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlappyCopter));
            this.ObstacleTop = new System.Windows.Forms.PictureBox();
            this.Copter = new System.Windows.Forms.PictureBox();
            this.ObstacleBottom = new System.Windows.Forms.PictureBox();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.SkyBounds = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ScoreText = new System.Windows.Forms.Label();
            this.Welcome = new System.Windows.Forms.Label();
            this.MiddleObstacle1 = new System.Windows.Forms.PictureBox();
            this.MiddleObstacle2 = new System.Windows.Forms.PictureBox();
            this.SpeedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ObstacleTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Copter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObstacleBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SkyBounds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MiddleObstacle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MiddleObstacle2)).BeginInit();
            this.SuspendLayout();
            // 
            // ObstacleTop
            // 
            this.ObstacleTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ObstacleTop.BackgroundImage")));
            this.ObstacleTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ObstacleTop.Location = new System.Drawing.Point(745, 15);
            this.ObstacleTop.Margin = new System.Windows.Forms.Padding(4);
            this.ObstacleTop.Name = "ObstacleTop";
            this.ObstacleTop.Size = new System.Drawing.Size(133, 62);
            this.ObstacleTop.TabIndex = 0;
            this.ObstacleTop.TabStop = false;
            this.ObstacleTop.Click += new System.EventHandler(this.ObstacleTop_Click);
            // 
            // Copter
            // 
            this.Copter.BackColor = System.Drawing.SystemColors.Window;
            this.Copter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Copter.BackgroundImage")));
            this.Copter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Copter.Image = global::Arcade.Properties.Resources.ufo2;
            this.Copter.Location = new System.Drawing.Point(19, 225);
            this.Copter.Margin = new System.Windows.Forms.Padding(4);
            this.Copter.Name = "Copter";
            this.Copter.Size = new System.Drawing.Size(75, 56);
            this.Copter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Copter.TabIndex = 1;
            this.Copter.TabStop = false;
            this.Copter.Click += new System.EventHandler(this.Copter_Click);
            // 
            // ObstacleBottom
            // 
            this.ObstacleBottom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ObstacleBottom.BackgroundImage")));
            this.ObstacleBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ObstacleBottom.Location = new System.Drawing.Point(413, 425);
            this.ObstacleBottom.Margin = new System.Windows.Forms.Padding(4);
            this.ObstacleBottom.Name = "ObstacleBottom";
            this.ObstacleBottom.Size = new System.Drawing.Size(133, 115);
            this.ObstacleBottom.TabIndex = 2;
            this.ObstacleBottom.TabStop = false;
            this.ObstacleBottom.Click += new System.EventHandler(this.ObstacleBottom_Click);
            // 
            // Ground
            // 
            this.Ground.BackColor = System.Drawing.Color.Black;
            this.Ground.Location = new System.Drawing.Point(0, 545);
            this.Ground.Margin = new System.Windows.Forms.Padding(4);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(1065, 12);
            this.Ground.TabIndex = 3;
            this.Ground.TabStop = false;
            this.Ground.Click += new System.EventHandler(this.Ground_Click);
            // 
            // SkyBounds
            // 
            this.SkyBounds.BackColor = System.Drawing.Color.Black;
            this.SkyBounds.Location = new System.Drawing.Point(0, -10);
            this.SkyBounds.Margin = new System.Windows.Forms.Padding(4);
            this.SkyBounds.Name = "SkyBounds";
            this.SkyBounds.Size = new System.Drawing.Size(1065, 17);
            this.SkyBounds.TabIndex = 4;
            this.SkyBounds.TabStop = false;
            this.SkyBounds.Click += new System.EventHandler(this.SkyBounds_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ScoreText
            // 
            this.ScoreText.AutoSize = true;
            this.ScoreText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ScoreText.Location = new System.Drawing.Point(16, 15);
            this.ScoreText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(46, 17);
            this.ScoreText.TabIndex = 5;
            this.ScoreText.Text = "label1";
            this.ScoreText.Click += new System.EventHandler(this.ScoreText_Click);
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Welcome.Location = new System.Drawing.Point(394, 240);
            this.Welcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(253, 17);
            this.Welcome.TabIndex = 7;
            this.Welcome.Text = "Press The Enter Key To Begin Playing!";
            // 
            // MiddleObstacle1
            // 
            this.MiddleObstacle1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MiddleObstacle1.BackgroundImage")));
            this.MiddleObstacle1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MiddleObstacle1.Location = new System.Drawing.Point(845, 338);
            this.MiddleObstacle1.Name = "MiddleObstacle1";
            this.MiddleObstacle1.Size = new System.Drawing.Size(86, 84);
            this.MiddleObstacle1.TabIndex = 8;
            this.MiddleObstacle1.TabStop = false;
            this.MiddleObstacle1.Click += new System.EventHandler(this.MiddleObstacle1_Click);
            // 
            // MiddleObstacle2
            // 
            this.MiddleObstacle2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MiddleObstacle2.BackgroundImage")));
            this.MiddleObstacle2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MiddleObstacle2.Location = new System.Drawing.Point(397, 107);
            this.MiddleObstacle2.Name = "MiddleObstacle2";
            this.MiddleObstacle2.Size = new System.Drawing.Size(100, 88);
            this.MiddleObstacle2.TabIndex = 9;
            this.MiddleObstacle2.TabStop = false;
            this.MiddleObstacle2.Click += new System.EventHandler(this.MiddleObstacle2_Click);
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SpeedLabel.Location = new System.Drawing.Point(952, 15);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(57, 17);
            this.SpeedLabel.TabIndex = 10;
            this.SpeedLabel.Text = "Speed: ";
            this.SpeedLabel.TextChanged += new System.EventHandler(this.SpeedLabel_TextChanged);
            // 
            // FlappyCopter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.SpeedLabel);
            this.Controls.Add(this.MiddleObstacle2);
            this.Controls.Add(this.MiddleObstacle1);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.ScoreText);
            this.Controls.Add(this.SkyBounds);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.ObstacleBottom);
            this.Controls.Add(this.Copter);
            this.Controls.Add(this.ObstacleTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FlappyCopter";
            this.Text = "FlappyCopter";
            this.Load += new System.EventHandler(this.FlappyCopter_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Down);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterKeyPressed);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Up);
            ((System.ComponentModel.ISupportInitialize)(this.ObstacleTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Copter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObstacleBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SkyBounds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MiddleObstacle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MiddleObstacle2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ObstacleTop;
        private System.Windows.Forms.PictureBox Copter;
        private System.Windows.Forms.PictureBox ObstacleBottom;
        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.PictureBox SkyBounds;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label ScoreText;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.PictureBox MiddleObstacle1;
        private System.Windows.Forms.PictureBox MiddleObstacle2;
        private System.Windows.Forms.Label SpeedLabel;
    }
}