
namespace DIOSeries.UI.View.Controls {
    partial class WindowVideoPlayer {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowVideoPlayer));
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonPlayPause = new System.Windows.Forms.Button();
            this.buttonTimerTemp = new System.Windows.Forms.Button();
            this.textBoxPathVideo = new System.Windows.Forms.TextBox();
            this.panelBackgroundProgressbar = new System.Windows.Forms.Panel();
            this.panelProgress = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelBackgroundProgressbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.textBoxPathVideo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 133);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(265, 31);
            this.panel4.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonPlayPause);
            this.panel1.Controls.Add(this.buttonTimerTemp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 31);
            this.panel1.TabIndex = 3;
            // 
            // buttonPlayPause
            // 
            this.buttonPlayPause.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonPlayPause.FlatAppearance.BorderSize = 0;
            this.buttonPlayPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.buttonPlayPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.buttonPlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlayPause.Image = ((System.Drawing.Image)(resources.GetObject("buttonPlayPause.Image")));
            this.buttonPlayPause.Location = new System.Drawing.Point(0, 0);
            this.buttonPlayPause.Name = "buttonPlayPause";
            this.buttonPlayPause.Size = new System.Drawing.Size(34, 31);
            this.buttonPlayPause.TabIndex = 4;
            this.buttonPlayPause.UseVisualStyleBackColor = true;
            // 
            // buttonTimerTemp
            // 
            this.buttonTimerTemp.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonTimerTemp.FlatAppearance.BorderSize = 0;
            this.buttonTimerTemp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(5)))), ((int)(((byte)(20)))));
            this.buttonTimerTemp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(5)))), ((int)(((byte)(20)))));
            this.buttonTimerTemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimerTemp.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonTimerTemp.Location = new System.Drawing.Point(206, 0);
            this.buttonTimerTemp.Name = "buttonTimerTemp";
            this.buttonTimerTemp.Size = new System.Drawing.Size(59, 31);
            this.buttonTimerTemp.TabIndex = 1;
            this.buttonTimerTemp.Text = "00:00:00";
            this.buttonTimerTemp.UseVisualStyleBackColor = true;
            // 
            // textBoxPathVideo
            // 
            this.textBoxPathVideo.BackColor = System.Drawing.Color.Black;
            this.textBoxPathVideo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPathVideo.Enabled = false;
            this.textBoxPathVideo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxPathVideo.Location = new System.Drawing.Point(51, 9);
            this.textBoxPathVideo.Name = "textBoxPathVideo";
            this.textBoxPathVideo.Size = new System.Drawing.Size(105, 13);
            this.textBoxPathVideo.TabIndex = 2;
            // 
            // panelBackgroundProgressbar
            // 
            this.panelBackgroundProgressbar.BackColor = System.Drawing.Color.Black;
            this.panelBackgroundProgressbar.Controls.Add(this.panelProgress);
            this.panelBackgroundProgressbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBackgroundProgressbar.Location = new System.Drawing.Point(0, 130);
            this.panelBackgroundProgressbar.Name = "panelBackgroundProgressbar";
            this.panelBackgroundProgressbar.Size = new System.Drawing.Size(265, 3);
            this.panelBackgroundProgressbar.TabIndex = 3;
            // 
            // panelProgress
            // 
            this.panelProgress.BackColor = System.Drawing.Color.Black;
            this.panelProgress.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelProgress.Location = new System.Drawing.Point(0, 0);
            this.panelProgress.Name = "panelProgress";
            this.panelProgress.Size = new System.Drawing.Size(200, 3);
            this.panelProgress.TabIndex = 4;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(265, 130);
            this.axWindowsMediaPlayer1.TabIndex = 4;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.WindowMediaPlayer_PlayStateChange);
            // 
            // WindowVideoPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.panelBackgroundProgressbar);
            this.Controls.Add(this.panel4);
            this.Name = "WindowVideoPlayer";
            this.Size = new System.Drawing.Size(265, 164);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelBackgroundProgressbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxPathVideo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelBackgroundProgressbar;
        private System.Windows.Forms.Panel panelProgress;
        private System.Windows.Forms.Button buttonTimerTemp;
        private System.Windows.Forms.Button buttonPlayPause;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Timer timer1;
    }
}
