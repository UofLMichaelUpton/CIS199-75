using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeChangeGUI
{
    public partial class makeChangeForm : Form
    {
        public makeChangeForm()
        {
            InitializeComponent();
        }

        private void calculateChangeButton_Click(object sender, EventArgs e)
        {
            const byte TWENTY = 20,  //constant for twenty dollar bill
                       TEN = 10,  //constant for ten dollar bill
                       FIVE = 5,  //constant for five dollar bill
                       ONE = 1;  //constant for one dollar bill
            int twenties,  //variable for how many twenties there are
                tens,  //variable for how many tens there are
                fives,  //variable for how many fives there are
                ones,  //variable for how many ones there are
                total,  //variable for user-entered total to make change for
                newTotal;  //variable for the new total after each bill type is totalled and taken out

            //convert the amount entered by the user to an integer
            total = Convert.ToInt32(amountTextBox.Text);

            //determine the amount of twenty dollar bills and create a new total
            twenties = total / TWENTY;
            newTotal = total % TWENTY;

            //determine the amount of ten dollar bills and create a new total
            tens = newTotal / TEN;
            newTotal %= TEN;

            //determine the amount of five dollar bills and create a new total
            fives = newTotal / FIVE;
            newTotal %= FIVE;

            //determine the amount of one dollar bills
            ones = newTotal / ONE;

            //display the results to the user in the displayLabel
            displayLabel.Text = twenties + " $20 bills\n" +
                                tens + " $10 bills\n" +
                                fives + " $5 bills\n" +
                                ones + " $1 bills";
        }
    }
}
