namespace Arcade
{
    partial class Copter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Copter));
            this.flappyCopter = new System.Windows.Forms.PictureBox();
            this.obstacleTop = new System.Windows.Forms.PictureBox();
            this.obstacleBottom = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.scoreText = new System.Windows.Forms.Label();
            this.endText1 = new System.Windows.Forms.Label();
            this.endText2 = new System.Windows.Forms.Label();
            this.restartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.flappyCopter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacleTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacleBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // flappyCopter
            // 
            this.flappyCopter.Image = ((System.Drawing.Image)(resources.GetObject("flappyCopter.Image")));
            this.flappyCopter.Location = new System.Drawing.Point(26, 172);
            this.flappyCopter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flappyCopter.Name = "flappyCopter";
            this.flappyCopter.Size = new System.Drawing.Size(75, 41);
            this.flappyCopter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyCopter.TabIndex = 0;
            this.flappyCopter.TabStop = false;
            this.flappyCopter.Click += new System.EventHandler(this.flappyCopter_Click);
            // 
            // obstacleTop
            // 
            this.obstacleTop.Image = ((System.Drawing.Image)(resources.GetObject("obstacleTop.Image")));
            this.obstacleTop.Location = new System.Drawing.Point(117, 1);
            this.obstacleTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.obstacleTop.Name = "obstacleTop";
            this.obstacleTop.Size = new System.Drawing.Size(124, 80);
            this.obstacleTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obstacleTop.TabIndex = 1;
            this.obstacleTop.TabStop = false;
            this.obstacleTop.Click += new System.EventHandler(this.obstacleTop_Click);
            // 
            // obstacleBottom
            // 
            this.obstacleBottom.Image = ((System.Drawing.Image)(resources.GetObject("obstacleBottom.Image")));
            this.obstacleBottom.Location = new System.Drawing.Point(259, 270);
            this.obstacleBottom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.obstacleBottom.Name = "obstacleBottom";
            this.obstacleBottom.Size = new System.Drawing.Size(75, 150);
            this.obstacleBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obstacleBottom.TabIndex = 2;
            this.obstacleBottom.TabStop = false;
            this.obstacleBottom.Click += new System.EventHandler(this.obstacleBottom_Click);
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(0, 417);
            this.ground.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(373, 64);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            this.ground.Click += new System.EventHandler(this.ground_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 15;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Location = new System.Drawing.Point(11, 9);
            this.scoreText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(35, 13);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "label1";
            this.scoreText.Click += new System.EventHandler(this.scoreText_Click);
            // 
            // endText1
            // 
            this.endText1.AutoSize = true;
            this.endText1.Location = new System.Drawing.Point(58, 278);
            this.endText1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.endText1.Name = "endText1";
            this.endText1.Size = new System.Drawing.Size(35, 13);
            this.endText1.TabIndex = 5;
            this.endText1.Text = "label2";
            this.endText1.Visible = false;
            this.endText1.Click += new System.EventHandler(this.endText1_Click);
            // 
            // endText2
            // 
            this.endText2.AutoSize = true;
            this.endText2.Location = new System.Drawing.Point(58, 313);
            this.endText2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.endText2.Name = "endText2";
            this.endText2.Size = new System.Drawing.Size(35, 13);
            this.endText2.TabIndex = 6;
            this.endText2.Text = "label3";
            this.endText2.Visible = false;
            this.endText2.Click += new System.EventHandler(this.endText2_Click);
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(183, 190);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(75, 23);
            this.restartButton.TabIndex = 7;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // Copter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(371, 482);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.endText2);
            this.Controls.Add(this.endText1);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.obstacleBottom);
            this.Controls.Add(this.obstacleTop);
            this.Controls.Add(this.flappyCopter);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Copter";
            this.Text = "FlappyCopter";
            this.Load += new System.EventHandler(this.FlappyCopter_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inGameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
            ((System.ComponentModel.ISupportInitialize)(this.flappyCopter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacleTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacleBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flappyCopter;
        private System.Windows.Forms.PictureBox obstacleTop;
        private System.Windows.Forms.PictureBox obstacleBottom;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Label endText1;
        private System.Windows.Forms.Label endText2;
        private System.Windows.Forms.Button restartButton;
    }
}

