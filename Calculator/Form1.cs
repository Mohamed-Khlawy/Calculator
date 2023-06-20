using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string operation;
        string isEqualOrNot;
        bool isOperatorClicked;
        bool isViewTextHasValue;
        double FirstNumber;
        double SecondNumber;
        double result;
        public Form1()
        {
            InitializeComponent();
            isOperatorClicked = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            isOperatorClicked = false;
            viewText.Text = "";
            viewLabel.Text = "";
            result = 0;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            string buttonText = button.Text;

            // Append the button text to the text box
            if (viewText.Text == "0")
                viewText.Text = button.Text;
            else if (viewText.Text == result.ToString())
            {
                viewText.Text = button.Text;
            }
            else
                viewText.Text += buttonText;
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            if (!isOperatorClicked && viewText.Text!="")
            {
                System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
                operation = button.Text;
                FirstNumber = double.Parse(viewText.Text);
                viewLabel.Text = viewText.Text + " " + operation;
                viewText.Text = "";
                isOperatorClicked = true;
            }
            else
            {
                btnEqual_Click(sender, e);
                System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
                operation = button.Text;
                if (isViewTextHasValue && result != 0)
                {
                    viewLabel.Text = result.ToString() + " " + operation;
                    viewText.Text = result.ToString();
                }
                else
                {
                    viewLabel.Text = FirstNumber.ToString() + " " + operation;
                    MessageBox.Show("Second number is missing");
                    return;
                }
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            isEqualOrNot = button.Text;
            if (isEqualOrNot == "=")
            {
                isOperatorClicked = false;
            }
            if (!string.IsNullOrEmpty(viewText.Text) && viewText.Text != result.ToString())
            {
                SecondNumber = double.Parse(viewText.Text);
                isViewTextHasValue = true;
            }
            else if (!string.IsNullOrEmpty(viewText.Text) && viewText.Text == result.ToString())
            {
                return;
            }
            else
            {
                isViewTextHasValue = false;
                return;
            }
            switch (operation)
            {
                case "+":
                    result = FirstNumber + SecondNumber;
                    viewLabel.Text =
                        FirstNumber.ToString() + " " + operation + " "
                        + SecondNumber.ToString() + " " + "=";
                    viewText.Text = result.ToString();
                    FirstNumber = result;
                    break;
                case "-":
                    result = FirstNumber - SecondNumber;
                    viewLabel.Text =
                        FirstNumber.ToString() + " " + operation + " "
                        + SecondNumber.ToString() + " " + "=";
                    viewText.Text = result.ToString();
                    FirstNumber = result;
                    break;
                case "x":
                    result = FirstNumber * SecondNumber;
                    viewLabel.Text =
                        FirstNumber.ToString() + " " + operation + " "
                        + SecondNumber.ToString() + " " + "=";
                    viewText.Text = result.ToString();
                    FirstNumber = result;
                    break;
                case "/":
                    if (SecondNumber != 0)
                    {
                        result = FirstNumber / SecondNumber;
                        viewLabel.Text =
                        FirstNumber.ToString() + " " + operation + " "
                        + SecondNumber.ToString() + " " + "=";
                        viewText.Text = result.ToString();
                        FirstNumber = result;
                    }
                    else
                    {
                        MessageBox.Show("Cannot divide by zero.");
                        return;
                    }
                    break;
                default:
                    break;
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (viewText.Text == "")
            {
                viewText.Text = "-";
            }
            else if (viewText.Text != "" && !viewText.Text.Contains("-") && viewText.Text != "0")
            {
                viewText.Text = "-" + viewText.Text;
            }
            else if(viewText.Text != "" && viewText.Text.Contains("-") && viewText.Text != "0")
            {
                viewText.Text = viewText.Text.Replace("-", "");
            }
        }

        private void btnCleanNumber_Click(object sender, EventArgs e)
        {
            viewText.Text = "";
        }
    }
}
