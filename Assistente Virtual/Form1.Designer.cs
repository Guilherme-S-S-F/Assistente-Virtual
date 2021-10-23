
namespace Assistente_Virtual
{
    public partial class FormAssistente
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAssistente));
            this.AssistenteNotify = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mtsAssis = new System.Windows.Forms.ToolStripMenuItem();
            this.ocultarJanelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbChat = new System.Windows.Forms.ListBox();
            this.probMicLevel = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.VolumeSlider = new System.Windows.Forms.TrackBar();
            this.lblVolumeAssis = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // AssistenteNotify
            // 
            this.AssistenteNotify.ContextMenuStrip = this.contextMenuStrip1;
            this.AssistenteNotify.Icon = ((System.Drawing.Icon)(resources.GetObject("AssistenteNotify.Icon")));
            this.AssistenteNotify.Text = "Assis";
            this.AssistenteNotify.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtsAssis,
            this.ocultarJanelaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(151, 70);
            // 
            // mtsAssis
            // 
            this.mtsAssis.Name = "mtsAssis";
            this.mtsAssis.Size = new System.Drawing.Size(150, 22);
            this.mtsAssis.Text = "Mostrar Janela";
            this.mtsAssis.Click += new System.EventHandler(this.mtsAssis_Click);
            // 
            // ocultarJanelaToolStripMenuItem
            // 
            this.ocultarJanelaToolStripMenuItem.Name = "ocultarJanelaToolStripMenuItem";
            this.ocultarJanelaToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.ocultarJanelaToolStripMenuItem.Text = "Ocultar Janela";
            this.ocultarJanelaToolStripMenuItem.Click += new System.EventHandler(this.ocultarJanelaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // lbChat
            // 
            this.lbChat.FormattingEnabled = true;
            this.lbChat.Location = new System.Drawing.Point(293, 12);
            this.lbChat.Name = "lbChat";
            this.lbChat.Size = new System.Drawing.Size(320, 264);
            this.lbChat.TabIndex = 1;
            // 
            // probMicLevel
            // 
            this.probMicLevel.ForeColor = System.Drawing.Color.Lime;
            this.probMicLevel.Location = new System.Drawing.Point(415, 282);
            this.probMicLevel.Name = "probMicLevel";
            this.probMicLevel.Size = new System.Drawing.Size(198, 23);
            this.probMicLevel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Your Voice:";
            // 
            // VolumeSlider
            // 
            this.VolumeSlider.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.VolumeSlider.Location = new System.Drawing.Point(392, 360);
            this.VolumeSlider.Maximum = 100;
            this.VolumeSlider.Name = "VolumeSlider";
            this.VolumeSlider.Size = new System.Drawing.Size(221, 45);
            this.VolumeSlider.TabIndex = 4;
            this.VolumeSlider.Scroll += new System.EventHandler(this.VolumeSlider_Scroll);
            // 
            // lblVolumeAssis
            // 
            this.lblVolumeAssis.AutoSize = true;
            this.lblVolumeAssis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolumeAssis.Location = new System.Drawing.Point(387, 332);
            this.lblVolumeAssis.Name = "lblVolumeAssis";
            this.lblVolumeAssis.Size = new System.Drawing.Size(226, 25);
            this.lblVolumeAssis.TabIndex = 5;
            this.lblVolumeAssis.Text = "Volume da Assistente:";
            // 
            // FormAssistente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 450);
            this.Controls.Add(this.lblVolumeAssis);
            this.Controls.Add(this.VolumeSlider);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.probMicLevel);
            this.Controls.Add(this.lbChat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAssistente";
            this.Text = "Assistent";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VolumeSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon AssistenteNotify;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mtsAssis;
        private System.Windows.Forms.ToolStripMenuItem ocultarJanelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ListBox lbChat;
        public System.Windows.Forms.ProgressBar probMicLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar VolumeSlider;
        private System.Windows.Forms.Label lblVolumeAssis;
    }
}

