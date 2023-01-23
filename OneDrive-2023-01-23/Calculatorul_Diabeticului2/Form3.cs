﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculatorul_Diabeticului2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void gpaine_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void calc_calorii_Click(object sender, EventArgs e)
        {
            double a = 4 * double.Parse(textBox5.Text);
            double b = 4 * double.Parse(label5.Text);
            double c = 9 * double.Parse(textBox4.Text);
            textBox6.Text = "" + (a + b + c);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

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
                c = c - 0.5;
            textBox7.Text = c.ToString("F1");
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
                chpaine.Text = "" + 25;
            if (comboBox1.SelectedIndex == 1)
                chpaine.Text = "" + 1;
            if (comboBox1.SelectedIndex == 2)
                chpaine.Text = "" + 5;
        }

        private void chpaine_TextChanged(object sender, EventArgs e)
        {

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
