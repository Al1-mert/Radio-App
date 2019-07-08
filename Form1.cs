using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Radyo
{
    public partial class Form1 : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        private int settingsOffsetX = 212;
        private bool settingsVisible = false;

        SettingsForm ayarlar = new SettingsForm();

        public Form1()
        {
            InitializeComponent();
       
        }

        //başlangıçta otomatik çal
        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @Properties.Settings.Default.defaultURL;
            axWindowsMediaPlayer1.settings.volume = Properties.Settings.Default.defaultSound;

           
            if(!Properties.Settings.Default.playAtStart) axWindowsMediaPlayer1.Ctlcontrols.stop();

            axWindowsMediaPlayer1.uiMode = "none";

        }

     
        //formu sürüklenebilir yap--
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();

                //Ayarlar formu da beraber sürüklensin
                ayarlar.Location = new Point(
               (ayarlar.Location.X - lastLocation.X) + e.X, (ayarlar.Location.Y - lastLocation.Y) + e.Y);
                ayarlar.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        //--formu sürüklenebilir yap




        private void playButton_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();

        }
        private void pauseButton_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();

        }
        private void refreshButton_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"x";
            axWindowsMediaPlayer1.URL = @Properties.Settings.Default.defaultURL;
        }

        //ayarlar menusunu aç
        private void settingsButton_Click(object sender, EventArgs e)
        {
            settingsVisible = !(settingsVisible);
            if (settingsVisible)
                ayarlar.Show();
            else
            {
                ayarlar.Hide();
            }
            ayarlar.Location = new Point(this.Location.X+settingsOffsetX, this.Location.Y);

        }

        //sesi değiştir
     public void changeVolume(int volume)
        {
            axWindowsMediaPlayer1.settings.volume = volume;

        }
     public void changeURL(string URL)
        {
            axWindowsMediaPlayer1.URL = @"x";
            axWindowsMediaPlayer1.URL = @URL;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ayarlar.volumeSlider.Value = Properties.Settings.Default.defaultSound;
            ayarlar.playAtStart.Checked = Properties.Settings.Default.playAtStart;
            ayarlar.saveAsDefaultUrlCheckBox.Checked = Properties.Settings.Default.saveAsDefault;
            ayarlar.YayinAdresiTextBox.Text = Properties.Settings.Default.lastURL;
            ayarlar.a = this;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();

        }
    }
}
