using DIOSeries.Bussines;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DIOSeries.UI.Controls {
    public partial class CardThumbSerie : UserControl {

        public ISerie _serie;
        public event EventHandler ButtonOpenVideoClick;
        public event EventHandler ButtonOpenDetailsSerie;
        
        public CardThumbSerie(ISerie serie) {
            
            InitializeComponent();
            
            _serie = serie;
            
            LoadEvents();
            SetProperties();
        }

        private void LoadEvents() {
            this.buttonPlay.Click += ButtonVideoPlay_Click;
            this.buttonPropertySerie.Click += ButtonOpenDetailsSerie;
        }
        private void SetProperties() {
            this.pictureBoxThumbCard.Image = LoadImage();
            this.labelPathVideo.Text = _serie.Video;
            this.viewsVideo1.Views = _serie.Views.ToString();
            this.labelTitleSerie.Text = _serie.Title;
            this.buttonPropertySerie.Tag = _serie.Id;
        }

        private Image LoadImage() {
            try {
                return Image.FromFile(_serie.Image);
            }
            catch (Exception) {
                return Properties.Resources.image_default_thumb;
            }
        }

        private void ButtonVideoPlay_Click(object sender, EventArgs e) {
            new FormVideo(_serie.Video).Show();
        }

        private void ButtonProperties_Click(object sender, EventArgs e) {
            ButtonOpenVideoClick.Invoke(sender, e);
        }
    }
}
