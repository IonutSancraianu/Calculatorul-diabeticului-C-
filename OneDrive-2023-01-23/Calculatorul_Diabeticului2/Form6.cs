using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculatorul_Diabeticului2
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void calculeazacarbo_Click(object sender, EventArgs e)
        {
            double n = double.Parse(gpaine.Text);
            double m = double.Parse(chpaine.Text);
            //selectati procentul de carbohidrati in comboBox
            double c;
            c = (n * m) / 100;
            label5.Text = c.ToString("F2");
        }

        private void calc_lipide_Click(object sender, EventArgs e)
        {
            double n = double.Parse(gpaine.Text);
            double m = double.Parse(chpaine.Text);
            //selectati procentul de lipide in comboBox
            double c;
            c = (n * m) / 100;
            textBox4.Text = c.ToString("F2");
        }

        private void calc_proteine_Click(object sender, EventArgs e)
        {
            double n = double.Parse(gpaine.Text);
            double m = double.Parse(chpaine.Text);
            //selectati procentul de proteine in comboBox
            double c;
            c = (n * m) / 100;
            textBox5.Text = c.ToString("F2");
        }

        private void calc_calorii_Click(object sender, EventArgs e)
        {
            double a = 4 * double.Parse(textBox5.Text);
            double b = 4 * double.Parse(label5.Text);
            double c = 9 * double.Parse(textBox4.Text);
            textBox6.Text = "" + (a + b + c);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
                chpaine.Text = "" + 61;
            if (comboBox1.SelectedIndex == 1)
                chpaine.Text = "" + 31;
            if (comboBox1.SelectedIndex == 2)
                chpaine.Text = "" + 5;
        }

        private void calc_dozadeinsulina_Click(object sender, EventArgs e)
        {
            double n = double.Parse(textBox2.Text);
            double m = double.Parse(label5.Text);
            double c;
            c = m / n;
            if (checkBox1.CheckState == CheckState.Checked)
                c = c + 1;
            if (checkBox2.CheckState == CheckState.Checked)
            {
                c = c - 1;
                Form8 x=new Form8();
                x.Show();
            }
            textBox7.Text = c.ToString("F1");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox2.Clear();
            chpaine.Clear();
            gpaine.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            label5.Text = "";
        }

    }
}
