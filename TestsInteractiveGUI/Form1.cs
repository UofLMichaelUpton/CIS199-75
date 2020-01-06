using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestsInteractiveGUI
{
    public partial class testAverageForm : Form
    {
        public testAverageForm()
        {
            InitializeComponent();
        }

        private void calculateAverageButton_Click(object sender, EventArgs e)
        {
            const byte NUM_OF_TESTS = 5,  //constant for the number of tests as divisor
                       PERCENTAGE_DIVISOR = 100;  //constant to turn average into a percentage
            double testOne,  //variable for test 1
                   testTwo,  //variable for test 2
                   testThree,  //variable for test 3
                   testFour,  //variable for test 4
                   testFive,  //variable for test 5
                   testSum,  //variable for the sum of all five tests
                   average;  //variable for the average

            //convert the scores entered in the text boxes to doubles
            testOne = Convert.ToDouble(testOneTextBox.Text);
            testTwo = Convert.ToDouble(testTwoTextBox.Text);
            testThree = Convert.ToDouble(testThreeTextBox.Text);
            testFour = Convert.ToDouble(testFourTextBox.Text);
            testFive = Convert.ToDouble(testFourTextBox.Text);

            //add up the sum of the entered test scores
            testSum = testOne + testTwo + testThree + testFour + testFive;

            //calculate the average and divide by 100 for a percentage
            average = (testSum / NUM_OF_TESTS) / PERCENTAGE_DIVISOR;

            //display the sum in the displayLabel
            displayLabel.Text = "The average of the test scores is " + average.ToString("P2") + ".";
        }
    }
}
