//Programmer: Eva Zolotarev
//Project: Assignment #1
//Date: 2/17/2020
//Description: Application for Motorway Motel: takes guests information.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zolotarev_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void totalButton_Click(object sender, EventArgs e)
        {
            //Use Try-catch to handle any data entry exceptions
            try
            {
                //Declare Local Variables
                const decimal TAX_RATE = 0.07m;

                //Declare Local Variables
                int room;
                int numberNights;
                decimal nightlyRates;
                decimal miniBar;
                decimal telephoneCharges;
                decimal miscCharges;

                //Bill Summary Local Variables
                decimal roomCharges;
                decimal subTotal;
                decimal additionalCharges;
                decimal taxAmount;
                decimal totalCharges;

                //Get values from text boxes and assign to variables
                room = int.Parse(roomNumberTextBox.Text);
                numberNights = int.Parse(numberNightsTextBox.Text);
                nightlyRates = decimal.Parse(dollarRateTextBox.Text);
                miniBar = decimal.Parse(barTextBox.Text);
                telephoneCharges = decimal.Parse(phoneTextBox.Text);
                miscCharges = decimal.Parse(miscTextBox.Text);

                //Calculate and display Room Charges
                roomCharges = numberNights * nightlyRates;
                roomChargesOutput.Text = roomCharges.ToString("c");

                //Calculate and display Additional Charges
                additionalCharges = miniBar + telephoneCharges + miscCharges;
                additionalChargesOutput.Text = additionalCharges.ToString("c");

                //Calculate and display subTotal 
                subTotal = roomCharges + additionalCharges;
                subtotalOutput.Text = subTotal.ToString("c");

                //Calculate and display Tax Amount
                taxAmount = subTotal * TAX_RATE;
                taxOutput.Text = taxAmount.ToString("c");

                //Calculate and display Total Amount
                totalCharges = subTotal + taxAmount;
                totalOutput.Text = totalCharges.ToString("c");

                //Set focus to first input control on form
                clearButton.Focus();
            }
            catch (Exception ex)
            {
                //Display the default error message 
                MessageBox.Show(ex.Message);
            }
        }

        //This button clears the information from labels/textboxes
        private void clearButton_Click(object sender, EventArgs e)
        {
            firstNameInputTextBox.Text = "";
            lastNameInputTextBox.Text = "";
            roomNumberTextBox.Text = "";
            numberNightsTextBox.Text = "";
            dollarRateTextBox.Text = "";
            barTextBox.Text = "";
            phoneTextBox.Text = "";
            miscTextBox.Text = "";
            roomChargesOutput.Text = "";
            additionalChargesOutput.Text = "";
            subtotalOutput.Text = "";
            taxOutput.Text = "";
            totalOutput.Text = "";

            //Set focus to first input control on form
            firstNameInputTextBox.Focus();
        }

        //This button shows a help message
        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, there! This is the Sleep Inn Application. Below, please enter the following: day you'll be checking out (date), first name, and last name. The front desk employee will fill out your room number, number of nights, dollar rate, and extra charges (ie: mini bar, telephone, and misc charges). Thank you and have a nice stay!");
        }

        //This button closes the Program
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
