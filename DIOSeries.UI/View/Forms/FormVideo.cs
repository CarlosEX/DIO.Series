using System.Windows.Forms;

namespace DIOSeries.UI {
    public partial class FormVideo : Form {
        public FormVideo(string url) {
            InitializeComponent();
            this.windowVideoPlayer1.URL(url);
            //this.windowVideoPlayer1.fulls
        }
    }
}
