using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;


namespace GameBox
{
    
    public partial class Form1 : Form
    {
         
        public static WindowsMediaPlayer Wmp = new WindowsMediaPlayer();

        public Form1()
        {
            InitializeComponent();
            Wmp.URL = "music.mp3";
        }

       private void Bt_Exit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to exit? ", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
                foreach (Form form in Application.OpenForms)
                    form.Close();

        }

        private void CB_music_CheckedChanged(object sender, EventArgs e)
        {
            if(!CB_music.Checked)
            {
                CB_music.Text = "Music off";
                Wmp.controls.pause();
            }
            else
            {
                CB_music.Text = "Music on";
                Wmp.controls.play();
            }
              
        }

        private void Bt_SAL_2pl_Click(object sender, EventArgs e)
        {
            NextScreen(2, false);
            
        }

        private void Bt_SAL_1pl_Click(object sender, EventArgs e)
        {
            NextScreen(1, false);

        }

        private void Bt_REV_2pl_Click(object sender, EventArgs e)
        {
            NextScreen(2, true);

        }

        private void NextScreen(int num_players, Boolean gamechoise)
        {
            GameBox.Program.GameChoice = gamechoise;
            GameBox.Program.cnt_players = num_players;
            login_form login = new login_form(Wmp);
            Wmp.controls.pause();
            Form1 temp = new Form1();
            this.Hide();
            temp.Close();
            login.Show();
        }
    }
}
