using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Simple_Form_Application
{
    public partial class Form1 : Form
    {
        private object textbox1;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to submit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {

                string FirstNameValue = textBox1.Text;
                string MiddleNameValue = textBox2.Text;
                string LastNameValue = textBox3.Text;
                string SuffixValue = textBox4.Text;


                string fullName = $"{FirstNameValue} {MiddleNameValue} {LastNameValue} {SuffixValue}";


                MessageBox.Show($"Hello There! {FirstNameValue} {MiddleNameValue} {LastNameValue} {SuffixValue} !", "Greetings!", MessageBoxButtons.OK, MessageBoxIcon.Information); // Corrected "Grreetings!" to "Greetings!"

            }
        }
    }
}