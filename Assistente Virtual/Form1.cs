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

namespace Assistente_Virtual
{
    public partial class FormAssistente : Form
    {
        
        public static FormAssistente instance;
        public FormAssistente()
        {
            InitializeComponent();
            instance = this;            
            new SpeechEngine();

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
        public void LoadChatInfo()
        {
            lbChat.Items.Clear();
            foreach(string i in SpeechEngine.ChatLines)
            {
                
                lbChat.Items.Add(i);
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

        private void VolumeSlider_Scroll(object sender, EventArgs e)
        {
            
        }
    }
}
