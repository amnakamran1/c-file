namespace simple_form
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int val1 = int.Parse(textBox1.Text);
            int val2 = int.Parse(textBox2.Text);

            int result = val1 + val2;

            MessageBox.Show("The result is: " + result.ToString(), "Calculation Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void button2_Click(object sender, EventArgs e)
        {
            int val1 = int.Parse(textBox1.Text);
            int val2 = int.Parse(textBox2.Text);

            int result = val1 - val2;

            MessageBox.Show("The result is: " + result.ToString(), "Calculation Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            int val1 = int.Parse(textBox1.Text);
            int val2 = int.Parse(textBox2.Text);

            int result = val1 * val2;

            MessageBox.Show("The result is: " + result.ToString(), "Calculation Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int val1 = int.Parse(textBox1.Text);
            int val2 = int.Parse(textBox2.Text);

            int result = val1 / val2;

            MessageBox.Show("The result is: " + result.ToString(), "Calculation Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    
    }
}
