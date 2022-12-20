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
    public partial class Ex63 : Form
    {
        public Ex63()
        {
            InitializeComponent();
        }
        int[,] matrix = new int[2, 2];
        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    matrix[i, j] = random.Next(101);
                }
            }
            textBox1.Text = matrix[0, 0].ToString();
            textBox2.Text = matrix[0, 1].ToString();
            textBox3.Text = matrix[1, 0].ToString();
            textBox4.Text = matrix[1, 1].ToString();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            int determinant = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            textBox5.Text = determinant.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int multiplication1 = matrix[0, 0] * matrix[1, 1];
            textBox6.Text = multiplication1.ToString();
            int multiplication2 = matrix[0, 1] * matrix[1, 0];
            textBox7.Text = multiplication2.ToString();
        }


    }
}
