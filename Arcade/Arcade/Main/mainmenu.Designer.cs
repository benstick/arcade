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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainmenu));
            this.FadeinTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.DuckhuntDemo = new System.Windows.Forms.PictureBox();
            this.FlappyCopterDemo = new System.Windows.Forms.PictureBox();
            this.SankeDemo = new System.Windows.Forms.PictureBox();
            this.NoNameDemo = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.UserFocusCheck = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DuckhuntDemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyCopterDemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SankeDemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoNameDemo)).BeginInit();
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
            this.DuckhuntDemo.Image = global::Arcade.Properties.Resources.SpaceHuntDemoIntroSS;
            this.DuckhuntDemo.Location = new System.Drawing.Point(138, 65);
            this.DuckhuntDemo.Name = "DuckhuntDemo";
            this.DuckhuntDemo.Size = new System.Drawing.Size(150, 100);
            this.DuckhuntDemo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DuckhuntDemo.TabIndex = 2;
            this.DuckhuntDemo.TabStop = false;
            this.DuckhuntDemo.Visible = false;
            this.DuckhuntDemo.Click += new System.EventHandler(this.DuckhuntDemo_Click);
            // 
            // FlappyCopterDemo
            // 
            this.FlappyCopterDemo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.FlappyCopterDemo.Enabled = false;
            this.FlappyCopterDemo.Image = global::Arcade.Properties.Resources.FlappyCopterDemoSS;
            this.FlappyCopterDemo.Location = new System.Drawing.Point(500, 65);
            this.FlappyCopterDemo.Name = "FlappyCopterDemo";
            this.FlappyCopterDemo.Size = new System.Drawing.Size(150, 100);
            this.FlappyCopterDemo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FlappyCopterDemo.TabIndex = 5;
            this.FlappyCopterDemo.TabStop = false;
            this.FlappyCopterDemo.Visible = false;
            this.FlappyCopterDemo.Click += new System.EventHandler(this.FlappyCopterDemo_Click);
            // 
            // SankeDemo
            // 
            this.SankeDemo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SankeDemo.Enabled = false;
            this.SankeDemo.Location = new System.Drawing.Point(150, 318);
            this.SankeDemo.Margin = new System.Windows.Forms.Padding(2);
            this.SankeDemo.Name = "SankeDemo";
            this.SankeDemo.Size = new System.Drawing.Size(75, 41);
            this.SankeDemo.TabIndex = 10;
            this.SankeDemo.TabStop = false;
            this.SankeDemo.Visible = false;
            // 
            // NoNameDemo
            // 
            this.NoNameDemo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.NoNameDemo.Enabled = false;
            this.NoNameDemo.Image = global::Arcade.Properties.Resources.NoNameDemoSS;
            this.NoNameDemo.Location = new System.Drawing.Point(500, 259);
            this.NoNameDemo.Margin = new System.Windows.Forms.Padding(2);
            this.NoNameDemo.Name = "NoNameDemo";
            this.NoNameDemo.Size = new System.Drawing.Size(150, 100);
            this.NoNameDemo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NoNameDemo.TabIndex = 9;
            this.NoNameDemo.TabStop = false;
            this.NoNameDemo.Visible = false;
            this.NoNameDemo.Click += new System.EventHandler(this.NoNameDemo_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 22);
            this.toolStripButton2.Text = "Exit";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(44, 22);
            this.toolStripButton1.Text = "About";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(47, 22);
            this.toolStripButton3.Text = "Restart";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // UserFocusCheck
            // 
            this.UserFocusCheck.Tick += new System.EventHandler(this.UserFocusCheck_Tick);
            // 
            // mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Arcade.Properties.Resources.mainlogo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.NoNameDemo);
            this.Controls.Add(this.SankeDemo);
            this.Controls.Add(this.FlappyCopterDemo);
            this.Controls.Add(this.DuckhuntDemo);
            this.Controls.Add(this.ExitLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "mainmenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.mainmenu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainmenu_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainmenu_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.DuckhuntDemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyCopterDemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SankeDemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoNameDemo)).EndInit();
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
        private System.Windows.Forms.PictureBox NoNameDemo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Timer UserFocusCheck;
    }
}