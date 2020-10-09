using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetAnswer delegateAnswer = new GetAnswer(Formula.getSum);

            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);

            MessageBox.Show(delegateAnswer(num1, num2).ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetAnswer delegateAnswer1 = new GetAnswer(Formula.getDifference);
            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);

            MessageBox.Show(delegateAnswer1(num1, num2).ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetAnswer delegateAnswer2 = new GetAnswer(Formula.getProduct);
            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);

            MessageBox.Show(delegateAnswer2(num1, num2).ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetAnswer delegateAnswer3 = new GetAnswer(Formula.getQuotient);
            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);

            MessageBox.Show(delegateAnswer3(num1, num2).ToString());
        }
    }
}
