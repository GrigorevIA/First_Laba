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
    public partial class Ex13 : Form
    {
        public Ex13()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string number = textBox1.Text;
            errorProvider1.Clear();
            int summa = 0;
            int cost = 0;
            try
            {
                textBox2.Clear();
                summa = Convert.ToInt32(number);
                if (summa > 1000)
                {
                    cost = summa * 9/10;
                }
                else
                {
                    cost = summa;
                }
                textBox2.Text = cost.ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show("Введено не число!");
            }
        }
    }
}
