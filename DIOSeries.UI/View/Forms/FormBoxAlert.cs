using System;
using System.Drawing;
using System.Windows.Forms;

namespace DIOSeries.UI {
    public partial class FormBoxAlert : Form {
        
        private readonly string _messageErroDefault = "Aconteceu um error!";
        private readonly string _messageSuccessDefault = "Operação Concluída";
        private static readonly Bitmap _imageErro = Properties.Resources.error;
        private static readonly Bitmap _imageSuccess = Properties.Resources.success;

        public FormBoxAlert() {
            InitializeComponent(); 
            this.buttonClose.Click += ButtonClose_Click;
        }
        
        public void Show(IconBox iconBox, string message) {
            
            switch (iconBox) {
                case IconBox.Erro:
                    ShowError(message);
                    break;
                case IconBox.Success:
                    ShowSuccess(message);
                    break;
                default:
                    break;
            }
        }

        public void Show(IconBox iconBox) {
            
            switch (iconBox) {
                case IconBox.Erro:
                    ShowErrorDefault();
                    break;
                case IconBox.Success:
                    ShowSuccessDefault();
                    break;
                default:
                    break;
            }
        }

        private void ShowErrorDefault() {
            this.buttonMessageText.Text = _messageErroDefault;
            this.pictureBoxAlert.Image = _imageErro;
            this.ShowDialog();
        }
        private void ShowSuccessDefault() {
            this.pictureBoxAlert.Image = _imageSuccess;
            this.buttonMessageText.Text = _messageSuccessDefault;
            this.ShowDialog();
        }

        private void ShowError(string message) {
            this.buttonMessageText.Text = message;
            this.pictureBoxAlert.Image = _imageErro;
            this.ShowDialog();
        }
        
        private void ShowSuccess(string message) {
            this.pictureBoxAlert.Image = _imageSuccess;
            this.buttonMessageText.Text = message;
            this.ShowDialog();
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
