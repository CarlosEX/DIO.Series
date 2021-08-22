using DIOSeries.Bussines;
using DIOSeries.Database;
using System;
using System.Windows.Forms;

namespace DIOSeries.UI {
    public partial class FormCategorias : Form {
        
        private static readonly string _connectionString  = ApplicationDatabase.ConnectionString;
        private readonly IGender _gender = GenderFactory.Create();
        private FlagGender _flagGender = FlagGender.Active;

        public FormCategorias() {
            InitializeComponent();
            LoadDataGridView(_flagGender);
            LoadEvents();
        }

        #region Methods
        private void LoadEvents() {
            this.deletarCategoriaToolStripMenuItem.Click += DeletedGender_Click;
            this.buttonAddGender.Click += AddGender_Click;
            this.editarToolStripMenuItem.Click += OpenFormRenameGender_Click;
            this.radioButtonFilterAll.CheckedChanged += RadioButtonFilter_Changed;
            this.radioButtonFilterDeleted.CheckedChanged += RadioButtonFilter_Changed;
            this.radioButtonFilterActive.CheckedChanged += RadioButtonFilter_Changed;
        }

        private FlagGender ParametersFilterColumnDeleted() {

            if (radioButtonFilterAll.Checked) {
                _flagGender = FlagGender.All;
            }
            if (radioButtonFilterActive.Checked) {
                _flagGender = FlagGender.Active;
            }
            if (radioButtonFilterDeleted.Checked) {
                _flagGender = FlagGender.Deleted;
            }

            return _flagGender;
        }


        private void LoadDataGridView(FlagGender flagGender) {
            
            DataGridViewGender.Load(
                dataGridView1, 
                GenderDatabaseFactory.Create(_connectionString).GetAllListGenders(flagGender)
            );

            LoadQuantityGender();

        }

        
        private void LoadQuantityGender() {
            textBoxTotalGender.Text = this.dataGridView1.RowCount.ToString();
        }

        private void AddGender() {

            var nameGender = textBox1.Text;

            if (string.IsNullOrWhiteSpace(nameGender)) {
                new FormBoxAlert().Show(IconBox.Erro, "Campo [nome] é obrigatório");
                textBox1.Select();
            }
            else {
                _gender.Name = nameGender;

                var genderDatabase = GenderDatabaseFactory.Create(_connectionString, _gender);
                genderDatabase.Insert();
                new FormBoxAlert().Show(IconBox.Success, "Categoria criada com sucesso!" );
                LoadDataGridView(_flagGender);
            }
        }
        
        private void DeleteGender() {
            
            var result = MessageBox.Show("Confirma a exclusão dessa categoria?", "Deletar Categoria", buttons: MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes) {

                var idGender = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                _gender.Id = idGender;
                _gender.Deleted = 1;

                var genderDatabase = GenderDatabaseFactory.Create(_connectionString, _gender);
                genderDatabase.Delete();

                LoadDataGridView(_flagGender);
            }
        }

        private void EditeNameGender(string name) {

            _gender.Name = name;
            _gender.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            var genderDatabase = GenderDatabaseFactory.Create(_connectionString, _gender);
            genderDatabase.Update();

            new FormBoxAlert().Show(IconBox.Success);
     
            LoadDataGridView(_flagGender);
        }
        #endregion

        #region Events
       
        private void DeletedGender_Click(object sender, EventArgs e) {
            DeleteGender();
        }
        private void AddGender_Click(object sender, EventArgs e) {
            AddGender();
        }
       
        private void RadioButtonFilter_Changed(object sender, EventArgs e) {
            ParametersFilterColumnDeleted();
            LoadDataGridView(_flagGender);
        }
        private void OpenFormRenameGender_Click(object sender, EventArgs e) {

            try {
                var nameGender = dataGridView1.CurrentRow.Cells[1].Value.ToString();

                using (var form = new FormEditeGender(nameGender)) {
                    form.ShowDialog();

                    if (form.GetState()) {
                        EditeNameGender(form.NameGender);
                    }
                }
            }
            catch {
                new FormBoxAlert().Show(IconBox.Erro, "Error ao renomear categoria");
            }
        }
        #endregion
    }
}
