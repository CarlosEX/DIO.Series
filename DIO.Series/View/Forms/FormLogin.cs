using DIO.Series.View.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DIO.Series.View {
    public partial class FormLogin : Form {
        public FormLogin() {
            InitializeComponent();
            this.textBoxLogin.TextChanged += TextboxLogin_Change;
            this.textBoxLogin.Select();
            this.buttonLogin.Click += ButtonLogin_Click;
        }
        private void TextboxLogin_Change(object sender, EventArgs e) {
            PlaceHolderLogin();
        }
        private void ButtonLogin_Click(object sender, EventArgs e) {
            this.Close();
            new FormSeries().ShowDialog();
        }
        private void PlaceHolderLogin() {
            if (string.IsNullOrWhiteSpace(textBoxLogin.Text)) {
                panelBorder.BackColor = Color.FromArgb(224,224,224);
            }
            else {
                panelBorder.BackColor = Color.Red;
            }
        }
    }
}
