using System.Data;
using System.Windows.Forms;

namespace DIOSeries.UI {
    public class DataGridViewGender {
        public static void Load(DataGridView dataGridView, DataTable dataTable) {
            //dataGridView.DataSource = null;
            dataGridView.DataSource = dataTable;
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
