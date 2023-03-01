namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        double a = 0, b = 0, c = 0;
        double f, d;
        char znak = '+';


        private void button18_Click(object sender, EventArgs e) //SUMMA
        {
            a = Convert.ToDouble(textBox1.Text);
            znak = (sender as Button).Text[0];
            textBox1.Clear();

        }

        private void button19_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(textBox1.Text);
            switch (znak)
            {
                case '+':
                    c = a + b;
                    break;
                case '-':
                    c = a - b;
                    break;
                case '/':
                    c = a / b;
                    break;
                case '*':
                    c = a * b;
                    break;
            }
            textBox1.Text = c.ToString();
        }

        private void button9_Click(object sender, EventArgs e) //C
        {
            textBox1.Clear();
        }

        private void button24_Click(object sender, EventArgs e) //+-
        {
            if (textBox1 != null)
            {
                if (textBox1.Text[0] == '-')
                {
                    textBox1.Text = textBox1.Text.Remove(0, 1);
                }
                else textBox1.Text = '-' + textBox1.Text;
            }
        }

        private void button10_Click(object sender, EventArgs e) // Backspace
        {
            if (textBox1 != null)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }

        }

        private void button20_Click(object sender, EventArgs e) //CE
        {
            if (textBox1 != null)
            {
                
            }
        }
    }
}