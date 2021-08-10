using System;
using System.Windows.Forms;

namespace DIOSeries.UI {
    public partial class FormBoxAlert : Form {
        private readonly string _textError = "Aconteceu um error!";
        private readonly string _textSuccess = "Operação Concluída";

        public FormBoxAlert() {
            InitializeComponent();
            this.buttonClose.Click += ButtonClose_Click;
        }

        public void ShowError() {
            this.buttonMessageText.Text = _textError;
            this.pictureBoxAlert.Image = Properties.Resources.error;
            this.ShowDialog();
        }
        public void ShowError(string message) {
            this.buttonMessageText.Text = message;
            this.pictureBoxAlert.Image = Properties.Resources.error;
            this.ShowDialog();
        }
        public void ShowSuccess() {
            this.pictureBoxAlert.Image = Properties.Resources.success;
            this.buttonMessageText.Text = _textSuccess;
            this.ShowDialog();
        }
        public void ShowSuccess(string message) {
            this.pictureBoxAlert.Image = Properties.Resources.success;
            this.buttonMessageText.Text = message;
            this.ShowDialog();
        }

        private void FormBox_KeyPress(object sender, KeyPressEventArgs e) {
            
        }
        private void Form_MouseClick(object sender, EventArgs e) {
            this.Close();
        }
        private void ButtonClose_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void FormBoxAlert_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar > -1)
                this.Close();
        }
    }
}
