using System.Windows.Forms;

namespace DIO.Series.View.Controls {
    public partial class ViewsVideo : UserControl {
       
        public string Views { get => buttonTextViews.Text; set => buttonTextViews.Text = value; }
        
        public ViewsVideo() {
            InitializeComponent();
        }
    }
}
