namespace lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double operand1, operand2;
            if (double.TryParse(textBox1.Text, out operand1) && double.TryParse(textBox2.Text, out operand2))
            {
                string operatorSymbol = comboBox1.Text;
                double result = 0;

                switch (operatorSymbol)
                {
                    case "+":
                        result = operand1 + operand2;
                        break;
                    case "-":
                        result = operand1 - operand2;
                        break;
                    case "*":
                        result = operand1 * operand2;
                        break;
                    case "/":
                        result = operand1 / operand2;
                        break;                    
                }

                string historyEntry = $"{operand1} {operatorSymbol} {operand2} = {result}";
                listBox1.Items.Add(historyEntry);
            }
            else
            {
                MessageBox.Show("Error: Invalid input");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}