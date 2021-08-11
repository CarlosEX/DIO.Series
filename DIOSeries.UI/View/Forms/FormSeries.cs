using DIOSeries.Bussines;
using DIOSeries.Database;
using DIOSeries.Database.Entities.Factory;
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
        public event NotifyCollectionChangedEventHandler CollectionChanged;

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

        private DataTable GetListListGendersActivate() {
            var genderList = GenderDatabaseFactory.Create(_connectionString);
            string sql = $"SELECT * FROM genders WHERE gender_deleted = 0";
            return genderList.GetGenderDataTable(sql);
        }

        private DataTable LoadDataTableSeries() {
            var seriesList = SerieDatabaseFactory.Create(_connectionString);
            string sql = $"SELECT * FROM series";
            return seriesList.GetSerieDataTable(sql);
        }

        private List<ISerie> CreateCardSerie() {

            List<ISerie> listSeries = new List<ISerie>();

            using (var dataTable = LoadDataTableSeries()) {

                for (int i = 0; i < dataTable.Rows.Count; i++) {
                    int id = Convert.ToInt32(dataTable.Rows[i]["serie_id"]);
                    string title = dataTable.Rows[i]["serie_title"].ToString();
                    string description = dataTable.Rows[i]["serie_description"].ToString();
                    string year = dataTable.Rows[i]["serie_year"].ToString();
                    int deleted = Convert.ToInt32(dataTable.Rows[i]["serie_deleted"]);
                    string image = dataTable.Rows[i]["serie_image"].ToString();
                    string video = dataTable.Rows[i]["serie_video"].ToString();
                    int views = Convert.ToInt32(dataTable.Rows[i]["serie_views"]);
                    int gender_id = Convert.ToInt32(dataTable.Rows[i]["gender_id"]);

                    var serie = new Serie(title, new Gender() { Name = "Serie", Id = 2 }) {
                        Id = id,
                        Description = description,
                        Year = year,
                        Deleted = StateRegister.Active,
                        Image = image,
                        Video = video,
                        Views = views,
                        Gender = new Gender() { Id = gender_id }
                    };

                    listSeries.Add(serie);
                }
            }
            return listSeries;
        }

        private void CreateSections() {

            this.panelSeries.Controls.Clear();

            using (var dataTable = GetListListGendersActivate()) {

                for (int i = 0; i < dataTable.Rows.Count; i++) {

                    var nameGender = dataTable.Rows[i].Field<string>(1);
                    //var idGender = dataTable.Rows[i].Field<int>(0);

                    this.panelSeries.Controls.Add(new BannerSeries(nameGender, CreateCardSerie()) { Dock = DockStyle.Top });
                }
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
