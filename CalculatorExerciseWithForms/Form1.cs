using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorExerciseWithForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddition_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int firstNumber = 0;
            int secondNumber = 0;
            int result = 0;
            try
            {
                firstNumber = int.Parse(txtFirst.Text);
                secondNumber = int.Parse(txtSecond.Text);
                result = 0;
                if (btnAddition.Checked)
                    result = firstNumber + secondNumber;
                else 
                if (btnSubtract.Checked)
                    result = firstNumber - secondNumber;
                else 
                if (btnMultiply.Checked)
                    result = firstNumber * secondNumber;
                else
                if (btnDivision.Checked)
                    result = firstNumber / secondNumber;

                txtResult.Text = result.ToString();
            }
            catch (FormatException ex)
            {
                txtResult.Text = "NA";
                MessageBox.Show(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                txtResult.Text = "NA";
                MessageBox.Show(ex.Message);
            }
        }
    }
}
