using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArabictoRoman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Int variable to store textbox value
            int arabic;
            // String variable to save the output roman numeral
            string output;

            try
            {
                // Set int variable equal to the input text box
                arabic = int.Parse(textBox1.Text);

                // If statement overload to prevent program from producting false information
                if (arabic >= 4000)
                {
                    // Output label color set to Red for error handling
                    outPutLabel.BackColor = System.Drawing.Color.Red;
                    // Error message
                    outPutLabel.Text = " Arabic OVERLOAD ";
                }
                else
                {
                    // set Output to everything i want in my final label, conversion happens here
                    output = arabic + " = " + ArabictoRoman.IntegerToRoman(arabic);

                    // Set OutputLabel color GREEN to signify successful conversion
                    outPutLabel.BackColor = System.Drawing.Color.LightGreen;

                    // Display the conversion in the label for the user
                    outPutLabel.Text = output;
                    // Store conversions in the list box
                    listBox2.Items.Add(output);
                }
                
            }
            catch // ERROR HANDLING
            {
                // CHANGE OUTPUT Label to red
                outPutLabel.BackColor = System.Drawing.Color.Red;
                // Display my error handling message
                outPutLabel.Text = "Arabic Numbers Only";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Reset Output Label color
            outPutLabel.BackColor = System.Drawing.Color.LightGray;
            // Delete output label text
            outPutLabel.Text = " ";
            // Clear list box items
            listBox2.Items.Clear();
            // Clear user textbox
            textBox1.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Closes this form
            this.Close();
        }

        private void romanToArabicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RomanToArabic2.Form1 var = new RomanToArabic2.Form1();
            var.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
