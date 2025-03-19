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
            string[] phones = { "iPhone 16 Pro Max (256GB)", "iPhone 16 Pro (128GB)", "iPhone 16 Plus (128GB)", "iPhone 16 (128GB)" };
            listBox1.Items.AddRange(phones);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lstModels.SelectedItem == null || cmbLoanTerm.SelectedItem == null)
            {
                MessageBox.Show("Please select an iPhone model and a loan term.");
                return;
            }

            double phonePrice = phonePrices[lstModels.SelectedItem.ToString()];
            double addOnCost = GetAddOnCost();
            double principalAmount = phonePrice + addOnCost;
            double downPayment = 7000;
            int loanTerm = int.Parse(cmbLoanTerm.SelectedItem.ToString().Split(' ')[0]);
            double interestRate = loanTerms[loanTerm];
            double interestAmount = (principalAmount - downPayment) * (interestRate / 100);
            double totalAmount = (principalAmount - downPayment) + interestAmount;
            double monthlyAmortization = totalAmount / loanTerm;

            DisplayLoanDetails(principalAmount, downPayment, loanTerm, interestRate, interestAmount, monthlyAmortization, totalAmount);
        }

        private double GetAddOnCost()
        {
            double cost = 0;
            if (chkAppleCare.Checked) cost += 2590;
            if (chkUSB.Checked) cost += 1990;
            if (chkMagSafe.Checked) cost += 2490;
            return cost;
        }

        private void DisplayLoanDetails(int loanTerm, double interestAmount, double monthlyAmortization)
            {
            MessageBox.Show($"Principal Amount: Php {principalAmount}\nDown Payment: Php {downPayment}\nLoan Term: {loanTerm} Months\nInterest Rate: {interestRate}%\nInterest Amount: Php {interestAmount}\nMonthly Amortization: Php {monthlyAmortization:F2}\nTotal Amount: Php {totalAmount}");

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
               
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }
