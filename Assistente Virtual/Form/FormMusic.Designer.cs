
namespace Assistente_Virtual
{
    partial class FormMusic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMusic));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_Volume = new System.Windows.Forms.TrackBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbl_FinalDuration = new System.Windows.Forms.Label();
            this.lbl_DurationNow = new System.Windows.Forms.Label();
            this.lb_MusicsList = new System.Windows.Forms.ListBox();
            this.music_Context = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_playlistTittle = new System.Windows.Forms.Label();
            this.lbl_musicasTittle = new System.Windows.Forms.Label();
            this.txt_PlaylistName = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_MusicTittle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_Next = new System.Windows.Forms.PictureBox();
            this.pb_Previous = new System.Windows.Forms.PictureBox();
            this.pb_SelectMusicOfd = new System.Windows.Forms.PictureBox();
            this.pb_Close = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pb_Play = new System.Windows.Forms.PictureBox();
            this.pb_Pause = new System.Windows.Forms.PictureBox();
            this.btn_RemovePlaylist = new Assistente_Virtual.Design.Custom_Button();
            this.btn_NewPlaylist = new Assistente_Virtual.Design.Custom_Button();
            this.btn_Musics = new Assistente_Virtual.Design.Custom_Button();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Volume)).BeginInit();
            this.music_Context.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Previous)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_SelectMusicOfd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Pause)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(230)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 10);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMenu_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMenu_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMenu_MouseUp);
            // 
            // tb_Volume
            // 
            this.tb_Volume.Location = new System.Drawing.Point(12, 75);
            this.tb_Volume.Maximum = 100;
            this.tb_Volume.Name = "tb_Volume";
            this.tb_Volume.Size = new System.Drawing.Size(104, 45);
            this.tb_Volume.TabIndex = 5;
            this.tb_Volume.TickFrequency = 0;
            this.tb_Volume.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tb_Volume.Value = 100;
            this.tb_Volume.Scroll += new System.EventHandler(this.tb_Volume_Scroll);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(44, 59);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(330, 10);
            this.progressBar1.TabIndex = 6;
            // 
            // lbl_FinalDuration
            // 
            this.lbl_FinalDuration.AutoSize = true;
            this.lbl_FinalDuration.ForeColor = System.Drawing.Color.White;
            this.lbl_FinalDuration.Location = new System.Drawing.Point(380, 56);
            this.lbl_FinalDuration.Name = "lbl_FinalDuration";
            this.lbl_FinalDuration.Size = new System.Drawing.Size(34, 13);
            this.lbl_FinalDuration.TabIndex = 8;
            this.lbl_FinalDuration.Text = "00:00";
            // 
            // lbl_DurationNow
            // 
            this.lbl_DurationNow.AutoSize = true;
            this.lbl_DurationNow.ForeColor = System.Drawing.Color.White;
            this.lbl_DurationNow.Location = new System.Drawing.Point(4, 56);
            this.lbl_DurationNow.Name = "lbl_DurationNow";
            this.lbl_DurationNow.Size = new System.Drawing.Size(34, 13);
            this.lbl_DurationNow.TabIndex = 9;
            this.lbl_DurationNow.Text = "00:00";
            // 
            // lb_MusicsList
            // 
            this.lb_MusicsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lb_MusicsList.ContextMenuStrip = this.music_Context;
            this.lb_MusicsList.ForeColor = System.Drawing.Color.White;
            this.lb_MusicsList.FormattingEnabled = true;
            this.lb_MusicsList.Location = new System.Drawing.Point(12, 165);
            this.lb_MusicsList.Name = "lb_MusicsList";
            this.lb_MusicsList.Size = new System.Drawing.Size(236, 121);
            this.lb_MusicsList.TabIndex = 11;
            this.lb_MusicsList.SelectedIndexChanged += new System.EventHandler(this.lb_MusicsList_SelectedIndexChanged);
            // 
            // music_Context
            // 
            this.music_Context.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removarToolStripMenuItem});
            this.music_Context.Name = "contextMenuStrip1";
            this.music_Context.Size = new System.Drawing.Size(163, 26);
            // 
            // removarToolStripMenuItem
            // 
            this.removarToolStripMenuItem.Name = "removarToolStripMenuItem";
            this.removarToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.removarToolStripMenuItem.Text = "Remover Música";
            this.removarToolStripMenuItem.Click += new System.EventHandler(this.removarToolStripMenuItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(254, 165);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl_playlistTittle
            // 
            this.lbl_playlistTittle.AutoSize = true;
            this.lbl_playlistTittle.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_playlistTittle.ForeColor = System.Drawing.Color.White;
            this.lbl_playlistTittle.Location = new System.Drawing.Point(309, 136);
            this.lbl_playlistTittle.Name = "lbl_playlistTittle";
            this.lbl_playlistTittle.Size = new System.Drawing.Size(66, 26);
            this.lbl_playlistTittle.TabIndex = 13;
            this.lbl_playlistTittle.Text = "Playlist";
            // 
            // lbl_musicasTittle
            // 
            this.lbl_musicasTittle.AutoSize = true;
            this.lbl_musicasTittle.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_musicasTittle.ForeColor = System.Drawing.Color.White;
            this.lbl_musicasTittle.Location = new System.Drawing.Point(12, 136);
            this.lbl_musicasTittle.Name = "lbl_musicasTittle";
            this.lbl_musicasTittle.Size = new System.Drawing.Size(68, 26);
            this.lbl_musicasTittle.TabIndex = 14;
            this.lbl_musicasTittle.Text = "Músicas";
            // 
            // txt_PlaylistName
            // 
            this.txt_PlaylistName.Location = new System.Drawing.Point(254, 266);
            this.txt_PlaylistName.Name = "txt_PlaylistName";
            this.txt_PlaylistName.Size = new System.Drawing.Size(100, 20);
            this.txt_PlaylistName.TabIndex = 15;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_MusicTittle
            // 
            this.lbl_MusicTittle.AutoSize = true;
            this.lbl_MusicTittle.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MusicTittle.Location = new System.Drawing.Point(147, 13);
            this.lbl_MusicTittle.Name = "lbl_MusicTittle";
            this.lbl_MusicTittle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_MusicTittle.Size = new System.Drawing.Size(168, 33);
            this.lbl_MusicTittle.TabIndex = 19;
            this.lbl_MusicTittle.Text = "fafafafafafafa";
            this.lbl_MusicTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(360, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pb_Next
            // 
            this.pb_Next.Image = ((System.Drawing.Image)(resources.GetObject("pb_Next.Image")));
            this.pb_Next.Location = new System.Drawing.Point(300, 80);
            this.pb_Next.Name = "pb_Next";
            this.pb_Next.Size = new System.Drawing.Size(34, 30);
            this.pb_Next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Next.TabIndex = 22;
            this.pb_Next.TabStop = false;
            this.pb_Next.Click += new System.EventHandler(this.pb_Next_Click);
            // 
            // pb_Previous
            // 
            this.pb_Previous.Image = ((System.Drawing.Image)(resources.GetObject("pb_Previous.Image")));
            this.pb_Previous.Location = new System.Drawing.Point(122, 80);
            this.pb_Previous.Name = "pb_Previous";
            this.pb_Previous.Size = new System.Drawing.Size(34, 30);
            this.pb_Previous.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Previous.TabIndex = 21;
            this.pb_Previous.TabStop = false;
            this.pb_Previous.Click += new System.EventHandler(this.pb_Previous_Click);
            // 
            // pb_SelectMusicOfd
            // 
            this.pb_SelectMusicOfd.Image = ((System.Drawing.Image)(resources.GetObject("pb_SelectMusicOfd.Image")));
            this.pb_SelectMusicOfd.Location = new System.Drawing.Point(391, 165);
            this.pb_SelectMusicOfd.Name = "pb_SelectMusicOfd";
            this.pb_SelectMusicOfd.Size = new System.Drawing.Size(41, 38);
            this.pb_SelectMusicOfd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_SelectMusicOfd.TabIndex = 18;
            this.pb_SelectMusicOfd.TabStop = false;
            this.pb_SelectMusicOfd.Click += new System.EventHandler(this.pb_SelectMusicOfd_Click);
            // 
            // pb_Close
            // 
            this.pb_Close.Image = ((System.Drawing.Image)(resources.GetObject("pb_Close.Image")));
            this.pb_Close.Location = new System.Drawing.Point(407, 13);
            this.pb_Close.Name = "pb_Close";
            this.pb_Close.Size = new System.Drawing.Size(25, 25);
            this.pb_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Close.TabIndex = 7;
            this.pb_Close.TabStop = false;
            this.pb_Close.Click += new System.EventHandler(this.pb_Close_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(254, 75);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(162, 75);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pb_Play
            // 
            this.pb_Play.Image = ((System.Drawing.Image)(resources.GetObject("pb_Play.Image")));
            this.pb_Play.Location = new System.Drawing.Point(208, 75);
            this.pb_Play.Name = "pb_Play";
            this.pb_Play.Size = new System.Drawing.Size(40, 40);
            this.pb_Play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Play.TabIndex = 1;
            this.pb_Play.TabStop = false;
            this.pb_Play.Click += new System.EventHandler(this.pb_Play_Click);
            // 
            // pb_Pause
            // 
            this.pb_Pause.Image = ((System.Drawing.Image)(resources.GetObject("pb_Pause.Image")));
            this.pb_Pause.Location = new System.Drawing.Point(208, 75);
            this.pb_Pause.Name = "pb_Pause";
            this.pb_Pause.Size = new System.Drawing.Size(40, 40);
            this.pb_Pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Pause.TabIndex = 4;
            this.pb_Pause.TabStop = false;
            this.pb_Pause.Click += new System.EventHandler(this.pb_Pause_Click);
            // 
            // btn_RemovePlaylist
            // 
            this.btn_RemovePlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(230)))));
            this.btn_RemovePlaylist.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(230)))));
            this.btn_RemovePlaylist.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_RemovePlaylist.BorderRadius = 5;
            this.btn_RemovePlaylist.BorderSize = 0;
            this.btn_RemovePlaylist.FlatAppearance.BorderSize = 0;
            this.btn_RemovePlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RemovePlaylist.ForeColor = System.Drawing.Color.White;
            this.btn_RemovePlaylist.Location = new System.Drawing.Point(254, 192);
            this.btn_RemovePlaylist.Name = "btn_RemovePlaylist";
            this.btn_RemovePlaylist.Size = new System.Drawing.Size(121, 23);
            this.btn_RemovePlaylist.TabIndex = 17;
            this.btn_RemovePlaylist.Text = "Remove Playlist";
            this.btn_RemovePlaylist.TextColor = System.Drawing.Color.White;
            this.btn_RemovePlaylist.UseVisualStyleBackColor = false;
            this.btn_RemovePlaylist.Click += new System.EventHandler(this.btn_RemovePlaylist_Click);
            // 
            // btn_NewPlaylist
            // 
            this.btn_NewPlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(230)))));
            this.btn_NewPlaylist.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(230)))));
            this.btn_NewPlaylist.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_NewPlaylist.BorderRadius = 5;
            this.btn_NewPlaylist.BorderSize = 0;
            this.btn_NewPlaylist.FlatAppearance.BorderSize = 0;
            this.btn_NewPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NewPlaylist.ForeColor = System.Drawing.Color.White;
            this.btn_NewPlaylist.Location = new System.Drawing.Point(360, 263);
            this.btn_NewPlaylist.Name = "btn_NewPlaylist";
            this.btn_NewPlaylist.Size = new System.Drawing.Size(72, 23);
            this.btn_NewPlaylist.TabIndex = 16;
            this.btn_NewPlaylist.Text = "new playlist";
            this.btn_NewPlaylist.TextColor = System.Drawing.Color.White;
            this.btn_NewPlaylist.UseVisualStyleBackColor = false;
            this.btn_NewPlaylist.Click += new System.EventHandler(this.btn_NewPlaylist_Click);
            // 
            // btn_Musics
            // 
            this.btn_Musics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(230)))));
            this.btn_Musics.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(230)))));
            this.btn_Musics.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Musics.BorderRadius = 10;
            this.btn_Musics.BorderSize = 0;
            this.btn_Musics.FlatAppearance.BorderSize = 0;
            this.btn_Musics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Musics.ForeColor = System.Drawing.Color.White;
            this.btn_Musics.Location = new System.Drawing.Point(346, 90);
            this.btn_Musics.Name = "btn_Musics";
            this.btn_Musics.Size = new System.Drawing.Size(90, 30);
            this.btn_Musics.TabIndex = 10;
            this.btn_Musics.Text = "músicas";
            this.btn_Musics.TextColor = System.Drawing.Color.White;
            this.btn_Musics.UseVisualStyleBackColor = false;
            this.btn_Musics.Click += new System.EventHandler(this.btn_Musics_Click);
            // 
            // FormMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(436, 292);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pb_Next);
            this.Controls.Add(this.pb_Previous);
            this.Controls.Add(this.lbl_MusicTittle);
            this.Controls.Add(this.pb_SelectMusicOfd);
            this.Controls.Add(this.btn_RemovePlaylist);
            this.Controls.Add(this.btn_NewPlaylist);
            this.Controls.Add(this.txt_PlaylistName);
            this.Controls.Add(this.lbl_musicasTittle);
            this.Controls.Add(this.lbl_playlistTittle);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lb_MusicsList);
            this.Controls.Add(this.btn_Musics);
            this.Controls.Add(this.lbl_DurationNow);
            this.Controls.Add(this.lbl_FinalDuration);
            this.Controls.Add(this.pb_Close);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tb_Volume);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pb_Play);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pb_Pause);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMusic";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMusic_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMenu_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMenu_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMenu_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.tb_Volume)).EndInit();
            this.music_Context.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Previous)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_SelectMusicOfd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Pause)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_Play;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pb_Pause;
        private System.Windows.Forms.TrackBar tb_Volume;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pb_Close;
        private System.Windows.Forms.Label lbl_FinalDuration;
        private System.Windows.Forms.Label lbl_DurationNow;
        private Design.Custom_Button btn_Musics;
        private System.Windows.Forms.ListBox lb_MusicsList;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_playlistTittle;
        private System.Windows.Forms.Label lbl_musicasTittle;
        private System.Windows.Forms.TextBox txt_PlaylistName;
        private Design.Custom_Button btn_NewPlaylist;
        private Design.Custom_Button btn_RemovePlaylist;
        private System.Windows.Forms.PictureBox pb_SelectMusicOfd;
        private System.Windows.Forms.ContextMenuStrip music_Context;
        private System.Windows.Forms.ToolStripMenuItem removarToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_MusicTittle;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pb_Previous;
        private System.Windows.Forms.PictureBox pb_Next;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}