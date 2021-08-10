using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DIO.Series.View.Controls {
    public partial class TextBoxCustom : UserControl {

        public TextBoxCustom() {
            InitializeComponent();
            this.richTextBox1.Enter += RichTextBox1_Enter;
            this.richTextBox1.Leave += RichTextBox1_Leave;
        }

        private void RichTextBox1_Enter(object sender, EventArgs e) {
            richTextBox1.ForeColor = Color.FromArgb(233,5,20);
            panel1.Height = 3;
            panel1.BackColor = Color.FromArgb(233, 5, 20);
        }

        private void RichTextBox1_Leave(object sender, EventArgs e) {
            richTextBox1.ForeColor = Color.White;
            panel1.Height = 1;
            panel1.BackColor = Color.FromArgb(32,32,32);
        }

        [Category("Custom Control")]
        public override Font Font {
            get => base.Font;
            set {
                base.Font = value;
                richTextBox1.Font = value;

                if (this.DesignMode)
                    UpdateControlHeigth();
            }
        }

        [Category("Custom Control")]
        public override Color ForeColor {
            get => base.ForeColor;
            set {
                base.ForeColor = value;
                richTextBox1.ForeColor = value;
            }
        }
        [Category("Custom Control")]
        public int MaxLenght {
            get { return richTextBox1.MaxLength; }
            set { richTextBox1.MaxLength = value; }
        }

        [Category("Custom Control")]
        public bool Multiline {
            get { return richTextBox1.Multiline; }
            set { richTextBox1.Multiline = value; }
        }

        [Category("Custom Control")]
        public override string Text {
            get => richTextBox1.Text;
            set {
                richTextBox1.Text = value;
            }
        }

        [Category("Custom Control")]
        private void UpdateControlHeigth() {
            if (richTextBox1.Multiline == false) {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                richTextBox1.Multiline = true;
                richTextBox1.MinimumSize = new Size(0, txtHeight);
                richTextBox1.Multiline = false;

                this.Height = richTextBox1.Height + this.Padding.Top + this.Padding.Bottom;

            }
        }
    }
}
