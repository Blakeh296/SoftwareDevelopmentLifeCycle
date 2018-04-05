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



        private void button2_Click(object sender, EventArgs e)
        {
            int counter = 3999;
            string conversion;
            string output;

            while (counter >= 1)
            {
                conversion = NumberConversion.IntegerToRoman(counter);

                output = conversion + " = " + counter;
                listBox2.Items.Add(output);

                counter = counter - 1;
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
