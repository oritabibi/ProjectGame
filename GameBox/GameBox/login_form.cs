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

    public partial class login_form : Form
    {
        public login_form(WindowsMediaPlayer Wmp)
        {
            InitializeComponent();
            Wmp.controls.play();
            if(GameBox.Program.cnt_players==1)
            {
                this.MTB_pass2.Enabled = false;
                this.MTB_user_name2.Enabled = false;
                this.MTB_Guest_name2.Enabled = false;
                this.COB_user2.Enabled = false;
            }
        }

        private void Bt_login_exit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to exit? ", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
                foreach (Form form in Application.OpenForms)
                    form.Close();
            GameBox.Program.user1 = "leor";
            GameBox.Form1.Wmp.controls.play();
        }

        private void Bt_user_continue_Click(object sender, EventArgs e)
        {
            if (GameBox.Program.cnt_players == 1)
            {
                if (User_Check(MTB_user_name1.Text) == false || Password_Check(MTB_pass1.Text) == false)
                {
                    MessageBox.Show("Invalid input - User1 ");
                    return;
                }
            }
            else
            {
                if (User_Check(MTB_user_name1.Text) == false || Password_Check(MTB_pass1.Text) == false)
                {
                    MessageBox.Show("Invalid input - User1 ");
                    return;
                }
               else if (User_Check(MTB_user_name2.Text) == false || Password_Check(MTB_pass2.Text) == false)
                {
                    MessageBox.Show("Invalid input - User2 ");
                    return;
                }

            }
        }

        private Boolean Password_Check(string pass)
        {
            if (pass.Length == 5)
                return true;
            return false;
        }
        private Boolean User_Check(string user)
        {
            if (user.Length < 2 || user.Length > 10)
                return false;
            return true;
        }

        private void Bt_guest_continue_Click(object sender, EventArgs e)
        {
            if (GameBox.Program.cnt_players == 1)
            {
                if (User_Check(MTB_Guest_name1.Text) ==false)
                {
                    MessageBox.Show("Invalid input -Guest1 ");
                    return;
                }
            }
            else
            {
                if (User_Check(MTB_Guest_name1.Text) == false)
                {
                    MessageBox.Show("Invalid input -Guest1 ");
                    return;
                }
                if (User_Check(MTB_Guest_name2.Text) == false)
                {
                    MessageBox.Show("Invalid input -Guest2 ");
                    return;
                }
            }

            

        }
    }

}
