using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EggsInteractiveGUI
{
    public partial class eggsInteractiveForm : Form
    {
        public eggsInteractiveForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            const byte DOZEN = 12;  //constant for a dozen
            int eggs,  //variable for number of eggs entered
                dozens,  //variable for number of dozens calculated
                singleEggs;  //variable for number of single eggs calculated

            //convert the number of eggs entered to an integer
            eggs = Convert.ToInt32(eggsTextBox.Text);

            //calculate the dozens and single eggs
            dozens = eggs / DOZEN;
            singleEggs = eggs % DOZEN;

            //display dozens and single eggs to the user in the displayLabel
            displayLabel.Text = "There are " + dozens + " dozen and " + singleEggs + " eggs.";
        }
    }
}
