using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Calculator
{
    public partial class Calculator : Form
    {
        string input = string.Empty;
        string fakeInput = string.Empty;
        string procent = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;
        Boolean canInput = true;
        Boolean symbol = false;

        public Calculator()
        {
            InitializeComponent();
        }
        private void updateDisplay()
        {
            if (symbol)
            {
                this.textBox1.Text = "�" + input;
            }
            else
            {
                this.textBox1.Text = input + fakeInput;
            }
        }
        private void displayResult(Double result)
        {
            if (symbol)
            {
                textBox1.Text = "�" + result.ToString();
            }
            else
            {
                textBox1.Text = result.ToString();
            }
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Button2_Click_1(object sender, EventArgs e)
        {
            if (canInput)
            {
                input += "8";
            }
            updateDisplay();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            if (canInput)
            {
                input += "7";
            }
            updateDisplay();
        }
        private void Two_Click(object sender, EventArgs e)
        {
            if (canInput)
            {
                input += "2";
            }
            updateDisplay();
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            if (canInput)
            {
                input += "0";
            }
            updateDisplay();
        }

        private void Punt_Click(object sender, EventArgs e)
        {
            if (canInput)
            {
                input += ".";
            }
            updateDisplay();
        }

        private void Four_Click(object sender, EventArgs e)
        {
            if (canInput)
            {
                input += "4";
            }
            updateDisplay();
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            if (canInput)
            {
                input += "9";
            }
            updateDisplay();
        }

        private void Five_Click(object sender, EventArgs e)
        {
            if (canInput)
            {
                input += "5";
            }
            updateDisplay();
        }

        private void Six_Click(object sender, EventArgs e)
        {
            if (canInput)
            {
                input += "6";
            }
            updateDisplay();
        }

        private void One_Click(object sender, EventArgs e)
        {
            if (canInput)
            {
                input += "1";
            }
            updateDisplay();
        }

        private void Three_Click(object sender, EventArgs e)
        {
            if (canInput)
            {
                input += "3";
            }
            updateDisplay();
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            canInput = true;
            fakeInput = "";
            operand1 = input;
            operation = '+';
            input = string.Empty;
            updateDisplay();
        }
        private void Multiply_Click(object sender, EventArgs e)
        {
            canInput = true;
            fakeInput = "";
            operand1 = input;
            operation = '*';
            input = string.Empty;
            updateDisplay();
        }
        private void Subtract_Click(object sender, EventArgs e)
        {
            canInput = true;
            fakeInput = "";
            operand1 = input;
            operation = '-';
            input = string.Empty;
            updateDisplay();
        }
        private void Delen_Click(object sender, EventArgs e)
        {
            canInput = true;
            fakeInput = "";
            operand1 = input;
            operation = '/';
            input = string.Empty;
            updateDisplay();
        }

        private void RemoveInput_Click(object sender, EventArgs e)
        {
            canInput = true;
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
            this.symbol = false;
            fakeInput = "";
            updateDisplay();
        }
        private void Math_Click(object sender, EventArgs e)
        {
            double num1, num2;
            operand2 = input;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);
            if (procent == "2")
            {
                num2 = (num1 / 100) * num2;
            }
            else if (procent == "1")
            {
                num1 = (num1 / 100);
            }
            if (operation == '+')
            {
                result = num1 + num2;
            }
            else if (operation == '-')
            {
                result = num1 - num2;
            }
            else if (operation == '*')
            {
                result = num1 * num2;
            }
            else if (operation == '%')
            {
                result = num1 / num2;
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    textBox1.Text = "ERROR!";
                }
            }
            else
            {
                textBox1.Text = "ERROR!";
            }
            input = result.ToString();
            displayResult(result);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            symbol = true;
            updateDisplay();
        }

        private void Procent_Click(object sender, EventArgs e)
        {
            fakeInput = "%";
            if (string.IsNullOrEmpty(operand1))
            {
                procent = "1";
            }
            else
            {
                procent = "2";
            }
            canInput = false;
            updateDisplay();
        }
    }
}