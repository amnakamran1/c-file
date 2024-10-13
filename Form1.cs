namespace Calculate_Percentage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            double total = Convert.ToDouble(textBox1.Text);
            double obtained = Convert.ToDouble(textBox2.Text);

            double percentage = (obtained / total) * 100;
            string grade;
            if (percentage >= 90)
            {
                grade = "A+";
            }
            else if (percentage >= 80)
            {
                grade = "A";
            }
            else if (percentage >= 70)
            {
                grade = "B";
            }
            else if (percentage >= 60)
            {
                grade = "c";
            }
            else
            {
                grade = "f";
            }

            MessageBox.Show($"Your percentage is :{percentage} .Your grade is {grade}", "Calculation Result :");
        }
    }

}






   
        
    

