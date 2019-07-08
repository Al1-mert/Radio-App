namespace Radyo
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.volumeSlider = new Bunifu.Framework.UI.BunifuSlider();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.settingsUpperGradient = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.exitButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.muteButton = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.AracCubugunaGizle = new Bunifu.Framework.UI.BunifuThinButton2();
            this.playAtStart = new Bunifu.Framework.UI.BunifuCheckbox();
            this.OtomatikCal = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.YayinAdresiTextBox = new Bunifu.Framework.BunifuCustomTextbox();
            this.YayinAdresi = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.saveAsDefaultUrlCheckBox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.defaultUrlLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.settingsUpperGradient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.muteButton)).BeginInit();
            this.SuspendLayout();
            // 
            // volumeSlider
            // 
            this.volumeSlider.BackColor = System.Drawing.Color.Transparent;
            this.volumeSlider.BackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.volumeSlider.BorderRadius = 10;
            this.volumeSlider.IndicatorColor = System.Drawing.Color.MistyRose;
            this.volumeSlider.Location = new System.Drawing.Point(55, 162);
            this.volumeSlider.MaximumValue = 100;
            this.volumeSlider.Name = "volumeSlider";
            this.volumeSlider.Size = new System.Drawing.Size(357, 30);
            this.volumeSlider.TabIndex = 0;
            this.volumeSlider.Value = 50;
            this.volumeSlider.ValueChanged += new System.EventHandler(this.bunifuSlider1_ValueChanged);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // settingsUpperGradient
            // 
            this.settingsUpperGradient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("settingsUpperGradient.BackgroundImage")));
            this.settingsUpperGradient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingsUpperGradient.Controls.Add(this.exitButton);
            this.settingsUpperGradient.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.settingsUpperGradient.GradientBottomRight = System.Drawing.Color.Black;
            this.settingsUpperGradient.GradientTopLeft = System.Drawing.Color.BlanchedAlmond;
            this.settingsUpperGradient.GradientTopRight = System.Drawing.Color.Black;
            this.settingsUpperGradient.Location = new System.Drawing.Point(-6, -2);
            this.settingsUpperGradient.Name = "settingsUpperGradient";
            this.settingsUpperGradient.Quality = 10;
            this.settingsUpperGradient.Size = new System.Drawing.Size(434, 27);
            this.settingsUpperGradient.TabIndex = 1;
            // 
            // exitButton
            // 
            this.exitButton.Active = false;
            this.exitButton.Activecolor = System.Drawing.Color.Transparent;
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.BorderRadius = 0;
            this.exitButton.ButtonText = "Çıkış";
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.DisabledColor = System.Drawing.Color.Gray;
            this.exitButton.Iconcolor = System.Drawing.Color.Transparent;
            this.exitButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("exitButton.Iconimage")));
            this.exitButton.Iconimage_right = null;
            this.exitButton.Iconimage_right_Selected = null;
            this.exitButton.Iconimage_Selected = null;
            this.exitButton.IconMarginLeft = 0;
            this.exitButton.IconMarginRight = 0;
            this.exitButton.IconRightVisible = true;
            this.exitButton.IconRightZoom = 0D;
            this.exitButton.IconVisible = false;
            this.exitButton.IconZoom = 90D;
            this.exitButton.IsTab = false;
            this.exitButton.Location = new System.Drawing.Point(333, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Normalcolor = System.Drawing.Color.Transparent;
            this.exitButton.OnHovercolor = System.Drawing.Color.Transparent;
            this.exitButton.OnHoverTextColor = System.Drawing.Color.White;
            this.exitButton.selected = false;
            this.exitButton.Size = new System.Drawing.Size(101, 24);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Çıkış";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitButton.Textcolor = System.Drawing.Color.White;
            this.exitButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // muteButton
            // 
            this.muteButton.Image = ((System.Drawing.Image)(resources.GetObject("muteButton.Image")));
            this.muteButton.Location = new System.Drawing.Point(12, 160);
            this.muteButton.Name = "muteButton";
            this.muteButton.Size = new System.Drawing.Size(37, 30);
            this.muteButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.muteButton.TabIndex = 2;
            this.muteButton.TabStop = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Araç çubuğuna küçültüldü";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Büyültmek için tıkla";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // AracCubugunaGizle
            // 
            this.AracCubugunaGizle.ActiveBorderThickness = 1;
            this.AracCubugunaGizle.ActiveCornerRadius = 20;
            this.AracCubugunaGizle.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.AracCubugunaGizle.ActiveForecolor = System.Drawing.Color.White;
            this.AracCubugunaGizle.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.AracCubugunaGizle.BackColor = System.Drawing.Color.White;
            this.AracCubugunaGizle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AracCubugunaGizle.BackgroundImage")));
            this.AracCubugunaGizle.ButtonText = "Araç çubuğuna gizle";
            this.AracCubugunaGizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AracCubugunaGizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AracCubugunaGizle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.AracCubugunaGizle.IdleBorderThickness = 1;
            this.AracCubugunaGizle.IdleCornerRadius = 20;
            this.AracCubugunaGizle.IdleFillColor = System.Drawing.Color.White;
            this.AracCubugunaGizle.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.AracCubugunaGizle.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.AracCubugunaGizle.Location = new System.Drawing.Point(229, 113);
            this.AracCubugunaGizle.Margin = new System.Windows.Forms.Padding(5);
            this.AracCubugunaGizle.Name = "AracCubugunaGizle";
            this.AracCubugunaGizle.Size = new System.Drawing.Size(181, 41);
            this.AracCubugunaGizle.TabIndex = 3;
            this.AracCubugunaGizle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AracCubugunaGizle.Click += new System.EventHandler(this.AracCubugunaGizle_Click);
            // 
            // playAtStart
            // 
            this.playAtStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.playAtStart.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.playAtStart.Checked = true;
            this.playAtStart.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.playAtStart.ForeColor = System.Drawing.Color.White;
            this.playAtStart.Location = new System.Drawing.Point(12, 123);
            this.playAtStart.Name = "playAtStart";
            this.playAtStart.Size = new System.Drawing.Size(20, 20);
            this.playAtStart.TabIndex = 4;
            this.playAtStart.OnChange += new System.EventHandler(this.playAtStart_OnChange);
            // 
            // OtomatikCal
            // 
            this.OtomatikCal.AutoSize = true;
            this.OtomatikCal.Font = new System.Drawing.Font("qtquickcontrols", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OtomatikCal.Location = new System.Drawing.Point(38, 123);
            this.OtomatikCal.Name = "OtomatikCal";
            this.OtomatikCal.Size = new System.Drawing.Size(180, 17);
            this.OtomatikCal.TabIndex = 5;
            this.OtomatikCal.Text = "Başladığında otomatik çalsın";
            // 
            // YayinAdresiTextBox
            // 
            this.YayinAdresiTextBox.BorderColor = System.Drawing.Color.SeaGreen;
            this.YayinAdresiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YayinAdresiTextBox.Location = new System.Drawing.Point(106, 31);
            this.YayinAdresiTextBox.Name = "YayinAdresiTextBox";
            this.YayinAdresiTextBox.Size = new System.Drawing.Size(278, 26);
            this.YayinAdresiTextBox.TabIndex = 6;
            this.YayinAdresiTextBox.Text = "http://46.20.3.246/stream/507/";
            this.YayinAdresiTextBox.TextChanged += new System.EventHandler(this.YayinAdresiTextBox_TextChanged);
            // 
            // YayinAdresi
            // 
            this.YayinAdresi.AutoSize = true;
            this.YayinAdresi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YayinAdresi.Location = new System.Drawing.Point(12, 35);
            this.YayinAdresi.Name = "YayinAdresi";
            this.YayinAdresi.Size = new System.Drawing.Size(88, 18);
            this.YayinAdresi.TabIndex = 7;
            this.YayinAdresi.Text = "Yayın Adresi";
            // 
            // saveAsDefaultUrlCheckBox
            // 
            this.saveAsDefaultUrlCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.saveAsDefaultUrlCheckBox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.saveAsDefaultUrlCheckBox.Checked = true;
            this.saveAsDefaultUrlCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.saveAsDefaultUrlCheckBox.ForeColor = System.Drawing.Color.White;
            this.saveAsDefaultUrlCheckBox.Location = new System.Drawing.Point(106, 63);
            this.saveAsDefaultUrlCheckBox.Name = "saveAsDefaultUrlCheckBox";
            this.saveAsDefaultUrlCheckBox.Size = new System.Drawing.Size(20, 20);
            this.saveAsDefaultUrlCheckBox.TabIndex = 4;
            this.saveAsDefaultUrlCheckBox.OnChange += new System.EventHandler(this.saveAsDefaultUrlCheckBox_OnChange);
            // 
            // defaultUrlLabel
            // 
            this.defaultUrlLabel.AutoSize = true;
            this.defaultUrlLabel.Font = new System.Drawing.Font("qtquickcontrols", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defaultUrlLabel.Location = new System.Drawing.Point(132, 63);
            this.defaultUrlLabel.Name = "defaultUrlLabel";
            this.defaultUrlLabel.Size = new System.Drawing.Size(187, 17);
            this.defaultUrlLabel.TabIndex = 5;
            this.defaultUrlLabel.Text = "Varsayılan URL olarak kaydet";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(424, 202);
            this.Controls.Add(this.YayinAdresi);
            this.Controls.Add(this.YayinAdresiTextBox);
            this.Controls.Add(this.defaultUrlLabel);
            this.Controls.Add(this.saveAsDefaultUrlCheckBox);
            this.Controls.Add(this.OtomatikCal);
            this.Controls.Add(this.playAtStart);
            this.Controls.Add(this.AracCubugunaGizle);
            this.Controls.Add(this.muteButton);
            this.Controls.Add(this.settingsUpperGradient);
            this.Controls.Add(this.volumeSlider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.settingsUpperGradient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.muteButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel settingsUpperGradient;
        private System.Windows.Forms.PictureBox muteButton;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private Bunifu.Framework.UI.BunifuThinButton2 AracCubugunaGizle;
        private Bunifu.Framework.UI.BunifuCustomLabel OtomatikCal;
        private Bunifu.Framework.UI.BunifuCustomLabel YayinAdresi;
        private Bunifu.Framework.UI.BunifuFlatButton exitButton;
        public Bunifu.Framework.UI.BunifuSlider volumeSlider;
        public Bunifu.Framework.UI.BunifuCheckbox playAtStart;
        private Bunifu.Framework.UI.BunifuCustomLabel defaultUrlLabel;
        public Bunifu.Framework.UI.BunifuCheckbox saveAsDefaultUrlCheckBox;
        public Bunifu.Framework.BunifuCustomTextbox YayinAdresiTextBox;
    }
}