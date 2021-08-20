
namespace DIOSeries.UI.View.Forms {
    partial class FormDownloadVideoWeb {
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
            this.textBoxCustomGenderName = new DIO.Series.View.Controls.TextBoxCustom();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxCustomGenderName
            // 
            this.textBoxCustomGenderName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCustomGenderName.BackColor = System.Drawing.Color.Black;
            this.textBoxCustomGenderName.ForeColor = System.Drawing.Color.White;
            this.textBoxCustomGenderName.Location = new System.Drawing.Point(103, 121);
            this.textBoxCustomGenderName.MaxLenght = 2147483647;
            this.textBoxCustomGenderName.Multiline = true;
            this.textBoxCustomGenderName.Name = "textBoxCustomGenderName";
            this.textBoxCustomGenderName.Size = new System.Drawing.Size(325, 37);
            this.textBoxCustomGenderName.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(28, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 78;
            this.label3.Text = "CATEGORIA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(24, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(373, 26);
            this.label6.TabIndex = 76;
            this.label6.Text = "Esse é um projeto que desenvolvi como parte dos desefios da plataforma DIO\r\ne do " +
    "Bootcamp da Averes relacionados a plataforma .NET com C#\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(22, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(287, 29);
            this.label5.TabIndex = 77;
            this.label5.Text = "Detalhes da minha série";
            // 
            // FormDownloadVideoWeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(602, 300);
            this.Controls.Add(this.textBoxCustomGenderName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "FormDownloadVideoWeb";
            this.Text = "FormDownloadVideoWeb";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DIO.Series.View.Controls.TextBoxCustom textBoxCustomGenderName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}