using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_2_zad_1
{
    public partial class Form1 : Form
    {
        float wagas, wagai;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            wagas = float.Parse(textBox1.Text) - 100;
            if (radioButton1.Checked)
            {
                wagai = (float)(wagas * 0.85);
            }
            else if (radioButton2.Checked)
            {
                wagai = (float)(wagas * 0.9);
            }

            if (checkBox1.Checked && checkBox2.Checked)
            {
                label4.Text = "Waga standardowa = " + wagas.ToString() + " " + "Waga idealna = " + wagai.ToString(); ;
            }
            else if (checkBox1.Checked)
            {
                label4.Text = "Waga standardowa = " + wagas.ToString();
            }
            else if(checkBox2.Checked)
            {
                label4.Text = "Waga idealna = " + wagai.ToString();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
