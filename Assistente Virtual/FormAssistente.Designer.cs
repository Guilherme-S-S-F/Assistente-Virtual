
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbMicLevel = new System.Windows.Forms.ProgressBar();
            this.pnMic = new System.Windows.Forms.Panel();
            this.lblVolume = new System.Windows.Forms.Label();
            this.btnClose = new Assistente_Virtual.Design.Custom_Button();
            this.SliderVolume = new System.Windows.Forms.TrackBar();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnMic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SliderVolume)).BeginInit();
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Assistente_Virtual.Properties.Resources.BrainLogo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.FormAssistente_DoubleClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormAssistente_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormAssistente_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormAssistente_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mic : ";
            // 
            // pbMicLevel
            // 
            this.pbMicLevel.Location = new System.Drawing.Point(53, 15);
            this.pbMicLevel.Maximum = 50;
            this.pbMicLevel.Name = "pbMicLevel";
            this.pbMicLevel.Size = new System.Drawing.Size(86, 18);
            this.pbMicLevel.TabIndex = 0;
            // 
            // pnMic
            // 
            this.pnMic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnMic.Controls.Add(this.lblVolume);
            this.pnMic.Controls.Add(this.btnClose);
            this.pnMic.Controls.Add(this.SliderVolume);
            this.pnMic.Controls.Add(this.pbMicLevel);
            this.pnMic.Controls.Add(this.label1);
            this.pnMic.Location = new System.Drawing.Point(179, 31);
            this.pnMic.Name = "pnMic";
            this.pnMic.Size = new System.Drawing.Size(200, 105);
            this.pnMic.TabIndex = 2;
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.Location = new System.Drawing.Point(3, 69);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(62, 18);
            this.lblVolume.TabIndex = 7;
            this.lblVolume.Text = "Volume:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnClose.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnClose.BorderColor = System.Drawing.Color.Black;
            this.btnClose.BorderRadius = 4;
            this.btnClose.BorderSize = 0;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(172, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 33);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.TextColor = System.Drawing.Color.White;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnHideMic_Click);
            // 
            // SliderVolume
            // 
            this.SliderVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SliderVolume.Location = new System.Drawing.Point(68, 57);
            this.SliderVolume.Maximum = 100;
            this.SliderVolume.Name = "SliderVolume";
            this.SliderVolume.Size = new System.Drawing.Size(129, 45);
            this.SliderVolume.TabIndex = 6;
            this.SliderVolume.TickFrequency = 0;
            this.SliderVolume.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.SliderVolume.Value = 90;
            this.SliderVolume.ValueChanged += new System.EventHandler(this.SliderVolume_ValueChanged);
            // 
            // FormAssistente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(901, 403);
            this.Controls.Add(this.pnMic);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAssistente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assistent";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DoubleClick += new System.EventHandler(this.FormAssistente_DoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormAssistente_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormAssistente_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormAssistente_MouseUp);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnMic.ResumeLayout(false);
            this.pnMic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SliderVolume)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon AssistenteNotify;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mtsAssis;
        private System.Windows.Forms.ToolStripMenuItem ocultarJanelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ProgressBar pbMicLevel;
        private System.Windows.Forms.Panel pnMic;
        private Design.Custom_Button btnClose;
        public System.Windows.Forms.TrackBar SliderVolume;
        private System.Windows.Forms.Label lblVolume;
    }
}

