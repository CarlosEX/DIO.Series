using System;
using System.Windows.Forms;

namespace DIOSeries.UI {
    public partial class FormEditeGender : Form {
        
        private bool _confirmedEdit;
        private string _nameGender;
       
        public string NameGender { get => _nameGender; set => _nameGender = value; }
        public FormEditeGender(string text) {
            InitializeComponent();
            this.textBoxNameGender.Text = text;
            this.buttonCancel.Click += ButtonCancel_Click;
            this.buttonUpdate.Click += ButtonUpadate_Click;
            this.FormClosed += Form_Closed;
        }
        
        public bool GetState() {
            return _confirmedEdit;
        }

        private void ButtonUpadate_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(textBoxNameGender.Text)) {
                MessageBox.Show("Informe o nome da categoria!", "Campo obrigatório", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Warning);
                textBoxNameGender.Select();
            }
            else {
                _confirmedEdit = true;
                _nameGender = textBoxNameGender.Text;
                this.Close();
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e) {
            _confirmedEdit = false;
            this.Close();
        }
        private void Form_Closed(object sender, EventArgs e) {
            //_confirmedEdit = false;
        }
    }
}
