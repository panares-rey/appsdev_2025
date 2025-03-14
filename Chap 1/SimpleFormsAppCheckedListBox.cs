using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] movies = { "Rick and Morty", "End Game", "Venom", "Home Alone" };
            MoviecheckedListBox1.Items.AddRange(movies);    
            MoviecheckedListBox1.CheckOnClick = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var movies in MoviecheckedListBox1.Items)
            {
                bool isSelected = MoviecheckedListBox1.GetItemChecked(MoviecheckedListBox1.Items.IndexOf(movies));
                if (isSelected && !MovielistBox1.Items.Contains(movies))
                {
                    MovielistBox1.Items.Add(movies);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MovielistBox1.Items.Count >= 1)
            {
                MovielistBox1.Items.Remove(MovielistBox1.SelectedItem);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MovielistBox1.Items.Clear();
        }
    }
}