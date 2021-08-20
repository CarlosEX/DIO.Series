using DIOSeries.Bussines;
using DIOSeries.UI.Factory;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DIOSeries.UI.Controls {
    public partial class BannerSeries : UserControl {

        private readonly static Size _sizeCard = new Size(320,100);
        private readonly static Padding _paddingCard = new Padding(7, 0, 0, 0);
        private readonly IList<ISerie> _listSeries;

        public BannerSeries(string nameGender, IList<ISerie> listSeries) {
            InitializeComponent();

            this.Dock = DockStyle.Top;

            _listSeries = listSeries;
            SetNameGender(nameGender);
            GenerateCard();
        }

        private void SetNameGender(string name) {
            labelNameGender.Text = name;
        }

        private void GenerateCard() {
            foreach (ISerie item in _listSeries) {
                var card = CardThumbSerieFactory.Create(item);
                    card.Dock = DockStyle.Left;
                    card.Size = _sizeCard;
                    card.Padding = _paddingCard;

                this.panelCards.Controls.Add(card);
            }
        }
    }
}
