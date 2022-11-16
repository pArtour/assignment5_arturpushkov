namespace Artur_Pushkov_assig5
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int randomNumber = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            randomNumber = random.Next(1, 101);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int guess = 0;
            if (!(int.TryParse(textBox1.Text, out guess)))
            {
                context_label.Text = "Please full the guess box";
                return;
            }
            if (guess < 1 ||  guess > 100)
            {
                context_label.Text = "Enter the correct number please";
                return;
            }
            if (guess < randomNumber)
            {
                context_label.Text = "Too low";
            }
            if (guess > randomNumber)
            {
                context_label.Text = "Too high";
            }
            if (guess == randomNumber)
            {
                context_label.Text = "Winner! You are right!";
            }
        }
    }
}