namespace Arcade
{
    partial class mainmenu
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
            this.FadeinTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.DuckhuntDemo = new System.Windows.Forms.PictureBox();
            this.FlappyCopterDemo = new System.Windows.Forms.PictureBox();
            this.SankeDemo = new System.Windows.Forms.PictureBox();
            this.CarDoggingDemo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DuckhuntDemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyCopterDemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SankeDemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarDoggingDemo)).BeginInit();
            this.SuspendLayout();
            // 
            // FadeinTimer
            // 
            this.FadeinTimer.Interval = 50;
            this.FadeinTimer.Tick += new System.EventHandler(this.FadeinTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Press any key to start";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ExitLabel
            // 
            this.ExitLabel.AutoSize = true;
            this.ExitLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ExitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitLabel.Location = new System.Drawing.Point(286, 286);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(190, 29);
            this.ExitLabel.TabIndex = 1;
            this.ExitLabel.Text = "Press Esc to exit";
            this.ExitLabel.Visible = false;
            this.ExitLabel.EnabledChanged += new System.EventHandler(this.FadeinTimer_Tick);
            // 
            // DuckhuntDemo
            // 
            this.DuckhuntDemo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.DuckhuntDemo.Enabled = false;
            this.DuckhuntDemo.Location = new System.Drawing.Point(115, 121);
            this.DuckhuntDemo.Name = "DuckhuntDemo";
            this.DuckhuntDemo.Size = new System.Drawing.Size(136, 97);
            this.DuckhuntDemo.TabIndex = 2;
            this.DuckhuntDemo.TabStop = false;
            this.DuckhuntDemo.Visible = false;
            this.DuckhuntDemo.Click += new System.EventHandler(this.DuckhuntDemo_Click);
            // 
            // FlappyCopterDemo
            // 
            this.FlappyCopterDemo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.FlappyCopterDemo.Enabled = false;
            this.FlappyCopterDemo.Location = new System.Drawing.Point(491, 121);
            this.FlappyCopterDemo.Name = "FlappyCopterDemo";
            this.FlappyCopterDemo.Size = new System.Drawing.Size(136, 97);
            this.FlappyCopterDemo.TabIndex = 5;
            this.FlappyCopterDemo.TabStop = false;
            this.FlappyCopterDemo.Visible = false;
            this.FlappyCopterDemo.Click += new System.EventHandler(this.FlappyCopterDemo_Click);
            // 
            // SankeDemo
            // 
            this.SankeDemo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SankeDemo.Enabled = false;
            this.SankeDemo.Location = new System.Drawing.Point(115, 286);
            this.SankeDemo.Name = "SankeDemo";
            this.SankeDemo.Size = new System.Drawing.Size(136, 97);
            this.SankeDemo.TabIndex = 6;
            this.SankeDemo.TabStop = false;
            this.SankeDemo.Visible = false;
            this.SankeDemo.Click += new System.EventHandler(this.SankeDemo_Click);
            // 
            // CarDoggingDemo
            // 
            this.CarDoggingDemo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CarDoggingDemo.Enabled = false;
            this.CarDoggingDemo.Location = new System.Drawing.Point(491, 286);
            this.CarDoggingDemo.Name = "CarDoggingDemo";
            this.CarDoggingDemo.Size = new System.Drawing.Size(136, 97);
            this.CarDoggingDemo.TabIndex = 7;
            this.CarDoggingDemo.TabStop = false;
            this.CarDoggingDemo.Visible = false;
            this.CarDoggingDemo.Click += new System.EventHandler(this.CarDoggingDemo_Click);
            // 
            // mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Arcade.Properties.Resources.mainlogo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CarDoggingDemo);
            this.Controls.Add(this.SankeDemo);
            this.Controls.Add(this.FlappyCopterDemo);
            this.Controls.Add(this.DuckhuntDemo);
            this.Controls.Add(this.ExitLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainmenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.mainmenu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainmenu_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainmenu_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.DuckhuntDemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyCopterDemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SankeDemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarDoggingDemo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer FadeinTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ExitLabel;
        private System.Windows.Forms.PictureBox DuckhuntDemo;
        private System.Windows.Forms.PictureBox FlappyCopterDemo;
        private System.Windows.Forms.PictureBox SankeDemo;
        private System.Windows.Forms.PictureBox CarDoggingDemo;
    }
}