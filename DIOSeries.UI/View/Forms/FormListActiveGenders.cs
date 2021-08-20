using DIOSeries.Database;
using System;
using System.Data;
using System.Windows.Forms;

namespace DIOSeries.UI {
    public partial class FormListActiveGenders : Form {
        
        private static readonly string _connectionString = ApplicationDatabase.ConnectionString;
        private string _nameGender;
        private string _idGender;
        private bool _confirmed;

        public string NameGender { get => _nameGender; set => _nameGender = value; }
        public string IdGender { get => _idGender; set => _idGender = value; }
        public bool Confirmed { get => _confirmed; set => _confirmed = value; }

        public FormListActiveGenders() {
            InitializeComponent();
            LoadDataGridView();
            _confirmed = false;
            this.buttonCancel.Click += ButtonCancel_Click;
            this.buttonConfirmed.Click += ButtonConfirmed_Click;
        }

        private void LoadDataGridView() {
            DataGridViewGender.Load(
                dataGridView1,
                GenderDatabaseFactory.Create(_connectionString).GetAllListGenders(FlagGender.Active));
            LoadQuantityGender();
        }

        private void LoadQuantityGender() {
           textBoxTotalGender.Text = this.dataGridView1.RowCount.ToString();
        }

        private void SetValuesDataGridViewInPropertyes() {
            string name = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
            string id = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            _idGender = id;
            _nameGender = name;
            _confirmed = true;
            this.Close();
        }

        private void DataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            SetValuesDataGridViewInPropertyes();
        }

        private void ButtonConfirmed_Click(object sender, EventArgs e) {
            SetValuesDataGridViewInPropertyes();
        }
        private void ButtonCancel_Click(object sender, EventArgs e) {
            _confirmed = false;
            this.Close();
        }
    }
}
