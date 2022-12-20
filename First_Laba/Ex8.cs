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
    public partial class Ex8 : Form
    {
        public Ex8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string A1 = textBox1.Text;
            string B1 = textBox2.Text;
            string C1 = textBox3.Text;
            errorProvider1.Clear();
            int A; int B; int C;
            string check;
            try
            {
                textBox4.Clear();
                A = Convert.ToInt32(A1);
                B = Convert.ToInt32(B1);
                C = Convert.ToInt32(C1);
                if (A < B & B < C)
                {
                    check = "Неравенство верное";
                }
                else
                {
                    check = "Неравенство неверное"; 
                }
                textBox4.Text = check.ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show("Введено не число!");
            }
        }
    }
}
