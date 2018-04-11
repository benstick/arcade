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
            this.CarDoggingDemo = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.DuckhuntDemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyCopterDemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SankeDemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarDoggingDemo)).BeginInit();
            this.toolStrip1.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(381, 300);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 36);
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
            this.ExitLabel.Location = new System.Drawing.Point(381, 352);
            this.ExitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(236, 36);
            this.ExitLabel.TabIndex = 1;
            this.ExitLabel.Text = "Press Esc to exit";
            this.ExitLabel.Visible = false;
            this.ExitLabel.EnabledChanged += new System.EventHandler(this.FadeinTimer_Tick);
            // 
            // DuckhuntDemo
            // 
            this.DuckhuntDemo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.DuckhuntDemo.Enabled = false;
            this.DuckhuntDemo.Location = new System.Drawing.Point(153, 149);
            this.DuckhuntDemo.Margin = new System.Windows.Forms.Padding(4);
            this.DuckhuntDemo.Name = "DuckhuntDemo";
            this.DuckhuntDemo.Size = new System.Drawing.Size(181, 119);
            this.DuckhuntDemo.TabIndex = 2;
            this.DuckhuntDemo.TabStop = false;
            this.DuckhuntDemo.Visible = false;
            this.DuckhuntDemo.Click += new System.EventHandler(this.DuckhuntDemo_Click);
            // 
            // FlappyCopterDemo
            // 
            this.FlappyCopterDemo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.FlappyCopterDemo.Enabled = false;
            this.FlappyCopterDemo.Location = new System.Drawing.Point(655, 149);
            this.FlappyCopterDemo.Margin = new System.Windows.Forms.Padding(4);
            this.FlappyCopterDemo.Name = "FlappyCopterDemo";
            this.FlappyCopterDemo.Size = new System.Drawing.Size(181, 119);
            this.FlappyCopterDemo.TabIndex = 5;
            this.FlappyCopterDemo.TabStop = false;
            this.FlappyCopterDemo.Visible = false;
            this.FlappyCopterDemo.Click += new System.EventHandler(this.FlappyCopterDemo_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton1,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1067, 27);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(54, 24);
            this.toolStripButton1.Text = "About";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(37, 24);
            this.toolStripButton2.Text = "Exit";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(59, 24);
            this.toolStripButton3.Text = "Restart";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Arcade.Properties.Resources.mainlogo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.CarDoggingDemo);
            this.Controls.Add(this.SankeDemo);
            this.Controls.Add(this.FlappyCopterDemo);
            this.Controls.Add(this.DuckhuntDemo);
            this.Controls.Add(this.ExitLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainmenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.mainmenu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainmenu_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainmenu_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.DuckhuntDemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyCopterDemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SankeDemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarDoggingDemo)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
    }
}