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
   
    public partial class Calculator : Form
    {
        private double Buffer { get; set; } = double.NaN;

        public enum Operations
        {
            Addition,
            Subtraction,
            Multiplication,
            Division,
        }

        private Stack<Operations> OperationsStack { get; set; }

        public Calculator()
        {
            InitializeComponent();
            OperationsStack = new Stack<Operations>();
        }

        private void NumberButtonsHandler(object sender, EventArgs e)
        {
            var btnText = ((Button)sender).Text;

            if (btnText == ".")
            {
                if (!txtOutput.Text.Contains("."))
                {
                    txtOutput.Text += ".";
                }

            }
            else
            {
                txtOutput.Text += btnText;
            }
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            PerformOperation();
            OperationsStack.Push(Operations.Addition);
            txtOutput.Clear();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            PerformOperation();
            OperationsStack.Push(Operations.Division);
            txtOutput.Clear();
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            PerformOperation();
            OperationsStack.Push(Operations.Multiplication);
            txtOutput.Clear();
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            PerformOperation();
            OperationsStack.Push(Operations.Subtraction);
            txtOutput.Clear();
        }

        public void PerformOperation()
        {
            if (double.IsNaN(Buffer))
            {
                Buffer = double.Parse(txtOutput.Text);
            }
            else if (OperationsStack.Count != 0)
            {
                var Operation = OperationsStack.Pop();
                Evaluate(Operation);
            }
        }

        private void Evaluate(Operations operation)
        {
            if (!string.IsNullOrEmpty(txtOutput.Text))
            {
                switch (operation)
                {
                    case Operations.Addition:
                        Buffer += double.Parse(txtOutput.Text);
                        break;
                    case Operations.Subtraction:
                        Buffer -= double.Parse(txtOutput.Text);
                        break;
                    case Operations.Multiplication:
                        Buffer *= double.Parse(txtOutput.Text);
                        break;
                    case Operations.Division:
                        Buffer /= double.Parse(txtOutput.Text);
                        break;
                }
            }

            txtOutput.Text = Buffer.ToString();
            lblBuffer.Text = Buffer.ToString();

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtOutput.Text))
            {
                if (OperationsStack.Count!=0)
                {
                    var operation = OperationsStack.Pop();
                    Evaluate(operation);
                }

            }
            txtOutput.Text = Buffer.ToString();
            lblBuffer.Text = Buffer.ToString();
            OperationsStack.Clear();
        }
    }
}
