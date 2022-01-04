using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WMPLib;
using Musics;
using Assis_Serializer;
using Assistente_Virtual.Engine;
using Assistente_Virtual.Services;
namespace Assistente_Virtual
{
    public partial class FormMusic : Form
    {
        
        DataSerializer serializer = new DataSerializer();
        string savesPath = Application.StartupPath + @"\Data\MusicPlaylists.playlistList";
        WindowsMediaPlayerClass musicPlayer;

        public string firstPlaylist = "";
        bool showingMusics = false;
        int originalHeight = 128;
        int slidedHeight = 298;

        string SelectedPlaylist = "";
        OpenFileDialog ofd;

        public static FormMusic instance;
        List<MusicPlayList> playlists = new List<MusicPlayList>();
        List<string> playlistsNames;

        
        public FormMusic()
        {
            InitializeComponent();
            btn_Musics.Text = "músicas+";
            showingMusics = false;
            this.Height = originalHeight;
            musicPlayer = new WindowsMediaPlayerClass();
            
            musicPlayer.settings.volume = 100;
            musicPlayer.mute = false;
            playlistsNames = new List<string>();
            lbl_MusicTittle.Text = "Títulos";
            LoadListPlaylists();
            firstPlaylist = comboBox1.Items[0].ToString();
            SpeakerService.musicOpened = true;
            instance = this;
            
        }

        private void FormMusic_Load(object sender, EventArgs e)
        {
            
        }
        private void pb_Close_Click(object sender, EventArgs e)
        {
            SpeakerService.musicOpened = false;
            this.Close();
        }
        #region MoveForms
        bool mov = false;
        int movX;
        int movY;
        private void FormMenu_MouseDown(object sender, MouseEventArgs e)
        {
            mov = true;
            movX = e.X;
            movY = e.Y;
        }

        private void FormMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == true)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void FormMenu_MouseUp(object sender, MouseEventArgs e)
        {
            mov = false;
        }


        #endregion
        
        private void btn_Musics_Click(object sender, EventArgs e)
        {
            if(showingMusics == false)
            {
                btn_Musics.Text = "músicas-";
                showingMusics = true;
                this.Height = slidedHeight;
            }
            else if (showingMusics == true)
            {
                btn_Musics.Text = "músicas+";
                showingMusics = false;
                this.Height = originalHeight;          
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedPlaylist = comboBox1.SelectedItem.ToString();
            ReloadPlaylist();
        }
        //Reload the music list to show the musics from the current playlist
        public void ReloadPlaylist()
        {
            lb_MusicsList.Items.Clear();
            foreach(MusicPlayList x in playlists)
            {
                if(x.Name == SelectedPlaylist)
                {
                    
                    if (x.musicList == null)
                    {
                        return;
                    }
                    List<Music> musics = x.GetList();
                    foreach(Music a in musics)
                    {
                        lb_MusicsList.Items.Add(a.Name);
                    }
                }
            }
        }
        //Add a new playlist.
        private void btn_NewPlaylist_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_PlaylistName.Text))
            {
                MessageBox.Show("Você não pode deixar o nome em branco");
                return;
            }
            else if (playlistsNames.Contains(txt_PlaylistName.Text))
            {
                MessageBox.Show("Já existe playlist com o mesmo nome");
                txt_PlaylistName.Text = null;
                return;
            }
            MusicPlayList playlist = new MusicPlayList(txt_PlaylistName.Text);
            playlists.Add(playlist);
            playlistsNames.Add(txt_PlaylistName.Text);
            txt_PlaylistName.Text = null;

            comboBox1.Items.Clear();
            foreach (MusicPlayList x in playlists)
            {                
                    comboBox1.Items.Add(x.Name);                                
            }

            SaveListPlaylists();
        }
        //Delete a playlist from the list with the musics.
        private void btn_RemovePlaylist_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.Items.Count == 0)
            {
                MessageBox.Show("Você não possui playlist");
                return;
            }
            else if (String.IsNullOrEmpty(comboBox1.SelectedItem.ToString()))
            {
                MessageBox.Show("Selecione uma playlist para poder remove-lá");
                return;
            }            
            else if (!playlistsNames.Contains(comboBox1.SelectedItem.ToString()))
            {
                MessageBox.Show("Essa playlist não existe");
                return;
            }
            string filename = "";
            foreach(MusicPlayList x in playlists)
            {
                if(x.Name == comboBox1.SelectedItem.ToString())
                {
                    filename = x.Name;
                }
            }

            playlists.RemoveAll(x => x.Name == comboBox1.SelectedItem.ToString());
            playlistsNames.RemoveAll(x => x == comboBox1.SelectedItem.ToString());
            comboBox1.Items.Remove(comboBox1.SelectedItem.ToString());
            comboBox1.Text = null;
            try
            {
                File.Delete(Application.StartupPath + @"\Data\Playlist(" + filename + @").playlist");
            }
            catch(ApplicationException ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            SaveListPlaylists();
            ReloadPlaylist();
        }
        //Open the dialog folder to select any music to add.
        private void pb_SelectMusicOfd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(SelectedPlaylist))
            {
                MessageBox.Show("selecione uma playlist para poder adicionar uma música");
                return;
            } 

            ofd = new OpenFileDialog();
            ofd.Filter = ".mp3 files (*.mp3)|*.mp3|.wav files (*.wav)|*.wav|All files (*.*)|*.*";
            
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                foreach(MusicPlayList x in playlists)
                {
                    if(x.Name == SelectedPlaylist)
                    {
                        x.AddMusic(ofd.FileName, ofd.SafeFileName);
                        x.SaveMusics();                        
                        ReloadPlaylist();
                    }
                    
                }
                SaveListPlaylists();
            }
        }

        private void pb_Pause_Click(object sender, EventArgs e)
        {
            StopMusic();
        }

        private void pb_Play_Click(object sender, EventArgs e)
        {
            
            PlayMusic();
        }
        public void PlayMusic()
        {
            if(musicPlayer.playState == WMPPlayState.wmppsPlaying)
            {
                return;
            }
            if (lb_MusicsList.SelectedItem == null)
            {               
                MessageBox.Show("Select a music");
                return;
            }
            if (musicPlayer.URL == null)
            {
                MessageBox.Show("Select a music");
            }
            musicPlayer.play();
            pb_Pause.BringToFront();
          
            timer1.Start();            
        }
        public void StopMusic()
        {
            
            timer1.Stop();
            musicPlayer.pause();
            pb_Play.BringToFront();
        }
        private void tb_Volume_Scroll(object sender, EventArgs e)
        {
            musicPlayer.settings.volume = tb_Volume.Value;
        }

        private void lb_MusicsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lb_MusicsList.SelectedItem == null)
            {
                MessageBox.Show("Seleciona uma música válida.");
                return;
            }
            StopMusic();
            
            try
            {
                musicPlayer.stop();
                MusicPlayList aux = playlists.Find(x => x.Name == SelectedPlaylist);
                musicPlayer.URL = aux.GetPath(lb_MusicsList.SelectedItem.ToString());
                
                musicPlayer.stop();

                if(musicPlayer.controls.currentItem.name.Length > 15)
                {
                    string title = musicPlayer.controls.currentItem.name.Substring(0, 15) + "...";

                    lbl_MusicTittle.Text = title;
                }
                else
                {
                    lbl_MusicTittle.Text = musicPlayer.controls.currentItem.name;
                }
            }
            catch(ApplicationException ex)
            {
                MessageBox.Show("Cannot find the path error: " + ex);
            }
        }
        //Save the playlists.
        private void SaveListPlaylists()
        {
            serializer.BinarySerialize(playlistsNames, savesPath);
        }
        private void LoadListPlaylists()
        {
            

            if (!File.Exists(savesPath))
            {
                return;
            }
            playlistsNames = (List<string>)serializer.BinaryDeserialize(savesPath);

           foreach(string x in playlistsNames)
           {                
                    playlists.Add(new MusicPlayList(x));                                
           }

            
            foreach (MusicPlayList x in playlists)
            {
                x.LoadMusics();
                comboBox1.Items.Add(x.Name);
            }
            ReloadPlaylist();
        }
        //Remove the selected music from the playlist
        private void removarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string musicToRemove = lb_MusicsList.SelectedItem.ToString();
            
            foreach(MusicPlayList XPlayList in playlists)
            {
                if(XPlayList.Name == SelectedPlaylist)
                {
                    foreach(Music x in XPlayList.musicList)
                    {
                        if(x.Name == musicToRemove)
                        {
                            XPlayList.RemoveMusic(x.Name);
                            XPlayList.SaveMusics();
                            ReloadPlaylist();
                            return;
                        }
                    }
                }
            }
            ReloadPlaylist();

        }
        //Go 5 seconds back on the music
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            musicPlayer.controls.currentPosition -= 5;
        }
        //Go 5 seconds forward on the music
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            musicPlayer.controls.currentPosition += 5;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(musicPlayer.playState == WMPPlayState.wmppsPlaying)
            {
                progressBar1.Maximum = (int)musicPlayer.controls.currentItem.duration;
                progressBar1.Value = (int)musicPlayer.controls.currentPosition;
            }
            else
            {
                NextPlaylistMusic();
            }

            lbl_DurationNow.Text = musicPlayer.controls.currentPositionString;
            lbl_FinalDuration.Text = musicPlayer.controls.currentItem.durationString.ToString();
        }
        //Play the next playlist music when the current music finish.
        public void NextPlaylistMusic()
        {            
            if(lb_MusicsList.SelectedIndex < lb_MusicsList.Items.Count -1)
            {
                
                lb_MusicsList.SelectedIndex += 1;
                PlayMusic();
            }
            else
            {
                lb_MusicsList.SelectedIndex = 0;
                PlayMusic();
            }
        }
        //Play the previous music of the playlist.
        public void PreviousMusic()
        {
            if (lb_MusicsList.SelectedIndex > 0)
            {

                lb_MusicsList.SelectedIndex -= 1;
                PlayMusic();
            }
            else
            {
                lb_MusicsList.SelectedIndex = lb_MusicsList.Items.Count - 1;
                PlayMusic();
            }
        }

        //Go to the next music of the playlist.
        private void pb_Next_Click(object sender, EventArgs e)
        {
            if (lb_MusicsList.SelectedIndex < lb_MusicsList.Items.Count - 1)
            {

                lb_MusicsList.SelectedIndex += 1;
                PlayMusic();
            }
        }
        //Go to the previous music of the playlist.
        private void pb_Previous_Click(object sender, EventArgs e)
        {
            if (lb_MusicsList.SelectedIndex > 0)
            {

                lb_MusicsList.SelectedIndex -= 1;
                PlayMusic();
            }
        }
        //Play the selected playlist starting with the first music.

        public void PlayThisPlaylist(string playlist)
        {
            
            //Sets the current playlist to the required playlist
            SelectedPlaylist = playlist;
            comboBox1.Text = playlist;
            comboBox1.SelectedIndex = comboBox1.Items.IndexOf(playlist);

            lb_MusicsList.SelectedItem = lb_MusicsList.Items[0];

            MusicPlayList aux = playlists.Find(x => x.Name == SelectedPlaylist);
            musicPlayer.URL = aux.GetPath(lb_MusicsList.SelectedItem.ToString());
            lbl_MusicTittle.Text = musicPlayer.controls.currentItem.name;
            musicPlayer.stop();

            PlayMusic();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       
    }
}
