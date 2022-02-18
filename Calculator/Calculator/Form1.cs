using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        double resultValue = 0;
        string operatorClicked = "";
        bool isoperatorClicked = false;
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void Click_button(object sender, EventArgs e)
        {
            if (ResultBox.Text == "0" || isoperatorClicked) 
            {
                ResultBox.Clear();
            }
            isoperatorClicked = false;
            Button button = (Button)sender;
            if(button.Text == ".")
            {
                if (!ResultBox.Text.Contains(".")) {
                    ResultBox.Text = ResultBox.Text + button.Text;
                }
            }
            else
            {
                ResultBox.Text = ResultBox.Text + button.Text;
            }
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                equalbtn.PerformClick();
                operatorClicked = button.Text;
                isoperatorClicked = true;
            }
            else 
            {
                operatorClicked = button.Text;
                resultValue = double.Parse(ResultBox.Text);
                isoperatorClicked = true;
            }

            operatorClicked = button.Text;
            resultValue = double.Parse(ResultBox.Text);
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResultBox.Text = "0";
            resultValue = 0;
        }

        private void equalbtn_Click(object sender, EventArgs e)
        {
            switch (operatorClicked) 
            {
                case "+":
                    ResultBox.Text = (resultValue + double.Parse(ResultBox.Text)).ToString();
                    break;
                case "-":
                    ResultBox.Text = (resultValue - double.Parse(ResultBox.Text)).ToString();
                    break;
                case "x":
                    ResultBox.Text = (resultValue * double.Parse(ResultBox.Text)).ToString();
                    break;
                case "÷":
                    ResultBox.Text = (resultValue / double.Parse(ResultBox.Text)).ToString();
                    break;
                default:
                    break;
            
            }
        }
    }
}
