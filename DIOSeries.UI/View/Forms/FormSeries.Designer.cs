
using ColorSlider;

namespace DIOSeries.UI {
    partial class FormSeries {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSeries));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.colorSliderWidth = new ColorSlider.ColorSlider();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonReflash = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.colorSliderHeight = new ColorSlider.ColorSlider();
            this.panelSeries = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1249, 88);
            this.panel1.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.colorSliderWidth);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(189, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(901, 88);
            this.panel4.TabIndex = 12;
            // 
            // colorSliderWidth
            // 
            this.colorSliderWidth.BackColor = System.Drawing.Color.Black;
            this.colorSliderWidth.BarPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(94)))), ((int)(((byte)(110)))));
            this.colorSliderWidth.BarPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(74)))));
            this.colorSliderWidth.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.colorSliderWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorSliderWidth.ElapsedInnerColor = System.Drawing.Color.Maroon;
            this.colorSliderWidth.ElapsedPenColorBottom = System.Drawing.Color.Maroon;
            this.colorSliderWidth.ElapsedPenColorTop = System.Drawing.Color.Maroon;
            this.colorSliderWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.colorSliderWidth.ForeColor = System.Drawing.Color.Silver;
            this.colorSliderWidth.LargeChange = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.colorSliderWidth.Location = new System.Drawing.Point(0, 0);
            this.colorSliderWidth.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.colorSliderWidth.Minimum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.colorSliderWidth.Name = "colorSliderWidth";
            this.colorSliderWidth.Padding = 10;
            this.colorSliderWidth.ScaleDivisions = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.colorSliderWidth.ScaleSubDivisions = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.colorSliderWidth.ShowDivisionsText = true;
            this.colorSliderWidth.ShowSmallScale = false;
            this.colorSliderWidth.Size = new System.Drawing.Size(901, 88);
            this.colorSliderWidth.SmallChange = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.colorSliderWidth.TabIndex = 17;
            this.colorSliderWidth.Text = "Largura";
            this.colorSliderWidth.ThumbInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(5)))), ((int)(((byte)(20)))));
            this.colorSliderWidth.ThumbOuterColor = System.Drawing.Color.Firebrick;
            this.colorSliderWidth.ThumbPenColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(5)))), ((int)(((byte)(20)))));
            this.colorSliderWidth.ThumbRoundRectSize = new System.Drawing.Size(16, 16);
            this.colorSliderWidth.ThumbSize = new System.Drawing.Size(16, 16);
            this.colorSliderWidth.TickAdd = 0F;
            this.colorSliderWidth.TickColor = System.Drawing.Color.Silver;
            this.colorSliderWidth.TickDivide = 0F;
            this.colorSliderWidth.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.colorSliderWidth.Value = new decimal(new int[] {
            320,
            0,
            0,
            0});
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1090, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(159, 88);
            this.panel5.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(5)))), ((int)(((byte)(20)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(5)))), ((int)(((byte)(20)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 88);
            this.button3.TabIndex = 9;
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.textBox1.Location = new System.Drawing.Point(22, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 34);
            this.textBox1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.buttonReflash);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(85, 430);
            this.panel2.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(5)))), ((int)(((byte)(20)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(5)))), ((int)(((byte)(20)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(0, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 80);
            this.button2.TabIndex = 9;
            this.button2.Text = "Atualizar";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonReflash
            // 
            this.buttonReflash.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReflash.FlatAppearance.BorderSize = 0;
            this.buttonReflash.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(5)))), ((int)(((byte)(20)))));
            this.buttonReflash.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(5)))), ((int)(((byte)(20)))));
            this.buttonReflash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReflash.ForeColor = System.Drawing.Color.White;
            this.buttonReflash.Image = ((System.Drawing.Image)(resources.GetObject("buttonReflash.Image")));
            this.buttonReflash.Location = new System.Drawing.Point(0, 160);
            this.buttonReflash.Name = "buttonReflash";
            this.buttonReflash.Size = new System.Drawing.Size(85, 80);
            this.buttonReflash.TabIndex = 8;
            this.buttonReflash.Text = "Atualizar";
            this.buttonReflash.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonReflash.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonReflash.UseVisualStyleBackColor = true;
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
            this.button1.Location = new System.Drawing.Point(0, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 80);
            this.button1.TabIndex = 7;
            this.button1.Text = "Séries";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(5)))), ((int)(((byte)(20)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(5)))), ((int)(((byte)(20)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 80);
            this.button5.TabIndex = 6;
            this.button5.Text = "Categorias";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.colorSliderHeight);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1186, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(63, 430);
            this.panel3.TabIndex = 8;
            // 
            // colorSliderHeight
            // 
            this.colorSliderHeight.BackColor = System.Drawing.Color.Black;
            this.colorSliderHeight.BarPenColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(94)))), ((int)(((byte)(110)))));
            this.colorSliderHeight.BarPenColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(74)))));
            this.colorSliderHeight.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.colorSliderHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorSliderHeight.ElapsedInnerColor = System.Drawing.Color.Maroon;
            this.colorSliderHeight.ElapsedPenColorBottom = System.Drawing.Color.Maroon;
            this.colorSliderHeight.ElapsedPenColorTop = System.Drawing.Color.Maroon;
            this.colorSliderHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.colorSliderHeight.ForeColor = System.Drawing.Color.Silver;
            this.colorSliderHeight.LargeChange = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.colorSliderHeight.Location = new System.Drawing.Point(0, 0);
            this.colorSliderHeight.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.colorSliderHeight.Minimum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.colorSliderHeight.Name = "colorSliderHeight";
            this.colorSliderHeight.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.colorSliderHeight.Padding = 10;
            this.colorSliderHeight.ScaleDivisions = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.colorSliderHeight.ScaleSubDivisions = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.colorSliderHeight.ShowDivisionsText = true;
            this.colorSliderHeight.ShowSmallScale = false;
            this.colorSliderHeight.Size = new System.Drawing.Size(63, 430);
            this.colorSliderHeight.SmallChange = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.colorSliderHeight.TabIndex = 17;
            this.colorSliderHeight.Text = "Altura";
            this.colorSliderHeight.ThumbInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(5)))), ((int)(((byte)(20)))));
            this.colorSliderHeight.ThumbOuterColor = System.Drawing.Color.Firebrick;
            this.colorSliderHeight.ThumbPenColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(5)))), ((int)(((byte)(20)))));
            this.colorSliderHeight.ThumbRoundRectSize = new System.Drawing.Size(16, 16);
            this.colorSliderHeight.ThumbSize = new System.Drawing.Size(16, 16);
            this.colorSliderHeight.TickAdd = 0F;
            this.colorSliderHeight.TickColor = System.Drawing.Color.Silver;
            this.colorSliderHeight.TickDivide = 0F;
            this.colorSliderHeight.TickStyle = System.Windows.Forms.TickStyle.BottomRight;
            this.colorSliderHeight.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.colorSliderHeight.ValueChanged += new System.EventHandler(this.ColorSliderHeigh_ValueChanged);
            // 
            // panelSeries
            // 
            this.panelSeries.AutoScroll = true;
            this.panelSeries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSeries.Location = new System.Drawing.Point(85, 88);
            this.panelSeries.Name = "panelSeries";
            this.panelSeries.Size = new System.Drawing.Size(1101, 430);
            this.panelSeries.TabIndex = 9;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(5)))), ((int)(((byte)(20)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(5)))), ((int)(((byte)(20)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(0, 240);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 80);
            this.button4.TabIndex = 10;
            this.button4.Text = "Download";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // FormSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1249, 518);
            this.Controls.Add(this.panelSeries);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSeries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Series";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonReflash;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelSeries;
        private ColorSlider.ColorSlider colorSliderHeight;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel4;
        private ColorSlider.ColorSlider colorSliderWidth;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}