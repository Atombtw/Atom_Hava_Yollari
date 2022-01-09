using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Denem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Nereden: " + comboBox1.Text + " " + "Nereye: " + comboBox2.Text + " " + "Tarih: " + dateTimePicker1.Text + " " + "Saat: " + maskedTextBox1.Text + " " + "Yolcu Ad Soyad: " + textBox3.Text + " " + "TC: " + maskedTextBox2.Text + " " + "Telefon: " + maskedTextBox3.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tut;
            tut = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = tut;
        }
    }
}
