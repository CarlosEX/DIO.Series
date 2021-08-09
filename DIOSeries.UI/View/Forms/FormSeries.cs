using DIOSeries.Bussines;
using DIOSeries.Database;
using DIOSeries.UI.Controls;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Windows.Forms;

namespace DIOSeries.UI {
    public partial class FormSeries : Form, INotifyCollectionChanged {
        
        private static readonly string _connectionString = ApplicationDatabase.ConnectionString;
        IList<IGender> listGenders = new List<IGender>();

        public FormSeries() {
            InitializeComponent();
            CreateSections();
            buttonReflash.Click += ButtonReload_Click;
            colorSliderWidth.ValueChanged += ColorSliderWidth_ValueChanged;
            colorSliderHeight.ValueChanged += ColorSliderHeigh_ValueChanged;

        }

        public event NotifyCollectionChangedEventHandler CollectionChanged;
        private DataTable LoadDataTableGenders() {
            var genderList = GenderDatabaseFactory.Create(_connectionString);
            string sql = $"SELECT * FROM genders WHERE gender_deleted = 0";
            return genderList.GetGenderDataTable(sql);
        }

        private void SizeHeightBanner() {
            
        }

        private void CreateSections() {
           
            var dataTable = LoadDataTableGenders();
            
            this.panelSeries.Controls.Clear();

            for (int i = 0; i < dataTable.Rows.Count; i++) {

                string nameFild = dataTable.Rows[i].Field<string>(1);
                var banner = new BannerSeries() { Dock = DockStyle.Top };
                banner.Name = nameFild;
                banner.SetNameGender(nameFild);

                this.panelSeries.Controls.Add(banner);
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
