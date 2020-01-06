using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PigLatinGUI
{
    public partial class pigLatinForm : Form
    {
        public pigLatinForm()
        {
            InitializeComponent();
        }

        private void translateButton_Click(object sender, EventArgs e)
        {
            string subString1,  //variable to create a substring
                   subString2;  //variable to create a second substring

            //break the entered work up into two substrings
            //first substring is the first letter and second substring is the rest of the word
            subString1 = wordTextBox.Text.Substring(0, 1);
            subString2 = wordTextBox.Text.Substring(1, wordTextBox.Text.Length - 1);

            //display the word to the user moving the first letter to the end and 
            //displaying "ay" after it
            displayLabel.Text = subString2 + subString1 + "ay";
        }
    }
}
