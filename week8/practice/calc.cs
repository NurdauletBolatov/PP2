using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice
{enum Operation
    {
        Add, Subtract, Multiply, Divide
    }
    public partial class calc : Form
    {
        private Operation operation;
        private bool isOperationRunning;
        private double result;

        public calc()
        {
            InitializeComponent();
            isOperationRunning = false;
            result = 0.0;
        }
        private void button_Click(object sender,EventArgs e)
        {
            Button button = (Button)sender;
            if (isOperationRunning)
            {
                textBoxResult.Text = button.Text;
                isOperationRunning = false;
                return;
            }
            if (textBoxResult.Text == "0")
            {
                if (button.Text != "0")
                {
                    textBoxResult.Text = button.Text;

                }
            }
            else
            {
                textBoxResult.Text = textBoxResult.Text + button.Text;
            }
        }

        private void operation_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            textBoxLabel.Text = textBoxResult.Text + " " + button.Text;

            switch (button.Text)
            {
                case "+":
                    operation = Operation.Add;
                    break;
                case "-":
                    operation = Operation.Subtract;
                    break;
                case "x":
                    operation = Operation.Multiply;
                    break;
                case "/":
                    operation = Operation.Divide;
                    break;
                default:
                    break;
            }
            isOperationRunning = true;
            result = double.Parse(textBoxResult.Text);


        }
        private void equals_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case Operation.Add:
                    result = result + double.Parse(textBoxResult.Text);
                    break;
                case Operation.Subtract:
                    result = result - double.Parse(textBoxResult.Text);
                    break;
                case Operation.Multiply:
                    result = result * double.Parse(textBoxResult.Text);
                    break;
                case Operation.Divide:
                    result = result / double.Parse(textBoxResult.Text);
                    break;
                default:
                    break;
            }
            textBoxResult.Text = result.ToString();
            textBoxLabel.Text = string.Empty;
        }
        private void clear_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
            Console.WriteLine("Clear");
            result = 0.0;
            isOperationRunning = false;
            textBoxLabel.Text = string.Empty;
        }



        private void Form1_Load(object sender,EventArgs e)
        {

        }

        
    }
}
