using System;
using System.Drawing;
using System.Windows.Forms;

namespace DIOSeries.UI {
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
