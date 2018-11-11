namespace GameBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Bt_SAL_1pl = new System.Windows.Forms.Button();
            this.Bt_REV_2pl = new System.Windows.Forms.Button();
            this.Bt_SAL_2pl = new System.Windows.Forms.Button();
            this.Bt_Exit = new System.Windows.Forms.Button();
            this.Bt_admin = new System.Windows.Forms.Button();
            this.CB_music = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(387, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECT GAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 229);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reversi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(767, 229);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(369, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ladders And Snakes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(67, 274);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(529, 336);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(707, 274);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(529, 336);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // Bt_SAL_1pl
            // 
            this.Bt_SAL_1pl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_SAL_1pl.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_SAL_1pl.Location = new System.Drawing.Point(1004, 618);
            this.Bt_SAL_1pl.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_SAL_1pl.Name = "Bt_SAL_1pl";
            this.Bt_SAL_1pl.Size = new System.Drawing.Size(165, 50);
            this.Bt_SAL_1pl.TabIndex = 5;
            this.Bt_SAL_1pl.Text = "1 Player";
            this.Bt_SAL_1pl.UseVisualStyleBackColor = true;
            this.Bt_SAL_1pl.Click += new System.EventHandler(this.Bt_SAL_1pl_Click);
            // 
            // Bt_REV_2pl
            // 
            this.Bt_REV_2pl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_REV_2pl.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_REV_2pl.Location = new System.Drawing.Point(252, 618);
            this.Bt_REV_2pl.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_REV_2pl.Name = "Bt_REV_2pl";
            this.Bt_REV_2pl.Size = new System.Drawing.Size(168, 50);
            this.Bt_REV_2pl.TabIndex = 6;
            this.Bt_REV_2pl.Text = "2 Players";
            this.Bt_REV_2pl.UseVisualStyleBackColor = true;
            this.Bt_REV_2pl.Click += new System.EventHandler(this.Bt_REV_2pl_Click);
            // 
            // Bt_SAL_2pl
            // 
            this.Bt_SAL_2pl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_SAL_2pl.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_SAL_2pl.Location = new System.Drawing.Point(775, 618);
            this.Bt_SAL_2pl.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_SAL_2pl.Name = "Bt_SAL_2pl";
            this.Bt_SAL_2pl.Size = new System.Drawing.Size(169, 50);
            this.Bt_SAL_2pl.TabIndex = 7;
            this.Bt_SAL_2pl.Text = "2 Players";
            this.Bt_SAL_2pl.UseVisualStyleBackColor = true;
            this.Bt_SAL_2pl.Click += new System.EventHandler(this.Bt_SAL_2pl_Click);
            // 
            // Bt_Exit
            // 
            this.Bt_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_Exit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Bt_Exit.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Exit.Location = new System.Drawing.Point(1211, 15);
            this.Bt_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_Exit.Name = "Bt_Exit";
            this.Bt_Exit.Size = new System.Drawing.Size(101, 66);
            this.Bt_Exit.TabIndex = 8;
            this.Bt_Exit.Text = "Exit";
            this.Bt_Exit.UseVisualStyleBackColor = true;
            this.Bt_Exit.Click += new System.EventHandler(this.Bt_Exit_Click);
            // 
            // Bt_admin
            // 
            this.Bt_admin.BackColor = System.Drawing.Color.Transparent;
            this.Bt_admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_admin.FlatAppearance.BorderSize = 0;
            this.Bt_admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_admin.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_admin.Image = ((System.Drawing.Image)(resources.GetObject("Bt_admin.Image")));
            this.Bt_admin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bt_admin.Location = new System.Drawing.Point(16, 15);
            this.Bt_admin.Margin = new System.Windows.Forms.Padding(4);
            this.Bt_admin.Name = "Bt_admin";
            this.Bt_admin.Size = new System.Drawing.Size(172, 58);
            this.Bt_admin.TabIndex = 9;
            this.Bt_admin.Text = "Admin";
            this.Bt_admin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Bt_admin.UseVisualStyleBackColor = false;
            // 
            // CB_music
            // 
            this.CB_music.Appearance = System.Windows.Forms.Appearance.Button;
            this.CB_music.AutoSize = true;
            this.CB_music.Checked = true;
            this.CB_music.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_music.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_music.FlatAppearance.BorderSize = 0;
            this.CB_music.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_music.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_music.Image = ((System.Drawing.Image)(resources.GetObject("CB_music.Image")));
            this.CB_music.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CB_music.Location = new System.Drawing.Point(196, 6);
            this.CB_music.Margin = new System.Windows.Forms.Padding(4);
            this.CB_music.Name = "CB_music";
            this.CB_music.Size = new System.Drawing.Size(180, 54);
            this.CB_music.TabIndex = 10;
            this.CB_music.Text = "Music on";
            this.CB_music.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CB_music.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CB_music.UseVisualStyleBackColor = true;
            this.CB_music.CheckedChanged += new System.EventHandler(this.CB_music_CheckedChanged);
            this.CB_music.BackgroundImageChanged += new System.EventHandler(this.CB_music_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1325, 785);
            this.Controls.Add(this.CB_music);
            this.Controls.Add(this.Bt_admin);
            this.Controls.Add(this.Bt_Exit);
            this.Controls.Add(this.Bt_SAL_2pl);
            this.Controls.Add(this.Bt_REV_2pl);
            this.Controls.Add(this.Bt_SAL_1pl);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "GameBox";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Bt_SAL_1pl;
        private System.Windows.Forms.Button Bt_REV_2pl;
        private System.Windows.Forms.Button Bt_SAL_2pl;
        private System.Windows.Forms.Button Bt_Exit;
        private System.Windows.Forms.Button Bt_admin;
        private System.Windows.Forms.CheckBox CB_music;
    }
}

