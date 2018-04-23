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
            this.HealthBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.WallRight = new System.Windows.Forms.PictureBox();
            this.WallLeft = new System.Windows.Forms.PictureBox();
            this.WallTop = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.ufo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.WallRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WallLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WallTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ufo)).BeginInit();
            this.SuspendLayout();
            // 
            // HealthBar
            // 
            this.HealthBar.BackColor = System.Drawing.Color.Red;
            this.HealthBar.ForeColor = System.Drawing.Color.Lime;
            this.HealthBar.Location = new System.Drawing.Point(61, 12);
            this.HealthBar.Name = "HealthBar";
            this.HealthBar.Size = new System.Drawing.Size(100, 16);
            this.HealthBar.TabIndex = 5;
            this.HealthBar.Value = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Health";
            // 
            // WallRight
            // 
            this.WallRight.Location = new System.Drawing.Point(783, -1);
            this.WallRight.Name = "WallRight";
            this.WallRight.Size = new System.Drawing.Size(10, 566);
            this.WallRight.TabIndex = 4;
            this.WallRight.TabStop = false;
            this.WallRight.Visible = false;
            // 
            // WallLeft
            // 
            this.WallLeft.Location = new System.Drawing.Point(-8, -1);
            this.WallLeft.Name = "WallLeft";
            this.WallLeft.Size = new System.Drawing.Size(10, 566);
            this.WallLeft.TabIndex = 3;
            this.WallLeft.TabStop = false;
            this.WallLeft.Visible = false;
            // 
            // WallTop
            // 
            this.WallTop.Location = new System.Drawing.Point(-7, -1);
            this.WallTop.Name = "WallTop";
            this.WallTop.Size = new System.Drawing.Size(800, 10);
            this.WallTop.TabIndex = 2;
            this.WallTop.TabStop = false;
            this.WallTop.Visible = false;
            // 
            // ground
            // 
            this.ground.Image = global::Arcade.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-122, 515);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1000, 50);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ground.TabIndex = 1;
            this.ground.TabStop = false;
            // 
            // ufo
            // 
            this.ufo.Image = global::Arcade.Properties.Resources.ufo1;
            this.ufo.Location = new System.Drawing.Point(352, 15);
            this.ufo.Name = "ufo";
            this.ufo.Size = new System.Drawing.Size(50, 50);
            this.ufo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ufo.TabIndex = 0;
            this.ufo.TabStop = false;
            // 
            // NoName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HealthBar);
            this.Controls.Add(this.WallRight);
            this.Controls.Add(this.WallLeft);
            this.Controls.Add(this.WallTop);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.ufo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NoName";
            this.Text = "Game";
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
        private System.Windows.Forms.ProgressBar HealthBar;
        private System.Windows.Forms.Label label1;
    }
}

