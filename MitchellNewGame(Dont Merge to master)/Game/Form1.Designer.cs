namespace Game
{
    partial class Form1
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
            this.ground = new System.Windows.Forms.PictureBox();
            this.ufo = new System.Windows.Forms.PictureBox();
            this.GameloopTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ufo)).BeginInit();
            this.SuspendLayout();
            // 
            // ground
            // 
            this.ground.Image = global::Game.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-42, 423);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(800, 50);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ground.TabIndex = 1;
            this.ground.TabStop = false;
            // 
            // ufo
            // 
            this.ufo.Image = global::Game.Properties.Resources.ufo;
            this.ufo.Location = new System.Drawing.Point(371, 134);
            this.ufo.Name = "ufo";
            this.ufo.Size = new System.Drawing.Size(50, 42);
            this.ufo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ufo.TabIndex = 0;
            this.ufo.TabStop = false;
            this.ufo.Click += new System.EventHandler(this.ufo_Click);
            // 
            // GameloopTimer
            // 
            this.GameloopTimer.Tick += new System.EventHandler(this.GameloopTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(719, 468);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.ufo);
            this.Name = "Form1";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ufo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ufo;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Timer GameloopTimer;
    }
}

