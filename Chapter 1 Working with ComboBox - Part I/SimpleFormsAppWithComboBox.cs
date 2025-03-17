using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleFormsAppWithComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] foodCuisine = { "Filipino", "Japanese", "Chinese", "Korean" };
            comboBox1.Items.AddRange(foodCuisine);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedItem = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox1.Items)
            {
                bool isSelected = checkedListBox1.GetItemChecked(checkedListBox1.Items.IndexOf(item));
                if (isSelected && !listBox1.Items.Contains(item))
                {
                    listBox1.Items.Add(item);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count >= 1)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] FilipinoFood = { "Adobo 50$", "Sinigang 40$","Kare-Kare 20$","Quek-Quek 10$","Hot Dog 5$" };
            string[] JapaneseFood = { "Sushi 10$", "Omurice  15$", "Sushi and Sashimi.  30$", "Udon  15$" };
            string[] ChineseFood = { "dumplings  10$", "Kung Pao Chicken 20$", "Sweet and Sour Pork  30$" };
            string[] KoreanFood = { "Jjigae 10$", "Jinju Kang  30$", "Bibimbap  10$", "Bulgogi   15$" };

            checkedListBox1.Items.Clear();

            if (comboBox1.SelectedItem.ToString().Contains("Filipino"))
            {
                checkedListBox1.Items.AddRange(FilipinoFood);
            }
            else if (comboBox1.SelectedItem.ToString().Contains("Japanese"))
            {
                checkedListBox1.Items.AddRange(JapaneseFood);
            }
            else if (comboBox1.SelectedItem.ToString().Contains("Chinese"))
            {
                checkedListBox1.Items.AddRange(ChineseFood);
            }
            else if (comboBox1.SelectedItem.ToString().Contains("Korean"))
            {
                checkedListBox1.Items.AddRange(KoreanFood);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

        }
    }
}