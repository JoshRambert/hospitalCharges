using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_5_hospital_charges
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Create a program that claculates hospital
        //charges including the base pay of 
        //days spent at the hospital using three created methods
        const double BASE_PAY = 350;

        private double CalcStayCharges(double daysCharges)
        {
            return daysCharges * BASE_PAY;
        }

        private double CalcMiscCharges(double MiscCharges)
        {
            return MiscCharges;
        }
        private double CalcTotalCharges(double totalCharges)
        {
            return totalCharges;
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            //Create variables to hold the values
            double daysCharges, rehabCharges, labCharges, surgCharges;
            double medCharges, totalCharges;

            //Get the amount of days spent
            if (double.TryParse(daysChargesTextbox.Text, out daysCharges))
            {
                //calculate total for dayscharges
                daysCharges = CalcStayCharges(daysCharges);
            }
            else
            {
                //display an error message
                MessageBox.Show("Enter a valid Number");
            }

            //Get the Miscellaneous charges for rehab
            if (double.TryParse(rehabChargsTextBox.Text, out rehabCharges))
            {
                //call the MiscCharges method
                rehabCharges = CalcMiscCharges(rehabCharges);
            }
            else
            {
                //display an error message
                MessageBox.Show("Enter a valid number");
            }

            //Get the miscCharges for lab fees
            if (double.TryParse(labChargesTextBox.Text, out labCharges))
            {
                //call the miscCharges method 
                labCharges = CalcMiscCharges(labCharges);
            }
            else
            {
                //display an error message
                MessageBox.Show("Enter a valid number");
            }

            //Get the miscCharges for surgical charges
            if (double.TryParse(surgChargesTextBox.Text, out surgCharges))
            {
                //call the miscCharges method
                surgCharges = CalcMiscCharges(surgCharges);
            }
            else
            {
                //Display an error message
                MessageBox.Show("Enter a valid number");
            }

            //get the miscCharges for the medication charges
            if (double.TryParse(medChargesTextBox.Text, out medCharges))
            {
                //Call the micsCharges method for medication charges
                medCharges = CalcMiscCharges(medCharges);
            }
            else
            {
                //Display an error message
                MessageBox.Show("Enter a valid Number");
            }

            //get the total charges of
            totalCharges = medCharges + surgCharges + labCharges + rehabCharges + daysCharges;

            //display the total in the display label
            totalDisplayLabel.Text = totalCharges.ToString("c");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close the App
            this.Close();
        }
    }
}
