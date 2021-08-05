using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIO.Series.View.Forms {
    public partial class FormCategorias : Form {
        public FormCategorias() {
            InitializeComponent();
            var lin = new DataGridViewRow();
            lin.Height = 32;
            this.dataGridView1.Rows.Clear();
            this.dataGridView1.Rows.Add(lin);
            this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows[0].Cells[0].Value = "Ação";
            this.dataGridView1.Rows[1].Cells[0].Value = "Ficção Científica";
            this.dataGridView1.Rows[2].Cells[0].Value = "Desenhos e Animes";
        }
    }
}
