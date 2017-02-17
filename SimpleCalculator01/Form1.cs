using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*簡化後
          private void button1_Click(object sender, EventArgs e)
        {
            calculate(true);
        }
         private void button2_Click(object sender, EventArgs e)
        {
            calculate(false);
        }
        private void calculate(bool add)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            if (add)
            {
                label1.Text = (x + y).ToString();
            }
            else
            {
                label1.Text = (x - y).ToString();
            }


        }*/
        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            label1.Text = (x + y).ToString();//ToString用意是轉換成字串

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            label1.Text = (x - y).ToString();
        }
    }
}
