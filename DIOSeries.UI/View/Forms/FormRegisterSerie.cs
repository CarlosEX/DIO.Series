using DIOSeries.Bussines;
using DIOSeries.Database.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DIOSeries.UI {
    public partial class FormRegisterSerie : Form {

        private static readonly string _connectionString = ApplicationDatabase.ConnectionString;
        private readonly ISerie _serie;

        public FormRegisterSerie() {
            InitializeComponent();
            LoadEvents();
            LoadImageThumDefault();
        }
        public FormRegisterSerie(ISerie serie) {
            InitializeComponent();
            LoadEvents();
            _serie = serie;
            LoadDetailsSerie();
        }

        private void LoadDetailsSerie() {
            this.textBoxCustomDescription.Text = _serie.Description;
            this.textBoxCustomGenderName.Text = _serie.Gender.Name;
            this.textBoxCustomGenderId.Text = _serie.Gender.Id.ToString();
            this.textBoxCustomTitle.Text = _serie.Title;
            this.textBoxCustomYear.Text = _serie.Year;
            this.pictureBoxThumb.Image = Image.FromFile(_serie.Image);
            this.textBoxPathVideo.Text = _serie.Video;
            LoadVideo();
        }

        private void LoadEvents() {
            this.radioButtonImageNormal.CheckedChanged += RadioButtonImage_ChackedChanged;
            this.radioButtonImageZoom.CheckedChanged += RadioButtonImage_ChackedChanged;
            this.radioButtonImageStrech.CheckedChanged += RadioButtonImage_ChackedChanged;
            this.pictureBoxThumb.DoubleClick += ImageThumb_DoubleClick;
            this.buttonOpenListSeries.Click += OpenFormListGenders_Click;
            this.buttonOpenFileVideo.Click += ButtonOpenFileVideo_Click;
            this.buttonOpenFileImage.Click += ImageThumb_DoubleClick;
            this.buttonSplitPanelVideoImage.Click += ButtonSplitPanelVideoImage_Click;
        }

        private void LoadImageThumDefault() {
            this.pictureBoxThumb.Image = Properties.Resources.image_thumb_default_series;
        }

        private void SaveSerie() {

            if (IsValidateFilds()) {

                try {

                    int generId = Convert.ToInt32(textBoxCustomGenderId.Text);
                    string titleSerie = textBoxCustomTitle.Text;
                    string descriptionSerie = textBoxCustomDescription.Text;
                    string yearSerie = textBoxCustomYear.Text;
                    string pathImage = textBoxPathImage.Text;
                    string pathVideo = textBoxPathVideo.Text;
                    string nameGender = textBoxCustomGenderName.Text;

                    IGender gender = GenderFactory.Create(generId, nameGender);
                    
                    ISerie serie = SerieFactoy.Create(titleSerie, gender);
                        serie.Description = descriptionSerie;
                        serie.Year = yearSerie;
                        serie.Image = pathImage;
                        serie.Video = pathVideo;

                    var dataBase = new SerieDatabase(_connectionString, serie);
                        dataBase.Insert();

                    new FormBoxAlert().Show(IconBox.Success, "Serie, salva com sucesso!");

                }
                catch (Exception) {
                    new FormBoxAlert().Show(IconBox.Erro, "Error, no salvamento da série.");
                }
            }

            if (!IsValidateFilds())
                new FormBoxAlert().Show(IconBox.Erro, "Campos obrigatórios ausentes");

        }

        private void ClearFilds() {
            textBoxCustomDescription.Text = string.Empty;
            textBoxCustomGenderId.Text = string.Empty;
            textBoxCustomTitle.Text = string.Empty;
            textBoxCustomYear.Text = string.Empty;
            textBoxCustomGenderName.Text = string.Empty;
            pictureBoxThumb.Image = Properties.Resources.image_thumb_default_series;
            windowVideoPlayer1.Dispose();
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

        private void buttonSave_Click(object sender, EventArgs e) {
            SaveSerie();
            ClearFilds();
        }

        private void OpenFormListGenders_Click(object sender, EventArgs e) {
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

        private void ImageThumb_DoubleClick(object sender, EventArgs e) {

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

        private void RadioButtonImage_ChackedChanged(object sender, EventArgs e) {
            StylePictureBox();
        }

        private void button1_Click(object sender, EventArgs e) {
            CustonOrientationSplitContainer(splitContainer1);
        }
        private void ButtonSplitPanelVideoImage_Click(object sender, EventArgs e) {
            CustonOrientationSplitContainer(splitContainer2);
        }
       
        private void CustonOrientationSplitContainer(SplitContainer splitContainer) {
            if (splitContainer.Orientation == Orientation.Horizontal) {
                splitContainer.Orientation = Orientation.Vertical;
            }
            else {
                splitContainer.Orientation = Orientation.Horizontal;
            }
        }

        private void ButtonOpenFileVideo_Click(object sender, EventArgs e) {
            using (var result = new OpenFileDialog()) {
                result.Filter = "Video (*.mp4;*.wav;)|*.mp4;*.wav;";

                if (result.ShowDialog() == DialogResult.OK) {
                    string fileName = result.FileName;
                    textBoxPathVideo.Text = fileName;
                    windowVideoPlayer1.URL(fileName);
                }
            }
        }

        private void LoadVideo() {
            if(!string.IsNullOrEmpty(_serie.Video))
                windowVideoPlayer1.URL(_serie.Video);
        }

        public void Play(AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer) {
            axWindowsMediaPlayer.Ctlcontrols.play();
        }

        public void Pause(AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer) {
            axWindowsMediaPlayer.Ctlcontrols.pause();
        }
    }
}
