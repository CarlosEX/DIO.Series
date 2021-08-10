using DIOSeries.Bussines;
using DIOSeries.Database.Entities;
using DIOSeries.UI.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DIOSeries.UI {
    public partial class FormRegisterSerie : Form {

        private static readonly string _connectionString = ApplicationDatabase.ConnectionString;
        
        public FormRegisterSerie() {
            InitializeComponent();
            LoadEvents();
            this.pictureBoxThumb.Image = Properties.Resources.image_thumb_default_series;
        }

        private void LoadEvents() {
            this.radioButtonImageNormal.CheckedChanged += RadioButtonImage_ChackedChanged;
            this.radioButtonImageZoom.CheckedChanged += RadioButtonImage_ChackedChanged;
            this.radioButtonImageStrech.CheckedChanged += RadioButtonImage_ChackedChanged;
            this.pictureBoxThumb.DoubleClick += ImageThumb_DoubleClick;
            this.buttonOpenListSeries.Click += OpenFormListGenders_Click;
        }

        private void LoadSeries() {
            for (int i = 0; i < 10; i++) {
                this.Controls.Add(new CardThumbSerie() ) ;
            }
        }

        private void SaveNewSerie() {

            if (IsValidateFilds()) {
                SaveSerie();
            }
            if (!IsValidateFilds()) {
                new FormBoxAlert().ShowError("Campos obrigatórios ausentes");
            }
        }

        private void SaveSerie() {
            var gender = GenderFactory.Create();
            gender.Id = Convert.ToInt32(textBoxCustomGenderId.Text);
            gender.Name = textBoxCustomGenderName.Text;

            string titleSerie = textBoxCustomTitle.Text;
            string descriptionSerie = textBoxCustomDescription.Text;
            string yearSerie = textBoxCustomYear.Text;
            string pathImage = textBoxPathImage.Text;

            var newSerie = SerieFactoy.Create(titleSerie, gender);
            newSerie.Description = descriptionSerie;
            newSerie.Year = yearSerie;
            newSerie.Image = pathImage;

            var dataBase = new SerieDatabase(_connectionString, newSerie);
            dataBase.Insert();
            new FormBoxAlert().ShowSuccess();
        }

        private bool IsValidateFilds() {

            bool isValidade = true;

            IList<string> filds = new List<string>();
            filds.Add(textBoxCustomTitle.Text);
            filds.Add(textBoxCustomGenderName.Text);
            
            foreach (var item in filds) {
                if (string.IsNullOrWhiteSpace(item))
                    isValidade = false;
            }
            return isValidade;
        }

        private void buttonSave_Click(object sender, System.EventArgs e) {
            SaveNewSerie();
        }

        private void OpenFormListGenders_Click(object sender, System.EventArgs e) {
            using (var f = new FormTempOpacitBackground(this)) {
                using (var form = new FormListActiveGenders()) {
                    form.ShowDialog();
                    if (form.Confirmed) {
                        textBoxCustomGenderName.Text = form.NameGender;
                        textBoxCustomGenderId.Text = form.IdGender;
                    }
                }
            }
        }

        private void ImageThumb_DoubleClick(object sender, System.EventArgs e) {

            using (var result = new OpenFileDialog()) {
                result.Filter = "Imagen (*.png;*.jpg;.jpeg;*.gif)|*.png;*.jpg;*.jpeg;*.gif";

                if (result.ShowDialog() == DialogResult.OK) {
                    string fileName = result.FileName;
                    pictureBoxThumb.Image = Image.FromFile(fileName);
                    textBoxPathImage.Text = fileName;
                }
            }
        }

        private void StylePictureBox() {
            if (radioButtonImageStrech.Checked) {
                pictureBoxThumb.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (radioButtonImageZoom.Checked) {
                pictureBoxThumb.SizeMode = PictureBoxSizeMode.Zoom;
            }
            if (radioButtonImageNormal.Checked) {
                pictureBoxThumb.SizeMode = PictureBoxSizeMode.Normal;
            }
        }

        private void RadioButtonImage_ChackedChanged(object sender, System.EventArgs e) {
            StylePictureBox();
        }

        private void button1_Click(object sender, EventArgs e) {
            if(splitContainer1.Orientation == Orientation.Horizontal) {
                splitContainer1.Orientation = Orientation.Vertical;
            }
            else {
                splitContainer1.Orientation = Orientation.Horizontal;
            }
        }

    }
}
