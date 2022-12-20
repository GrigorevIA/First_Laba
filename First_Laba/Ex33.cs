using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_Laba
{
    public partial class Ex33 : Form
    {
        public Ex33()
        {
            InitializeComponent();
        }
        
        int[,] matrix;

        private void button1_Click(object sender, EventArgs e)
        {
            matrix = new int[18, 24];
            textBox1.Clear();
            Random random = new Random();
            for (int i = 0; i < 18; i++)
            {
                for (int j = 0; j < 24; j++)
                {
                    matrix[i, j] = random.Next(101);
                    textBox1.Text += matrix[i, j] + " ";
                }
                textBox1.Text += Environment.NewLine;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string number1 = textBox2.Text;
            string number2 = textBox3.Text;
            int i; int j;
            errorProvider1.Clear();
            try
            {
                i = Convert.ToInt32(number1);
                j = Convert.ToInt32(number2);
                textBox4.Clear();
                for (int i1 = 0; i1 < 18; i1++)
                {
                    for (int j1 = 0; j1 < 24; j1++)
                    {
                        if (j1 == i - 1)
                        {
                            textBox4.Text += matrix[i1, j - 1] + " ";
                        }
                        else if (j1 == j - 1)
                        {
                            textBox4.Text += matrix[i1, i - 1] + " ";
                        }
                        else
                        {
                            textBox4.Text += matrix[i1, j1] + " ";
                        }
                    }
                    textBox4.Text += Environment.NewLine;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Введено не число!");
            }
        }
    }
}
