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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
 
        }

        private void Paine_Click(object sender, EventArgs e)
        {
            Form2 x = new Form2();
            x.Show();
        }

        private void Paste_Click(object sender, EventArgs e)
        {
            Form3 x = new Form3();
            x.Show();
        }

        private void carne_alba_Click(object sender, EventArgs e)
        {
            Form4 x = new Form4();
            x.Show();
        }

        private void Ciocolata_Click(object sender, EventArgs e)
        {
            Form6 x = new Form6();
            x.Show();
        }

        private void Mere_Click(object sender, EventArgs e)
        {
            Form5 x = new Form5();
            x.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}
