
namespace DIOSeries.UI.Controls {
    partial class CardThumbSerie {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardThumbSerie));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPathVideo = new System.Windows.Forms.Label();
            this.viewsVideo1 = new DIO.Series.View.Controls.ViewsVideo();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonPropertySerie = new System.Windows.Forms.Button();
            this.labelTitleSerie = new System.Windows.Forms.Label();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.pictureBoxThumbCard = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThumbCard)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panel1.Controls.Add(this.labelPathVideo);
            this.panel1.Controls.Add(this.viewsVideo1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.labelTitleSerie);
            this.panel1.Controls.Add(this.buttonPlay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 46);
            this.panel1.TabIndex = 0;
            // 
            // labelPathVideo
            // 
            this.labelPathVideo.AutoSize = true;
            this.labelPathVideo.ForeColor = System.Drawing.Color.White;
            this.labelPathVideo.Location = new System.Drawing.Point(46, 4);
            this.labelPathVideo.Name = "labelPathVideo";
            this.labelPathVideo.Size = new System.Drawing.Size(57, 13);
            this.labelPathVideo.TabIndex = 4;
            this.labelPathVideo.Text = "pathImage";
            this.labelPathVideo.Visible = false;
            // 
            // viewsVideo1
            // 
            this.viewsVideo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.viewsVideo1.Dock = System.Windows.Forms.DockStyle.Right;
            this.viewsVideo1.Location = new System.Drawing.Point(319, 0);
            this.viewsVideo1.Name = "viewsVideo1";
            this.viewsVideo1.Size = new System.Drawing.Size(39, 46);
            this.viewsVideo1.TabIndex = 3;
            this.viewsVideo1.Views = "5";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonPropertySerie);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(40, 46);
            this.panel2.TabIndex = 2;
            // 
            // buttonPropertySerie
            // 
            this.buttonPropertySerie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPropertySerie.FlatAppearance.BorderSize = 0;
            this.buttonPropertySerie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(5)))), ((int)(((byte)(20)))));
            this.buttonPropertySerie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(5)))), ((int)(((byte)(20)))));
            this.buttonPropertySerie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPropertySerie.ForeColor = System.Drawing.Color.White;
            this.buttonPropertySerie.Image = ((System.Drawing.Image)(resources.GetObject("buttonPropertySerie.Image")));
            this.buttonPropertySerie.Location = new System.Drawing.Point(0, 0);
            this.buttonPropertySerie.Name = "buttonPropertySerie";
            this.buttonPropertySerie.Size = new System.Drawing.Size(40, 46);
            this.buttonPropertySerie.TabIndex = 1;
            this.buttonPropertySerie.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonPropertySerie.UseVisualStyleBackColor = true;
            // 
            // labelTitleSerie
            // 
            this.labelTitleSerie.AutoSize = true;
            this.labelTitleSerie.ForeColor = System.Drawing.Color.White;
            this.labelTitleSerie.Location = new System.Drawing.Point(46, 17);
            this.labelTitleSerie.Name = "labelTitleSerie";
            this.labelTitleSerie.Size = new System.Drawing.Size(46, 13);
            this.labelTitleSerie.TabIndex = 1;
            this.labelTitleSerie.Text = "Bird Box";
            // 
            // buttonPlay
            // 
            this.buttonPlay.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonPlay.FlatAppearance.BorderSize = 0;
            this.buttonPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(5)))), ((int)(((byte)(20)))));
            this.buttonPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(5)))), ((int)(((byte)(20)))));
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.ForeColor = System.Drawing.Color.White;
            this.buttonPlay.Image = ((System.Drawing.Image)(resources.GetObject("buttonPlay.Image")));
            this.buttonPlay.Location = new System.Drawing.Point(358, 0);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(42, 46);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonPlay.UseVisualStyleBackColor = true;
            // 
            // pictureBoxThumbCard
            // 
            this.pictureBoxThumbCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxThumbCard.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxThumbCard.Image")));
            this.pictureBoxThumbCard.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxThumbCard.Name = "pictureBoxThumbCard";
            this.pictureBoxThumbCard.Size = new System.Drawing.Size(400, 195);
            this.pictureBoxThumbCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxThumbCard.TabIndex = 1;
            this.pictureBoxThumbCard.TabStop = false;
            // 
            // CardThumbSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.pictureBoxThumbCard);
            this.Controls.Add(this.panel1);
            this.Name = "CardThumbSerie";
            this.Size = new System.Drawing.Size(400, 241);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThumbCard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Label labelTitleSerie;
        private System.Windows.Forms.PictureBox pictureBoxThumbCard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonPropertySerie;
        private DIO.Series.View.Controls.ViewsVideo viewsVideo1;
        private System.Windows.Forms.Label labelPathVideo;
    }
}
