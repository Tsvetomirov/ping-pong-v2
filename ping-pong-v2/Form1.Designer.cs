namespace Ping_Pong_v2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Ball = new System.Windows.Forms.PictureBox();
            this.Slider = new System.Windows.Forms.PictureBox();
            this.Vert = new System.Windows.Forms.Timer(this.components);
            this.Horz = new System.Windows.Forms.Timer(this.components);
            this.key_watch = new System.Windows.Forms.Timer(this.components);
            this.pblpause = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slider)).BeginInit();
            this.pblpause.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // Ball
            // 
            this.Ball.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ball.Enabled = false;
            this.Ball.Image = ((System.Drawing.Image)(resources.GetObject("Ball.Image")));
            this.Ball.Location = new System.Drawing.Point(0, 0);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(65, 65);
            this.Ball.TabIndex = 0;
            this.Ball.TabStop = false;
            // 
            // Slider
            // 
            this.Slider.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Slider.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Slider.Location = new System.Drawing.Point(279, 432);
            this.Slider.Name = "Slider";
            this.Slider.Size = new System.Drawing.Size(183, 17);
            this.Slider.TabIndex = 1;
            this.Slider.TabStop = false;
            // 
            // Vert
            // 
            this.Vert.Enabled = true;
            this.Vert.Interval = 1;
            this.Vert.Tick += new System.EventHandler(this.Vert_Tick);
            // 
            // Horz
            // 
            this.Horz.Enabled = true;
            this.Horz.Tick += new System.EventHandler(this.Horz_Tick);
            // 
            // key_watch
            // 
            this.key_watch.Enabled = true;
            this.key_watch.Interval = 1;
            this.key_watch.Tick += new System.EventHandler(this.key_watch_Tick);
            // 
            // pblpause
            // 
            this.pblpause.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pblpause.Controls.Add(this.bunifuCustomLabel1);
            this.pblpause.Dock = System.Windows.Forms.DockStyle.Top;
            this.pblpause.Location = new System.Drawing.Point(0, 0);
            this.pblpause.Name = "pblpause";
            this.pblpause.Size = new System.Drawing.Size(800, 56);
            this.pblpause.TabIndex = 3;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(353, 10);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(158, 36);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Game Paused";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Red;
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(772, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(29, 27);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 2;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pblpause);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.Slider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slider)).EndInit();
            this.pblpause.ResumeLayout(false);
            this.pblpause.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.PictureBox Slider;
        private System.Windows.Forms.Timer Vert;
        private System.Windows.Forms.Timer Horz;
        private System.Windows.Forms.Timer key_watch;
        private System.Windows.Forms.Panel pblpause;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}

