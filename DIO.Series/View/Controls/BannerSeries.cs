using DIO.Series.View.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DIO.Series.View.Controls {
    public partial class BannerSeries : UserControl {

        private static Size _sizeCard = new Size(420,270);
        private static Padding _paddingCard = new Padding(10, 0, 0, 0);

        //imagesExamples
        private static string imagePath1 = @"C:\Users\creat\Desktop\6497998efb875d6b8704b1baf32cedf9.jpg";
        private static string imagePath2 = @"C:\Users\creat\Desktop\OIP.jpg";
        private static string imagePath3 = @"C:\Users\creat\Desktop\dd1ae3fc5a356fcbc3d8c478e4f18829.jpg";
        private static string imagePath4 = @"C:\Users\creat\Downloads\Design sem nome (1).jpg";

        public BannerSeries() {
            InitializeComponent();
            ListCardThumb();
        }

        private void CardThumb_ButtonClick(object sender, EventArgs e) {
            new FormVideo().Show();
        }

        private void ListCardThumb() {

            List<CardThumbSerie> listCards = new List<CardThumbSerie>() {
               new CardThumbSerie(imagePath1){ Dock = DockStyle.Left, Size = _sizeCard, Padding = _paddingCard },
               new CardThumbSerie(imagePath2){ Dock = DockStyle.Left, Size = _sizeCard, Padding = _paddingCard },
            };

            var cardd = new CardThumbSerie(imagePath4) { Dock = DockStyle.Left, Size = _sizeCard, Padding = _paddingCard };
            cardd.ButtonClick += CardThumb_ButtonClick;
            this.panelCards.Controls.Add(cardd);

            foreach (var card in listCards) {
                this.panelCards.Controls.Add(card);
            }
        }
    }
}
