using System.Drawing;
using System.Windows.Forms;

namespace DIOSeries.UI {
    public partial class FormTempOpacitBackground : Form {
        public FormTempOpacitBackground(Form form) {
            InitializeComponent();
            CustomForm(form);
        }

        private void CustomForm(Form form) {
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Opacity = 0.8;
            this.BackColor = Color.Black;
            this.ShowInTaskbar = false;
            this.ShowIcon = false;
            this.WindowState = FormWindowState.Maximized;
            this.Size = form.Size;
            this.Show();
        }
        public void OpenShowForm(Form form) {
            form.ShowDialog();
        }
        public void OpenShowDialogForm(Form form) {
            form.ShowDialog();
        }
    }
}
