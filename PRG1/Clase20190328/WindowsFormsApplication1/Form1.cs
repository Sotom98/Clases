using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e) {
            if (checkBox1.Checked == true) {
                label1.Text = "Selecciono el check 1";
            }

            if (checkBox2.Checked == true) {
                label1.Text = "Selecciono el check 2";
            }

            if (checkBox3.Checked == true) {
                label1.Text = "Seleciono el check 3";
            }
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) {
            checkBox1.Checked = false;
            checkBox3.Checked = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e) {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e) {
            if (radioButton1.Checked == true) {
                label1.Text = "Suma";
            }

            if (radioButton2.Checked == true) {
                label1.Text = "Resta";
            }

            if (radioButton3.Checked == true) {
                label1.Text = "Multiplicacion";
            }

            if (radioButton4.Checked == true) {
                label1.Text = "Division";
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        private void label1_Click(object sender, EventArgs e) {
            label1.Text = "Ha dado un click";
        }

        private void label1_DoubleClick(object sender, EventArgs e) {
            label1.Text = "Ha dado dos clicks";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            Form1 f1 = new Form1();

            if (comboBox1.SelectedIndex == 0) {
                label1.BackColor = Color.Green;
            }

            if (comboBox1.SelectedIndex == 1) {
                label1.BackColor = Color.Yellow;
            }

            if (comboBox1.SelectedIndex == 2) {
                label1.BackColor = Color.Red;
            }

            if (comboBox1.SelectedIndex == 3) {
                BackColor = Color.Gray;
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            for (int i = 0; i < 10; i++) {
                comboBox1.Items.Add(i.ToString());
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e) {
            textBox2.Text = textBox1.Text;
        }
    }
}
