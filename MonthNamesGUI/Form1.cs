using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonthNamesGUI
{
    public partial class monthNameForm : Form
    {
        enum Month
        {
            January = 1, February, March, April, May, June, July, August, September, October, November, December
        }
        public monthNameForm()
        {
            InitializeComponent();
        }

        private void monthNameButton_Click(object sender, EventArgs e)
        {
            byte monthNumber;  //variable to hold month number entered

            //convert the entered month number to a byte
            monthNumber = Convert.ToByte(monthNumberTextBox.Text);

            //display the month name in the displayLabel
            displayLabel.Text = "The month you have entered is " + (Month)monthNumber + ".";
        }
    }
}
