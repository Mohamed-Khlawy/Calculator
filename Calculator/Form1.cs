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
        bool isOperatorClicked;
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
        }

        private void Button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            string buttonText = button.Text;

            // Append the button text to the text box
            viewText.Text = buttonText;
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            if (!isOperatorClicked)
            {
                System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
                operation = button.Text;
                FirstNumber = double.Parse(viewText.Text);
                viewLabel.Text += viewText.Text + " " + operation;
                viewText.Text = "";
                isOperatorClicked = true;
            }
            else
            {
                btnEqual_Click(sender, e);
                System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
                operation = button.Text;
                viewLabel.Text = result.ToString() + " " + operation;
                viewText.Text = result.ToString();
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            
            SecondNumber = double.Parse(viewText.Text);
            switch(operation)
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
    }
}
