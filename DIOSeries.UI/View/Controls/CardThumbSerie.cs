using DIOSeries.Bussines;
using DIOSeries.Database.Entities.Factory;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DIOSeries.UI.Controls {
    public partial class CardThumbSerie : UserControl {

        private static readonly string _connectionString = ApplicationDatabase.ConnectionString;
        private readonly ISerie _serie;
                
        public CardThumbSerie(ISerie serie) {
            
            InitializeComponent();
            
            _serie = serie;
            
            LoadEvents();
            SetProperties();
        }

        private void LoadEvents() {
            buttonPlay.Click += new EventHandler(ButtonVideoPlay_Click);
            buttonPropertySerie.Click += new EventHandler(ButtonProperties_Click);
        }

        private void SetProperties() {
            pictureBoxThumbCard.Image = LoadImage();
            labelPathVideo.Text = _serie.Video;
            viewsVideo1.Views = _serie.Views.ToString();
            labelTitleSerie.Text = _serie.Title;
            buttonPropertySerie.Tag = _serie.Id;
        }

        private void UpadateViews() {
            _serie.IncrementViews();
            SerieDatabaseFactory.Create(_connectionString, _serie).UpdateViews();
            viewsVideo1.Views = _serie.Views.ToString();
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
            UpadateViews();
        }

        private void ButtonProperties_Click(object sender, EventArgs e) {
            var form = new FormRegisterSerie(_serie);
            form.WindowState = FormWindowState.Maximized;
            form.ShowDialog();
        }
    }
}
