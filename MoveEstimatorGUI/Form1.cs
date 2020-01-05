using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoveEstimatorGUI
{
    public partial class moveEstimatorForm : Form
    {
        public moveEstimatorForm()
        {
            InitializeComponent();
        }

        private void calculateMoveEstimateButton_Click(object sender, EventArgs e)
        {
            const double BASE_FEE = 200, //constant for the base fee
                         HOURLY_RATE = 150,  //constant for the hourly rate
                         MILEAGE_RATE = 2;  //constant for the mileage rate
            int hours,  //variable for user input estimated hours
                miles;  //variable for user input estimated hours
            double hourlyRateEstimate,  //variable for estimated hours rate
                   mileageRateEstimate,  //variable for estimated mileage rate
                   grandTotal;  //variable for the estimated total

            //convert user input to integers
            hours = Convert.ToInt32(hoursTextBox.Text);
            miles = Convert.ToInt32(milesTextBox.Text);

            //compute the total
            hourlyRateEstimate = hours * HOURLY_RATE;
            mileageRateEstimate = miles * MILEAGE_RATE;
            grandTotal = BASE_FEE + hourlyRateEstimate + mileageRateEstimate;

            //display the itemized total to the user in the displayLabel
            displayLabel.Text = "Base Fee:\t" + BASE_FEE.ToString("C") +
                                "\nHourly Fee:\t" + hourlyRateEstimate.ToString("C") +
                                "\nMileage Fee:\t" + mileageRateEstimate.ToString("C") +
                                "\nTotal Estimate:\t" + grandTotal.ToString("C");
        }
    }
}
