using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void progressBar1_Click(object sender, EventArgs e) {
            InitializeComponent();
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
            progressBar1.Step = 4;
        }

        private void button1_Click(object sender, EventArgs e) {
            progressBar1.PerformStep();

            if (progressBar1.Value == 100) {
                Form2 fm2 = new Form2();
                fm2.Show();

            }
        }

        private void button2_Click(object sender, EventArgs e) {

        }

        private void timer1_Tick(object sender, EventArgs e) {
            progressBar1.PerformStep();
        }

        private void button5_Click(object sender, EventArgs e) {
            Form2 fm2 = new Form2();

            fm2.Show();

        }

        private void timer2_Tick(object sender, EventArgs e) {
            button2.BackColor = Color.Red;
        }
    }
}
