using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_Laba
{
    public partial class Ex38 : Form
    {
        public Ex38()
        {
            InitializeComponent();
        }
        int[,] matrix;
        int n = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            string number = textBox2.Text;
            errorProvider1.Clear();
            try
            {
                n = Convert.ToInt32(number);
                matrix = new int[n, n];
                textBox1.Clear();
                Random random = new Random();
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matrix[i, j] = random.Next(101);
                        textBox1.Text += matrix[i, j] + " ";
                    }
                    textBox1.Text += Environment.NewLine;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Введено не число!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            try
            {
                int rezerve;
                textBox3.Clear();
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i == j)
                        {
                            rezerve = matrix[i, j];
                            matrix[i, j] = matrix[i, n - 1 - j];
                            matrix[i, n - 1 - j] = rezerve;    
                        }
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        textBox3.Text += matrix[i, j] + " ";
                    }
                    textBox3.Text += Environment.NewLine;
                }

            }
            catch (System.FormatException)
            {
                MessageBox.Show("Введено не число!");

            }
        }
    }
}
