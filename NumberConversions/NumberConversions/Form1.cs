using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberConversions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
            int counter = 1;
            string conversion;

            try
            {
                    while (counter <= 3999)
                    {

                        conversion = NumberConversion.IntegerToRoman(counter);
                        listBox2.Items.Add(counter + " = " + conversion);

                        counter = counter + 1;
                    }
                }
                catch
            {
                MessageBox.Show("Unknown error occured");
            }
                


            

            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            int counter = 1;
            string conversion2;

            try
            {





                while (counter <= 3999)
                {
                    conversion2 = NumberConversion.IntegerToRoman(counter);
                    listBox2.Items.Add(conversion2 + " = " + counter);
                    counter = counter + 1;
                }
            }
            catch
            {

                MessageBox.Show("an error occured");

            }

        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            
            listBox2.Items.Clear();
            
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void arabicToRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArabictoRoman.Form1 var = new ArabictoRoman.Form1();
            var.Show();
        }

        private void romanToArabicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RomantoArabic.Form1 var = new RomantoArabic.Form1();
            var.Show();
        }
    }
}
