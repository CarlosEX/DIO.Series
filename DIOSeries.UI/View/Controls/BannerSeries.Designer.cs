
namespace DIOSeries.UI.Controls {
    partial class BannerSeries {
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
            this.panelCards = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNameGender = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCards
            // 
            this.panelCards.AutoScroll = true;
            this.panelCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCards.Location = new System.Drawing.Point(0, 65);
            this.panelCards.Name = "panelCards";
            this.panelCards.Size = new System.Drawing.Size(1283, 435);
            this.panelCards.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelNameGender);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1283, 65);
            this.panel1.TabIndex = 13;
            // 
            // labelNameGender
            // 
            this.labelNameGender.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNameGender.AutoSize = true;
            this.labelNameGender.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F);
            this.labelNameGender.ForeColor = System.Drawing.Color.White;
            this.labelNameGender.Location = new System.Drawing.Point(14, 16);
            this.labelNameGender.Name = "labelNameGender";
            this.labelNameGender.Size = new System.Drawing.Size(178, 28);
            this.labelNameGender.TabIndex = 13;
            this.labelNameGender.Text = "Categoria Nome";
            // 
            // BannerSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panelCards);
            this.Controls.Add(this.panel1);
            this.Name = "BannerSeries";
            this.Size = new System.Drawing.Size(1283, 500);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelNameGender;
        protected internal System.Windows.Forms.Panel panelCards;
    }
}
