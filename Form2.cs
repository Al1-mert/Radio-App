using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radyo
{
    public partial class SettingsForm : Form
    {
        public Form1 a; //needed to reference form1. rename later


        public static float radioVolume = 50;
        public SettingsForm()
        {
            InitializeComponent();
        }

        //Sesi ayarla
        private void bunifuSlider1_ValueChanged(object sender, EventArgs e)
        {
            a.changeVolume(volumeSlider.Value);
            Properties.Settings.Default.defaultSound = volumeSlider.Value;
        }

        //Araç çubuğundan çıkar 
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            notifyIcon1.Visible = false;
            foreach (Form forms in Application.OpenForms)
            {
                forms.Show();
            }
        }

        //Araç çubuğundan çıkar 
        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            notifyIcon1.Visible = false;
            foreach (Form forms in Application.OpenForms)
            {
                forms.Show();
            }
        }

         //Araç çubuğuna gizle
        private void AracCubugunaGizle_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip( 2000);
            foreach (Form forms in Application.OpenForms)
            {
                forms.Hide();
            }
        }

        //yayın stream urlsini değiştir
        private void YayinAdresiTextBox_TextChanged(object sender, EventArgs e)
        {
            YayinAdresiTextBox.Text = YayinAdresiTextBox.Text.ToLower();
            
            if(saveAsDefaultUrlCheckBox.Checked)
            {
                Properties.Settings.Default.defaultURL = YayinAdresiTextBox.Text;
            }
            Properties.Settings.Default.lastURL = YayinAdresiTextBox.Text;
            try { a.changeURL(YayinAdresiTextBox.Text); }
            catch
            {  
                //null exception only happens at start
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            Application.Exit();
        }

        private void playAtStart_OnChange(object sender, EventArgs e)
        {
            Properties.Settings.Default.playAtStart = !Properties.Settings.Default.playAtStart;
        }

        private void saveAsDefaultUrlCheckBox_OnChange(object sender, EventArgs e)
        {
            Properties.Settings.Default.saveAsDefault = !Properties.Settings.Default.saveAsDefault;
        }
    }
}
