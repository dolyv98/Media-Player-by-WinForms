namespace WindowsFormsApp1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.MinBtn = new System.Windows.Forms.Button();
            this.MaxBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.FullBtn = new System.Windows.Forms.Panel();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.MusicDB = new System.Windows.Forms.DataGridView();
            this.recentbtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.PreBtn = new System.Windows.Forms.Button();
            this.OpenBtn = new System.Windows.Forms.Button();
            this.Volumspeed = new System.Windows.Forms.TrackBar();
            this.MuteVolumeBtn = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.PauseBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Playing = new System.Windows.Forms.ListBox();
            this.MediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1.SuspendLayout();
            this.FullBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MusicDB)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Volumspeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(139)))), ((int)(((byte)(115)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.MinBtn);
            this.panel1.Controls.Add(this.MaxBtn);
            this.panel1.Controls.Add(this.ExitBtn);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 29);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // MinBtn
            // 
            this.MinBtn.FlatAppearance.BorderSize = 0;
            this.MinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinBtn.Image = global::WindowsFormsApp1.Properties.Resources.if_minus_1303882__3_;
            this.MinBtn.Location = new System.Drawing.Point(757, -1);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.Size = new System.Drawing.Size(29, 29);
            this.MinBtn.TabIndex = 11;
            this.MinBtn.UseVisualStyleBackColor = true;
            this.MinBtn.Click += new System.EventHandler(this.MinBtn_Click);
            // 
            // MaxBtn
            // 
            this.MaxBtn.FlatAppearance.BorderSize = 0;
            this.MaxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaxBtn.Image = global::WindowsFormsApp1.Properties.Resources.square__1_;
            this.MaxBtn.Location = new System.Drawing.Point(795, -1);
            this.MaxBtn.Name = "MaxBtn";
            this.MaxBtn.Size = new System.Drawing.Size(29, 29);
            this.MaxBtn.TabIndex = 10;
            this.MaxBtn.UseVisualStyleBackColor = true;
            this.MaxBtn.Click += new System.EventHandler(this.MaxBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Image = global::WindowsFormsApp1.Properties.Resources.cancel__2_;
            this.ExitBtn.Location = new System.Drawing.Point(827, -1);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(29, 29);
            this.ExitBtn.TabIndex = 9;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // FullBtn
            // 
            this.FullBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FullBtn.Controls.Add(this.Deletebtn);
            this.FullBtn.Controls.Add(this.MusicDB);
            this.FullBtn.Controls.Add(this.recentbtn);
            this.FullBtn.Controls.Add(this.panel3);
            this.FullBtn.Controls.Add(this.pictureBox1);
            this.FullBtn.Controls.Add(this.Playing);
            this.FullBtn.Controls.Add(this.MediaPlayer);
            this.FullBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.FullBtn.Location = new System.Drawing.Point(0, 29);
            this.FullBtn.Name = "FullBtn";
            this.FullBtn.Size = new System.Drawing.Size(861, 555);
            this.FullBtn.TabIndex = 1;
            // 
            // Deletebtn
            // 
            this.Deletebtn.FlatAppearance.BorderSize = 0;
            this.Deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deletebtn.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.ForeColor = System.Drawing.Color.LavenderBlush;
            this.Deletebtn.Location = new System.Drawing.Point(1, 432);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(164, 31);
            this.Deletebtn.TabIndex = 8;
            this.Deletebtn.Text = "Delete History";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // MusicDB
            // 
            this.MusicDB.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.MusicDB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MusicDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MusicDB.Location = new System.Drawing.Point(0, 139);
            this.MusicDB.Name = "MusicDB";
            this.MusicDB.Size = new System.Drawing.Size(163, 253);
            this.MusicDB.TabIndex = 6;
            // 
            // recentbtn
            // 
            this.recentbtn.FlatAppearance.BorderSize = 0;
            this.recentbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recentbtn.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recentbtn.ForeColor = System.Drawing.Color.LavenderBlush;
            this.recentbtn.Location = new System.Drawing.Point(0, 102);
            this.recentbtn.Name = "recentbtn";
            this.recentbtn.Size = new System.Drawing.Size(164, 31);
            this.recentbtn.TabIndex = 7;
            this.recentbtn.Text = "Recent";
            this.recentbtn.UseVisualStyleBackColor = true;
            this.recentbtn.Click += new System.EventHandler(this.recentbtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(139)))), ((int)(((byte)(115)))));
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.PreBtn);
            this.panel3.Controls.Add(this.OpenBtn);
            this.panel3.Controls.Add(this.Volumspeed);
            this.panel3.Controls.Add(this.MuteVolumeBtn);
            this.panel3.Controls.Add(this.StopBtn);
            this.panel3.Controls.Add(this.PlayBtn);
            this.panel3.Controls.Add(this.PauseBtn);
            this.panel3.Controls.Add(this.NextBtn);
            this.panel3.Location = new System.Drawing.Point(1, 464);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(860, 81);
            this.panel3.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::WindowsFormsApp1.Properties.Resources.full_screen;
            this.button2.Location = new System.Drawing.Point(503, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 35);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.FullScreenBtn_Click);
            // 
            // PreBtn
            // 
            this.PreBtn.BackColor = System.Drawing.Color.Transparent;
            this.PreBtn.FlatAppearance.BorderSize = 0;
            this.PreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreBtn.Image = global::WindowsFormsApp1.Properties.Resources.arrow___Copy___Copy;
            this.PreBtn.Location = new System.Drawing.Point(214, 20);
            this.PreBtn.Name = "PreBtn";
            this.PreBtn.Size = new System.Drawing.Size(35, 35);
            this.PreBtn.TabIndex = 7;
            this.PreBtn.UseVisualStyleBackColor = false;
            this.PreBtn.Click += new System.EventHandler(this.PreBtn_Click);
            // 
            // OpenBtn
            // 
            this.OpenBtn.FlatAppearance.BorderSize = 0;
            this.OpenBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.OpenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenBtn.Image = global::WindowsFormsApp1.Properties.Resources.app;
            this.OpenBtn.Location = new System.Drawing.Point(161, 20);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(35, 35);
            this.OpenBtn.TabIndex = 4;
            this.OpenBtn.UseVisualStyleBackColor = true;
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // Volumspeed
            // 
            this.Volumspeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(139)))), ((int)(((byte)(115)))));
            this.Volumspeed.Location = new System.Drawing.Point(604, 20);
            this.Volumspeed.Name = "Volumspeed";
            this.Volumspeed.Size = new System.Drawing.Size(100, 45);
            this.Volumspeed.TabIndex = 6;
            this.Volumspeed.Scroll += new System.EventHandler(this.Volumspeed_Scroll);
            // 
            // MuteVolumeBtn
            // 
            this.MuteVolumeBtn.BackColor = System.Drawing.Color.Transparent;
            this.MuteVolumeBtn.FlatAppearance.BorderSize = 0;
            this.MuteVolumeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MuteVolumeBtn.Image = global::WindowsFormsApp1.Properties.Resources._003_music_1;
            this.MuteVolumeBtn.Location = new System.Drawing.Point(563, 20);
            this.MuteVolumeBtn.Name = "MuteVolumeBtn";
            this.MuteVolumeBtn.Size = new System.Drawing.Size(35, 35);
            this.MuteVolumeBtn.TabIndex = 5;
            this.MuteVolumeBtn.UseVisualStyleBackColor = false;
            this.MuteVolumeBtn.Click += new System.EventHandler(this.MuteVolumeBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.BackColor = System.Drawing.Color.Transparent;
            this.StopBtn.FlatAppearance.BorderSize = 0;
            this.StopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopBtn.Image = global::WindowsFormsApp1.Properties.Resources.square;
            this.StopBtn.Location = new System.Drawing.Point(269, 20);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(35, 35);
            this.StopBtn.TabIndex = 4;
            this.StopBtn.UseVisualStyleBackColor = false;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // PlayBtn
            // 
            this.PlayBtn.BackColor = System.Drawing.Color.Transparent;
            this.PlayBtn.FlatAppearance.BorderSize = 0;
            this.PlayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayBtn.Image = global::WindowsFormsApp1.Properties.Resources._006_play_button;
            this.PlayBtn.Location = new System.Drawing.Point(324, 20);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(35, 35);
            this.PlayBtn.TabIndex = 3;
            this.PlayBtn.UseVisualStyleBackColor = false;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // PauseBtn
            // 
            this.PauseBtn.BackColor = System.Drawing.Color.Transparent;
            this.PauseBtn.FlatAppearance.BorderSize = 0;
            this.PauseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PauseBtn.Image = global::WindowsFormsApp1.Properties.Resources._005_pause_round_button;
            this.PauseBtn.Location = new System.Drawing.Point(383, 20);
            this.PauseBtn.Name = "PauseBtn";
            this.PauseBtn.Size = new System.Drawing.Size(35, 35);
            this.PauseBtn.TabIndex = 1;
            this.PauseBtn.UseVisualStyleBackColor = false;
            this.PauseBtn.Click += new System.EventHandler(this.PauseBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.BackColor = System.Drawing.Color.Transparent;
            this.NextBtn.FlatAppearance.BorderSize = 0;
            this.NextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextBtn.Image = global::WindowsFormsApp1.Properties.Resources.arrow___Copy;
            this.NextBtn.Location = new System.Drawing.Point(441, 20);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(35, 35);
            this.NextBtn.TabIndex = 0;
            this.NextBtn.UseVisualStyleBackColor = false;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._26158980_360934284379701_4712513708595609600_n___Copy1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(861, 100);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Playing
            // 
            this.Playing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Playing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Playing.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Playing.ForeColor = System.Drawing.Color.LavenderBlush;
            this.Playing.FormattingEnabled = true;
            this.Playing.HorizontalScrollbar = true;
            this.Playing.ItemHeight = 19;
            this.Playing.Location = new System.Drawing.Point(702, 102);
            this.Playing.Name = "Playing";
            this.Playing.Size = new System.Drawing.Size(155, 342);
            this.Playing.TabIndex = 2;
            this.Playing.SelectedIndexChanged += new System.EventHandler(this.Playing_SelectedIndexChanged);
            // 
            // MediaPlayer
            // 
            this.MediaPlayer.Enabled = true;
            this.MediaPlayer.Location = new System.Drawing.Point(166, 104);
            this.MediaPlayer.Name = "MediaPlayer";
            this.MediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayer.OcxState")));
            this.MediaPlayer.Size = new System.Drawing.Size(533, 390);
            this.MediaPlayer.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(861, 570);
            this.Controls.Add(this.FullBtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HiMP3";
            this.panel1.ResumeLayout(false);
            this.FullBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MusicDB)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Volumspeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel FullBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.ListBox Playing;
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Button PauseBtn;
        private System.Windows.Forms.Button MuteVolumeBtn;
        private System.Windows.Forms.TrackBar Volumspeed;
        private System.Windows.Forms.Button PreBtn;
        private System.Windows.Forms.Button OpenBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button MinBtn;
        private System.Windows.Forms.Button MaxBtn;
		private System.Windows.Forms.DataGridView MusicDB;
		private System.Windows.Forms.Button recentbtn;
        private System.Windows.Forms.Button Deletebtn;
    }
}

