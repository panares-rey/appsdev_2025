namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Your label2 click logic (if any)
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // Your label5 click logic (if any)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Are you sure you want to submit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
               
                string FirstNameValue = textbox1.Text;  
                string MiddleNameValue = textBox2.Text;
                string LastNameValue = textBox3.Text;
                string SuffixValue = textBox4.Text;

                
                string fullName = $"{FirstNameValue} {MiddleNameValue} {LastNameValue} {SuffixValue}";

               
                MessageBox.Show($"Hello There! {FirstNameValue} {MiddleNameValue} {LastNameValue} {SuffixValue} !", "Greetings!", MessageBoxButtons.OK, MessageBoxIcon.Information); // Corrected "Grreetings!" to "Greetings!"
            }
        }
    }
}
