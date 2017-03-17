using System;
using System.Windows.Forms;

namespace Factorial
{
    public partial class Form1 : Form
    {
        int num = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Button_click(object sender, EventArgs e)
        {
            if (result.Text == "0")
                result.Clear();

            Button b = (Button)sender;
            number.Text = number.Text + b.Text;
            num = Convert.ToInt32(number.Text);
        }

        private void calculate_button_Click(object sender, EventArgs e)
        {
            if(num > 1)
            {
                ulong iterative_factorial(int n)
                {
                    ulong factorial = 1;

                    for (uint i = 2; i <= n; i++) factorial = factorial * i;

                    return factorial;
                }
                result.Text = Convert.ToString(iterative_factorial(num));
            } else if(num == 0 || num == 1)
            {
                result.Text = "1";
            } 
        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            number.Clear();
            result.Clear();
        }
    }
}