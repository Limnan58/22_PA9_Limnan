using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA9_Limnan
{
    public partial class Form1 : Form
    {
        public float currency;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void selectcurrency_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                currency = float.Parse(tb1.Text);
                if (radioButton1.Checked)
                {
                    tb2.Text = (currency * 0.74f).ToString();
                }
                else if (radioButton2.Checked)
                {
                    tb2.Text = (currency * 81.97f).ToString();
                }
                if (currency < 0)
                {
                    tb2.Text = ("Please enter a positive number.");
                }
            }
            catch
            {
                tb2.Text = ("Not a valid number");
            }
           
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tb1.Clear();
            tb2.Clear();

        }
    }
}
