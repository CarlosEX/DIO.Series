
namespace DIOSeries.UI {
    partial class FormVideo {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVideo));
            this.windowVideoPlayer1 = new DIOSeries.UI.View.Controls.WindowVideoPlayer();
            this.windowVideoPlayer2 = new DIOSeries.UI.View.Controls.WindowVideoPlayer();
            this.SuspendLayout();
            // 
            // windowVideoPlayer1
            // 
            this.windowVideoPlayer1.BackColor = System.Drawing.Color.Black;
            this.windowVideoPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.windowVideoPlayer1.Location = new System.Drawing.Point(0, 0);
            this.windowVideoPlayer1.Name = "windowVideoPlayer1";
            this.windowVideoPlayer1.Size = new System.Drawing.Size(800, 450);
            this.windowVideoPlayer1.TabIndex = 0;
            // 
            // windowVideoPlayer2
            // 
            this.windowVideoPlayer2.BackColor = System.Drawing.Color.Black;
            this.windowVideoPlayer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.windowVideoPlayer2.Location = new System.Drawing.Point(0, 0);
            this.windowVideoPlayer2.Name = "windowVideoPlayer2";
            this.windowVideoPlayer2.Size = new System.Drawing.Size(800, 450);
            this.windowVideoPlayer2.TabIndex = 1;
            // 
            // FormVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.windowVideoPlayer2);
            this.Controls.Add(this.windowVideoPlayer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormVideo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVideo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private View.Controls.WindowVideoPlayer windowVideoPlayer1;
        private View.Controls.WindowVideoPlayer windowVideoPlayer2;
    }
}