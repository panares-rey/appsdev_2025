namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        private object firstname;
        private object firstNAME;
        private object lastname;
        private object lastNAME;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fNameValue = FirstNAME.Text;
            string lNameValue = LastNAME.Text;
            MessageBox.Show($"Hello World {fNameValue} {lNameValue}", "Greeting" , MessageBoxButtons.OK , MessageBoxIcon.Information);
        }
    }
}
