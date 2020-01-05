using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectedRaisesGUI
{
    public partial class projectedRaiseForm : Form
    {
        public projectedRaiseForm()
        {
            InitializeComponent();
        }

        private void CalculateSalaryButton_Click(object sender, EventArgs e)
        {
            const double PROJECTED_RAISE = .04;  //constant for projected 4% raise
            double salary,  //variable for salary input by user
                   newSalary;  //variable for next year's projected salary

            //convert the user's input salary to a double
            salary = Convert.ToDouble(salaryTextBox.Text);

            //calculate the projected salary for next year
            newSalary = salary + (salary * PROJECTED_RAISE);

            //display the projected salary to the user
            displayLabel.Text = "With a projected raise of " + PROJECTED_RAISE.ToString("P") + 
                                "\nyour expected salary for next year is " + newSalary.ToString("C") + ".";
        }
    }
}
