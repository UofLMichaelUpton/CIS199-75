using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InchesToCentimetersGUI
{
    public partial class InchesToCentimetersForm : Form
    {
        public InchesToCentimetersForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            const double CENTIMETERS_IN_INCH = 2.54;  //constant for centimeters in an inch
            double inches,  //variable for inches the user will input
                   centimeters;  //variable for user-entered inches converted to centimeters

            inches = Convert.ToDouble(inchesTextBox.Text);  //convert string in text box to double
            centimeters = inches * CENTIMETERS_IN_INCH;  //convert inches to centimeters

            solutionDisplayLabel.Text = inches + " inches is equal to " + centimeters + " centimeters.";
        }
    }
}
