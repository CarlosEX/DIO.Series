using DIOSeries.Bussines;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DIOSeries.UI {
    public class DataGridViewGender {
        public static void Load(DataGridView dataGridView, IList<IGender> listGender) {
            dataGridView.DataSource = listGender;
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        
    }
}
