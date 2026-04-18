using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // --------------------
        // Helpers
        // --------------------

        private void ResetIfError()
        {
            if (textBox1.Text == "Error")
                textBox1.Clear();
        }

        private void AppendNumber(string num)
        {
            ResetIfError();

            if (textBox1.Text == "0")
                textBox1.Text = num;
            else
                textBox1.Text += num;
        }

        private bool IsLastCharOperator()
        {
            if (string.IsNullOrEmpty(textBox1.Text))
                return false;

            char last = textBox1.Text.Last();
            return last == '+' || last == '-' || last == '*' || last == '/';
        }

        // --------------------
        // Core calculation
        // --------------------

        private void CalculateExpression()
        {
            try
            {
                string expression = textBox1.Text;

                var result = new DataTable().Compute(expression, null);

                textBox1.Text = result.ToString();
            }
            catch
            {
                textBox1.Text = "Error";
            }
        }

        // --------------------
        // Number buttons
        // --------------------

        private void Number0_Click(object sender, EventArgs e) => AppendNumber("0");
        private void Number1_Click(object sender, EventArgs e) => AppendNumber("1");
        private void Number2_Click(object sender, EventArgs e) => AppendNumber("2");
        private void Number3_Click(object sender, EventArgs e) => AppendNumber("3");
        private void Number4_Click(object sender, EventArgs e) => AppendNumber("4");
        private void Number5_Click(object sender, EventArgs e) => AppendNumber("5");
        private void Number6_Click(object sender, EventArgs e) => AppendNumber("6");
        private void Number7_Click(object sender, EventArgs e) => AppendNumber("7");
        private void Number8_Click(object sender, EventArgs e) => AppendNumber("8");
        private void Number9_Click(object sender, EventArgs e) => AppendNumber("9");

        // --------------------
        // Operators
        // --------------------

        private void Add_Click(object sender, EventArgs e)
        {
            ResetIfError();
            if (!IsLastCharOperator())
                textBox1.Text += "+";
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            ResetIfError();
            if (!IsLastCharOperator())
                textBox1.Text += "-";
        }

        private void Multi_Click(object sender, EventArgs e)
        {
            ResetIfError();
            if (!IsLastCharOperator())
                textBox1.Text += "*";
        }

        private void Dev_Click(object sender, EventArgs e)
        {
            ResetIfError();
            if (!IsLastCharOperator())
                textBox1.Text += "/";
        }

        // --------------------
        // Extra buttons
        // --------------------

        private void AddDecimal_Click(object sender, EventArgs e)
        {
            ResetIfError();

            if (textBox1.Text == "")
                textBox1.Text = "0.";
            else if (!textBox1.Text.Contains("."))
                textBox1.Text += ".";
        }

        private void Percentage_Click(object sender, EventArgs e)
        {
            ResetIfError();

            try
            {
                double value = Convert.ToDouble(textBox1.Text);
                textBox1.Text = (value / 100).ToString();
            }
            catch
            {
                textBox1.Text = "Error";
            }
        }

        private void OpenParenthesis_Click(object sender, EventArgs e)
        {
            ResetIfError();
            textBox1.Text += "(";
        }

        private void CloseParenthesis_Click(object sender, EventArgs e)
        {
            ResetIfError();
            textBox1.Text += ")";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void BackSpace_Click(object sender, EventArgs e)
        {
            ResetIfError();

            if (string.IsNullOrEmpty(textBox1.Text))
                return;

            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);

            if (textBox1.Text == "")
                textBox1.Text = "0";
        }

        // --------------------
        // Equal
        // --------------------

        private void Equal_Click(object sender, EventArgs e)
        {
            ResetIfError();

            CalculateExpression();



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         
                labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}