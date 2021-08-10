
namespace DIOSeries.UI {
    partial class FormBoxAlert {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBoxAlert));
            this.pictureBoxAlert = new System.Windows.Forms.PictureBox();
            this.buttonMessageText = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlert)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAlert
            // 
            this.pictureBoxAlert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxAlert.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAlert.Image")));
            this.pictureBoxAlert.Location = new System.Drawing.Point(131, 37);
            this.pictureBoxAlert.Name = "pictureBoxAlert";
            this.pictureBoxAlert.Size = new System.Drawing.Size(55, 55);
            this.pictureBoxAlert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxAlert.TabIndex = 0;
            this.pictureBoxAlert.TabStop = false;
            // 
            // buttonMessageText
            // 
            this.buttonMessageText.AutoEllipsis = true;
            this.buttonMessageText.FlatAppearance.BorderSize = 0;
            this.buttonMessageText.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonMessageText.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonMessageText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMessageText.Location = new System.Drawing.Point(44, 107);
            this.buttonMessageText.Name = "buttonMessageText";
            this.buttonMessageText.Size = new System.Drawing.Size(230, 23);
            this.buttonMessageText.TabIndex = 3;
            this.buttonMessageText.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonClose.Location = new System.Drawing.Point(290, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(26, 23);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // FormBoxAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(318, 156);
            this.ControlBox = false;
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonMessageText);
            this.Controls.Add(this.pictureBoxAlert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBoxAlert";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormBoxAlert_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlert)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAlert;
        private System.Windows.Forms.Button buttonMessageText;
        private System.Windows.Forms.Button buttonClose;
    }
}