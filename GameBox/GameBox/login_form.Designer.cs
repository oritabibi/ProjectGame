namespace GameBox
{
    partial class login_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.MTB_user_name1 = new System.Windows.Forms.MaskedTextBox();
            this.MTB_pass1 = new System.Windows.Forms.MaskedTextBox();
            this.Bt_guest_continue = new System.Windows.Forms.Button();
            this.Bt_user_continue = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.COB_user1 = new System.Windows.Forms.ComboBox();
            this.COB_user2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MTB_pass2 = new System.Windows.Forms.MaskedTextBox();
            this.MTB_user_name2 = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.MTB_Guest_name1 = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.MTB_Guest_name2 = new System.Windows.Forms.MaskedTextBox();
            this.Bt_login_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 34.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(366, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // MTB_user_name1
            // 
            this.MTB_user_name1.Location = new System.Drawing.Point(158, 156);
            this.MTB_user_name1.Name = "MTB_user_name1";
            this.MTB_user_name1.Size = new System.Drawing.Size(131, 22);
            this.MTB_user_name1.TabIndex = 1;
            // 
            // MTB_pass1
            // 
            this.MTB_pass1.Location = new System.Drawing.Point(158, 186);
            this.MTB_pass1.Name = "MTB_pass1";
            this.MTB_pass1.Size = new System.Drawing.Size(131, 22);
            this.MTB_pass1.TabIndex = 6;
            // 
            // Bt_guest_continue
            // 
            this.Bt_guest_continue.Location = new System.Drawing.Point(379, 433);
            this.Bt_guest_continue.Name = "Bt_guest_continue";
            this.Bt_guest_continue.Size = new System.Drawing.Size(135, 51);
            this.Bt_guest_continue.TabIndex = 7;
            this.Bt_guest_continue.Text = "Continue As Guest";
            this.Bt_guest_continue.UseVisualStyleBackColor = true;
            this.Bt_guest_continue.Click += new System.EventHandler(this.Bt_guest_continue_Click);
            // 
            // Bt_user_continue
            // 
            this.Bt_user_continue.Location = new System.Drawing.Point(379, 273);
            this.Bt_user_continue.Name = "Bt_user_continue";
            this.Bt_user_continue.Size = new System.Drawing.Size(135, 51);
            this.Bt_user_continue.TabIndex = 8;
            this.Bt_user_continue.Text = "Continue As User";
            this.Bt_user_continue.UseVisualStyleBackColor = true;
            this.Bt_user_continue.Click += new System.EventHandler(this.Bt_user_continue_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "User1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Name(2-10 chars)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(716, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 30);
            this.label4.TabIndex = 11;
            this.label4.Text = "User2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Password(5 chars)";
            // 
            // COB_user1
            // 
            this.COB_user1.FormattingEnabled = true;
            this.COB_user1.Items.AddRange(new object[] {
            "Login",
            "Create New User"});
            this.COB_user1.Location = new System.Drawing.Point(137, 223);
            this.COB_user1.Name = "COB_user1";
            this.COB_user1.Size = new System.Drawing.Size(152, 24);
            this.COB_user1.TabIndex = 13;
            // 
            // COB_user2
            // 
            this.COB_user2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.COB_user2.FormattingEnabled = true;
            this.COB_user2.Items.AddRange(new object[] {
            "Login",
            "Create New User"});
            this.COB_user2.Location = new System.Drawing.Point(693, 208);
            this.COB_user2.Name = "COB_user2";
            this.COB_user2.Size = new System.Drawing.Size(142, 24);
            this.COB_user2.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(568, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Password(5 chars)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(568, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Name(2-10 chars)";
            // 
            // MTB_pass2
            // 
            this.MTB_pass2.Location = new System.Drawing.Point(714, 171);
            this.MTB_pass2.Name = "MTB_pass2";
            this.MTB_pass2.Size = new System.Drawing.Size(121, 22);
            this.MTB_pass2.TabIndex = 15;
            // 
            // MTB_user_name2
            // 
            this.MTB_user_name2.Location = new System.Drawing.Point(714, 141);
            this.MTB_user_name2.Name = "MTB_user_name2";
            this.MTB_user_name2.Size = new System.Drawing.Size(121, 22);
            this.MTB_user_name2.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(716, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 30);
            this.label8.TabIndex = 19;
            this.label8.Text = "Guest2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(168, 338);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 30);
            this.label9.TabIndex = 20;
            this.label9.Text = "Guest1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 393);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Name(2-10 chars)";
            // 
            // MTB_Guest_name1
            // 
            this.MTB_Guest_name1.Location = new System.Drawing.Point(158, 393);
            this.MTB_Guest_name1.Name = "MTB_Guest_name1";
            this.MTB_Guest_name1.Size = new System.Drawing.Size(131, 22);
            this.MTB_Guest_name1.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(548, 398);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "Name(2-10 chars)";
            // 
            // MTB_Guest_name2
            // 
            this.MTB_Guest_name2.Location = new System.Drawing.Point(705, 390);
            this.MTB_Guest_name2.Name = "MTB_Guest_name2";
            this.MTB_Guest_name2.Size = new System.Drawing.Size(130, 22);
            this.MTB_Guest_name2.TabIndex = 23;
            // 
            // Bt_login_exit
            // 
            this.Bt_login_exit.Location = new System.Drawing.Point(911, 12);
            this.Bt_login_exit.Name = "Bt_login_exit";
            this.Bt_login_exit.Size = new System.Drawing.Size(75, 23);
            this.Bt_login_exit.TabIndex = 25;
            this.Bt_login_exit.Text = "Exit";
            this.Bt_login_exit.UseVisualStyleBackColor = true;
            this.Bt_login_exit.Click += new System.EventHandler(this.Bt_login_exit_Click);
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(998, 553);
            this.Controls.Add(this.Bt_login_exit);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.MTB_Guest_name2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.MTB_Guest_name1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.COB_user2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MTB_pass2);
            this.Controls.Add(this.MTB_user_name2);
            this.Controls.Add(this.COB_user1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Bt_user_continue);
            this.Controls.Add(this.Bt_guest_continue);
            this.Controls.Add(this.MTB_pass1);
            this.Controls.Add(this.MTB_user_name1);
            this.Controls.Add(this.label1);
            this.Name = "login_form";
            this.Text = "login_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MTB_user_name1;
        private System.Windows.Forms.MaskedTextBox MTB_pass1;
        private System.Windows.Forms.Button Bt_guest_continue;
        private System.Windows.Forms.Button Bt_user_continue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox COB_user1;
        private System.Windows.Forms.ComboBox COB_user2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox MTB_pass2;
        private System.Windows.Forms.MaskedTextBox MTB_user_name2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox MTB_Guest_name1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox MTB_Guest_name2;
        private System.Windows.Forms.Button Bt_login_exit;
    }
}