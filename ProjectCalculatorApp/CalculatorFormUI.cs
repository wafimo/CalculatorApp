using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCalculatorApp
{
    public partial class CalculatorFormUI : Form
    {

        Double value = 0;
        String operation = "";
        bool operationPressed = false;
        public CalculatorFormUI()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (resultTextBox.Text == "0" || (operationPressed))
            {
                resultTextBox.Clear();
            }
            operationPressed = false;
            Button b = (Button)sender;
            resultTextBox.Text = resultTextBox.Text + b.Text;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = "0";
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(resultTextBox.Text);
            operationPressed = true;
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    resultTextBox.Text = (value + Double.Parse(resultTextBox.Text)).ToString();
                    break;
                case "-":
                    resultTextBox.Text = (value - Double.Parse(resultTextBox.Text)).ToString();
                    break;
                case "*":
                    resultTextBox.Text = (value * Double.Parse(resultTextBox.Text)).ToString();
                    break;
                case "/":
                    resultTextBox.Text = (value / Double.Parse(resultTextBox.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void singleClearbutton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = "0";
            value = 0;
        }

        private void button_Click_1(object sender, EventArgs e)
        {
            String holder = resultTextBox.Text;
            int len = holder.Length;
            resultTextBox.Text = "";
            for (int i = 0; i < len - 1; i++)
            {
                resultTextBox.Text = resultTextBox.Text + Convert.ToString(holder[i]);
            }
        }
    }
}