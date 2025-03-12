using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] fruits = { "Home Alone", "Venom", "Rick and Morty");
            FruitCheckBoxList.CheckOnClick = true;

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var fruit in FruitCheckBoxList.Items)
            {
                bool isSelected = FruitCheckBoxList.GetItemChecked(FruitCheckBoxList.Items.IndexOf(fruit));
                if (isSelected && !fruitListBox.Items.Contains(fruit))
                {
                    fruitListBox.Items.Add(fruit); 
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (fruitListBox.SelectedItem != null)
            {
                
                fruitListBox.Items.Remove(fruitListBox.SelectedItem);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            fruitListBox.Items.Clear();
        }

        private void FruitCheckBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
