
namespace DIOSeries.UI {
    partial class FormRegisterSerie {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegisterSerie));
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBoxThumb = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonImageNormal = new System.Windows.Forms.RadioButton();
            this.radioButtonImageZoom = new System.Windows.Forms.RadioButton();
            this.radioButtonImageStrech = new System.Windows.Forms.RadioButton();
            this.textBoxPathImage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonOpenListSeries = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxCustomDescription = new DIO.Series.View.Controls.TextBoxCustom();
            this.textBoxCustomGenderId = new DIO.Series.View.Controls.TextBoxCustom();
            this.textBoxCustomGenderName = new DIO.Series.View.Controls.TextBoxCustom();
            this.textBoxCustomYear = new DIO.Series.View.Controls.TextBoxCustom();
            this.textBoxCustomTitle = new DIO.Series.View.Controls.TextBoxCustom();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThumb)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.buttonSave);
            this.panel2.Controls.Add(this.buttonNew);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(85, 619);
            this.panel2.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(5)))), ((int)(((byte)(20)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(5)))), ((int)(((byte)(20)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 80);
            this.button1.TabIndex = 11;
            this.button1.Text = "Split";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(5)))), ((int)(((byte)(20)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(5)))), ((int)(((byte)(20)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(0, 539);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 80);
            this.button3.TabIndex = 10;
            this.button3.Text = "Excluir";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(5)))), ((int)(((byte)(20)))));
            this.buttonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(5)))), ((int)(((byte)(20)))));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
            this.buttonSave.Location = new System.Drawing.Point(0, 80);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(85, 80);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Salvar";
            this.buttonSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonNew.FlatAppearance.BorderSize = 0;
            this.buttonNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(5)))), ((int)(((byte)(20)))));
            this.buttonNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(5)))), ((int)(((byte)(20)))));
            this.buttonNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNew.ForeColor = System.Drawing.Color.White;
            this.buttonNew.Image = ((System.Drawing.Image)(resources.GetObject("buttonNew.Image")));
            this.buttonNew.Location = new System.Drawing.Point(0, 0);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(85, 80);
            this.buttonNew.TabIndex = 7;
            this.buttonNew.Text = "Nova";
            this.buttonNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonNew.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonNew.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(85, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBoxThumb);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxCustomDescription);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxCustomGenderId);
            this.splitContainer1.Panel2.Controls.Add(this.buttonOpenListSeries);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxCustomGenderName);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxCustomYear);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxCustomTitle);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Size = new System.Drawing.Size(670, 619);
            this.splitContainer1.SplitterDistance = 223;
            this.splitContainer1.TabIndex = 20;
            // 
            // pictureBoxThumb
            // 
            this.pictureBoxThumb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxThumb.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxThumb.Name = "pictureBoxThumb";
            this.pictureBoxThumb.Size = new System.Drawing.Size(670, 198);
            this.pictureBoxThumb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxThumb.TabIndex = 1;
            this.pictureBoxThumb.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonImageNormal);
            this.panel1.Controls.Add(this.radioButtonImageZoom);
            this.panel1.Controls.Add(this.radioButtonImageStrech);
            this.panel1.Controls.Add(this.textBoxPathImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 198);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 25);
            this.panel1.TabIndex = 0;
            // 
            // radioButtonImageNormal
            // 
            this.radioButtonImageNormal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radioButtonImageNormal.AutoSize = true;
            this.radioButtonImageNormal.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.radioButtonImageNormal.Location = new System.Drawing.Point(486, 4);
            this.radioButtonImageNormal.Name = "radioButtonImageNormal";
            this.radioButtonImageNormal.Size = new System.Drawing.Size(58, 17);
            this.radioButtonImageNormal.TabIndex = 3;
            this.radioButtonImageNormal.TabStop = true;
            this.radioButtonImageNormal.Text = "Normal";
            this.radioButtonImageNormal.UseVisualStyleBackColor = true;
            // 
            // radioButtonImageZoom
            // 
            this.radioButtonImageZoom.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radioButtonImageZoom.AutoSize = true;
            this.radioButtonImageZoom.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.radioButtonImageZoom.Location = new System.Drawing.Point(544, 4);
            this.radioButtonImageZoom.Name = "radioButtonImageZoom";
            this.radioButtonImageZoom.Size = new System.Drawing.Size(52, 17);
            this.radioButtonImageZoom.TabIndex = 2;
            this.radioButtonImageZoom.TabStop = true;
            this.radioButtonImageZoom.Text = "Zoom";
            this.radioButtonImageZoom.UseVisualStyleBackColor = true;
            // 
            // radioButtonImageStrech
            // 
            this.radioButtonImageStrech.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radioButtonImageStrech.AutoSize = true;
            this.radioButtonImageStrech.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.radioButtonImageStrech.Location = new System.Drawing.Point(602, 4);
            this.radioButtonImageStrech.Name = "radioButtonImageStrech";
            this.radioButtonImageStrech.Size = new System.Drawing.Size(56, 17);
            this.radioButtonImageStrech.TabIndex = 1;
            this.radioButtonImageStrech.TabStop = true;
            this.radioButtonImageStrech.Text = "Strech";
            this.radioButtonImageStrech.UseVisualStyleBackColor = true;
            // 
            // textBoxPathImage
            // 
            this.textBoxPathImage.BackColor = System.Drawing.Color.Black;
            this.textBoxPathImage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPathImage.Enabled = false;
            this.textBoxPathImage.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxPathImage.Location = new System.Drawing.Point(6, 8);
            this.textBoxPathImage.Name = "textBoxPathImage";
            this.textBoxPathImage.Size = new System.Drawing.Size(373, 13);
            this.textBoxPathImage.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(25, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 78;
            this.label4.Text = "DESCRIÇÃO";
            // 
            // buttonOpenListSeries
            // 
            this.buttonOpenListSeries.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenListSeries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenListSeries.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenListSeries.Image")));
            this.buttonOpenListSeries.Location = new System.Drawing.Point(602, 141);
            this.buttonOpenListSeries.Name = "buttonOpenListSeries";
            this.buttonOpenListSeries.Size = new System.Drawing.Size(44, 37);
            this.buttonOpenListSeries.TabIndex = 76;
            this.buttonOpenListSeries.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(175, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 74;
            this.label3.Text = "CATEGORIA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(25, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 72;
            this.label2.Text = "ANO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(25, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "NOME:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(22, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(373, 26);
            this.label6.TabIndex = 68;
            this.label6.Text = "Esse é um projeto que desenvolvi como parte dos desefios da plataforma DIO\r\ne do " +
    "Bootcamp da Averes relacionados a plataforma .NET com C#\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(20, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(287, 29);
            this.label5.TabIndex = 69;
            this.label5.Text = "Detalhes da minha série";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(670, 4);
            this.panel3.TabIndex = 80;
            // 
            // textBoxCustomDescription
            // 
            this.textBoxCustomDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCustomDescription.BackColor = System.Drawing.Color.Black;
            this.textBoxCustomDescription.ForeColor = System.Drawing.Color.White;
            this.textBoxCustomDescription.Location = new System.Drawing.Point(28, 221);
            this.textBoxCustomDescription.MaxLenght = 2147483647;
            this.textBoxCustomDescription.Multiline = true;
            this.textBoxCustomDescription.Name = "textBoxCustomDescription";
            this.textBoxCustomDescription.Size = new System.Drawing.Size(618, 159);
            this.textBoxCustomDescription.TabIndex = 79;
            // 
            // textBoxCustomGenderId
            // 
            this.textBoxCustomGenderId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCustomGenderId.BackColor = System.Drawing.Color.Black;
            this.textBoxCustomGenderId.ForeColor = System.Drawing.Color.White;
            this.textBoxCustomGenderId.Location = new System.Drawing.Point(544, 141);
            this.textBoxCustomGenderId.MaxLenght = 2147483647;
            this.textBoxCustomGenderId.Multiline = true;
            this.textBoxCustomGenderId.Name = "textBoxCustomGenderId";
            this.textBoxCustomGenderId.Size = new System.Drawing.Size(52, 37);
            this.textBoxCustomGenderId.TabIndex = 77;
            this.textBoxCustomGenderId.Visible = false;
            // 
            // textBoxCustomGenderName
            // 
            this.textBoxCustomGenderName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCustomGenderName.BackColor = System.Drawing.Color.Black;
            this.textBoxCustomGenderName.ForeColor = System.Drawing.Color.White;
            this.textBoxCustomGenderName.Location = new System.Drawing.Point(250, 141);
            this.textBoxCustomGenderName.MaxLenght = 2147483647;
            this.textBoxCustomGenderName.Multiline = true;
            this.textBoxCustomGenderName.Name = "textBoxCustomGenderName";
            this.textBoxCustomGenderName.Size = new System.Drawing.Size(294, 37);
            this.textBoxCustomGenderName.TabIndex = 75;
            // 
            // textBoxCustomYear
            // 
            this.textBoxCustomYear.BackColor = System.Drawing.Color.Black;
            this.textBoxCustomYear.ForeColor = System.Drawing.Color.White;
            this.textBoxCustomYear.Location = new System.Drawing.Point(74, 141);
            this.textBoxCustomYear.MaxLenght = 4;
            this.textBoxCustomYear.Multiline = true;
            this.textBoxCustomYear.Name = "textBoxCustomYear";
            this.textBoxCustomYear.Size = new System.Drawing.Size(95, 37);
            this.textBoxCustomYear.TabIndex = 73;
            // 
            // textBoxCustomTitle
            // 
            this.textBoxCustomTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCustomTitle.BackColor = System.Drawing.Color.Black;
            this.textBoxCustomTitle.ForeColor = System.Drawing.Color.White;
            this.textBoxCustomTitle.Location = new System.Drawing.Point(74, 98);
            this.textBoxCustomTitle.MaxLenght = 2147483647;
            this.textBoxCustomTitle.Multiline = true;
            this.textBoxCustomTitle.Name = "textBoxCustomTitle";
            this.textBoxCustomTitle.Size = new System.Drawing.Size(584, 37);
            this.textBoxCustomTitle.TabIndex = 71;
            // 
            // FormRegisterSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(755, 619);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FormRegisterSerie";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Série";
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThumb)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonImageNormal;
        private System.Windows.Forms.RadioButton radioButtonImageZoom;
        private System.Windows.Forms.RadioButton radioButtonImageStrech;
        private System.Windows.Forms.TextBox textBoxPathImage;
        private System.Windows.Forms.PictureBox pictureBoxThumb;
        private DIO.Series.View.Controls.TextBoxCustom textBoxCustomTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonOpenListSeries;
        private DIO.Series.View.Controls.TextBoxCustom textBoxCustomGenderName;
        private System.Windows.Forms.Label label3;
        private DIO.Series.View.Controls.TextBoxCustom textBoxCustomYear;
        private System.Windows.Forms.Label label2;
        private DIO.Series.View.Controls.TextBoxCustom textBoxCustomGenderId;
        private DIO.Series.View.Controls.TextBoxCustom textBoxCustomDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
    }
}