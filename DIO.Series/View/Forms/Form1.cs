using System;
using System.Windows.Forms;

namespace DIO.Series.View {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            this.buttonLogin.Click += ButtonLogin_Click;
            
        }
        private void ButtonLogin_Click(object sender, EventArgs e) {
            new FormLogin().ShowDialog();
        }
    }
}
