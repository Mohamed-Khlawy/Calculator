﻿using System;
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
        //string WhichButton;
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

        private void dot_Click(object sender, EventArgs e)
        {
            if(!viewText.Text.Contains('.'))
            {
                if (viewText.Text == "" || viewText.Text==result.ToString())
                {
                    viewText.Text = "0" + ".";
                }
                else
                {
                    viewText.Text += ".";
                }
            }
            else if(viewText.Text.Contains('.') && viewText.Text == result.ToString())
            {
                viewText.Text = "0" + ".";
            }
            else
                return;
        }

        private void nine_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            button.BackColor = btnCleanNumber.BackColor;
        }

        private void nine_MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            button.BackColor = Color.DarkGray;
        }

        private void btnCleanNumber_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            button.BackColor = zero.BackColor;
        }

        private void btnCleanNumber_MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            button.BackColor = Color.Gray;
        }

        private void btnEqual_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            button.BackColor = Color.DarkMagenta;
        }

        private void btnEqual_MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            button.BackColor = Color.Purple;
        }

        
        private bool IsOperatorKey(Keys key)
        {
            // Define the operator keys that you want to accept
            Keys[] operatorKeys = { Keys.Add, Keys.Subtract, Keys.Multiply, Keys.Divide };
            return operatorKeys.Contains(key);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Failed To Make Enter Key Act like btnEqual!!!

            //if(e.KeyChar==(char)Keys.Enter)
            //{
            //    btnEqual.PerformClick();
            //    return;
            //}
            switch (e.KeyChar.ToString())
            {
                case "0":
                    zero.PerformClick();
                    break;
                case "1":
                    one.PerformClick();
                    break;
                case "2":
                    two.PerformClick();
                    break;
                case "3":
                    three.PerformClick();
                    break;
                case "4":
                    four.PerformClick();
                    break;
                case "5":
                    five.PerformClick();
                    break;
                case "6":
                    six.PerformClick();
                    break;
                case "7":
                    seven.PerformClick();
                    break;
                case "8":
                    eight.PerformClick();
                    break;
                case "9":
                    nine.PerformClick();
                    break;
                case "+":
                    btnAdd.PerformClick();
                    break;
                case "-":
                    btnSubtract.PerformClick();
                    break;
                case "*":
                    btnMultibly.PerformClick();
                    break;
                case "/":
                    btnDivide.PerformClick();
                    break;
                case ".":
                    dot.PerformClick();
                    break;
                case "=":
                    btnEqual.PerformClick();
                    break;
            }
            e.Handled = true; // Prevent further handling of the key event
        }
    }
}
