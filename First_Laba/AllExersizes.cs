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
    public partial class AllExersizes : Form
    {
        public AllExersizes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ex63 ex63 = new Ex63();
            ex63.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ex38 ex38 = new Ex38();
            ex38.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ex33 ex33 = new Ex33();
            ex33.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ex13 ex13 = new Ex13();
            ex13.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ex8 ex8 = new Ex8();
            ex8.ShowDialog();
        }
    }
}
