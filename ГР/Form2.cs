using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ГР
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s;
            int i;
            Class1 fr = new Class1();
            if (radioButton1.Checked)
            {
                i = int.Parse(textBox3.Text);

                s = fr.CodeEncode(textBox1.Text, i);
                textBox2.Text = s;
            }

            if (radioButton2.Checked)
            {
                i = 5;
                s = fr.CodeEncode(textBox1.Text, i);
                textBox2.Text = s;
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllText(filename, textBox2.Text);
            MessageBox.Show("Файл сохранен");
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строку
            string fileText = System.IO.File.ReadAllText(filename);
            textBox1.Text = fileText;
            MessageBox.Show("Файл открыт");
        }
    }
}
