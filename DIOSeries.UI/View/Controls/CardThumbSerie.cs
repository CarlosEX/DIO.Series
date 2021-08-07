using System;
using System.Drawing;
using System.Windows.Forms;

namespace DIOSeries.UI.Controls {
    public partial class CardThumbSerie : UserControl {
        
        public event EventHandler ButtonClick;
        
        public CardThumbSerie(string pathImage) {
            InitializeComponent();
            this.buttonPlay.Click += ButonPlay_Click;
            this.pictureBoxThumbCard.Image = Image.FromFile(pathImage);
        }

        public void SetImageThumb(string pathImage) {
            this.pictureBoxThumbCard.Image = Image.FromFile(pathImage);
        }
        private void ButonPlay_Click(object sender, EventArgs e) {
            ButtonClick.Invoke(sender, e);
        }
    }
}
