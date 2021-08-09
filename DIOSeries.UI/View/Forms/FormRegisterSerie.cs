using DIOSeries.Bussines;
using DIOSeries.Database.Entities;
using DIOSeries.UI.Controls;
using System.Windows.Forms;

namespace DIOSeries.UI {
    public partial class FormRegisterSerie : Form {

        private static readonly string _connectionString = ApplicationDatabase.ConnectionString;
        
        public FormRegisterSerie() {
            InitializeComponent();
            //this.pictureBox2.Image = 
        }

        private void LoadSeries() {
            for (int i = 0; i < 10; i++) {
                this.Controls.Add(new CardThumbSerie() ) ;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e) {

        }

        private void buttonSave_Click(object sender, System.EventArgs e) {
            var title = textBoxTitle.Text;
            var gender = new Gender() { Id = 5 };

            var x = SerieFactoy.Create(title, gender);
           
            
            var dataBase = new SerieDatabase(_connectionString, x);
            dataBase.Insert();
        }
    }
}
