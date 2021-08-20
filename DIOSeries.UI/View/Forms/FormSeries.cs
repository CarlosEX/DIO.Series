using DIOSeries.Bussines;
using DIOSeries.Database;
using DIOSeries.Database.Entities.Factory;
using DIOSeries.UI.Controls;
using DIOSeries.UI.Factory;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DIOSeries.UI {
    public partial class FormSeries : Form {

        private static readonly string _connectionString = ApplicationDatabase.ConnectionString;

        public FormSeries() {
            InitializeComponent();
            CreateSections();
            LoadEvents();
        }
       
        private void LoadEvents() {
            buttonReflash.Click += ButtonReload_Click;
            colorSliderWidth.ValueChanged += ColorSliderWidth_ValueChanged;
            colorSliderHeight.ValueChanged += ColorSliderHeigh_ValueChanged;
        }


        private IList<ISerie> GetListSeriesByGender(int id) {
            return SerieDatabaseFactory.Create(_connectionString).GetAllListSerie(id);
        }

        private void CreateSections() {

            this.panelSeries.Controls.Clear();
            
            IList<IGender> listGendersActive = GenderDatabaseFactory.Create(_connectionString).GetAllListGenders(FlagGender.Active);

            foreach (var item in listGendersActive) {
                BannerSeries bannerSeries = BannerSerieFactory.Create(item.Name, GetListSeriesByGender(item.Id)); 
                this.panelSeries.Controls.Add(bannerSeries);
            }
            
            SizeBannerHeight(Convert.ToInt32(colorSliderHeight.Value));
            SizeBannerWidth(Convert.ToInt32(colorSliderWidth.Value));
        }


        private void button5_Click(object sender, EventArgs e) {
            using (var f = new FormTempOpacitBackground(this)) {
                new FormCategorias().ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            using (var f = new FormTempOpacitBackground(this)) {
                new FormRegisterSerie().ShowDialog();
            }
        }

        private void ButtonReload_Click(object sender, EventArgs e) {
            CreateSections();
        }

        private void SizeBannerHeight(int heigh) {
            foreach (BannerSeries item in panelSeries.Controls) {
                item.Height = heigh;
            }

        }
        private void SizeBannerWidth(int width) {

            foreach (BannerSeries banner in panelSeries.Controls) {
                foreach (CardThumbSerie card in banner.panelCards.Controls) {
                    card.Width = width;
                }
            }
        }

        private void ColorSliderHeigh_ValueChanged(object sender, EventArgs e) {
            SizeBannerHeight(Convert.ToInt32(colorSliderHeight.Value));
        }

        private void ColorSliderWidth_ValueChanged(object sender, EventArgs e) {
            SizeBannerWidth(Convert.ToInt32(colorSliderWidth.Value));
        }
    }
}
