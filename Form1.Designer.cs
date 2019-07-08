namespace Radyo
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
            this.formElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.playButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.pauseButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.refreshButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.playButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pauseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // formElipse
            // 
            this.formElipse.ElipseRadius = 30;
            this.formElipse.TargetControl = this;
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.White;
            this.playButton.Image = ((System.Drawing.Image)(resources.GetObject("playButton.Image")));
            this.playButton.ImageActive = null;
            this.playButton.Location = new System.Drawing.Point(12, 158);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(29, 32);
            this.playButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playButton.TabIndex = 2;
            this.playButton.TabStop = false;
            this.playButton.Zoom = 10;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.BackColor = System.Drawing.Color.White;
            this.pauseButton.Image = ((System.Drawing.Image)(resources.GetObject("pauseButton.Image")));
            this.pauseButton.ImageActive = null;
            this.pauseButton.Location = new System.Drawing.Point(47, 158);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(29, 32);
            this.pauseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pauseButton.TabIndex = 2;
            this.pauseButton.TabStop = false;
            this.pauseButton.Zoom = 10;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.White;
            this.refreshButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshButton.Image")));
            this.refreshButton.ImageActive = null;
            this.refreshButton.Location = new System.Drawing.Point(82, 158);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(23, 32);
            this.refreshButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refreshButton.TabIndex = 2;
            this.refreshButton.TabStop = false;
            this.refreshButton.Zoom = 10;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.White;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(171, 158);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(29, 32);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 2;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.AccessibleDescription = "";
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(-6, -2);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(224, 27);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(212, 202);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Radyo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.playButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pauseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse formElipse;
        private Bunifu.Framework.UI.BunifuImageButton playButton;
        private Bunifu.Framework.UI.BunifuImageButton pauseButton;
        private Bunifu.Framework.UI.BunifuImageButton refreshButton;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        public AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

