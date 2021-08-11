﻿using DIOSeries.Bussines;
using DIOSeries.Database;
using System;
using System.Data;
using System.Windows.Forms;

namespace DIOSeries.UI {
    public partial class FormCategorias : Form {
        
        private const string filterAllGender = "(0,1)";
        private const string filterActivateGender = "(0)";
        private const string filterDeletedeGender = "(1)";
        private static readonly string _connectionString  = ApplicationDatabase.ConnectionString;
        private readonly IGender _gender = GenderFactory.Create();

        public FormCategorias() {
            InitializeComponent();
            LoadDataGridView();
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
        private string ParametersFilterColumnDeleted() {

            string _filterColumnDeleted = "";

            if (radioButtonFilterAll.Checked) {
                _filterColumnDeleted = filterAllGender;
            }
            if (radioButtonFilterActive.Checked) {
                _filterColumnDeleted = filterActivateGender;
            }
            if (radioButtonFilterDeleted.Checked) {
                _filterColumnDeleted = filterDeletedeGender;
            }

            return _filterColumnDeleted;
        }

        private DataTable LoadDataTableGenders() {
            var genderList = GenderDatabaseFactory.Create(_connectionString);
            string sql = $"SELECT * FROM genders WHERE gender_deleted IN {ParametersFilterColumnDeleted()}";
            return genderList.GetGenderDataTable(sql);
        }
        private void LoadDataGridView() {
            DataGridViewGender.Load(dataGridView1, LoadDataTableGenders());
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
                LoadDataGridView();
            }
        }
        
        private void DeteteGender() {
            
            var result = MessageBox.Show("Confirma a exclusão dessa categoria?", "Deletar Categoria", buttons: MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes) {

                var idGender = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                _gender.Id = idGender;
                _gender.Deleted = 1;

                var genderDatabase = GenderDatabaseFactory.Create(_connectionString, _gender);
                genderDatabase.Delete();

                LoadDataGridView();
            }
        }

        private void EditeNameGender(string name) {

            _gender.Name = name;
            _gender.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            var genderDatabase = GenderDatabaseFactory.Create(_connectionString, _gender);
            genderDatabase.Update();

            new FormBoxAlert().Show(IconBox.Success);
     
            LoadDataGridView();
        }
        #endregion

        #region Events
       
        private void DeletedGender_Click(object sender, EventArgs e) {
            DeteteGender();
        }
        private void AddGender_Click(object sender, EventArgs e) {
            AddGender();
        }
       
        private void RadioButtonFilter_Changed(object sender, EventArgs e) {
            LoadDataGridView();
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
