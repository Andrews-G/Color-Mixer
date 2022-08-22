/***************************************************************************************
 * Color Mixer
 * Grant Andrews
 * 6/18/22
 * 
 * This program asks a user to selcet two colors by using radio buttons,
 * one color from each list box. Once the user has selected two colors 
 * and clicks the "Mix" button, the form will change the form's background color
 * to the color created by mixing the two colors. A "formula" will also
 * be displayed in a label below the buttons that tells the user what two
 * colors were mixed and what the resulting mixed color was.
 * ************************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Mixer
{
    public partial class colorMixerForm : Form
    {
        public colorMixerForm()
        {
            InitializeComponent();
        }

        private void mixButton_Click(object sender, EventArgs e)
        {
            // This event handler is executed when the "Mix" button is clicked.

            // First, declare the variables to be used for this event handler.

            string firstColor, secondColor, mixedColor;

            // Determine which radio buttons were checked and assign a string
            // to the appropriate variables based on the selected buttons.

            // Evaluate the firstColor.
            if (firstRedRadioButton.Checked)
            {
                firstColor = "Red";
            }

            else if (firstBlueRadioButton.Checked)
            {
                firstColor = "Blue";
            }

            else
            {
                firstColor = "Yellow";
            }


            // Evaluate the secondColor.
            if (secondRedRadioButton.Checked)
            {
                secondColor = "Red";
            }

            else if (secondBlueRadioButton.Checked)
            {
                secondColor = "Blue";
            }

            else
            {
                secondColor = "Yellow";
            }


            // Determine which color will be created by mixing the two selected colors.
            // Assign the appropriate string to the variable "mixedColor" based on the resulting color.

            if (firstColor == secondColor)
            {
                mixedColor = firstColor;
            }

            else if ((firstColor == "Red" || secondColor == "Red") && (firstColor == "Blue" || secondColor == "Blue"))
            {
                mixedColor = "Purple";
            }

            else if ((firstColor == "Red" || secondColor == "Red") && (firstColor == "Yellow" || secondColor == "Yellow"))
            {
                mixedColor = "Orange";
            }

            else
            {
                mixedColor = "Green";
            }


            // Change the form's background color based on the string value
            // that is assigned to the variable "mixedColor".

            if (mixedColor == "Red")
            {
                this.BackColor = Color.Red;
            }

            else if (mixedColor == "Blue")
            {
                this.BackColor = Color.Blue;
            }

            else if (mixedColor == "Yellow")
            {
                this.BackColor = Color.Yellow;
            }

            else if (mixedColor == "Purple")
            {
                this.BackColor = Color.Purple;
            }

            else if (mixedColor == "Orange")
            {
                this.BackColor = Color.Orange;
            }

            else
            {
                this.BackColor = Color.Green;
            }
                    

            // Change the text property of the "mixedColorLabel" to display to the user
            // which two colors were mixed, and the result of mixing the two colors.

            mixedColorLabel.Text= firstColor + " + " + secondColor + " = " + mixedColor ;
            
        }

        private void exitButton_Click(object sender, EventArgs e)

            // This event handler closes the form when the user clicks the "Exit" button.
        {
            this.Close();
        }
    }
}
