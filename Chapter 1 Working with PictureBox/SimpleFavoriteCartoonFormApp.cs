using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleFavoriteCartoonFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          string[] cartoons = { "Spongebob", "Patrick", "Mr. Krabs", "Sandy" };
            comboBox1.Items.AddRange(cartoons);
            comboBox1.SelectedIndex = 0;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a cartoon character first.");
                return;
            }

            string selectedItem = comboBox1.SelectedItem.ToString();

            switch (selectedItem)
            {
                case "Spongebob":

                    pictureBox1.Image = Image.FromFile(@"C:/Users/oo137/Downloads/fb01289d272eff2379c505e04f358fbf.jpg");
                    break;

                case "Patrick":
                    pictureBox1.Image = Image.FromFile(@"C:/Users/oo137/Downloads/maxresdefault.jpg");
                    break;

                case "Mr. Krabs":
                    pictureBox1.Image = Image.FromFile(@"C:\Users\oo137\Downloads\e38623cb61d5499381052b2a75a7f60a.jpg");
                    break;

                case "Sandy":
                    pictureBox1.Image = Image.FromFile(@"C:\Users\oo137\Downloads\v4-460px-Draw-Sandy-Cheeks-from-SpongeBob-SquarePants-Step-9.jpg");
                    break;

                default:
                    pictureBox1.Image = null; 
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
    }
}
