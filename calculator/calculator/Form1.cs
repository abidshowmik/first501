using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }
        int first_num = 0;
        int second_num = 0;
        int result = 0;

       

        private void addButton_Click(object sender, EventArgs e)
        {
            first_num = Convert.ToInt32(firstnumberTextBox.Text);
            second_num = Convert.ToInt32(secondnumberTextbox.Text);

            result = first_num + second_num;
            resultTextbox.Text = Convert.ToString(result);
            
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            first_num = Convert.ToInt32(firstnumberTextBox.Text);
            second_num = Convert.ToInt32(secondnumberTextbox.Text);

            result = first_num - second_num;
            resultTextbox.Text = Convert.ToString(result);
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            first_num = Convert.ToInt32(firstnumberTextBox.Text);
            second_num = Convert.ToInt32(secondnumberTextbox.Text);

            result = first_num * second_num;
            resultTextbox.Text = Convert.ToString(result);
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            first_num = Convert.ToInt32(firstnumberTextBox.Text);
            second_num = Convert.ToInt32(secondnumberTextbox.Text);

            result = first_num / second_num;
            resultTextbox.Text = Convert.ToString(result);
        }
    }
}
