using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using Assistente_Virtual.Engine;
using Assistente_Virtual.Design;
using Assistente_Virtual.Services;
using Assistente_Virtual.ErrorManager;
namespace Assistente_Virtual
{
    public partial class FormAssistente : Form
    {
        Thread threadMenu;
        public static FormAssistente instance;
        public ExecuteFile execute = new ExecuteFile();
        bool isHideMic = true;
        public FormAssistente()
        {
            InitializeComponent();
            instance = this;
            new SpeechEngine();

            this.WindowState = FormWindowState.Maximized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnMic.Hide();
            UpperBar.Hide();
        }       
        private void FormAssistente_DoubleClick(object sender, EventArgs e)
        {
            UpperBar.Show();
            if (isHideMic)
            {
                pnMic.Show();                       
            }            
        }
        
        private void mtsAssis_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void ocultarJanelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Form Design
       
        #endregion

        #region MoveForms
        bool mov =false;
        int movX;
        int movY;
        private void FormAssistente_MouseDown(object sender, MouseEventArgs e)
        {
            mov = true;
            movX = e.X;
            movY = e.Y;
        }

        private void FormAssistente_MouseMove(object sender, MouseEventArgs e)
        {
            if(mov == true)
            {
                this.pictureBox1.Location = new Point(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void FormAssistente_MouseUp(object sender, MouseEventArgs e)
        {
            mov = false;
        }


        #endregion
        #region MoveForms
        bool movpanel = false;
        int panelmovX;
        int panelmovY;
        private void PanelPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            movpanel = true;
            panelmovX = e.X;
            panelmovY = e.Y;
        }

        private void PanelPrincipal_MouseMove(object sender, MouseEventArgs e)
        {
            if (movpanel == true)
            {
                this.pnMic.Location = new Point(MousePosition.X - panelmovX, MousePosition.Y - panelmovY);
            }
        }

        private void PanelPrincipal_MouseUp(object sender, MouseEventArgs e)
        {
            movpanel = false;
        }


        #endregion

        private void btnHideMic_Click(object sender, EventArgs e)
        {
            pnMic.Hide();
            
        }

        private void SliderVolume_ValueChanged(object sender, EventArgs e)
        {
            SpeechEngine.Speaker.Volume = SliderVolume.Value;
            SliderVolume.Value = SpeechEngine.Speaker.Volume;
        }       
        
        public static void OpenMusic()
        {
            FormMusic music = new FormMusic();
            music.Show();
        }

        private void pnMic_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Music_Click(object sender, EventArgs e)
        {
            FormAssistente.OpenMusic();
        }

        private void btn_closeUpperBar_Click(object sender, EventArgs e)
        {
            UpperBar.Hide();
        }
    }
}
