namespace Arcade
{
    partial class NoName
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
            this.GameloopTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.HealthBarBackColor = new System.Windows.Forms.Panel();
            this.HealthBarFrontColor = new System.Windows.Forms.Panel();
            this.WallRight = new System.Windows.Forms.PictureBox();
            this.WallLeft = new System.Windows.Forms.PictureBox();
            this.WallTop = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.ufo = new System.Windows.Forms.PictureBox();
            this.FPSLabel = new System.Windows.Forms.Label();
            this.FPSTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.WallRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WallLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WallTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ufo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Health";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.Location = new System.Drawing.Point(409, 18);
            this.ScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(100, 25);
            this.ScoreLabel.TabIndex = 7;
            this.ScoreLabel.Text = "Score : 0";
            // 
            // HealthBarBackColor
            // 
            this.HealthBarBackColor.BackColor = System.Drawing.Color.Red;
            this.HealthBarBackColor.Location = new System.Drawing.Point(81, 18);
            this.HealthBarBackColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HealthBarBackColor.Name = "HealthBarBackColor";
            this.HealthBarBackColor.Size = new System.Drawing.Size(133, 18);
            this.HealthBarBackColor.TabIndex = 8;
            // 
            // HealthBarFrontColor
            // 
            this.HealthBarFrontColor.BackColor = System.Drawing.Color.Lime;
            this.HealthBarFrontColor.Location = new System.Drawing.Point(81, 18);
            this.HealthBarFrontColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HealthBarFrontColor.Name = "HealthBarFrontColor";
            this.HealthBarFrontColor.Size = new System.Drawing.Size(133, 18);
            this.HealthBarFrontColor.TabIndex = 9;
            // 
            // WallRight
            // 
            this.WallRight.Location = new System.Drawing.Point(1044, -1);
            this.WallRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WallRight.Name = "WallRight";
            this.WallRight.Size = new System.Drawing.Size(13, 697);
            this.WallRight.TabIndex = 4;
            this.WallRight.TabStop = false;
            this.WallRight.Visible = false;
            // 
            // WallLeft
            // 
            this.WallLeft.Location = new System.Drawing.Point(-11, -1);
            this.WallLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WallLeft.Name = "WallLeft";
            this.WallLeft.Size = new System.Drawing.Size(13, 697);
            this.WallLeft.TabIndex = 3;
            this.WallLeft.TabStop = false;
            this.WallLeft.Visible = false;
            // 
            // WallTop
            // 
            this.WallTop.Location = new System.Drawing.Point(-9, -1);
            this.WallTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WallTop.Name = "WallTop";
            this.WallTop.Size = new System.Drawing.Size(1067, 12);
            this.WallTop.TabIndex = 2;
            this.WallTop.TabStop = false;
            this.WallTop.Visible = false;
            // 
            // ground
            // 
            this.ground.Image = global::Arcade.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-168, 646);
            this.ground.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1400, 50);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ground.TabIndex = 1;
            this.ground.TabStop = false;
            // 
            // ufo
            // 
            this.ufo.Image = global::Arcade.Properties.Resources.ufo1;
            this.ufo.Location = new System.Drawing.Point(415, 391);
            this.ufo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ufo.Name = "ufo";
            this.ufo.Size = new System.Drawing.Size(50, 50);
            this.ufo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ufo.TabIndex = 0;
            this.ufo.TabStop = false;
            // 
            // FPSLabel
            // 
            this.FPSLabel.AutoSize = true;
            this.FPSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FPSLabel.Location = new System.Drawing.Point(912, 18);
            this.FPSLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FPSLabel.Name = "FPSLabel";
            this.FPSLabel.Size = new System.Drawing.Size(62, 20);
            this.FPSLabel.TabIndex = 10;
            this.FPSLabel.Text = "FPS : ";
            // 
            // FPSTimer
            // 
            this.FPSTimer.Interval = 1000;
            this.FPSTimer.Tick += new System.EventHandler(this.FPSTimer_Tick);
            // 
            // NoName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.FPSLabel);
            this.Controls.Add(this.HealthBarFrontColor);
            this.Controls.Add(this.HealthBarBackColor);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WallRight);
            this.Controls.Add(this.WallLeft);
            this.Controls.Add(this.WallTop);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.ufo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NoName";
            this.Text = "Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NoName_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WallRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WallLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WallTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ufo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ufo;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Timer GameloopTimer;
        private System.Windows.Forms.PictureBox WallTop;
        private System.Windows.Forms.PictureBox WallLeft;
        private System.Windows.Forms.PictureBox WallRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Panel HealthBarBackColor;
        private System.Windows.Forms.Panel HealthBarFrontColor;
        private System.Windows.Forms.Label FPSLabel;
        private System.Windows.Forms.Timer FPSTimer;
    }
}

