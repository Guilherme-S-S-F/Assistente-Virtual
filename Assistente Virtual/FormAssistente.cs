using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Assistente_Virtual.Engine;
using Assistente_Virtual.Design;

namespace Assistente_Virtual
{
    public partial class FormAssistente : Form
    {
        
        public static FormAssistente instance;
        bool isHideMic = true;
        public FormAssistente()
        {
            InitializeComponent();
            instance = this;
            new SpeechEngine();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnMic.Hide();
            
        }       
        private void FormAssistente_DoubleClick(object sender, EventArgs e)
        {
            if(isHideMic)
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
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void FormAssistente_MouseUp(object sender, MouseEventArgs e)
        {
            mov = false;
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
    }
}
