using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            double num1 = Double.Parse(inputBox1.Text);
            double num2 = Double.Parse(inputBox2.Text);
            int opIndex = opBox.SelectedIndex;
            double result = 0;
            switch (opIndex)
            {
                case 0:
                    result = num1 + num2;
                    break;
                case 1:
                    result = num1 - num2;
                    break;
                case 2:
                    result = num1 * num2;
                    break;
                case 3:
                    if (num2 == 0)
                    {
                        break;
                    }
                    result = num1 / num2;
                    break;
                case 4:
                    if (num2 == 0)
                    {
                        break;
                    }
                    result = num1 % num2;
                    break;
                default:
                    break;
           
            }
            resultBox.Text = result.ToString();

        }
    }
}
