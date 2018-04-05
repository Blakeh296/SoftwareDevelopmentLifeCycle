using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RomanToArabic2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Variable to hold Roman Numeral
            string Roman;
            // Counter for if statement
            int counter;
            // Output Arabic number
            int conversion;

            try // Error handling
            {

                //Store textbox in string variable
                Roman = textBox1.Text.ToUpper();

                // Store conversion in variable
                conversion = RomanToArabic.RomanToInteger(Roman);

                // Set IF Counter variable
                counter = conversion;

                if (3999 >= counter) // Perform conversion
                {
                    // Change Label color to Green for successful !
                    outPutLabel.BackColor = System.Drawing.Color.LightGreen;
                    // Display original input RomanNumeral + " = " + Output Arabic
                    outPutLabel.Text = Roman + " = " + conversion.ToString();


                }
                else // ERROR
                {
                    // Change output color to red
                    outPutLabel.BackColor = System.Drawing.Color.Red;
                    // display error message
                    outPutLabel.Text = " Roman Numeral to Large";
                }

            }
            catch // ERROR
            {
                // Change output label color to RED
                outPutLabel.BackColor = System.Drawing.Color.Red;
                // ERROR Message
                outPutLabel.Text = "Roman Numerals only";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Reset all text values
            textBox1.Text = " ";
            outPutLabel.Text = " ";
            // RESET label color
            outPutLabel.BackColor = System.Drawing.Color.LightGray;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Closes this form
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
